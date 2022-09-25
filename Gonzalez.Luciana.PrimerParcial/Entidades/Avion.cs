using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion
    {
        string matricula;
        int cantidadAsientos;   //premium + turista
        int cantidadAsientosTurista;
        int cantidadAsientosPremium;
        int cantidadBanios;
        int capacidadBodega;    //capacidad bolsos de mano?
        //----fin caracteristicas en comun----
        //List<Vuelo> listaVuelos;
        bool wifi;
        bool comida;


        public Avion(string matricula, int cantidadAsientos, int cantidadBanios, int capacidadBodega, bool wifi, bool comida)
        {
            this.matricula=matricula;
            this.cantidadAsientos = cantidadAsientos;
            this.cantidadAsientosTurista=(int)(cantidadAsientos * .8);
            this.cantidadAsientosPremium=(int)(cantidadAsientos * .2);
            this.cantidadBanios=cantidadBanios;
            this.capacidadBodega=capacidadBodega;
            this.wifi=wifi;
            this.comida=comida;
        }

        private bool Disponibilidad
        {
            get
            {
                return cantidadAsientos>0;
            }
        }

        public string Matricula
        {
            get
            {
                return matricula;
            }
        }

        public int Asientos
        {
            get
            {
                return cantidadAsientos;
            }
        }

        public int AsientosPremium
        {
            get
            {
                return cantidadAsientosPremium;
            }
        }

        public int AsientosTurista
        {
            get
            {
                return cantidadAsientosTurista;
            }
        }

        public int Banios
        {
            get
            {
                return cantidadBanios;
            }
        }

        public int CapacidadBodega
        {
            get
            {
                return capacidadBodega;
            }
        }

        public string Wifi
        {
            get
            {
                return (wifi) ? "SI" : "NO";
            }
        }
        public string Comida
        {
            get
            {
                return (comida) ? "SI" : "NO";
            }
        }
    }
}
