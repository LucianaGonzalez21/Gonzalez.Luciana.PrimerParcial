using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente: Persona
    {
        //string nombre;
        //string apellido;
        //int dni;
        //string genero;
        //int edad;

        public Cliente(string nombre, string apellido, int dni, string genero, int edad):base(nombre, apellido, dni, genero, edad)
        {
            //this.nombre=nombre;
            //this.apellido=apellido;
            //this.dni=dni;
            //this.genero=genero;
            //this.edad=edad;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
        }

        public int DNI
        {
            get
            {
                return dni;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
        }

        public string Genero
        {
            get
            {
                return genero;
            }
        }

        //public static int CalcularEdad(DateTime fechaNacimiento)
        //{
        //    DateTime fechaActual = DateTime.Now;

        //    int diferenciaDeDias = (int)(fechaActual - fechaNacimiento).TotalDays;

        //    return diferenciaDeDias / 360;
        //}

        public string MostrarCliente()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Genero: {genero}");
            sb.AppendLine($"Edad: {edad}");

            return sb.ToString();
        }
    }
}
