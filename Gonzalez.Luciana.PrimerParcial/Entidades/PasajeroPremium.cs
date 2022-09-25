using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PasajeroPremium: Pasajero
    {
        private int pesoValijaDos;

        public PasajeroPremium(string nombre, string apellido, string genero, int dni, int edad, bool bolsoMano, int pesoValijaUno, int pesoValijaDos) : base(nombre, apellido, genero, dni, edad, bolsoMano, pesoValijaUno)
        {
            this.pesoValijaDos = pesoValijaDos;
        }
    }
}
