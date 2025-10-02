using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_POO
{
    internal class Playlist
    {
        private string nombrePlaylist;
        private Usuario creador;
        private List<Cancion> canciones;

        //Constructore
        public Playlist (string nombrePlaylist, Usuario creador, List<Cancion> canciones)
        {
            this.nombrePlaylist = nombrePlaylist;
            this.creador = creador;
            this.canciones = canciones;
        }
        //Constructor vacio
        public Playlist()
        {
            this.nombrePlaylist = "Sin Nombre";
            this.creador = null;
            this.canciones = new List<Cancion>;
        }
        public string NombrePlaylist
        {
            get { return this.nombrePlaylist; }
            set { this.nombrePlaylist = value; }
        }
        public Usuario Creador
        {
            get { return this.creador;}
            set { this.creador = value;}
        }
        public List<Cancion> Canciones
        {
            get { return this.canciones;}
        }
        public List<Cancion> AgregarCancion(Cancion cancion,Usuario usuario)
        {
            if (this.creador == usuario)
            {
                {
                    this.Canciones.Add(cancion);
                    Console.WriteLine(cancion.Titulo + "se agregó exitosamente");
                    return this.Canciones;
                }
            }
            else
            {
                Console.WriteLine("Únicamente el creador puede modificar esta playlist");
                return this.Canciones;
            }

        }
        public List<Cancion> EliminarCancion(Cancion cancion, Usuario usuario)
        {
            if (this.creador == usuario)
            {
               
                this.Canciones.Remove(cancion);
                Console.WriteLine(cancion.Titulo + " se eliminó exitosamente");
                return this.Canciones;
              
            }
            else
            {
                Console.WriteLine("Únicamente el creador puede modificar esta playlist");
                return this.Canciones;
            }

        }
    }
}

