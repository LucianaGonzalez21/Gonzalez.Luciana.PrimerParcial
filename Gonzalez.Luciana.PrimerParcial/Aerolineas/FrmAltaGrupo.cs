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
        private Alojamiento alojamiento;

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
            rbCabania.Enabled = false;
            rbHotel.Enabled = false;
            rbDesayunoSi.Enabled = false;
            rbDesayunoNo.Enabled = false;
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
            if (ValidarDatos())
            {
                if (unVuelo.ValidarDisponibilidadVuelo(clase, unVuelo, listaPasajeros.Count))
                {
                    AltaAlojamiento();
                    AgregarPasajes();

                    if (ValidarPasajerosEnVuelo())
                    {
                        unVuelo.DescontarAsientosAvion(clase, listaPasajes.Count, unVuelo);
                        Aerolinea.AcumularViajesDeClientes(listaPasajeros);
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
        }

        private bool ValidarDatos()
        {
            StringBuilder sb = new StringBuilder();
            bool esValido = true;

            sb.AppendLine("Los siguientes datos no son validos:");

            if (unPasajero is null)
            {
                sb.AppendLine("Debe agregar al menos un pasajero");
                esValido = false;
            }

            if (unVuelo is null)
            {
                sb.AppendLine("Debe seleccionar un vuelo");
                esValido = false;
            }

            if (rbAlojamientoSi.Checked && rbDesayunoSi.Checked == false &&  rbDesayunoNo.Checked == false)
            {
                sb.AppendLine("Desayuno");
                esValido = false;
            }

            if (rbAlojamientoSi.Checked && rbCabania.Checked == false && rbHotel.Checked == false)
            {
                sb.AppendLine("Tipo de alojamiento");
                esValido = false;
            }

            if (rbAlojamientoSi.Checked && nudCantidadDias.Value == 0)
            {
                sb.AppendLine("La cantidad de dias de la estadia no puede ser 0");
                esValido = false;
            }

            if (!esValido)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }

        private void AgregarPasajes()
        {
            bool esPasajeRepetido = false;

            foreach (Pasajero pasajero in listaPasajeros)
            {
                unPasaje = new Pasaje(pasajero, unVuelo, clase, alojamiento);

                foreach (Pasaje pasaje in listaPasajes)
                {
                    if (pasaje.Equals(unPasaje))
                    {
                        esPasajeRepetido = true;
                    }
                }

                if (esPasajeRepetido == false)
                {
                    listaPasajes.Push(unPasaje);
                }
            }
        }

        private void AltaAlojamiento()
        {
            alojamiento = null;

            if (rbAlojamientoSi.Checked)
            {
                bool desayuno;

                if (rbDesayunoSi.Checked)
                {
                    desayuno = true;
                }
                else
                {
                    desayuno = false;
                }

                if (rbHotel.Checked)
                {
                    alojamiento = new Hotel(desayuno, (int)nudCantidadDias.Value);
                }
                else if (rbCabania.Checked)
                {
                    alojamiento = new Cabania(desayuno, (int)nudCantidadDias.Value);
                }
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                AltaAlojamiento();
                AgregarPasajes();

                if (unPasaje is not null)
                {
                    double costoTotal = listaPasajeros.Count * unPasaje.Costo;
                    lblImporteBruto.Text =  "$ " + unVuelo.CalcularCostoPasaje(unVuelo, clase).ToString();
                    lblImporteBruto.Visible = true;
                    lblImporteTotalVuelos.Text = $"$ {costoTotal}";
                    lblImporteTotalVuelos.Visible = true;
                    lblImporteAlojamiento.Text = $"$ {CalcularCostoAlojamiento().ToString()}";
                    lblImporteAlojamiento.Visible = true;
                    lblImporteTotalAlojamiento.Text = $"$ {(CalcularCostoAlojamiento() * listaPasajeros.Count).ToString()}";
                    lblImporteTotalAlojamiento.Visible = true;
                    lblImporteTotal.Text = $"$ {(costoTotal + (CalcularCostoAlojamiento() * listaPasajeros.Count)).ToString()}";
                    lblImporteTotal.Visible = true;
                }
                else
                {
                    lbl_textoError.Text = "Primero debe elegir un vuelo y al menos un pasajero";
                    lbl_textoError.Visible = true;
                }

            }
        }

        private double CalcularCostoAlojamiento()
        {
            AltaAlojamiento();

            if (alojamiento is not null)
            {
                return alojamiento.Costo_Total;
            }
            return 0;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta seguro que desea cancelar?", "Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Valida si el pasajero ya se encuentra registrado en el vuelo elegido
        /// </summary>
        /// <returns>True si ya está registrado. False si no</returns>
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

        private void rbAlojamientoSi_CheckedChanged(object sender, EventArgs e)
        {
            rbDesayunoSi.Enabled = true;
            rbDesayunoNo.Enabled = true;
            rbCabania.Enabled = true;
            rbHotel.Enabled = true;
            nudCantidadDias.Enabled = true;
        }

        private void rbAlojamientoNo_CheckedChanged(object sender, EventArgs e)
        {
            rbCabania.Enabled = false;
            rbHotel.Enabled = false;
            rbDesayunoSi.Enabled = false;
            rbDesayunoNo.Enabled = false;
            rbCabania.Checked = false;
            rbHotel.Checked = false;
            nudCantidadDias.Value = 0;
            nudCantidadDias.Enabled = false;
        }
    }
}
