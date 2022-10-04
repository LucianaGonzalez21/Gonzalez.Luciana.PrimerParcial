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
        private static Dictionary<string, double> diccionarioDestinos;

        static Aerolinea()
        {
            listaAviones = new Avion[7];
            listaUsuarios = new List<Usuario>();
            listaVuelos = new List<Vuelo>();
            listaClientes = new List<Cliente>();
            listaPasajeros = new List<Pasajero>();
            listaPasajerosPremium = new List<PasajeroPremium>();
            listaPasajes = new List<Pasaje>();
            codigoPasaje = 123;
            idCliente = 999;
            InicializarDiccionarioDestinos();

            AgregarAviones();
            AgregarUsuarios();
            AgregarVuelos();
            AgregarPasajeros();
            AgregarPasajes();
            AgregarClientes();
            AgregarVuelosAClientes();
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
            listaPasajes.Add(new Pasaje(listaPasajeros[3], listaVuelos[4], "Premium"));          
        }

        /// <summary>
        /// Recorre la lista hardcodeada de clientes y les suma 1 a su contador de viajes
        /// si estan a su vez registrados como pasajeros
        /// </summary>
        private static void AgregarVuelosAClientes()
        {
            foreach (Pasajero pasajero in listaPasajeros)
            {
                foreach (Cliente cliente in listaClientes)
                {
                    if (pasajero == cliente)
                    {
                        cliente.Cantidad_Viajes++;
                        break;
                    }
                }
            }
        }

        private static void AgregarPasajeros()
        {
            listaPasajeros.Add(new Pasajero("Emiliano", "Gomez", nameof(Generos.Masculino), 36123456, 30, true, 20));
            listaPasajeros.Add(new Pasajero("Mariela", "Gomez", nameof(Generos.Femenino), 35157159, 23, true, 15));
            listaPasajeros.Add(new Pasajero("German", "Gomez", nameof(Generos.Masculino), 20157159, 29, false));
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

        /// <summary>
        /// Valida si el usuario y clave ingresados por parametro coinciden con
        /// los de los usuarios ya registrados
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="clave"></param>
        /// <returns>Devuelve el Usuario si ya se encuentra en el sistema o null si no</returns>
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

        /// <summary>
        /// Calcula la duración del vuelo ingresado por parametro, a través de un
        /// numero aleatorio
        /// </summary>
        /// <param name="vuelo"></param>
        /// <returns>Devuelve un entero entre 2 y 4 para destinos nacionales y un entero entre 8 y 12 para internacionales</returns>
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

        /// <summary>
        /// Recorre la lista de clientes para comparar si el cliente pasado por parámetro ya existe en
        /// el sistema
        /// </summary>
        /// <param name="unCliente">Es el cliente a buscar en el sistema</param>
        /// <returns>True si existe, false si no</returns>
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

        /// <summary>
        /// Verifica que el avion del vuelo pasado por parametro tiene un vuelo
        /// registrado en la fecha del mismo
        /// </summary>
        /// <param name="unVuelo">Es el vuelo cuyo avion se verificará si posee otro viaje en la fecha del vuelo</param>
        /// <returns>True si el avion está disponible en la fecha, false si no</returns>
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

        /// <summary>
        /// Verifica si el pasajero relacionado al pasaje ingresado por parametro
        /// ya cuenta con un pasaje para el vuelo
        /// </summary>
        /// <param name="unPasaje"></param>
        /// <returns>True si el pasajero ya tiene un pasaje para el vuelo que intenta
        /// sacar, false si no</returns>
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

        /// <summary>
        /// crea una nueva lista que tenga las caracteristicas pasadas por parametro:
        /// origen, destino y si tiene o no wifi y comida
        /// </summary>
        /// <param name="origen"></param>
        /// <param name="destino"></param>
        /// <param name="wifi"></param>
        /// <param name="comida"></param>
        /// <returns>Devuelve una lista con los vuelos que cumplen con esas caracteristicas</returns>
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


        /// <summary>
        /// Inicializa el diccionarioDestinos con los enumerados de destinos nacionales
        /// e internacionales y pone en 0 todos sus values.
        /// </summary>
        /// <returns></returns>
        private static void InicializarDiccionarioDestinos()
        {
            diccionarioDestinos = new Dictionary<string, double>();

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
        }

        /// <summary>
        /// Carga el diccionarioDestinos recorriendo la lista de pasajes vendidos, y segun
        /// el destino del mismo, aumenta en 1 el value de esa key
        /// </summary>
        /// <returns></returns>
        private static void CargarDiccionarioDestinos()
        {
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
        }

        /// <summary>
        /// Recorre el diccionarioDestinos buscando el value mas alto 
        /// </summary>
        /// <returns>Devuelve el value mas alto del diccionarioDestinos</returns>
        private static double BuscarMaximoValorEnDiccionarioDestinos()
        {
            InicializarDiccionarioDestinos();
            CargarDiccionarioDestinos();
            double valorMaximoDeVecesElegido = 0;
            bool flag = true;

            foreach (KeyValuePair<string, double> item in diccionarioDestinos)
            {
                if (flag || item.Value > valorMaximoDeVecesElegido)
                {
                    valorMaximoDeVecesElegido = item.Value;
                    flag = false;
                }
            }

            return valorMaximoDeVecesElegido;
        }

        /// <summary>
        /// Busca en el diccionarioDestinos, aquellas keys que tengan el value mas alto
        /// y las agrega a un stringbuilder
        /// </summary>
        /// <returns>Devuelve un string con los destinos mas elegidos por los pasajeros</returns>
        public static string CalcularDestinosMasElegidos()
        {
            StringBuilder sb = new StringBuilder();
            double valorMaximoDeVecesElegido = BuscarMaximoValorEnDiccionarioDestinos();

            sb.AppendLine("Destinos mas elegidos:");

            foreach (KeyValuePair<string, double> item in diccionarioDestinos)
            {
                if (item.Value == valorMaximoDeVecesElegido)
                {
                    sb.AppendLine(item.Key);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Crea un vector donde se guardan las horas de vuelo de cada avion, en 
        /// el orden en que estan declarados los mismos
        /// </summary>
        /// <returns>Devuelve el vector con las horas</returns>
        private static int[] CalcularHorasVueloPorAvion()
        {
            int[] vectorHorasVuelo = new int[] { 0, 0, 0, 0, 0, 0, 0 };

            foreach (Pasaje item in listaPasajes)
            {
                switch (item.Matricula_Avion)
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

        /// <summary>
        /// Recorre los vectores de aviones y de horas de vuelo, y guarda en un string
        /// la matricula del avion con sus horas de vuelo
        /// </summary>
        /// <returns>Devuelve un string con todos los aviones y sus horas de vuelo correspondientes</returns>
        public static string InformarHorasDeVueloPorAvion()
        {
            int[] vectorHorasVuelo = CalcularHorasVueloPorAvion();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i<7; i++)
            {
                sb.AppendLine($"Matricula avion: {listaAviones[i].Matricula}   Horas de vuelo: {vectorHorasVuelo[i]}");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Carga el diccionarioDestinos con los costos de cada pasaje hacia ese destino
        /// </summary>
        /// <returns></returns>
        private static void CargarDiccionarioDestinosConCostos()
        {
            if (diccionarioDestinos is not null)
            {
                foreach (Pasaje item in listaPasajes)
                {
                    switch (item.Destino)
                    {
                        case nameof(DestinosNacionales.Bariloche):
                            diccionarioDestinos["Bariloche"] += item.Costo;
                            break;
                        case nameof(DestinosNacionales.Cordoba):
                            diccionarioDestinos["Cordoba"] += item.Costo;
                            break;
                        case nameof(DestinosNacionales.Corrientes):
                            diccionarioDestinos["Corrientes"] += item.Costo;
                            break;
                        case nameof(DestinosNacionales.Iguazu):
                            diccionarioDestinos["Iguazu"] += item.Costo;
                            break;
                        case nameof(DestinosNacionales.Jujuy):
                            diccionarioDestinos["Jujuy"] += item.Costo;
                            break;
                        case nameof(DestinosNacionales.Mendoza):
                            diccionarioDestinos["Mendoza"] += item.Costo;
                            break;
                        case nameof(DestinosNacionales.Neuquen):
                            diccionarioDestinos["Neuquen"] += item.Costo;
                            break;
                        case nameof(DestinosNacionales.Posadas):
                            diccionarioDestinos["Posadas"] += item.Costo;
                            break;
                        case nameof(DestinosNacionales.Puerto_Madryn):
                            diccionarioDestinos["Puerto_Madryn"] += item.Costo;
                            break;
                        case nameof(DestinosNacionales.Salta):
                            diccionarioDestinos["Salta"] += item.Costo;
                            break;
                        case nameof(DestinosNacionales.Santa_Rosa):
                            diccionarioDestinos["Santa_Rosa"] += item.Costo;
                            break;
                        case nameof(DestinosNacionales.Santiego_Del_Estero):
                            diccionarioDestinos["Santiego_Del_Estero"] += item.Costo;
                            break;
                        case nameof(DestinosNacionales.Trelew):
                            diccionarioDestinos["Trelew"] += item.Costo;
                            break;
                        case nameof(DestinosNacionales.Tucuman):
                            diccionarioDestinos["Tucuman"] += item.Costo;
                            break;
                        case nameof(DestinosNacionales.Ushuaia):
                            diccionarioDestinos["Ushuaia"] += item.Costo;
                            break;
                        case nameof(DestinosInternacionales.Acapulco):
                            diccionarioDestinos["Acapulco"] += item.Costo;
                            break;
                        case nameof(DestinosInternacionales.Miami):
                            diccionarioDestinos["Miami"] += item.Costo;
                            break;
                        case nameof(DestinosInternacionales.Recife):
                            diccionarioDestinos["Recife"] += item.Costo;
                            break;
                        case nameof(DestinosInternacionales.Roma):
                            diccionarioDestinos["Roma"] += item.Costo;
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// crea un stringbuilder con todos los destinos y cuanto facturó cada uno
        /// </summary>
        /// <returns>Devuelve un string con toda la informacion</returns>
        public static string InformarDestinosConFacturacion()
        {
            StringBuilder sb = new StringBuilder();
            InicializarDiccionarioDestinos();
            CargarDiccionarioDestinosConCostos();

            foreach (KeyValuePair<string, double> item in diccionarioDestinos)
            {
                sb.AppendLine($"Destino: {item.Key}  Facturacion: ${item.Value}");
            }

            return sb.ToString();
        }


        /// <summary>
        /// crea un stringbuilder con los nombres, apellidos y cantidad de viajes de cada pasajero
        /// </summary>
        /// <returns>Devuelve el string con toda la informacion</returns>
        public static string InformarCantidadDeVuelosPorPasajero()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Cliente item in listaClientes)
            {
                sb.AppendLine($"{item.Nombre} {item.Apellido} {item.Cantidad_Viajes}");
            }

            return sb.ToString();
        }

    }
}

