using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_POO
{
    internal class Persona
    {
        
        private bool sexo;
        private string nombre;
        private string apellido;
        private Fecha fnacimiento;
        private string nacionalidad;


        
        public Persona(bool sexo, string nombre, string apellido, Fecha fnacimiento, string nacionalidad)
        {
            this.sexo = sexo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fnacimiento = fnacimiento;
            this.nacionalidad = nacionalidad;
        }

        public Persona(bool sexo, Fecha fnacimiento)
        {
            this.sexo = sexo;
            this.nombre = "Sin nombre";
            this.apellido = "Sin Apellido";
            this.fnacimiento = fnacimiento;
            this.nacionalidad = "Sin nacionalidad";
        }

        // 2.1 Constructor vacio
        public Persona()
        {
            this.sexo = true;
            this.nombre = "Sin Nombre";
            this.apellido = "Sin Apellido";
            this.fnacimiento = new Fecha();
            this.nacionalidad = "Sin nacionalidad";
        }
        public bool Sexo
        {
            get { return this.sexo; }
            set { this.sexo = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set {
                if (value == " " || value == null)
                {
                    Console.WriteLine("El nombre no puede estar vacío, se le asignara: Sin nombre "); //Validación de espacio o casilla vacía
                    this.nombre = "Sin nombre";
                }
                else
                {
                    this.nombre = value; 
                }
                }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set {
                if (value == " " || value == null)
                {
                    Console.WriteLine("El apellido no puede estar vacío, se le asignara: Sin apellido "); //Validación de espacio o casilla vacía
                    this.apellido = "Sin apellido";
                }
                else
                {
                    this.apellido = value; 
                }
                }
        }
        public Fecha Fnacimiento
        {
            get { return fnacimiento; }
            set { fnacimiento = value; }
        }
        public string Nacionalidad
        {
            get { return this.nacionalidad; }
            set {
                if (value == " " || value == null)
                {
                    Console.WriteLine("La nacionalidad no puede estar vacío, se le asignara: Sin nacionalidad "); //Validación de espacio o casilla vacía
                    this.apellido = "Sin nacionalidad";
                }
                else
                {
                    this.nacionalidad = value; ;
                }
                }
        }
        
        public override string ToString()
        {
            string sexo = this.Sexo ? " Masculino " : " Femenino ";
            return
                  "Nombre y Apellido:" + this.Nombre + " " + this.Apellido + "\n" +
                  "Sexo : " + this.Sexo + "\n"+
                  "Fecha de Nacimiento: " + this.Fnacimiento + "\n" +
                  "Edad: " + this.Fnacimiento.CalcularEdad() + "Años" + "\n"+
                  "Nacionalidad: " + this.nacionalidad ;
        }
    }
}
