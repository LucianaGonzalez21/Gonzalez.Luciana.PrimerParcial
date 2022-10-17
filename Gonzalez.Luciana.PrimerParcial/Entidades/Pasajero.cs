using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasajero : Persona
    {
        protected bool bolsoMano;
        protected int pesoValijaUno;
        protected int pesoValijaDos;        

        public Pasajero(string nombre, string apellido, string genero, int dni, int edad, bool bolsoMano, int pesoValijaUno, int pesoValijaDos) : base(nombre, apellido, dni, genero, edad)
        {
            this.bolsoMano = bolsoMano;
            this.pesoValijaUno = pesoValijaUno;
            this.pesoValijaDos = pesoValijaDos;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
        }

        public string Bolso_De_Mano
        {
            get
            {
                return bolsoMano ? "Si" : "No";
            }
        }

        public int Kg_Valija1
        {
            get
            {
                return pesoValijaUno;
            }
        }

        public int Kg_Valija2
        {
            get
            {                  
                return pesoValijaDos;
            }
        }

        //public virtual double CalcularCostoPasaje(Vuelo vuelo)
        //{
        //    double costoPasaje = 0;
        //    int duracion = vuelo.Duracion;

        //    switch (vuelo.Destino)
        //    {
        //        case nameof(DestinosInternacionales.Acapulco):
        //        case nameof(DestinosInternacionales.Miami):
        //        case nameof(DestinosInternacionales.Recife):
        //        case nameof(DestinosInternacionales.Roma):
        //            costoPasaje = duracion * 100;
        //            break;
        //        default:
        //            costoPasaje = duracion * 50;
        //            break;

        //    }
        //    return costoPasaje;
        //}

        public static bool operator ==(Pasajero pasajeroUno, Pasajero pasajeroDos)
        {
            if (pasajeroUno is null || pasajeroDos is null)
            {
                return false;
            }

            return pasajeroUno.GetType() == pasajeroDos.GetType()
                && pasajeroUno.dni == pasajeroDos.dni;
        }

        public static bool operator !=(Pasajero pasajeroUno, Pasajero pasajeroDos)
        {
            return !(pasajeroUno == pasajeroDos);
        }

        public override bool Equals(object obj)
        {
            Pasajero pasajero = obj as Pasajero;

            return pasajero is not null && this == pasajero;
        }

        public override int GetHashCode()
        {
            return dni.GetHashCode();
        }

        public static bool operator ==(Pasajero pasajero, Cliente cliente)
        {
            if (pasajero is null || cliente is null)
            {
                return false;
            }

            return pasajero.dni == cliente.DNI;
        }

        public static bool operator !=(Pasajero pasajero, Cliente cliente)
        {
            return !(pasajero == cliente);
        }

        public override string ToString()
        {
            return base.ToString() + $"Bolso de mano: {Bolso_De_Mano}{Environment.NewLine}Peso valija 1: {Kg_Valija1}" +
                $"{Environment.NewLine}Peso valija 2:{Kg_Valija2}";
        }
    }
}

