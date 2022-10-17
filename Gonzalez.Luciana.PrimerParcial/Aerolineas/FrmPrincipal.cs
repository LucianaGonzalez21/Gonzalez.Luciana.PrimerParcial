using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Aerolineas
{
    public partial class FrmPrincipal : Form
    {
        Form login;
        public FrmPrincipal(Usuario usuario, Form login)
        {
            InitializeComponent();
            lblBienvenido.Text = usuario.ToString();
            this.login = login;

            this.ttAyuda.SetToolTip(btnVerClientes, "Muestra la lista de clientes con los siguientes datos: nombre, apellido," +
                "dni, edad, genero, id y cantidad de viajes que realizo");
            this.ttAyuda.SetToolTip(btnVerAviones, "Muestra la lista de aviones con los siguientes datos: matricula, cantidad" +
                "total de asientos, asientos de clase premium y de clase turista, cantidad de banios que posee," +
                "capacidad en kilogramos de la bodega y si ofrece los servicios de comida y wifi");
            this.ttAyuda.SetToolTip(btnVerPasajeros, "Muestra la lista de pasajeros con los siguientes datos: nombre, apellido," +
                "clase en la que viaja, origen y destino de su vuelo, fecha de partida, matricula del avion con " +
                "el que viaja y tipo de alojamiento si es que tiene");
            this.ttAyuda.SetToolTip(btnVerVuelos, "Muestra la lista de vuelos con los siguientes datos: origen, destinos, duracion del vuelo" +
                "en horas, en que estado se encuentra y las caracteristicas del avion en las que se realiza ese vuelo");
            this.ttAyuda.SetToolTip(btnVerAlojamientos, "Muestra una lista con nombre y apellido de pasajeros que han seleccionado" +
                "un alojamiento al momento de comprar un pasaje, si eligieron hotel o cabania, a cuantos kilometros del" +
                "centro se encuentra y el costo por el total de dias de estadia");
            this.ttAyuda.SetToolTip(btnAgregarCliente, "Se pide los datos de la persona a registrarse como cliente: nombre, apellido," +
                "dni, genero y fecha de nacimiento. Si los datos son validos, el cliente queda registrado en la base de datos" +
                "de la aerolinea");
            this.ttAyuda.SetToolTip(btnAgregarVuelo, "Pide los siguientes datos para dar de alta un vuelo: el avion en el que se va a " +
                "realizar dicho vuelo, su origen y destino y finalmente la fecha en la que parte");
            this.ttAyuda.SetToolTip(btnVenderPasaje, "Da de alta un pasaje para un solo cliente, mostrando una lista de aquellos que se" +
                "encuentran registrados. Se pide la clase en la que se va a viajar, si se lleva o no equipaje de mano y equipaje de bodega, \naclarando" +
                " el peso de las valijas en el ultimo caso, y si incluye o no estadia en hotel o cabania, pudiendo elegir si es con o sin desayuno");
            this.ttAyuda.SetToolTip(btnVentaGrupo, "Da de alta pasajes para un grupo de clientes. Se pide la clase en la que van a viajar todos," +
                "que vuelo tomaran, y si se alojaran durante la estadia. Muestra los costos de alojamiento y vuelo y la suma total para el grupo");
            this.ttAyuda.SetToolTip(btnEstadisticas, "Abre un nuevo formulario donde se podran apreciar las estadisticas de la empresa, tales" +
                "como los destinos mas elegidos, la cantidad de viajes de los clientes que han registrado viajes, etc");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            dgv_principal.DataSource = Aerolinea.listaVuelos;
        }

        private void btnAgregarVuelo_Click(object sender, EventArgs e)
        {
            AltaVuelo frmAltaVuelo = new AltaVuelo();
            DialogResult retorno = frmAltaVuelo.ShowDialog();

            if (retorno == DialogResult.OK)
            {
                lbl_tituloDataGridView.Text = "Lista de Vuelos";
                Aerolinea.listaVuelos.Add(frmAltaVuelo.Vuelo);
                dgv_principal.DataSource = null;
                dgv_principal.DataSource = Aerolinea.listaVuelos;
                dgv_principal.Columns["Avion"].Visible = false;
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            AltaCliente frmAltaCliente = new AltaCliente();

            DialogResult respuesta = frmAltaCliente.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                lbl_tituloDataGridView.Text = "Lista de Clientes";
                Aerolinea.listaClientes.Add(frmAltaCliente.Cliente);
                dgv_principal.DataSource = null;
                dgv_principal.DataSource = Aerolinea.listaClientes;
            }
        }

        private void btnVenderPasaje_Click(object sender, EventArgs e)
        {
            AltaPasaje frmAltaPasaje = new AltaPasaje();
            DialogResult retorno = frmAltaPasaje.ShowDialog();

            if (retorno == DialogResult.OK)
            {
                lbl_tituloDataGridView.Text = "Lista de Pasajes";
                (frmAltaPasaje.Pasaje).Codigo_Pasaje = Aerolinea.GenerarCodigoPasaje();
                Aerolinea.listaPasajes.Add(frmAltaPasaje.Pasaje);
                dgv_principal.DataSource = null;
                dgv_principal.DataSource = Aerolinea.listaPasajes;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta seguro que desea salir?", "Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                this.Close();
                login.Close();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_listaClientes_Click(object sender, EventArgs e)
        {
            if (Aerolinea.listaClientes == null)
            {
                MessageBox.Show("No hay clientes para mostrar");
            }
            else
            {
                lbl_tituloDataGridView.Text = "Lista de Clientes";
                dgv_principal.DataSource = null;
                dgv_principal.DataSource = Aerolinea.listaClientes;
            }
        }

        private void btn_listaPasajeros_Click(object sender, EventArgs e)
        {
            if (Aerolinea.listaPasajeros == null)
            {
                MessageBox.Show("No hay pasajeros para mostrar");
            }
            else
            {
                lbl_tituloDataGridView.Text = "Lista de Pasajeros";
                dgv_principal.DataSource = null;
                dgv_principal.DataSource = Aerolinea.listaPasajes;
                dgv_principal.Columns["Costo"].Visible = false;
                dgv_principal.Columns["Codigo_Pasaje"].Visible = false;
                dgv_principal.Columns["Duracion_Vuelo"].Visible = false;
                dgv_principal.Columns["Alojamiento"].Visible = false;
                dgv_principal.Columns["Costo_Alojamiento"].Visible = false;
                dgv_principal.Columns["Desayuno"].Visible = false;
                dgv_principal.Columns["Km_Del_Centro"].Visible = false;
            }
        }

        private void btn_listaVuelos_Click(object sender, EventArgs e)
        {
            if (Aerolinea.listaVuelos == null)
            {
                MessageBox.Show("No hay vuelos para mostrar");
            }
            else
            {
                lbl_tituloDataGridView.Text = "Lista de Vuelos";
                dgv_principal.DataSource = null;
                dgv_principal.DataSource = Aerolinea.listaVuelos;
                dgv_principal.Columns["Avion"].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAltaGrupo frmAltaGrupo = new FrmAltaGrupo();
            DialogResult retorno = frmAltaGrupo.ShowDialog();

            if (retorno == DialogResult.OK)
            {
                foreach (Pasaje item in frmAltaGrupo.ListaPasajes)
                {
                    item.Codigo_Pasaje = Aerolinea.GenerarCodigoPasaje();
                    Aerolinea.listaPasajes.Add(item);
                }

                lbl_tituloDataGridView.Text = "Lista de Pasajes";
                dgv_principal.DataSource = null;
                dgv_principal.DataSource = Aerolinea.listaPasajes;
            }
        }

        private void btn_listaAviones_Click(object sender, EventArgs e)
        {
            lbl_tituloDataGridView.Text = "Lista de Aviones";
            dgv_principal.DataSource = null;
            dgv_principal.DataSource = Aerolinea.listaAviones;
        }

        private void btn_estadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas();
            DialogResult retorno = frmEstadisticas.ShowDialog();

        }

        private void btn_alojamientos_Click(object sender, EventArgs e)
        {
            List<Pasaje> listaPasajesConAlojamiento;

            listaPasajesConAlojamiento = Aerolinea.FiltrarPasajesPorAlojamientos();

            if (listaPasajesConAlojamiento.Count > 0)
            {
                lbl_tituloDataGridView.Text = "Lista de alojamientos";
                dgv_principal.DataSource = null;
                dgv_principal.DataSource = listaPasajesConAlojamiento;
                dgv_principal.Columns["Clase"].Visible = false;
                dgv_principal.Columns["Costo"].Visible = false;
                dgv_principal.Columns["Codigo_Pasaje"].Visible = false;
                dgv_principal.Columns["Duracion_Vuelo"].Visible = false;
                dgv_principal.Columns["Origen"].Visible = false;
                dgv_principal.Columns["Destino"].Visible = false;
                dgv_principal.Columns["Fecha_Partida"].Visible = false;
                dgv_principal.Columns["Matricula_Avion"].Visible = false;
                dgv_principal.Columns["Alojamiento"].Visible = false;
            }
            else
            {
                MessageBox.Show("No hay alojamientos para mostrar");
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
  
        }

    }
}
