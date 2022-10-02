using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasajero:Persona
    {
        protected bool bolsoMano;
        protected int pesoValijaUno;

        public Pasajero(string nombre, string apellido, string genero, int dni, int edad, bool bolsoMano, int pesoValijaUno):base(nombre, apellido, dni, genero, edad)
        {
            this.nombre=nombre;
            this.apellido=apellido;
            this.genero=genero;
            this.dni=dni;
            this.edad=edad;
            this.bolsoMano=bolsoMano;
            this.pesoValijaUno=pesoValijaUno;
        }

        public Pasajero(string nombre, string apellido, string genero, int dni, int edad, bool bolsoMano):this(nombre, apellido, genero, dni, edad, bolsoMano, 0)
        {
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

        public int Peso_Valija
        {
            get
            {
                return pesoValijaUno;
            }
        }

        public virtual double CalcularCostoPasaje(Vuelo vuelo)
        {
            double costoPasaje = 0;
            //int duracion = Aerolinea.CalcularDuracionVuelo(vuelo);  //calcular duracion o vuelo.duracion???
            int duracion = vuelo.Duracion;

            switch (vuelo.Destino)
            {
                case nameof(DestinosInternacionales.Acapulco):
                case nameof(DestinosInternacionales.Miami):
                case nameof(DestinosInternacionales.Recife):
                case nameof(DestinosInternacionales.Roma):
                    costoPasaje = duracion * 100;
                    break;
                default:
                    costoPasaje = duracion * 50;
                    break;

            }
            return costoPasaje;
        }

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

        public override string ToString()
        {
            return base.ToString() + $"Bolso de mano: {Bolso_De_Mano}{Environment.NewLine}Peso valija 1: {Peso_Valija}";
        }
    }
}

