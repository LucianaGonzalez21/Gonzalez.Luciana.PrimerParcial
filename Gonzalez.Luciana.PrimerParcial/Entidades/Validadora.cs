using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validadora
    {
        public static bool ValidarCadena(string cadena)
        {
            if (string.IsNullOrEmpty(cadena) ||
                string.IsNullOrWhiteSpace(cadena))
            {
                return false;
            }

            return true;
        }

        public static bool ValidarCadenaSoloLetras(string cadena)
        {
            if( ValidarCadena(cadena) && Regex.IsMatch(cadena, @"^[a-zA-Z]+$"))
            {
                return true;
            }
            return false;
        }

        public static bool ValidarCadenaSoloNumerosConRango(string cadena, int minimo, int maximo)
        {
            if (int.TryParse(cadena, out int auxiliarNumero))
            {
                if(auxiliarNumero > minimo && minimo <maximo && auxiliarNumero < maximo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ValidarFechaNacimiento(DateTime fechaNacimiento)
        {
            return fechaNacimiento < DateTime.Now.Date;
        }

        public static bool ValidarFechaVuelo(DateTime fechaPartida)
        {
            return fechaPartida < DateTime.Now.Date;
        }
    }
}
