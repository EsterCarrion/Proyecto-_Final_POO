using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_POO
{
    internal class Fecha
    {
        private int dia;
        private int mes;
        private int año;

        //uso de get y set (propiedades)
        public int Dia
        {
            get { return this.dia; }
            set { this.dia = value; }
        }
        public int Mes
        {
            get { return this.mes; }
            set { this.mes = value; }
        }
        public int Año
        {
            get { return this.año; }
            set { this.año = value; }
        }

        //3 constructores //eso me dijo que estaba medio mal, no me acuerdo, creo que Cristian
        public Fecha(int dia, int mes, int año)
        {
            if (Validar(dia, mes, año))
            {
                this.dia = dia;
                this.mes = mes;
                this.año = año;
            }
            else
            {
                throw new ArgumentException("Fecha inválida");
            }

        }
        public Fecha()
        {
            this.dia = DateTime.Now.Day;
            this.mes = DateTime.Now.Month;
            this.año = DateTime.Now.Year;
        }
        public Fecha(int año)
        {
            if (año >= 1)
            {
                this.dia = 1;
                this.mes = 1;
                this.año = año;
            }
            else
            {
                throw new ArgumentException("Fecha inválida");
            }
        }
        private bool Validar(int dia, int mes, int año)
        {
            if (año < 1) return false;
            if (mes < 1 || mes > 12) return false;

            int[] diaspormes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (Bisiesto(año))
            {
                diaspormes[1] = 29;
            }
            if (dia < 1 || dia > diaspormes[mes - 1])
            {
                return false;
            }
            return true;
        }
        private bool Bisiesto(int año)
        {
            if ((año % 4 == 0) && (año % 100 != 0) || (año % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string MostrarFecha()
        {
            return $"{dia:D2}/{mes:D2}/{año}";

        }
        public string MostrarBisiesto()
        {
            if (Bisiesto(año))
            {
                return "El " + " año " + año + " es bisiesto";
            }
            else
            {
                return "El año " + año + " no es bisiesto";
            }
        }
        public override string ToString()
        {
            return MostrarFecha() + " - " + MostrarBisiesto();
        }
        // Método para aumentar y disminuir un dia en la fecha //
        public void AumentarDia()
        {
            int diasFebrero;

            if (Bisiesto(año))
            {
                diasFebrero = 29;
            }
            else
            {
                diasFebrero = 28;
            }

            int[] diaspormes = { 31, diasFebrero, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            this.Dia++;

            if (this.Dia > diaspormes[this.Mes - 1])
            {
                this.Dia = 1;
                this.Mes++;
                if (this.Mes > 12)
                {
                    this.mes = 1;
                    this.Año++;
                }
            }
        }
        public void DisminuirDia()
        {
            int diasfebrero;

            if (Bisiesto(año))
            {
                diasfebrero = 29;
            }
            else
            {
                diasfebrero = 28;
            }

            int[] diaspormes = { 31, diasfebrero, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            this.Dia--;

            if (this.Dia < 1)
            {
                this.Mes--;
                if (this.Mes < 1)
                {
                    this.Mes = 12;
                    this.Año--;
                    if (this.Año < 1) this.Año = 1;
                }
                this.Dia = diaspormes[mes - 1];
            }
        }
        //Método para comparar fechas
        public string CompararFechas(Fecha f2)
        {
            if (this.Año > f2.Año)
            {
                return "La fecha es mayor";
            }
            else if (this.Año < f2.Año)
            {
                return "La fecha es menor";
            }
            else
            {
                if (this.Mes > f2.Mes)
                {
                    return "la fecha es mayor";
                }
                else if (this.Mes < f2.Mes)
                {
                    return "la fecha es menor";
                }
                else
                {
                    if (this.Dia > f2.Dia)
                    {
                        return "La fecha es mayor";
                    }
                    else if (this.Dia < f2.Dia)
                    {
                        return "La fecha es menor";
                    }
                    else
                    {
                        return "Las fechas son iguales";
                    }
                }
            }

        }
        //Metodo que calcule la edad // si ya lo mejoro les muestro el lunes a mas tardar
        public string CalcularEdad()
        {
            Fecha actual = new Fecha(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);

            int edad = actual.Año - this.Año;
            return "Este año cumpliste o cumplirás " + edad + " años";
        }
    }
}
