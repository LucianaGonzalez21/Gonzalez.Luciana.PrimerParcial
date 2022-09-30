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

        public PasajeroPremium(string nombre, string apellido, string genero, int dni, int edad, bool bolsoMano, int pesoValijaUno, int pesoValijaDos) : base(nombre, apellido, genero, dni, edad, bolsoMano, pesoValijaUno)
        {
            this.pesoValijaDos = pesoValijaDos;
        }

        public int Peso_Valija_2
        {
            get
            {
                return pesoValijaDos;
            }
        }

        public override double CalcularCostoPasaje(Vuelo vuelo)
        {
            return base.CalcularCostoPasaje(vuelo) * 1.15;
        }

        public override string ToString()
        {
            return base.ToString() + $"{Environment.NewLine}Peso valija 2: {pesoValijaDos}";
        }
    }
}
