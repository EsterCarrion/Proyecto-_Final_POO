using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_POO
{
    internal class Cancion
    {
        // C 1. Atributos

        private string titulo;
        private double duracion;
        private string genero;
        private string album;
        private Fecha flanzamiento;
        private Artista nombreArtista;

        // C 2. Constructores

        //Constructor vacio

        public Cancion()
        {
            this.titulo = "Título desconocido";
            this.duracion = 0.00;
            this.genero = "Sin género";
            this.album = "Sin album";
            this.flanzamiento = new Fecha();
            this.nombreArtista = null;
        }

        //Constructor con parámetros

        public Cancion(string titulo, double duracion, string genero, string album, Fecha flanzamiento, Artista nombreArtista)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.genero = genero;
            this.album = album;
            this.flanzamiento = flanzamiento;
            this.nombreArtista = nombreArtista;
        }

        // C 3. Implementación métodos get y set

        public string Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }

        public double Duracion
        {
            get { return this.duracion; }
            set { this.duracion = value; }
        }

        public string Genero
        {
            get { return this.genero; }
            set { this.genero = value; }
        }

        public string Album
        {
            get { return this.album; }
            set { this.album = value; }
        }

        public Fecha Flanzamiento
        {
            get { return this.flanzamiento; }
            set { this.flanzamiento = value; }
        }

        public Artista NombreArtista
        {
            get { return this.nombreArtista; }
            set { this.nombreArtista = value; }
        }

        public void mostrarInfo()
        {

        }
    }
}
