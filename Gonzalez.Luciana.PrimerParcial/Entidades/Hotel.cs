using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hotel: Alojamiento
    {
        public Hotel(bool desayuno, int cantidadDias)
        {
            this.desayuno = desayuno;
            this.kilometrosDesdeElCentroTuristico = CalcularKilometrosDesdeElCentro();
            this.precio = DefinirCosto(cantidadDias);   
        }

        protected override double DefinirCosto(int cantidadDias)
        {
            return 1200 * cantidadDias;
        }
    }
}
