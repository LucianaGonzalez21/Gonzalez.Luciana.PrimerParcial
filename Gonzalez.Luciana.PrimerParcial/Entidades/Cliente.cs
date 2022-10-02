using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente: Persona
    {
        //int idCliente;
        public Cliente(string nombre, string apellido, int dni, string genero, int edad/*, int idCliente*/):base(nombre, apellido, dni, genero, edad)
        {
            //this.idCliente = idCliente;
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

        public int DNI
        {
            get
            {
                return dni;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
        }

        public string Genero
        {
            get
            {
                return genero;
            }
        }


        public static bool operator ==(Cliente clienteUno, Cliente clienteDos)
        {
            if(clienteUno is null || clienteDos is null)
            {
                return false;
            }

            return clienteUno.GetType() == clienteDos.GetType()
                && clienteUno.DNI == clienteDos.DNI;
        }

        public static bool operator !=(Cliente clienteUno, Cliente clienteDos)
        {
            return !(clienteUno == clienteDos);
        }

        public override bool Equals(object obj)
        {
            Cliente cliente = obj as Cliente;

            return cliente is not null && this == cliente;
        }

        public override int GetHashCode()
        {
            return dni.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
