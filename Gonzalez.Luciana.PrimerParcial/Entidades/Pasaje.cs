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
            this.costo= Aerolinea.CalcularCostoPasaje(vuelo, clase);
        }

        public int CodigoPasaje
        {
            set
            {
                codigoPasaje = value;
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

        //public double CalcularCostoPasaje(string destino, string clase)  
        //{
        //    double costoPasaje = 0;
        //    int duracion = CalcularDuracionVuelo(destino);

        //    switch(destino)
        //    {
        //        //case nameof(DestinosInternacionales.Acapulco):
        //        //case nameof(DestinosInternacionales.Miami):
        //        //case nameof(DestinosInternacionales.Recife):
        //        //case nameof(DestinosInternacionales.Roma):
        //        case "Acapulco":
        //        case "Miami":
        //        case "Recife":
        //        case "Roma":
        //            costoPasaje = duracion * 100;
        //            break;
        //        default:
        //            costoPasaje = duracion * 50;
        //            break;

        //    }

        //    if(clase == "Premium")
        //    {
        //        double recargoPremium = costoPasaje * .15;
        //        costoPasaje += recargoPremium;                
        //    }

        //    return costoPasaje;

        //}

        //public int CalcularDuracionVuelo(string destino)
        //{
        //    Random numeroAleatorio = new Random();
        //    int duracion = 0;

        //    switch(destino)
        //    {
        //        case nameof(DestinosInternacionales.Acapulco):
        //        case nameof(DestinosInternacionales.Miami):
        //        case nameof(DestinosInternacionales.Recife):
        //        case nameof(DestinosInternacionales.Roma):
        //            duracion = numeroAleatorio.Next(8, 13);
        //            break;
        //        default:
        //            duracion = numeroAleatorio.Next(2, 5);
        //            break;
        //    }

        //    return duracion;
        //}

    }
}
