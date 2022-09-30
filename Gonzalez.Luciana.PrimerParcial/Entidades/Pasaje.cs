using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasaje
    {
        private int codigoPasaje;
        private Pasajero pasajero;
        private Vuelo vuelo;
        private double costo;
        private string clase;
        
        public Pasaje(Pasajero pasajero, Vuelo vuelo, string clase)
        {
            //this.codigoPasaje=codigoPasaje;
            this.pasajero=pasajero;
            this.vuelo=vuelo;
            this.clase=clase;
            this.costo= pasajero.CalcularCostoPasaje(vuelo, clase); //cuando es de tipo premium?
        }

        public int CodigoPasaje
        {
            set
            {
                codigoPasaje = value;
            }
            get
            {
                return codigoPasaje;
            }
        }

        public double Costo
        {
            get
            {
                return costo;
            }
        }

        public string Nombre_Pasajero
        {
            get
            {
                return pasajero.Nombre;
            }
        }

        public string Apellido_Pasajero
        {
            get
            {
                return pasajero.Apellido;
            }
        }

        public string Clase
        {
            get
            {
                return clase;
            }
        }

        public string Bolso_De_Mano
        {
            get
            {
                return (pasajero.Bolso_De_Mano)? "Si" : "No";
            }
        }

        public int Peso_Valija
        {
            get
            {
                return pasajero.Peso_Valija;
            }
        }

        public string Origen
        {
            get
            {
                return vuelo.Origen;
            }
        }

        public string Destino
        {
            get
            {
                return vuelo.Destino;
            }
        }

        public int Duracion_Vuelo
        {
            get
            {
                return vuelo.Duracion;
            }
        }

        public DateTime Fecha_Partida
        {
            get
            {
                return vuelo.Fecha_Partida;
            }
        }

        public string Matricula_Avion
        {
            get
            {
                return vuelo.Matricula_Avion;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Codigo: {codigoPasaje}");
            sb.AppendLine($"Pasajero: {pasajero.Nombre} {pasajero.Apellido}");
            sb.AppendLine($"Origen: {vuelo.Origen}");
            sb.AppendLine($"Destino {vuelo.Destino}");
            sb.AppendLine($"Precio: {costo}");

            return sb.ToString();
        }

    }
}
