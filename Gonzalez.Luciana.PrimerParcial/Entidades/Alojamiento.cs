using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Alojamiento
    {
        protected double precio;
        protected bool desayuno;
        protected int kilometrosDesdeElCentroTuristico;

        public double Costo_Total
        {
            get
            {
                return precio;
            }
        }

        public string Desayuno
        {
            get
            {
                return (desayuno)? "Si" : "No";
            }
        }

        public int Km_Del_Centro
        {
            get
            {
                return kilometrosDesdeElCentroTuristico;
            }
        }

        protected abstract double DefinirCosto(int cantidadDias);

        protected int CalcularKilometrosDesdeElCentro()
        {
            Random kilometros = new Random();
            return kilometros.Next(5, 50);
        }
    }
}
