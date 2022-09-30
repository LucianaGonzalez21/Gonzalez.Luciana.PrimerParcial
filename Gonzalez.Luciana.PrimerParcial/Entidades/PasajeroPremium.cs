using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PasajeroPremium:Pasajero
    {
        protected int pesoValijaDos;

        public PasajeroPremium(string nombre, string apellido, string genero, int dni, int edad, bool bolsoMano, int pesoValijaUno, int pesoValijaDos) : base(nombre, apellido, genero, dni, edad, bolsoMano)
        {
            this.pesoValijaDos = pesoValijaDos;
        }

        public override double CalcularCostoPasaje(Vuelo vuelo, string clase)
        {
            return base.CalcularCostoPasaje(vuelo, clase) * 1.15;
        }
    }
}
