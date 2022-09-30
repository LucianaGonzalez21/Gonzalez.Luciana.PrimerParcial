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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Genero: {genero}");
            sb.AppendLine($"Edad: {edad}");

            return sb.ToString();
        }
    }
}
