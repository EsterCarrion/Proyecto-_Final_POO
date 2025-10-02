using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_POO
{
    internal class Artista : Usuario
    {
        // 1. Atributos necesarios

        private string nombreArtistico;
        private string generoMusical;
        private int numeroSeguidores;
        private int numeroAlbumes;
        private List<Cancion> canciones;

        // 2. Constructores

        // 2.1. Constructor Vacio

        public Artista() : base()
        {
            this.nombreArtistico = "Desconocido";
            this.generoMusical = "Sin género musical";
            this.numeroSeguidores = 0;
            this.numeroAlbumes = 0;
            this.canciones = new List<Cancion>();
        }

        // 2.2. Constructor con parámetros

        public Artista(string nombreArtistico, string generoMusical, int numeroSeguidores, int numeroAlbumes, List<Cancion> canciones, bool sexo, string nombre, string apellido, Fecha fnacimiento,string nacionalidad, string correo, string contraseña, bool cuentaPremium) : base(sexo, nombre, apellido, fnacimiento, nacionalidad, correo, contraseña, cuentaPremium)
        {
            this.nombreArtistico = nombreArtistico;
            this.generoMusical = generoMusical;
            this.numeroSeguidores = numeroSeguidores;
            this.numeroAlbumes = numeroAlbumes;
            if (canciones != null)
                this.canciones = canciones;
            else
                this.canciones = new List<Cancion>(); // inicializa vacía si se recibe null
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

        public List<Cancion> Canciones
        {
            get { return this.canciones; }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("La lista de canciones no puede ser nula, se inicializa vacía"); //Valida que la lista de canciones no sea nula
                    this.canciones = new List<Cancion>();
                }
                else
                {
                    this.canciones = value;
                }
            }
        }

        // 4. Implemenatar método para mostrar la información del artista

        public void mostrarInfo()
        {
            Console.WriteLine("Artista: " + this.nombreArtistico + " \nGénero musical: " + this.generoMusical + " \nNúmero de seguidores: " + this.numeroSeguidores + " seguidores\n " + "\nNúmero de albumes: " + this.numeroAlbumes + " \nNúmero de canciones: " + this.canciones.Count);

            if (this.canciones.Count > 0)
            {
                Console.WriteLine("Canciones: ");
                for (int i = 0; i < this.canciones.Count; i++)
                {
                    Console.WriteLine("[" + (i + 1) +"]" + this.canciones[i].Titulo);
                }
            }
            else
            {
                Console.WriteLine("No tiene canciones registradas");
            }
        }
    }
}
