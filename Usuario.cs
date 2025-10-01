using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_POO
{
    internal class Usuario:Persona
    {
        private string correo;
        private string contraseña;
        private bool cuentaPremium;

        public Usuario(bool sexo, string nombre, string apellido, Fecha fnacimiento, string pais,string correo  ,string contraseña,bool cuentaPremium)
            : base (sexo,nombre, apellido,fnacimiento,pais)
        { 


            this.correo = correo;
            this.contraseña = contraseña;
            this.cuentaPremium = cuentaPremium;
            
            
        }
 
        public string Correo
        {
            get { return this.correo; }
            set 
            {
                if (value.Contains("@") && value.Contains(".com"))
                {
                    this.correo = value;
                }
                else
                    this.correo = "Correo inválido";
            }
        }
        public string Contraseña
        {
            get { return this.contraseña; }
            set { this.contraseña= value; }
        }
        public bool CuentaPremium
        {
            get { return this.cuentaPremium;}
            set {  this.cuentaPremium = value;}
        }
        public string MostrarPerfil()
        {
            if (this.CuentaPremium == false)
                return 
                "Nombre y Apellido: " + this.Nombre + "  " + this.Apellido + "\n" +
                "Edad : " + this.Fnacimiento.CalcularEdad() + " Años" + "\n" +
                "Pais : " + this.Pais + "\n" +
                 "Correo electónico : " + this.correo + "\n" +
                 "Cuenta Premium: NO";
            else 
                return
                     "Nombre y Apellido: " + this.Nombre + "  " + this.Apellido + "\n" +
                "Edad : " + this.Fnacimiento.CalcularEdad() + " Años" + "\n" +
                "Pais : " + this.Pais + "\n" +
                 "Correo electónico : " + this.correo + "\n" +
                 "Cuenta Premium: SI";

        }
    }
    
}
