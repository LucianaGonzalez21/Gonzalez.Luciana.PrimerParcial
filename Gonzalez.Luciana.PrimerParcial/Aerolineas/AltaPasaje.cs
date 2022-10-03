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
        private string clase;
        private Pasajero unPasajero;
        private Cliente unCliente;
        private bool bolsoMano;

        Vuelo unVuelo;

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
            numValijaUno.Value = 0;
            numValijaDos.Value = 0;
            numValijaUno.Enabled = false;
            numValijaDos.Enabled = false;
        }

        private void AltaPasaje_Load(object sender, EventArgs e)
        {
            dgv_clientes.DataSource = Aerolinea.listaClientes;
            dgv_clientes.Columns["Cantidad_Viajes"].Visible = false;
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

                //validar unvuelo no sea null

                if(unVuelo is null)
                {
                    lbl_textoError.Text = "Primero debe elegir un vuelo";
                    lbl_textoError.Visible = true;
                }
                else
                {
                    if (clase == "Turista" && unVuelo.Asientos_Turista>0)
                    {
                        unPasajero = new Pasajero(unCliente.Nombre, unCliente.Apellido, unCliente.Genero, unCliente.DNI, unCliente.Edad, bolsoMano, (int)numValijaUno.Value);
                        ValidarPasaje(unPasajero, unVuelo, clase);
                    }
                    else if (clase == "Premium" && unVuelo.Asientos_Premium>0)
                    {
                        unPasajero = new PasajeroPremium(unCliente.Nombre, unCliente.Apellido, unCliente.Genero, unCliente.DNI, unCliente.Edad, bolsoMano, (int)numValijaUno.Value, (int)numValijaDos.Value);

                        ValidarPasaje(unPasajero, unVuelo, clase);

                    }
                    else
                    {
                        lbl_textoError.Text = "El vuelo seleccionado no cuenta con asientos disponibles";
                        lbl_textoError.Visible = true;
                    }
                }
                
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

        private void ValidarPasaje(Pasajero unPasajero, Vuelo unVuelo, string clase)
        {
            nuevoPasaje = new Pasaje(unPasajero, unVuelo, clase);

            if (Aerolinea.EsPasajeroEnElVuelo(nuevoPasaje))
            {
                lbl_textoError.Text = "El cliente ya es pasajero en el vuelo seleccionado";
                lbl_textoError.Visible = true;
            }
            else
            {
                DescontarAsientosAvion(clase);
                //unPasajero.CantidadViajes++;
                unCliente.Cantidad_Viajes++;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dgv_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceCliente = dgv_clientes.CurrentRow.Index;
            lbl_clienteSeleccionado.Text = Aerolinea.listaClientes[indiceCliente].Nombre + " " + Aerolinea.listaClientes[indiceCliente].Apellido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta seguro que desea cancelar?", "Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_elegirVuelo_Click(object sender, EventArgs e)
        {
            FrmElegirVuelo frmElegirVuelo = new FrmElegirVuelo();
            DialogResult respuesta = frmElegirVuelo.ShowDialog();
            
            if (respuesta == DialogResult.OK)
            {
                unVuelo = frmElegirVuelo.Vuelo;
                lbl_vueloSeleccionado.Text = unVuelo.ToString();
            }
        }

        private void DescontarAsientosAvion(string clase)
        {
            if (clase == "Turista")
            {
                unVuelo.Asientos_Turista--;
            }
            else
            {
                unVuelo.Asientos_Premium--;
            }
        }
    }
}
