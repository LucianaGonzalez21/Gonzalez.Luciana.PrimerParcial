using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Entidades;

namespace Entidades
{
    public class Pasajero:Persona
    {
        //private string nombre;
        //private string apellido;
        //private string genero;
        //private int dni;
        //private int edad;
        protected bool bolsoMano;
        protected int pesoValijaUno;

        public Pasajero(string nombre, string apellido, string genero, int dni, int edad, bool bolsoMano, int pesoValijaUno):base(nombre, apellido, dni, genero, edad)
        {
            this.nombre=nombre;
            this.apellido=apellido;
            this.genero=genero;
            this.dni=dni;
            this.edad=edad;
            this.bolsoMano=bolsoMano;
            this.pesoValijaUno=pesoValijaUno;
        }

        public Pasajero(string nombre, string apellido, string genero, int dni, int edad, bool bolsoMano):this(nombre, apellido, genero, dni, edad, bolsoMano, 0)
        {
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

        public bool Bolso_De_Mano
        {
            get
            {
                return bolsoMano;
            }
        }

        public int Peso_Valija
        {
            get
            {
                return pesoValijaUno;
            }
        }
    }
}

