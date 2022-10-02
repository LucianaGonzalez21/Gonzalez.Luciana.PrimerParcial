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
    public partial class FrmElegirVuelo : Form
    {
        private Vuelo unVuelo;
        private int indiceVuelo;
        private List<Vuelo> listaFiltrada;

        public FrmElegirVuelo()
        {
            InitializeComponent();
        }

        public Vuelo Vuelo
        {
            get
            {
                return unVuelo;
            }
        }

        private void rd_nacional_CheckedChanged(object sender, EventArgs e)
        {
            cmb_nacional.DataSource = Enum.GetValues(typeof(DestinosNacionales));
            cmb_nacional.Enabled = true;
            cmb_internacional.Enabled = false;
            cmb_internacional.SelectedItem = null;
            cmb_origen.Enabled = true;
        }

        private void rd_internacional_CheckedChanged(object sender, EventArgs e)
        {
            cmb_internacional.DataSource = Enum.GetValues(typeof(DestinosInternacionales));
            cmb_internacional.Enabled = true;
            cmb_nacional.Enabled = false;
            cmb_nacional.SelectedItem = null;
            cmb_origen.SelectedItem = Origen.Buenos_Aires;
            cmb_origen.Enabled = false;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (ValidarFiltros())
            {
                string destino = "Miami";

                if (cmb_nacional.SelectedItem != null)
                {
                    destino = cmb_nacional.Text;
                }
                else if (cmb_internacional.SelectedItem != null)
                {
                    destino = cmb_internacional.Text;
                }

                listaFiltrada = Aerolinea.FiltrarVuelos(cmb_origen.Text, destino, cb_wifi.Checked, cb_comida.Checked);

                if (listaFiltrada == null)
                {
                    MessageBox.Show("No hay vuelos con esas caracteristicas");
                }
                else
                {
                    dgv_listaVuelos.DataSource = null;
                    dgv_listaVuelos.DataSource = listaFiltrada;
                }
            }
        }

        private bool ValidarFiltros()
        {
            bool esValido = true;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Los siguientes datos no son validos:");

            if ((cmb_internacional.Text == null || cmb_nacional.Text == null)
                && cmb_origen.Text == null)
            {
                sb.AppendLine("Debe seleccionar un destino y un origen");
                esValido = false;
            }

            if (cmb_origen.Text == cmb_nacional.Text)
            {
                sb.AppendLine("Origen y destino no pueden ser los mismos");
                esValido = false;
            }

            if (!esValido)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }

        private void FrmElegirVuelo_Load(object sender, EventArgs e)
        {
            //dgv_listaVuelos.DataSource = Aerolinea.listaVuelos;
            cmb_origen.DataSource = Enum.GetValues(typeof(Origen));
            //cmbAviones.SelectedItem = null;
            cmb_internacional.SelectedItem = null;
            cmb_nacional.SelectedItem = null;
            cmb_origen.SelectedItem = null;

            dgv_listaVuelos.DataSource = null;
        }

        private void dgv_listaVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceVuelo = dgv_listaVuelos.CurrentRow.Index;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (unVuelo == null)
            {
                MessageBox.Show("Primero debe elegir un vuelo");
            }
            else
            {
                unVuelo = listaFiltrada[indiceVuelo];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
