using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected string genero;
        protected int edad;

        public Persona(string nombre, string apellido, int dni, string genero, int edad)
        {
            this.nombre=nombre;
            this.apellido=apellido;
            this.dni=dni;
            this.genero=genero;
            this.edad=edad;
        }

        public static int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;

            int diferenciaDeDias = (int)(fechaActual - fechaNacimiento).TotalDays;

            return diferenciaDeDias / 360;
        }
    }
}
