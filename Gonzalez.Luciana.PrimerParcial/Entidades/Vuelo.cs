using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Vuelo
    {
        private string destino;
        private string origen;
        private DateTime fechaInicio;
        private int duracion;   
        private string estadoVuelo;
        Avion avion;
        int cantidadAsientosTurista;
        int cantidadAsientosPremium;
        int cantidadAsientosTotal;
        //CANTIDAD DE PASAJEROS DEL VUELO. INICIALIZO EN CERO Y VOY SUMANDO

        public Vuelo(string destino, string origen, DateTime fechaInicio, Avion avion)
        {
            this.destino=destino;
            this.origen=origen;
            this.fechaInicio=fechaInicio;
            this.duracion=CalcularDuracionVuelo(destino);
            this.estadoVuelo = DefinirEstadoVuelo();
            this.avion = avion;
            this.cantidadAsientosTurista = avion.AsientosTurista;   //cuantos pasajeros permite el vuelo
            this.cantidadAsientosPremium = avion.AsientosPremium;
            this.cantidadAsientosTotal = avion.Asientos;
        }

        public int Asientos_Disponibles
        {
            get
            {
                return cantidadAsientosPremium + cantidadAsientosTurista;
            }
        }

        public int Asientos_Turista
        {
            set
            {
                cantidadAsientosTurista = value;
            }
            get
            {
                return cantidadAsientosTurista;
            }
        }

        public int Asientos_Premium
        {
            set
            {
                cantidadAsientosPremium = value;
            }
            get
            {
                return cantidadAsientosPremium;
            }
        }

        public string Origen
        {
            get
            {
                return origen;
            }
        }
        public string Destino
        {
            get
            {
                return destino;
            }
        }

        public int Duracion
        {
            get
            {
                return duracion;
            }
        }

        public DateTime Fecha_Partida
        {
            get
            {
                return fechaInicio;
            }
        }

        public string Estado_Vuelo
        {
            get
            {
                return estadoVuelo;
            }
        }

        public string Matricula_Avion
        {
            get
            {
                return avion.Matricula;
            }
        }

        private int CalcularDuracionVuelo(string destino)
        {
            Random random = new Random();
            int duracionCalculada;

            switch (destino)
            {
                case nameof(DestinosInternacionales.Miami):
                case nameof(DestinosInternacionales.Recife):
                case nameof(DestinosInternacionales.Roma):
                case nameof(DestinosInternacionales.Acapulco):
                    duracionCalculada = random.Next(8, 13);
            break;
            default:
                    duracionCalculada = random.Next(2, 5);
            break;
        }

            return duracionCalculada;
        }

    private string DefinirEstadoVuelo()
        {
            Random random = new Random();
            EstadoDeVuelo estadoVueloAleatorio = EstadoDeVuelo.Cancelado;
            
            switch (random.Next(0, 3))
            {
                case 0:
                    estadoVueloAleatorio = EstadoDeVuelo.Disponible;
                    break;
                case 1:
                    estadoVueloAleatorio = EstadoDeVuelo.Completo;
                    break;
                case 2:
                    estadoVueloAleatorio = EstadoDeVuelo.Cancelado;
                    break;
            }

            return estadoVueloAleatorio.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Origen: {origen}");
            sb.AppendLine($"Destino: {destino}");
            sb.AppendLine($"Fecha {fechaInicio}");

            return sb.ToString();
        }
    }
}
