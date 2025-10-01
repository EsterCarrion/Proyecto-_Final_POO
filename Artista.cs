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
            this.nombreArtistico = "Sin nombre";
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
            set { this.nombreArtistico = value; }
        }

        public string GeneroMusical
        {
            get { return this.generoMusical; }
            set { this.generoMusical = value; }
        }

        public int NumeroSeguidores
        {
            get { return this.numeroSeguidores; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error el número de seguidores no puede ser negativo.");
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
            set { this.oyentesMensuales = value; }
        }

        public int NumeroAlbumes
        {
            get { return this.numeroAlbumes; }
            set { this.numeroAlbumes = value; }
        }

        public int NumeroCanciones
        {
            get { return this.numeroCanciones; }
            set { this.numeroAlbumes = value; }
        }

        // 4. Implemenatar método para mostrar la información del artista

        public void mostrarInfo()
        {
            Console.WriteLine("Artista: " + this.nombreArtistico + " \nGénero musical: " + this.generoMusical + " \nNúmero de seguidores: " + this.numeroSeguidores + " seguidores\n " + " \nOyentes mensuales: " + this.oyentesMensuales + "\nNúmero de albumes: " + this.numeroAlbumes + " \nNúmero de canciones: " + this.numeroCanciones);
        }
    }
}
