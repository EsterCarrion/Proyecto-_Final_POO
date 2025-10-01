using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_POO
{
    internal class Usuario
    {
        private string nombre;
        private string apellido;
        private string correo;
        private string contraseña;
        private string pais;
        private bool cuentaPremium;
        private Fecha fnacimiento;

        public Usuario(string nombre, string apellido, string correo, string contraseña, string pais, bool cuentaPremium,Fecha fnacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.contraseña = contraseña;
            this.pais = pais;
            this.cuentaPremium = cuentaPremium;
            this.fnacimiento = fnacimiento;
            
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido 
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public string Correo
        {
            get { return this.correo; }
            set 
            {
                if (value.Contains("@") && value.Contains(".com"))
                {
                    this.Correo = value;
                }
                else
                    this.Correo = "Correo inválido";
            }
        }
        public string Contraseña
        {
            get { return this.contraseña; }
            set { this.contraseña= value; }
        }
        public string Pais
        {
            get { return this.pais; }
            set { this.pais = value; }
        }
        public bool CuentaPremium
        {
            get { return this.cuentaPremium;}
            set {  this.cuentaPremium = value;}
        }
        public Fecha FechaNacimiento
        {
            get { return this.fnacimiento; }
            set {  this.fnacimiento = value;}

        }
        
        public string MostrarPerfil()
        {
            if (this.CuentaPremium == false)
                return 
                "Nombre y Apellido: " + this.Nombre + "  " + this.Apellido + "\n" +
                "Edad : " + this.FechaNacimiento.CalcularEdad() + " Años" + "\n" +
                "Pais : " + this.Pais + "\n" +
                 "Correo electónico : " + this.correo + "\n" +
                 "Cuenta Premium: NO";
            else 
                return
                     "Nombre y Apellido: " + this.Nombre + "  " + this.Apellido + "\n" +
                "Edad : " + this.FechaNacimiento.CalcularEdad() + " Años" + "\n" +
                "Pais : " + this.Pais + "\n" +
                 "Correo electónico : " + this.correo + "\n" +
                 "Cuenta Premium: SI";

        }
    }
    
}
