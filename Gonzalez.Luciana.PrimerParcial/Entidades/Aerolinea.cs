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
        public static int codigoPasaje;
        public static int idCliente;
        private static Dictionary<string, int> diccionarioDestinos;

        static Aerolinea()
        {
            listaAviones = new Avion[7];
            listaPasajeros = new List<Pasajero>();
            listaUsuarios = new List<Usuario>();
            listaVuelos = new List<Vuelo>();
            listaPasajes = new List<Pasaje>();
            listaClientes = new List<Cliente>();
            listaPasajerosPremium = new List<PasajeroPremium>();
            codigoPasaje = 123;
            idCliente = 999;
            diccionarioDestinos = InicializarDiccionarioDestinos();

            AgregarAviones();
            AgregarUsuarios();
            AgregarVuelos();
            AgregarPasajeros();
            AgregarPasajes();
            AgregarClientes();
        }

        private static void AgregarClientes()
        {
            listaClientes.Add(new Cliente("Martin", "Martinez", 30123456, nameof(Generos.Masculino), 30, GenerarIdCliente()));
            listaClientes.Add(new Cliente("Emiliano", "Gomez", 36123456, nameof(Generos.Masculino), 30, GenerarIdCliente()));
            listaClientes.Add(new Cliente("Rosa", "Martinez", 15155406, nameof(Generos.Femenino), 60, GenerarIdCliente()));
            listaClientes.Add(new Cliente("Morena", "Rodriguez", 15159159, nameof(Generos.Femenino), 30, GenerarIdCliente()));
            listaClientes.Add(new Cliente("Jose", "Lopez", 15259159, nameof(Generos.Masculino), 40, GenerarIdCliente()));
            listaClientes.Add(new Cliente("Maria", "Ramirez", 15159459, nameof(Generos.Femenino), 30, GenerarIdCliente()));
            listaClientes.Add(new Cliente("Pedro", "Gutierrez", 38159159, nameof(Generos.No_Binario), 30, GenerarIdCliente()));
            listaClientes.Add(new Cliente("Pablo", "Garcia", 15299159, nameof(Generos.Femenino), 40, GenerarIdCliente()));
            listaClientes.Add(new Cliente("Micaela", "Gomez", 15157159, nameof(Generos.No_Binario), 32, GenerarIdCliente()));
            listaClientes.Add(new Cliente("Mariela", "Gomez", 35157159, nameof(Generos.Femenino), 23, GenerarIdCliente()));
            listaClientes.Add(new Cliente("German", "Gomez", 20157159, nameof(Generos.Masculino), 29, GenerarIdCliente()));
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
            listaVuelos.Add(new Vuelo(nameof(DestinosNacionales.Neuquen), nameof(Origen.Salta), Convert.ToDateTime("11/10/2022"), listaAviones[4]));
            listaVuelos.Add(new Vuelo(nameof(DestinosNacionales.Trelew), nameof(Origen.Ushuaia), Convert.ToDateTime("02/03/2023"), listaAviones[6]));
            listaVuelos.Add(new Vuelo(nameof(DestinosNacionales.Santiego_Del_Estero), nameof(Origen.Ushuaia), Convert.ToDateTime("12/30/2022"), listaAviones[1]));
            listaVuelos.Add(new Vuelo(nameof(DestinosNacionales.Santa_Rosa), nameof(Origen.Puerto_Madryn), Convert.ToDateTime("08/15/2023"), listaAviones[3]));
            listaVuelos.Add(new Vuelo(nameof(DestinosInternacionales.Recife), nameof(Origen.Buenos_Aires), Convert.ToDateTime("03/15/2023"), listaAviones[3]));
            listaVuelos.Add(new Vuelo(nameof(DestinosInternacionales.Roma), nameof(Origen.Buenos_Aires), Convert.ToDateTime("01/23/2023"), listaAviones[2]));
            listaVuelos.Add(new Vuelo(nameof(DestinosInternacionales.Recife), nameof(Origen.Buenos_Aires), Convert.ToDateTime("01/30/2023"), listaAviones[1]));
            listaVuelos.Add(new Vuelo(nameof(DestinosInternacionales.Miami), nameof(Origen.Buenos_Aires), Convert.ToDateTime("02/28/2023"), listaAviones[0]));
        }

        private static void AgregarUsuarios()
        {
            listaUsuarios.Add(new Usuario("lucas", "1234", "Lucas", "Rodriguez"));
            listaUsuarios.Add(new Usuario("ornella", "1234", "Ornella", "Curcio"));
            listaUsuarios.Add(new Usuario("ignacio", "1234", "Ignacio", "Smirlian"));
            listaUsuarios.Add(new Usuario("esteban", "1234", "Esteban", "Prieto"));
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
            foreach (Pasaje item in listaPasajes)
            {
                if (item.Equals(unPasaje) && item.GetHashCode() == unPasaje.GetHashCode())
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

            if (comida)
            {
                comidaString = "SI";
            }
            else
            {
                comidaString = "NO";
            }

            foreach (Vuelo item in listaVuelos)
            {
                if (item.Origen == origen && item.Destino == destino && item.Comida == comidaString && item.Wifi == wifiString)
                {
                    listaFiltrada.Add(item);
                }
            }

            return listaFiltrada;
        }

        public static int GenerarCodigoPasaje()
        {
            codigoPasaje++;

            return codigoPasaje;
        }

        public static int GenerarIdCliente()
        {
            idCliente++;

            return idCliente;
        }

        private static Dictionary<string, int> InicializarDiccionarioDestinos()
        {
            //key: destino, value: contador de ctdad veces elegido
            diccionarioDestinos = new Dictionary<string, int>();

            diccionarioDestinos.Add(nameof(DestinosNacionales.Bariloche), 0);
            diccionarioDestinos.Add(nameof(DestinosNacionales.Cordoba), 0);
            diccionarioDestinos.Add(nameof(DestinosNacionales.Corrientes), 0);
            diccionarioDestinos.Add(nameof(DestinosNacionales.Iguazu), 0);
            diccionarioDestinos.Add(nameof(DestinosNacionales.Jujuy), 0);
            diccionarioDestinos.Add(nameof(DestinosNacionales.Mendoza), 0);
            diccionarioDestinos.Add(nameof(DestinosNacionales.Neuquen), 0);
            diccionarioDestinos.Add(nameof(DestinosNacionales.Posadas), 0);
            diccionarioDestinos.Add(nameof(DestinosNacionales.Puerto_Madryn), 0);
            diccionarioDestinos.Add(nameof(DestinosNacionales.Salta), 0);
            diccionarioDestinos.Add(nameof(DestinosNacionales.Santa_Rosa), 0);
            diccionarioDestinos.Add(nameof(DestinosNacionales.Santiego_Del_Estero), 0);
            diccionarioDestinos.Add(nameof(DestinosNacionales.Trelew), 0);
            diccionarioDestinos.Add(nameof(DestinosNacionales.Tucuman), 0);
            diccionarioDestinos.Add(nameof(DestinosNacionales.Ushuaia), 0);
            diccionarioDestinos.Add(nameof(DestinosInternacionales.Acapulco), 0);
            diccionarioDestinos.Add(nameof(DestinosInternacionales.Miami), 0);
            diccionarioDestinos.Add(nameof(DestinosInternacionales.Recife), 0);
            diccionarioDestinos.Add(nameof(DestinosInternacionales.Roma), 0);

            return diccionarioDestinos;
        }

        private static Dictionary<string, int> CargarDiccionarioDestinos()
        {
            //Dictionary<string, int> diccionarioDestinos = InicializarDiccionarioDestinos();

            if (diccionarioDestinos is not null)
            {
                foreach (Pasaje item in listaPasajes)
                {
                    switch (item.Destino)
                    {
                        case nameof(DestinosNacionales.Bariloche):
                            diccionarioDestinos["Bariloche"]++;
                            break;
                        case nameof(DestinosNacionales.Cordoba):
                            diccionarioDestinos["Cordoba"]++;
                            break;
                        case nameof(DestinosNacionales.Corrientes):
                            diccionarioDestinos["Corrientes"]++;
                            break;
                        case nameof(DestinosNacionales.Iguazu):
                            diccionarioDestinos["Iguazu"]++;
                            break;
                        case nameof(DestinosNacionales.Jujuy):
                            diccionarioDestinos["Jujuy"]++;
                            break;
                        case nameof(DestinosNacionales.Mendoza):
                            diccionarioDestinos["Mendoza"]++;
                            break;
                        case nameof(DestinosNacionales.Neuquen):
                            diccionarioDestinos["Neuquen"]++;
                            break;
                        case nameof(DestinosNacionales.Posadas):
                            diccionarioDestinos["Posadas"]++;
                            break;
                        case nameof(DestinosNacionales.Puerto_Madryn):
                            diccionarioDestinos["Puerto_Madryn"]++;
                            break;
                        case nameof(DestinosNacionales.Salta):
                            diccionarioDestinos["Salta"]++;
                            break;
                        case nameof(DestinosNacionales.Santa_Rosa):
                            diccionarioDestinos["Santa_Rosa"]++;
                            break;
                        case nameof(DestinosNacionales.Santiego_Del_Estero):
                            diccionarioDestinos["Santiego_Del_Estero"]++;
                            break;
                        case nameof(DestinosNacionales.Trelew):
                            diccionarioDestinos["Trelew"]++;
                            break;
                        case nameof(DestinosNacionales.Tucuman):
                            diccionarioDestinos["Tucuman"]++;
                            break;
                        case nameof(DestinosNacionales.Ushuaia):
                            diccionarioDestinos["Ushuaia"]++;
                            break;
                        case nameof(DestinosInternacionales.Acapulco):
                            diccionarioDestinos["Acapulco"]++;
                            break;
                        case nameof(DestinosInternacionales.Miami):
                            diccionarioDestinos["Miami"]++;
                            break;
                        case nameof(DestinosInternacionales.Recife):
                            diccionarioDestinos["Recife"]++;
                            break;
                        case nameof(DestinosInternacionales.Roma):
                            diccionarioDestinos["Roma"]++;
                            break;
                    }
                }
            }
            return diccionarioDestinos;
        }

        //recorrer diccionario y buscar el value mas alto
        private static int BuscarMaximoValorEnDiccionarioDestinos()
        {
            Dictionary<string, int> diccionarioDestinos = CargarDiccionarioDestinos();
            int valorMaximoDeVecesElegido = 0;
            bool flag = true;

            foreach (KeyValuePair<string, int> item in diccionarioDestinos)
            {
                if(flag || item.Value > valorMaximoDeVecesElegido)
                {
                    valorMaximoDeVecesElegido = item.Value;
                    flag = false;
                }
            }

            return valorMaximoDeVecesElegido;
        }

        public static string CalcularDestinosMasElegidos()
        {
            StringBuilder sb = new StringBuilder();
            int valorMaximoDeVecesElegido = BuscarMaximoValorEnDiccionarioDestinos();

            sb.AppendLine("Destinos mas elegidos:");

            foreach (KeyValuePair<string, int> item in diccionarioDestinos)
            {
                if(item.Value == valorMaximoDeVecesElegido)
                {
                    sb.AppendLine(item.Key);
                }
            }
            return sb.ToString();
        }

        private static int[] CalcularHorasVueloPorAvion()
        {
            int[] vectorHorasVuelo = new int[] { 0, 0, 0, 0, 0, 0, 0 };

            foreach(Pasaje item in listaPasajes)
            {
                switch(item.Matricula_Avion)
                {
                    case "ABC123":
                        vectorHorasVuelo[0] += item.Duracion_Vuelo;
                        break;
                    case "DEF456":
                        vectorHorasVuelo[1] += item.Duracion_Vuelo;
                        break;
                    case "GHI789":
                        vectorHorasVuelo[2] += item.Duracion_Vuelo;
                        break;
                    case "JKL321":
                        vectorHorasVuelo[3] += item.Duracion_Vuelo;
                        break;
                    case "MNO654":
                        vectorHorasVuelo[4] += item.Duracion_Vuelo;
                        break;
                    case "PQR987":
                        vectorHorasVuelo[5] += item.Duracion_Vuelo;
                        break;
                    case "STU147":
                        vectorHorasVuelo[6] += item.Duracion_Vuelo;
                        break;
                }
            }
            return vectorHorasVuelo;
        }

        public static string InformarHorasDeVueloPorAvion()
        {
            int[] vectorHorasVuelo = CalcularHorasVueloPorAvion();
            StringBuilder sb = new StringBuilder();

            //sb.AppendLine("Matricula de Avion           Horas");
            //ver como acomodar los datos en columnas 

            for(int i=0; i<7; i++)
            {
                sb.AppendLine($"Matricula avion: {listaAviones[i].Matricula}   Horas de vuelo: {vectorHorasVuelo[i]}");
            }

            return sb.ToString();
        }
    }
}

