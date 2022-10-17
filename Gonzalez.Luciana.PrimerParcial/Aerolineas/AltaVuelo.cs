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
    public partial class AltaVuelo : Form
    {
        Vuelo nuevoVuelo;
        int indice;
        Avion avionSeleccionado;
        string destino;
        public AltaVuelo()
        {
            InitializeComponent();
        }

        public Vuelo Vuelo
        {
            get
            {
                return nuevoVuelo;
            }
        }

        private void AltaVuelo_Load(object sender, EventArgs e)
        {
            dgv_aviones.DataSource = Aerolinea.listaAviones;
            cmbOrigen.DataSource = Enum.GetValues(typeof(Origen));
            cmbDestinosInternacionales.SelectedItem = null;
            cmbDestinosNacionales.SelectedItem = null;
            cmbOrigen.SelectedItem = null;
        }

        private void rdNacional_CheckedChanged(object sender, EventArgs e)
        {
            cmbDestinosNacionales.DataSource = Enum.GetValues(typeof(DestinosNacionales));
            cmbDestinosNacionales.Enabled = true;
            cmbDestinosInternacionales.Enabled = false;
            cmbDestinosInternacionales.SelectedItem = null;
            cmbOrigen.Enabled = true;
        }

        private void rdInternacional_CheckedChanged(object sender, EventArgs e)
        {
            cmbDestinosInternacionales.DataSource = Enum.GetValues(typeof(DestinosInternacionales));
            cmbDestinosNacionales.Enabled = false;
            cmbDestinosInternacionales.Enabled = true;
            cmbDestinosNacionales.SelectedItem = null;
            cmbOrigen.SelectedItem = Origen.Buenos_Aires;
            cmbOrigen.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (string.IsNullOrWhiteSpace(cmbDestinosNacionales.Text) == false)
                {
                    destino = cmbDestinosNacionales.Text;
                }
                else if (string.IsNullOrWhiteSpace(cmbDestinosInternacionales.Text) == false)
                {
                    destino = cmbDestinosInternacionales.Text;
                }

                nuevoVuelo = new Vuelo(destino, cmbOrigen.Text, dtp_fechaPartida.Value.Date, avionSeleccionado);

                if (Aerolinea.EsAvionDisponible(nuevoVuelo))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lbl_textoError.Text = "El avion ya registra un vuelo en esa fecha";
                    lbl_textoError.ForeColor = Color.Red;
                    lbl_textoError.Visible = true;
                }

            }
        }

        private bool ValidarDatos()
        {
            bool esValido = true;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Los siguientes datos no son validos:");

            if (cmbDestinosInternacionales.Text == null || cmbDestinosNacionales.Text == null)
            {
                sb.AppendLine("Debe seleccionar un destino");
                esValido = false;
            }

            if(cmbOrigen.Text == null)
            {
                sb.AppendLine("Debe elegir un origen");
                esValido = false;
            }

            if (cmbOrigen.Text == cmbDestinosNacionales.Text)
            {
                sb.AppendLine("Origen y destino no pueden ser los mismos");
                esValido = false;
            }

            if(Validadora.ValidarFechaVuelo(dtp_fechaPartida.Value))
            {
                sb.AppendLine("Fecha de partida no valida");
                esValido = false;
            }

            if(avionSeleccionado is null)
            {
                sb.AppendLine("Debe seleccionar un avion");
                esValido = false;
            }

            if (!esValido)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return esValido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta seguro que desea cancelar?", "Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dgv_aviones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgv_aviones.CurrentRow.Index;
            avionSeleccionado = Aerolinea.listaAviones[indice];
            lblMatriculaAvion.Text = avionSeleccionado.Matricula;
            lblMatriculaAvion.Visible = true;
        }
    }
}
