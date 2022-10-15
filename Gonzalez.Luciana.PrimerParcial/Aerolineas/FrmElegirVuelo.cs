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
                string destino = string.Empty;

                if (string.IsNullOrWhiteSpace(cmb_nacional.Text) == false)
                {
                    destino = cmb_nacional.Text;
                }
                else if (string.IsNullOrWhiteSpace(cmb_internacional.Text) == false)
                {
                    destino = cmb_internacional.Text;
                }

                if ((string.IsNullOrWhiteSpace(cmb_internacional.Text) || string.IsNullOrWhiteSpace(cmb_nacional.Text))
                    && string.IsNullOrWhiteSpace(cmb_origen.Text))
                {
                    listaFiltrada = Aerolinea.FiltrarVuelos(cb_wifi.Checked, cb_comida.Checked);
                }
                else
                {
                    listaFiltrada = Aerolinea.FiltrarVuelos(cmb_origen.Text, destino, cb_wifi.Checked, cb_comida.Checked);
                }


                if (listaFiltrada.Count == 0)
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

        /// <summary>
        /// Valida que se haya elegido destino y origen y que estos sean distintos entre si
        /// Muestra a través de un MessageBox los datos no validos, si los hubiera
        /// </summary>
        /// <returns>True si los datos son validos, false si no lo son</returns>
        private bool ValidarFiltros()
        {
            bool esValido = true;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Los siguientes datos no son validos:");

            //if ((cmb_internacional.Text == null || cmb_nacional.Text == null)
            //    && cmb_origen.Text == null)
            //{
            //    sb.AppendLine("Debe seleccionar un destino y un origen");
            //    esValido = false;
            //}

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
            cmb_origen.DataSource = Enum.GetValues(typeof(Origen));
            cmb_internacional.SelectedItem = null;
            cmb_nacional.SelectedItem = null;
            cmb_origen.SelectedItem = null;
                        

            dgv_listaVuelos.DataSource = null;
        }

        private void dgv_listaVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceVuelo = dgv_listaVuelos.CurrentRow.Index;
            unVuelo = listaFiltrada[indiceVuelo];   //acaaa
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (unVuelo is null)
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta seguro que desea cancelar?", "Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
