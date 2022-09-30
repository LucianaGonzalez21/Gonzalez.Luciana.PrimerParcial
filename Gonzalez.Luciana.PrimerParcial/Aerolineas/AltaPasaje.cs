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
    public partial class AltaPasaje : Form
    {
        private Pasaje nuevoPasaje;
        private int indiceCliente;
        private int indiceVuelo;
        private string clase;
        private Pasajero unPasajero;
        private PasajeroPremium unPasajeroPremium;
        private Cliente unCliente;
        private bool bolsoMano;

        public AltaPasaje()
        {
            InitializeComponent();
        }

        public Pasaje Pasaje
        {
            get
            {
                return nuevoPasaje;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            numValijaUno.Enabled = false;
            numValijaDos.Enabled = false;
        }

        private void AltaPasaje_Load(object sender, EventArgs e)
        {
            dgv_vuelos.DataSource = Aerolinea.listaVuelos;
            dgv_clientes.DataSource = Aerolinea.listaClientes;
            //numValijaUno.Enabled = false;
            //numValijaDos.Enabled = false;
        }

        private void rdTurista_CheckedChanged(object sender, EventArgs e)
        {
            numValijaDos.Enabled = false;
            numValijaUno.Maximum = 25;
        }

        private void rdEquipajeBodegaSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTurista.Checked)
            {
                numValijaUno.Enabled = true;
                numValijaDos.Enabled = false;
                numValijaUno.Maximum = 25;
            }
            else if (rdPremium.Checked)
            {
                numValijaUno.Enabled = true;
                numValijaDos.Enabled = true;
                numValijaUno.Maximum = 21;
                numValijaDos.Maximum = 21;
            }

        }

        private void rdPremium_CheckedChanged(object sender, EventArgs e)
        {
            numValijaUno.Enabled = true;
            numValijaDos.Enabled = true;
            numValijaUno.Maximum = 21;
            numValijaDos.Maximum = 21;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {

                if (rdPremium.Checked)
                {
                    clase = rdPremium.Text;
                }
                else if (rdTurista.Checked)
                {
                    clase = rdTurista.Text;
                }

                if (rdEquipajeManoSi.Checked)
                {
                    bolsoMano = true;
                }
                else if (rdEquipajeManoNo.Checked)
                {
                    bolsoMano = false;
                }
                unCliente = Aerolinea.listaClientes[indiceCliente];
                //unPasajero = new Pasajero(unCliente.Nombre, unCliente.Apellido, unCliente.Genero, unCliente.DNI, unCliente.Edad, bolsoMano, (int)numValijaUno.Value);

                if (clase == "Turista" && Aerolinea.listaVuelos[indiceVuelo].Asientos_Turista>0)
                {
                    unPasajero = new Pasajero(unCliente.Nombre, unCliente.Apellido, unCliente.Genero, unCliente.DNI, unCliente.Edad, bolsoMano, (int)numValijaUno.Value);
                    Aerolinea.listaVuelos[indiceVuelo].Asientos_Turista--;
                    nuevoPasaje = new Pasaje(unPasajero, Aerolinea.listaVuelos[indiceVuelo], clase);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if(clase == "Premium" && Aerolinea.listaVuelos[indiceVuelo].Asientos_Premium>0)
                {
                    unPasajeroPremium = new PasajeroPremium(unCliente.Nombre, unCliente.Apellido, unCliente.Genero, unCliente.DNI, unCliente.Edad, bolsoMano, (int)numValijaUno.Value,(int)numValijaDos.Value);
                    Aerolinea.listaVuelos[indiceVuelo].Asientos_Premium--;
                    nuevoPasaje = new Pasaje(unPasajeroPremium, Aerolinea.listaVuelos[indiceVuelo], clase);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lbl_textoError.Text = "El vuelo seleccionado no cuenta con asientos disponibles";
                    lbl_textoError.ForeColor = Color.Red;
                    lbl_textoError.Visible = true;
                }

                //if (Aerolinea.listaVuelos[indiceVuelo].Asientos_Disponibles>0)
                //{
                //    nuevoPasaje = new Pasaje(unPasajero, Aerolinea.listaVuelos[indiceVuelo], clase);
                //    this.DialogResult = DialogResult.OK;
                //    this.Close();
                //}
                //else
                //{
                //    lbl_textoError.Text = "El vuelo seleccionado no cuenta con asientos disponibles";
                //    lbl_textoError.ForeColor = Color.Red;
                //    lbl_textoError.Visible = true;
                //}

                //MessageBox.Show(nuevoPasaje.ToString());
            }
        }

        private bool ValidarDatos()
        {
            bool esValido = true;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Los siguientes datos no son validos:");

            if (rdPremium.Checked == false && rdTurista.Checked == false)
            {
                sb.AppendLine("Clase");
                esValido = true;
            }

            if (rdEquipajeManoSi.Checked == false && rdEquipajeManoNo.Checked == false)
            {
                sb.AppendLine("Equipaje de mano");
                esValido = false;
            }

            if (rdEquipajeBodegaSi.Checked == false && rdEquipajeBodegaNo.Checked == false)
            {
                sb.AppendLine("Equipaje bodega");
                esValido = false;
            }

            if (!esValido)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }

        private void dgv_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceCliente = dgv_clientes.CurrentRow.Index;
            lbl_clienteSeleccionado.Text = Aerolinea.listaClientes[indiceCliente].Nombre;
        }

        private void dgv_aviones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceVuelo = dgv_vuelos.CurrentRow.Index;
            lbl_vueloSeleccionado.Text = Aerolinea.listaVuelos[indiceVuelo].Matricula_Avion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta seguro que desea salir?", "Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
