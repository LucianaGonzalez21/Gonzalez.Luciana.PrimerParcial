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
        private Alojamiento alojamiento;
        
        public Pasaje(Pasajero pasajero, Vuelo vuelo, string clase)
        {
            this.pasajero = pasajero;
            this.vuelo = vuelo;
            this.clase = clase;
            this.costo = CalcularImporteBruto();
        }

        public Pasaje(Pasajero pasajero, Vuelo vuelo, string clase, Alojamiento alojamiento): this(pasajero, vuelo, clase)
        {
            this.alojamiento = alojamiento;
        }

        public int Codigo_Pasaje
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

        public string Alojamiento
        {
            get
            {
                return (alojamiento is null) ? "No" : "Si";
            }
        }

        public string Tipo_Alojamiento
        {
            get
            {
                if(alojamiento is null)
                {
                    return "-";
                }
                else
                {
                    return (alojamiento is Hotel) ? "Hotel" : "Cabania";
                }
            }
        }

        public double Costo_Alojamiento
        {
            get
            {
                return (alojamiento is null) ? 0 : alojamiento.Costo_Total;
            }
        }

        public string Desayuno
        {
            get
            {
                return (alojamiento is null) ? "-" : alojamiento.Desayuno;
            }
        }

        public int Km_Del_Centro
        {
            get
            {
                return (alojamiento is null) ? 0 : alojamiento.Km_Del_Centro;
            }
        }

        public static bool operator ==(Pasaje pasajeUno, Pasaje pasajeDos)
        {
            if (pasajeUno is null || pasajeDos is null)
            {
                return false;
            }

            return pasajeUno.GetType() == pasajeDos.GetType()
                && pasajeUno.pasajero == pasajeDos.pasajero
                && pasajeUno.vuelo == pasajeDos.vuelo;
        }

        public static bool operator !=(Pasaje pasajeUno, Pasaje pasajeDos)
        {
            return !(pasajeUno == pasajeDos);
        }

        public override bool Equals(object obj)
        {
            Pasaje pasaje = obj as Pasaje;

            return pasaje is not null && this == pasaje;
        }

        public override int GetHashCode()
        {
            return (vuelo, pasajero).GetHashCode();
        }

        private double CalcularImporteBruto()
        {
            return pasajero.CalcularCostoPasaje(vuelo) * 1.21;
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
