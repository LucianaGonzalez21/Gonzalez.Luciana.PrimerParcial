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
    public partial class FrmAltaGrupo : Form
    {
        private string clase;
        private Pasajero unPasajero;
        private Vuelo unVuelo;
        private List<Pasajero> listaPasajeros;
        private Pasaje unPasaje;
        private Stack<Pasaje> listaPasajes;

        public FrmAltaGrupo()
        {
            InitializeComponent();
        }

        public Stack<Pasaje> ListaPasajes
        {
            get
            {
                return listaPasajes;
            }
        }

        private void FrmAltaGrupo_Load(object sender, EventArgs e)
        {
            listaPasajeros = new List<Pasajero>();
            listaPasajes = new Stack<Pasaje>();
        }

        private void rd_turista_CheckedChanged(object sender, EventArgs e)
        {
            clase = rd_turista.Text;
        }

        private void rd_premium_CheckedChanged(object sender, EventArgs e)
        {
            clase = rd_premium.Text;
        }

        private void btn_AgregarPasajero_Click(object sender, EventArgs e)
        {
            if (rd_premium.Checked == false && rd_turista.Checked == false)
            {
                MessageBox.Show("Primero debe elegir una clase");
            }
            else
            {
                FrmAltaPasajeroTurista frmAltaPasajero = new FrmAltaPasajeroTurista(clase);
                DialogResult retorno = frmAltaPasajero.ShowDialog();

                if (retorno == DialogResult.OK)
                {
                    unPasajero = frmAltaPasajero.Pasajero;
                    listaPasajeros.Add(unPasajero);
                    dgv_listaPasajeros.DataSource = null;
                    dgv_listaPasajeros.DataSource = listaPasajeros;
                    rd_premium.Enabled = false;
                    rd_turista.Enabled = false;
                }

            }
        }

        private void btn_seleccionarVuelo_Click(object sender, EventArgs e)
        {
            FrmElegirVuelo frmElegirVuelo = new FrmElegirVuelo();
            DialogResult retorno = frmElegirVuelo.ShowDialog();

            if (retorno == DialogResult.OK)
            {
                unVuelo = frmElegirVuelo.Vuelo;
                lbl_vueloSeleccionado.Visible = true;
                lbl_vueloSeleccionado.Text = unVuelo.ToString();
            }

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (unPasajero is not null && unVuelo is not null)
            {
                if (ValidarDisponibilidadVuelo())
                {
                    foreach (Pasajero item in listaPasajeros)
                    {
                        unPasaje = new Pasaje(item, unVuelo, clase);
                        listaPasajes.Push(unPasaje);
                    }

                    if (ValidarPasajerosEnVuelo())
                    {
                        double costoTotal = listaPasajeros.Count * unPasaje.Costo;
                        MessageBox.Show($"Costo a pagar con impuestos: ${costoTotal}");
                        //descontar asientos del avion
                        DescontarAsientosAvion(clase);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        lbl_textoError.Visible = true;
                        lbl_textoError.Text = $"El pasajero {unPasaje.Apellido_Pasajero} {unPasaje.Nombre_Pasajero} ya se encuentra en el vuelo";
                    }

                }
                else
                {
                    lbl_textoError.Visible = true;
                    lbl_textoError.Text = "El vuelo no cuenta con disponibilidad";
                }

            }
            else
            {
                lbl_textoError.Visible = true;
                lbl_textoError.Text = "Debe agregar al menos un cliente y seleccionar un vuelo";
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (unPasajero is not null && unVuelo is not null)
            {
                lbl_importeBruto.Text =  "$" + unPasajero.CalcularCostoPasaje(unVuelo).ToString();
                lbl_importeBruto.Visible = true;
            }
            else
            {
                lbl_textoError.Visible = true;
                lbl_textoError.Text = "Primero debe elegir un vuelo y pasajeros";
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

        private bool ValidarDisponibilidadVuelo()
        {
            if ((clase == "Turista" && unVuelo.Asientos_Turista - listaPasajeros.Count > 0)
                || (clase == "Premium" && unVuelo.Asientos_Premium - listaPasajeros.Count > 0))
            {
                return true;
            }
            return false;
        }

        private bool ValidarPasajerosEnVuelo()
        {
            foreach (Pasaje item in listaPasajes)
            {
                if (Aerolinea.EsPasajeroEnElVuelo(item))
                {
                    return false;
                }
            }
            return true;
        }

        private void DescontarAsientosAvion(string clase)
        {
            int cantidadAsientos;
            cantidadAsientos = listaPasajes.Count;

            if(clase == "Turista")
            {
                unVuelo.Asientos_Turista -= cantidadAsientos;
            }
            else
            {
                unVuelo.Asientos_Premium -= cantidadAsientos;
            }
        }
    }
}
