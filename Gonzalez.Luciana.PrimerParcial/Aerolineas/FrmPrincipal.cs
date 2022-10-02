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
        private int codigoVuelo;
        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            lblBienvenido.Text = usuario.ToString();
            codigoVuelo = 123;
        }

        public int CodigoVuelo
        {
            set
            {
                codigoVuelo = value;
            }
            get
            {
                return codigoVuelo;
            }
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
            //this.Hide();
            DialogResult retorno= frmAltaVuelo.ShowDialog();

            if(retorno == DialogResult.OK)
            {
                lbl_tituloDataGridView.Text = "Lista de Vuelos";
                Aerolinea.listaVuelos.Add(frmAltaVuelo.Vuelo);
                dgv_principal.DataSource = null;
                dgv_principal.DataSource = Aerolinea.listaVuelos;
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            AltaCliente frmAltaCliente = new AltaCliente();

            DialogResult respuesta = frmAltaCliente.ShowDialog();

            if(respuesta == DialogResult.OK)
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

            if(retorno == DialogResult.OK)
            {
                lbl_tituloDataGridView.Text = "Lista de Pasajes";
                (frmAltaPasaje.Pasaje).Codigo_Pasaje = GenerarCodigoPasaje();
                Aerolinea.listaPasajes.Add(frmAltaPasaje.Pasaje);
                dgv_principal.DataSource = null;
                dgv_principal.DataSource = Aerolinea.listaPasajes;

            }
        }

        private int GenerarCodigoPasaje()
        {
            CodigoVuelo += 1;
            return CodigoVuelo;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta seguro que desea salir?", "Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_listaClientes_Click(object sender, EventArgs e)
        {
            if(Aerolinea.listaClientes == null)
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
            if(Aerolinea.listaPasajeros == null)
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
                dgv_principal.Columns["Matricula_Avion"].Visible = false;
            }
        }

        private void btn_listaVuelos_Click(object sender, EventArgs e)
        {
            if(Aerolinea.listaVuelos == null)
            {
                MessageBox.Show("No hay vuelos para mostrar");
            }
            else
            {
                lbl_tituloDataGridView.Text = "Lista de Vuelos";
                dgv_principal.DataSource = null;
                dgv_principal.DataSource = Aerolinea.listaVuelos;
            }
        }
    }
}
