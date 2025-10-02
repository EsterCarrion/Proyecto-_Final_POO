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
        }
        public Persona()
        {
            this.sexo = true;
            this.nombre = "Sin Nombre";
            this.apellido = "Sin Apellido";
            this.fnacimiento = new Fecha(1, 1, 2000);
        }
        public bool Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public Fecha Fnacimiento
        {
            get { return fnacimiento; }
            set { fnacimiento = value; }
        }
        public string Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }
        
        public override string ToString()
        {
            string sexo = this.Sexo ? " Masculino " : " Femenino ";
            return
                  "Nombre y Apellido:" + this.Nombre + " " + this.Apellido + "\n" +
                  "Sexo : " + this.Sexo + "\n"+
                  "Fecha de Nacimiento: " + this.Fnacimiento + "\n" +
                  "Edad: " + this.Fnacimiento.CalcularEdad() + "Años" + "\n"+
                  "Nacionalidad: " + this.Nacionalidad ;
        }
      
        public string CompararEdad(Persona p2)
        {
            if (this.Fnacimiento.Año < p2.Fnacimiento.Año)
            {
                return this.Nombre + " es mayor.";
            }
            else if (this.Fnacimiento.Año > p2.Fnacimiento.Año)
            {
                return this.Nombre + " es menor.";
            }
            else
            {
                if (this.Fnacimiento.Mes < p2.Fnacimiento.Mes)
                {
                    return this.Nombre + " es mayor.";
                }
                else if (this.Fnacimiento.Mes > p2.Fnacimiento.Mes)
                {
                    return this.Nombre + " es menor.";
                }
                else
                {
                    if (this.Fnacimiento.Dia < p2.Fnacimiento.Dia)
                    {
                        return this.Nombre + " es mayor.";
                    }
                    else if (this.Fnacimiento.Dia > p2.Fnacimiento.Dia)
                    {
                        return this.Nombre + " es menor.";
                    }
                    else return this.Nombre + " y " + p2.Nombre + " tienen la misma edad";
                }
            }

        }
       
        public string ActualizarNombre(string nombre)
        {
            return this.Nombre = nombre;
        }
        public string ActualizarApellido(string apellido)
        {
            return this.Apellido = apellido;
        }
        public Fecha ActualizarFecha(Fecha fecha)
        {
            return this.Fnacimiento = fecha;
        }
    }
}
