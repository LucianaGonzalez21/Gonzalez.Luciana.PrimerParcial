using System;

namespace Entidades
{
    public class Usuario
    {
        public string usuario;
        public string clave;
        private string nombre;
        private string apellido;

        public Usuario(string usuario, string clave, string nombre, string apellido)
        {
            this.usuario=usuario;
            this.clave=clave;
            this.nombre=nombre;
            this.apellido=apellido;
        }

        public override string ToString()
        {
            return $"Bienvenido/a, {nombre} {apellido}. Fecha: {DateTime.Today.ToString("dd/MM/yyyy")}";
        }
    }
}
