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
            dgv_clientes.DataSource = Aerolinea.listaClientes;
        }

        private void btnAgregarVuelo_Click(object sender, EventArgs e)
        {
            AltaVuelo frmAltaVuelo = new AltaVuelo();
            //this.Hide();
            DialogResult retorno= frmAltaVuelo.ShowDialog();

            if(retorno == DialogResult.OK)
            {
                Aerolinea.listaVuelos.Add(frmAltaVuelo.Vuelo);
                dgv_clientes.DataSource = null;
                dgv_clientes.DataSource = Aerolinea.listaVuelos;
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            AltaCliente frmAltaCliente = new AltaCliente();

            DialogResult respuesta = frmAltaCliente.ShowDialog();

            if(respuesta == DialogResult.OK)
            {
                Aerolinea.listaClientes.Add(frmAltaCliente.Cliente);
                dgv_clientes.DataSource = null;
                dgv_clientes.DataSource = Aerolinea.listaClientes;
            }
        }

        private void btnVenderPasaje_Click(object sender, EventArgs e)
        {
            AltaPasaje frmAltaPasaje = new AltaPasaje();
            DialogResult retorno = frmAltaPasaje.ShowDialog();

            if(retorno == DialogResult.OK)
            {
                (frmAltaPasaje.Pasaje).CodigoPasaje = GenerarCodigoPasaje();
                Aerolinea.listaPasajes.Add(frmAltaPasaje.Pasaje);
                dgv_clientes.DataSource = null;
                dgv_clientes.DataSource = Aerolinea.listaPasajes;

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
    }
}
