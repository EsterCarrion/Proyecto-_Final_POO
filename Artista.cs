using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_POO
{
    internal class Artista
    {
        // 1. Atributos necesarios

        private string nombreArtistico;
        private string generoMusical;
        private int numeroSeguidores;
        private int oyentesMensuales;
        private int numeroAlbumes;
        private int numeroCanciones;

        // 2. Constructores

        //2.1. Constructor Vacio

        public Artista()
        {
            this.nombreArtistico = "Desconocido";
            this.generoMusical = "Sin género musical";
            this.numeroSeguidores = 0;
            this.oyentesMensuales = 0;
            this.numeroAlbumes = 0;
            this.numeroCanciones = 0;
        }

        // 2.2. Constructor con parámetros

        public Artista(string nombreArtistico, string generoMusical, int numeroSeguidores, int oyentesMensuales, int numeroAlbumes, int numeroCanciones)
        {
            this.nombreArtistico = nombreArtistico;
            this.generoMusical = generoMusical;
            this.numeroSeguidores = numeroSeguidores;
            this.oyentesMensuales = oyentesMensuales;
            this.numeroAlbumes = numeroAlbumes;
            this.numeroCanciones = numeroCanciones;
        }

        // 3. Implementación métodos get y set 
        public string NombreArtistico
        {
            get { return this.nombreArtistico; }
            set {
                if (value == " " || value == null )
                {
                    Console.WriteLine("El nombre artístico no puede estar vacío, se le asignara: Desconocido "); //Validación de espacio o casilla vacía
                    this.nombreArtistico = "Desconocido";
                }
                else
                {
                    this.nombreArtistico = value;
                }
                }
        }

        public string GeneroMusical
        {
            get { return this.generoMusical; }
            set {
                if (value == " " || value == null)
                {
                    Console.WriteLine("El genero musical no puede estar vacío, se le asignara: Sin género musical "); //Validación de espacio o casilla vacía
                    this.generoMusical = "Sin género musical";
                }
                else
                {
                    this.generoMusical = value;
                }
                }
        }

        public int NumeroSeguidores
        {
            get { return this.numeroSeguidores; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error el número de seguidores no puede ser negativo."); //Valida que los seguidores no sean negativos
                    numeroSeguidores = 0;
                }
                else
                {
                    this.numeroSeguidores = value;
                }
            }
        }
        public int OyentesMensuales
        {
            get { return this.oyentesMensuales; }
            set {
                if (value < 0)
                {
                    Console.WriteLine("Error el número de oyentes mensuales no puede ser negativo."); //Valida que los oyentes no sean negativos
                    this.oyentesMensuales = 0;
                }
                else
                {
                    this.oyentesMensuales = value;
                }
                }
        }

        public int NumeroAlbumes
        {
            get { return this.numeroAlbumes; }
            set {
                if (value < 0)
                {
                    Console.WriteLine("Error el número de albumes no puede ser negativo."); //Valida que los albumes no sean negativos
                    this.numeroAlbumes = 0;
                }
                else
                {
                    this.numeroAlbumes = value;
                }
                }
        }

        public int NumeroCanciones
        {
            get { return this.numeroCanciones; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error el número de canciones no puede ser negativo."); //Valida que las canciones no sean negativas
                    this.numeroCanciones = 0;
                }
                else
                {
                    this.numeroCanciones = value;
                }
            }
        }

        // 4. Implemenatar método para mostrar la información del artista

        public void mostrarInfo()
        {
            Console.WriteLine("Artista: " + this.nombreArtistico + " \nGénero musical: " + this.generoMusical + " \nNúmero de seguidores: " + this.numeroSeguidores + " seguidores\n " + " \nOyentes mensuales: " + this.oyentesMensuales + "\nNúmero de albumes: " + this.numeroAlbumes + " \nNúmero de canciones: " + this.numeroCanciones);
        }
    }
}
