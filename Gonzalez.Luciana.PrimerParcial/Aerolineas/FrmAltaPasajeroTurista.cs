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
    public partial class FrmAltaPasajeroTurista : Form
    {
        private bool equipajeMano;
        private int indiceCliente;
        private Pasajero unPasajero;
        private string clase;
        private Cliente unCliente;
        public FrmAltaPasajeroTurista(string clase)
        {
            InitializeComponent();
            this.clase = clase;

        }
        public Pasajero Pasajero
        {
            get
            {
                return unPasajero;
            }
        }

        private void FrmAltaPasajeroTurista_Load(object sender, EventArgs e)
        {
            dgv_listaClientes.DataSource = Aerolinea.listaClientes;

            if (clase == "Turista")
            {
                num_valijaUno.Maximum = 25;
                num_valijaDos.Enabled = false;
            }
            else
            {
                num_valijaUno.Maximum = 21;
                num_valijaDos.Maximum = 21;
            }
        }

        private void rd_equipajeManoSi_CheckedChanged(object sender, EventArgs e)
        {
            equipajeMano = true;
        }

        private void rd_equipajeManoNo_CheckedChanged(object sender, EventArgs e)
        {
            equipajeMano = false;
        }

        private bool ValidarDatos()
        {
            bool esValido = true;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Los siguientes datos no son validos:");

            if (unCliente is null)
            {
                sb.AppendLine("Debe seleccionar un cliente");
                esValido = false;
            }

            if (rd_equipajeManoSi.Checked == false && rd_equipajeManoNo.Checked == false)
            {
                sb.AppendLine("Equipaje de Mano");
                esValido = false;
            }

            if (rd_equipajeBodegaSi.Checked == false && rd_equipajeBodegaNo.Checked == false)
            {
                sb.AppendLine("Equipaje de Bodega");
                esValido = false;
            }

            if ((clase == "Turista" && rd_equipajeBodegaSi.Checked && num_valijaUno.Value == 0)
                || (clase == "Premium" && rd_equipajeBodegaSi.Checked && (num_valijaUno.Value == 0 || num_valijaDos.Value == 0)))
            {
                sb.AppendLine("Kilogramos de equipaje");
                esValido = false;
            }

            if (!esValido)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() && unCliente != null)
            {
                unPasajero = new Pasajero(unCliente.Nombre, unCliente.Apellido, unCliente.Genero, unCliente.DNI, unCliente.Edad, equipajeMano, (int)num_valijaUno.Value, (int)num_valijaDos.Value);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void rd_equipajeBodegaNo_CheckedChanged(object sender, EventArgs e)
        {
            num_valijaUno.Value = 0;
            num_valijaDos.Value = 0;
            num_valijaUno.Enabled = false;
            num_valijaDos.Enabled = false;
        }

        private void dgv_listaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceCliente = dgv_listaClientes.CurrentRow.Index;
            lbl_clienteSeleccionado.Text = Aerolinea.listaClientes[indiceCliente].Nombre + " " + Aerolinea.listaClientes[indiceCliente].Apellido;
            unCliente = Aerolinea.listaClientes[indiceCliente];
            lbl_clienteSeleccionado.Visible = true;
        }

        private void rd_equipajeBodegaSi_CheckedChanged(object sender, EventArgs e)
        {
            if (clase == "Turista")
            {
                num_valijaUno.Maximum = 25;
                num_valijaUno.Enabled = true;
                num_valijaDos.Enabled = false;
            }
            else
            {
                num_valijaUno.Enabled = true;
                num_valijaDos.Enabled = true;
                num_valijaUno.Maximum = 21;
                num_valijaDos.Maximum = 21;
            }
        }
    }
}
