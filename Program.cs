using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Registrar Usuarios

            Usuario usuario1 = new Usuario(true, "Ester", "Carrión",
                new Fecha(16, 07, 2005), "Ecuatoriana",
                "estercarrion@gmail.com", "12345", true);

            Console.WriteLine("Usuario registrado:");
            Console.WriteLine(usuario1.MostrarPerfil());
            Console.WriteLine();

            // 2. Registrar Artistas

            Artista shakira = new Artista(
                "Shakira", "Pop Latino", 89000000, 12, null,
                false, "Shakira", "Mebarak", new Fecha(2, 2, 1977), "Colombiana",
                "shakira@music.com", "password", true);

            Console.WriteLine("\nArtista registrado:");
            shakira.mostrarInfo();
            Console.WriteLine();

            // 3. Crear Canciones asociadas a artistas

            Cancion cancion1 = new Cancion("Puntería", 3.01, "Pop Latino", "Las Mujeres Ya No Lloran",
                new Fecha(22, 3, 2024), shakira);

            Cancion cancion2 = new Cancion("Acróstico", 2.50, "Balada Pop", "Las Mujeres Ya No Lloran",
                new Fecha(11, 5, 2023), shakira);

            // Agregar canciones al artista
            shakira.Canciones.Add(cancion1);
            shakira.Canciones.Add(cancion2);

            Console.WriteLine("\nCanciones registradas:");
            Console.WriteLine("------------------------------------------------");
            cancion1.mostrarInfo();
            Console.WriteLine("------------------------------------------------");
            cancion2.mostrarInfo();


            // 4. Crear Playlist asociada a un usuario

            Playlist playlist1 = new Playlist("Favoritas de Juan", usuario1, new List<Cancion>());
            playlist1.AgregarCancion(cancion1, usuario1);
            playlist1.AgregarCancion(cancion2, usuario1);

            Console.WriteLine("\nPlaylist creada:");
            playlist1.MostrarCanciones();

            // 5. Usar el Reproductor de Música

            ReproductorMusica reproductor = new ReproductorMusica(playlist1);

            reproductor.reproducirCancion();
            reproductor.mostrarcancionActual();
            Console.WriteLine();

            reproductor.siguienteCancion();
            reproductor.mostrarcancionActual();
            Console.WriteLine();

            reproductor.pausarReproduccion();
            reproductor.mostrarcancionActual();
            Console.WriteLine();

            reproductor.cancionAnterior();
            reproductor.mostrarcancionActual();
        }
    }
}
