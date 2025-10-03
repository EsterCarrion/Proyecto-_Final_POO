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
        //Cambiar lo que estoy llamando a dos clases

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
            set {
                if (value == " " || value == null)
                {
                    Console.WriteLine("El titulo de la canción no puede estar vacío, se le asignara: Desconocido "); //Validación de espacio o casilla vacía
                    this.titulo = "Desconocido";
                }
                else
                {
                    this.titulo = value;
                }
                }
        }

        public double Duracion
        {
            get { return this.duracion; }
            set {
                if (value < 0)
                {
                    Console.WriteLine("La duración no puede ser menor a cero, se le asignara: 0.00 "); //Validación de duración menor a cero en tiempo
                    this.duracion = 0.00;
                }
                else
                {
                    this.duracion = value;
                }
                }
        }

        public string Genero
        {
            get { return this.genero; }
            set
            {
                if (value == " " || value == null)
                {
                    Console.WriteLine("El género de la canción no puede estar vacío, se le asignara: Desconocido "); //Validación de espacio o casilla vacía
                    this.genero = "Desconocido";
                }
                else
                {
                    this.genero = value;
                }
            }
        }

        public string Album
        {
            get { return this.album; }
            set
            {
                if (value == " " || value == null)
                {
                    Console.WriteLine("El album de la canción no puede estar vacío, se le asignara: Desconocido "); //Validación de espacio o casilla vacía
                    this.album = "Desconocido";
                }
                else
                {
                    this.album = value;
                }
            }    
        }

        public Fecha Flanzamiento 
        {
            get { return this.flanzamiento; }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("La fecha de lanzamiento de la canción no puede estar vacío, se le asignara la fecha actual"); //Validación de casilla vacía
                    this.flanzamiento = new Fecha();
                }
                else
                {
                    this.flanzamiento = value;
                }
            }
        }

        public Artista NombreArtista
        {
            get { return this.nombreArtista; }
            set { this.nombreArtista = value; }
        }

        public void mostrarInfo()
        {
            Console.WriteLine("Titulo: " + this.titulo + "\nDuración: " + this.duracion +"\nGénero: " + this.genero + "\nAlbum: " + this.album + "\nFecha de lanzamiento: " + this.flanzamiento + "\nNombre del Artista: " + this.nombreArtista.NombreArtistico);
            Console.WriteLine();
        }
    }
}
