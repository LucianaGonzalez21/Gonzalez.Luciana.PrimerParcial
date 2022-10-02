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

        public static bool operator ==(Avion avionUno, Avion avionDos)
        {
            if (avionUno is null || avionDos is null)
            {
                return false;
            }

            return avionUno.GetType() == avionDos.GetType()
                && avionUno.matricula == avionDos.matricula;
        }

        public static bool operator !=(Avion avionUno, Avion avionDos)
        {
            return !(avionUno == avionDos);
        }

        public override bool Equals(object obj)
        {
            Avion avion = obj as Avion;

            return avion is not null && this == avion;
        }

        public override int GetHashCode()
        {
            return matricula.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Matricula: {matricula}");
            sb.AppendLine($"Cantidad asientos totales: {cantidadAsientos}");
            sb.AppendLine($"Cantidad asientos turista: {cantidadAsientosTurista}");
            sb.AppendLine($"Cantidad asientos premium: {cantidadAsientosPremium}");
            sb.AppendLine($"Cantidad de banios: {cantidadBanios}");
            sb.AppendLine($"Capacidad bodega: {capacidadBodega}");
            sb.AppendLine($"Tiene wifi: {Wifi}");
            sb.AppendLine($"Ofrece comida: {Comida}");

            return base.ToString();
        }
    }
}
