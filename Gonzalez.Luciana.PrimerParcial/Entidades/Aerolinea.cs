using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public static class Aerolinea
    {
        public static Avion[] listaAviones;
        public static List<Vuelo> listaVuelos;
        public static List<Pasajero> listaPasajeros;
        public static List<PasajeroPremium> listaPasajerosPremium;
        public static List<Usuario> listaUsuarios;
        public static List<Pasaje> listaPasajes;
        public static List<Cliente> listaClientes;

        static Aerolinea()
        {
            listaAviones = new Avion[7];
            listaPasajeros = new List<Pasajero>();
            listaUsuarios = new List<Usuario>();
            listaVuelos = new List<Vuelo>();
            listaPasajes = new List<Pasaje>();
            listaClientes = new List<Cliente>();
            listaPasajerosPremium = new List<PasajeroPremium>();

            AgregarAviones();
            AgregarUsuarios();
            AgregarVuelos();
            AgregarPasajeros();
            AgregarPasajes();
            AgregarClientes();
        }

        private static void AgregarClientes()
        {
            listaClientes.Add(new Cliente("Martin", "Martinez", 30123456, nameof(Generos.Masculino), 30));
            listaClientes.Add(new Cliente("Emiliano", "Gomez", 36123456, nameof(Generos.Masculino), 30));
            listaClientes.Add(new Cliente("Rosa", "Martinez", 15155406, nameof(Generos.Femenino), 60));
            listaClientes.Add(new Cliente("Morena", "Rodriguez", 15159159, nameof(Generos.Femenino), 30));
            listaClientes.Add(new Cliente("Jose", "Lopez", 15259159, nameof(Generos.Masculino), 40));
            listaClientes.Add(new Cliente("Maria", "Ramirez", 15159459, nameof(Generos.Femenino), 30));
            listaClientes.Add(new Cliente("Pedro", "Gutierrez", 38159159, nameof(Generos.No_Binario), 30));
            listaClientes.Add(new Cliente("Pablo", "Garcia", 15299159, nameof(Generos.Femenino), 40));
            listaClientes.Add(new Cliente("Micaela", "Gomez", 15157159, nameof(Generos.No_Binario), 32));
            listaClientes.Add(new Cliente("Mariela", "Gomez", 35157159, nameof(Generos.Femenino), 23));
            listaClientes.Add(new Cliente("German", "Gomez", 20157159, nameof(Generos.Masculino), 29));
        }

        private static void AgregarPasajes()
        {
            listaPasajes.Add(new Pasaje(listaPasajeros[0], listaVuelos[0], "Turista"));
            listaPasajes.Add(new Pasaje(listaPasajeros[2], listaVuelos[3], "Turista"));
            listaPasajes.Add(new Pasaje(listaPasajeros[1], listaVuelos[2], "Premium"));
        }

        private static void AgregarPasajeros()
        {
            listaPasajeros.Add(new Pasajero("Emiliano", "Gomez", nameof(Generos.Masculino), 36123456, 30, true, 20));
            listaPasajeros.Add(new Pasajero("Laura", "Fabiani", nameof(Generos.Femenino), 40123456, 22, true, 15));
            listaPasajeros.Add(new Pasajero("David", "Gutierrez", nameof(Generos.No_Binario), 12123123, 22, false));
            listaPasajeros.Add(new Pasajero("Rosa", "Martinez", nameof(Generos.Femenino), 15155406, 60, false));
        }

        private static void AgregarAviones()
        {
            listaAviones[0] = new Avion("ABC123", 10, 6, 30000, true, true);
            listaAviones[1] = new Avion("DEF456", 350, 8, 28000, true, true);
            listaAviones[2] = new Avion("GHI789", 250, 8, 30000, true, true);
            listaAviones[3] = new Avion("JKL321", 350, 6, 20000, false, true);
            listaAviones[4] = new Avion("MNO654", 250, 6, 31000, false, true);
            listaAviones[5] = new Avion("PQR987", 300, 6, 28000, true, true);
            listaAviones[6] = new Avion("STU147", 200, 6, 30000, false, false);
        }

        private static void AgregarVuelos()
        {
            listaVuelos.Add(new Vuelo(nameof(DestinosInternacionales.Acapulco), nameof(Origen.Buenos_Aires), Convert.ToDateTime("10/21/2022"), listaAviones[0]));
            listaVuelos.Add(new Vuelo(nameof(DestinosInternacionales.Miami), nameof(Origen.Buenos_Aires), Convert.ToDateTime("12/15/2022"), listaAviones[2]));
            listaVuelos.Add(new Vuelo(nameof(DestinosNacionales.Cordoba), nameof(Origen.Iguazu), Convert.ToDateTime("11/13/2023"), listaAviones[4]));
            listaVuelos.Add(new Vuelo(nameof(DestinosNacionales.Jujuy), nameof(Origen.Neuquen), Convert.ToDateTime("10/16/2022"), listaAviones[5]));
        }

        private static void AgregarUsuarios()
        {
            listaUsuarios.Add(new Usuario("lucas", "1234", "Lucas", "Rodriguez"));
            listaUsuarios.Add(new Usuario("ornella", "1234", "Ornella", "Curcio"));
            listaUsuarios.Add(new Usuario("Ignacio", "1234", "Ignacio", "Smirlian"));
            listaUsuarios.Add(new Usuario("Esteban", "1234", "Esteban", "Prieto"));
        }

        public static Usuario ValidarUsuario(string usuario, string clave)
        {
            if (Validadora.ValidarCadena(usuario) && Validadora.ValidarCadena(clave))
            {
                foreach (Usuario item in listaUsuarios)
                {
                    if (item.usuario == usuario && item.clave == clave)
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        public static int CalcularDuracionVuelo(Vuelo vuelo)
        {
            Random numeroAleatorio = new Random();
            int duracion = 0;

            switch (vuelo.Destino)
            {
                case nameof(DestinosInternacionales.Acapulco):
                case nameof(DestinosInternacionales.Miami):
                case nameof(DestinosInternacionales.Recife):
                case nameof(DestinosInternacionales.Roma):
                    duracion = numeroAleatorio.Next(8, 13);
                    break;
                default:
                    duracion = numeroAleatorio.Next(2, 5);
                    break;
            }

            return duracion;
        }

        public static bool EsCliente(Cliente unCliente)
        {
            foreach (Cliente item in Aerolinea.listaClientes)
            {
                if (item.Equals(unCliente) && item.GetHashCode() == unCliente.GetHashCode())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool EsAvionDisponible(Vuelo unVuelo)
        {
            foreach (Vuelo item in listaVuelos)
            {
                if (item.Equals(unVuelo) && item.GetHashCode() == unVuelo.GetHashCode())
                {
                    return false;
                }
            }
            return true;
        }

        public static bool EsPasajeroEnElVuelo(Pasaje unPasaje)
        {
            foreach(Pasaje item in listaPasajes)
            {
                if(item.Equals(unPasaje) && item.GetHashCode() == unPasaje.GetHashCode())
                {
                    return true;
                }
            }
            return false;
        }

        public static List<Vuelo> FiltrarVuelos(string origen, string destino, bool wifi, bool comida)
        {
            List<Vuelo> listaFiltrada = new List<Vuelo>();
            string wifiString;
            string comidaString;

            if (wifi)
            {
                wifiString = "SI";
            }
            else
            {
                wifiString = "NO"; 
            }

            if(comida)
            {
                comidaString = "SI";
            }
            else
            {
                comidaString = "NO";
            }

            foreach (Vuelo item in listaVuelos)
            {
                if(item.Origen == origen && item.Destino == destino && item.Comida == comidaString && item.Wifi == wifiString)
                {
                    listaFiltrada.Add(item);
                }
            }

            return listaFiltrada;
        }
    }
}
