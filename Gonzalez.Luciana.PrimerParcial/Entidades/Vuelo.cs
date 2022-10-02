﻿using System;
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

        public string Matricula_Avion
        {
            get
            {
                return avion.Matricula;
            }
        }

        public string Wifi
        {
            get
            {
                return avion.Wifi;
            }
        }

        public string Comida
        {
            get 
            {
                return avion.Comida;
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

        public static bool operator ==(Vuelo vueloUno, Vuelo vueloDos)
        {
            if (vueloUno is null || vueloDos is null)
            {
                return false;
            }

            return vueloUno.GetType() == vueloDos.GetType()
                && vueloUno.Fecha_Partida == vueloDos.Fecha_Partida
                && vueloUno.Matricula_Avion == vueloDos.Matricula_Avion;
        }

        public static bool operator !=(Vuelo vueloUno, Vuelo vueloDos)
        {
            return !(vueloUno == vueloDos);
        }

        public override bool Equals(object obj)
        {
            Vuelo vuelo = obj as Vuelo;

            return vuelo is not null && this == vuelo;
        }

        public override int GetHashCode()
        {
            return (avion.Matricula, fechaInicio).GetHashCode();  //propiedades?
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Origen: {origen}");
            sb.AppendLine($"Destino: {destino}");
            sb.AppendLine($"Fecha: {fechaInicio.Date}");

            return sb.ToString();
        }
    }
}
