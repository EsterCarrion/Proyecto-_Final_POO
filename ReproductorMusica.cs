using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_POO
{
    internal class ReproductorMusica
    {
        // E 1. Atributos

        private Playlist playlistActual;
        private int indiceActual;
        private string estado; // Tres estados: reproduciendo, pausado y detenido.

        // E 2. Constructores

        //Constructor con parámetros

        public ReproductorMusica(Playlist playlistActual, int indiceActual, string estado)
        {
            this.playlistActual = playlistActual;
            this.indiceActual = indiceActual;
            this.estado = estado;
        }

        //  Constructor con un parámetro

        public ReproductorMusica(Playlist playlist)
        {
            this.playlistActual = playlist;
            this.indiceActual = 0;
            this.estado = "detenido";
        }

        //Constructor vacio
        public ReproductorMusica()
        {
            this.playlistActual = new Playlist();
            this.indiceActual = 0;
            this.estado = "detenido";
        }

        // Get and Set

        public Playlist PlaylistActual
        {
            get { return this.playlistActual; }
            set {

                if (value == null)
                {
                    Console.WriteLine("No se puede asignar una playlist nula");
                    return;
                }

                this.playlistActual = value;

                // Reiniciar índice cuando cambia la playlist
                this.indiceActual = 0;
                Console.WriteLine("Se asignó una nueva playlist: " + value.NombrePlaylist + " ,el índice se reinició a 0");

                // Si la nueva playlist está vacía, cambia estado a detenido

                if (playlistActual.Canciones.Count == 0)
                {
                    this.estado = "detenido"; 
                    Console.WriteLine("La nueva playlist está vacía, estado cambiado a detenido");
                }
                }
        }

        public int IndiceActual
        {
            get { return this.indiceActual; }
            set 
            {
                if (playlistActual == null)
                {
                    Console.WriteLine("No hay una playlist asignada, no se puede cambiar el índice");
                    return;
                }

                else if (playlistActual.Canciones.Count == 0)
                {
                    Console.WriteLine("La playlist está vacía, no se puede cambiar el índice.");
                    return;
                }

                else if (value < 0 || value >= playlistActual.Canciones.Count)
                {
                    Console.WriteLine("Indice fuera de rango, debe estar entre 0 y " + (playlistActual.Canciones.Count - 1));
                    return;
                }
                else
                {
                    this.indiceActual = value;
                }
            }
        }
    

        public string Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }

        // E 3. Implementación de métodos

        // E 3.1. Método para reproducir una canción

        public void reproducirCancion()
        {
            if (playlistActual.Canciones.Count == 0) // Count: Sirve para saber cuantos elementos hay en una lista.
            {
                Console.WriteLine("No hay canciones en la playlist");
                return;
            }
            else
            {
                estado = "reproduciendo";
            }
        }

        // E 3.2. Método para pausar una canción

        public void pausarReproduccion()
        {
            if (estado == "reproduciendo")
            {
                estado = "pausado";
                Console.WriteLine("Reproducción pausada");
            }
            else
            {
                Console.WriteLine("No se puede pausar, no se está reproduciendo ninguna canción");
            }
        }

        // E 3.3. Método para avanzar a la siguiente canción
        public void siguienteCancion()
        {
            if (playlistActual.Canciones.Count == 0)
            {
                Console.WriteLine("La playlist está vacía.");
                return;
            }

            else if (indiceActual < playlistActual.Canciones.Count - 1)
            {
                indiceActual++;
                Console.WriteLine("Avanzando a la siguiente canción...");
                reproducirCancion();
            }
            else
            {
                Console.WriteLine("Ya estás en la última canción");
            }
        }

        // E 3.4. Método para retroceder a la canción anterior
        public void cancionAnterior()
        {
            if (playlistActual.Canciones.Count == 0)
            {
                Console.WriteLine("La playlist está vacía");
                return;
            }

            if (indiceActual > 0)
            {
                indiceActual--;
                Console.WriteLine("Retrocediendo a la canción anterior...");
                reproducirCancion();
            }
            else
            {
                Console.WriteLine("Ya estás en la primera canción");
            }
        }

        // E 3.5. Método para mostrar la canción actual y su artista
        public Cancion mostrarcancionActual()
        {
            if (playlistActual.Canciones.Count == 0)
            {
                Console.WriteLine("No hay canciones en la playlist");
                return null;
            }

            Cancion actual = playlistActual.Canciones[indiceActual];
            Console.WriteLine("Canción actual: " + actual.Titulo + " - " + actual.NombreArtista.NombreArtistico + " | Estado: " + this.estado);
            return actual;
        }
    }
}
