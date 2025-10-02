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

        //Constructores
        public Playlist (string nombrePlaylist, Usuario creador, List<Cancion> canciones)
        {
            this.nombrePlaylist = nombrePlaylist;
            this.creador = creador;
            this.canciones = canciones;
        }
        public Playlist(string nombrePlaylist, bool sexo, string nombre, string apellido, Fecha fnacimiento, string nacionalidad, string correo, string contraseña, bool cuentaPremium, List<Cancion> canciones)
        {
            this.nombrePlaylist = nombrePlaylist;
            this.creador = new Usuario (sexo,nombre, apellido,fnacimiento,   nacionalidad,  correo, contraseña,cuentaPremium);
            this.canciones = canciones;
        }
        public Playlist(bool sexo, string nombre, string apellido, int dia, int mes, int año, string nacionalidad, string correo, string contraseña, bool cuentaPremium, List<Cancion> canciones)
        {
            this.nombrePlaylist = "Sin nombre";
            this.creador = new Usuario (sexo,nombre,apellido, new Fecha (dia,mes,año), nacionalidad,correo,contraseña, cuentaPremium);
            this.canciones = canciones;
        }

        //Constructor vacio
        public Playlist()
        {
            this.nombrePlaylist = "Sin Nombre";
            this.creador = null;
            this.canciones = new List <Cancion>();
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
            get { return this.Canciones;}
        }
        //Método para agregar canciones
        public List<Cancion> AgregarCancion(Cancion cancion,Usuario usuario)
        {
            if (this.Creador == usuario)
            {
                if (this.Canciones.Contains(cancion))
                {
                    Console.WriteLine("La canción ya se encuentra en el playlist");
                }
                else
                {
                    this.Canciones.Add(cancion);
                    Console.WriteLine(cancion.Titulo + " se agregó exitosamente");
                }
            }
            else
            {
                Console.WriteLine("Únicamente el creador puede modificar esta playlist");
            }
            return this.Canciones;

        }
        //Método para eliminar canciones
        public List<Cancion> EliminarCancion(Cancion cancion, Usuario usuario)
        {
            if (this.Creador == usuario)
            {
                if (this.Canciones.Contains(cancion))
                {
                    this.Canciones.Remove(cancion);
                    Console.WriteLine(cancion.Titulo + " se eliminó exitosamente");
                }
                else
                {
                    Console.WriteLine("La cancion no existe en este playlist actualmente");
                }
            }
            else
            {
                Console.WriteLine("Únicamente el creador puede modificar esta playlist");
            }
            return this.Canciones;
        }
        //Método para mostrar canciones
        public  void MostrarCanciones()
        {
            if (this.Canciones == null)
            {
                Console.WriteLine("El playlist no existe");
            }
            if (this.Canciones.Count == 0) 
            {
                Console.WriteLine("El playlist etá vacío");
            }
            else
            {
                Console.WriteLine("----------" + this.NombrePlaylist + "----------");
                foreach (Cancion c in this.Canciones)
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}

