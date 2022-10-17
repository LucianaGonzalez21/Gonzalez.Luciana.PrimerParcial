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
        Alojamiento alojamiento;

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
            rbCabania.Enabled = false;
            rbHotel.Enabled = false;
            rbDesayunoNo.Enabled = false;
            rbDesayunoSi.Enabled = false;
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

                if (Aerolinea.VerificarDisponibilidadAsientos(unVuelo.Avion, clase))
                {
                    AgregarPasaje(unPasajero, unVuelo, clase);
                }
                else
                {
                    lbl_textoError.Text = "El vuelo seleccionado no cuenta con asientos disponibles";
                    lbl_textoError.Visible = true;
                }
            }
        }

        /// <summary>
        /// </summary>
        /// Valida que los datos ingresados a través del formulario sean validos para las instancias
        /// que se pretende construir. Si no lo son, informa a través de un MessageBox cuáles 
        /// no son correctos
        /// <returns>True si los datos ingresados son validos. False si no lo son</returns>
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

            if (unCliente is null)
            {
                sb.AppendLine("Debe seleccionar un cliente");
                esValido = false;
            }

            if (unVuelo is null)
            {
                sb.AppendLine("Primero debe elegir un vuelo");
                esValido = false;
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

            if (rbAlojamientoNo.Checked == false && rbAlojamientoSi.Checked == false)
            {
                sb.AppendLine("Alojamiento");
                esValido = false;
            }

            if (rbAlojamientoSi.Checked && rbDesayunoSi.Checked == false && rbDesayunoNo.Checked == false)
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
                sb.AppendLine("La cantidad de dias no puede ser 0");
                esValido = false;
            }

            if (!esValido)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }

        /// <summary>
        /// Compara si el pasajero ya se encuentra registrado en el vuelo. Si es asi, 
        /// lo notifica con un label. Sino, descuenta el asiento del avion relacionado 
        /// al vuelo, le suma al cliente un viaje y finalmente cierra el formulario.
        /// </summary>
        /// <param name="unPasajero">El pasajero que viajará en el vuelo</param>
        /// <param name="unVuelo">El vuelo elegido por el pasajero</param>
        /// <param name="clase">La clase en la que viajará el pasajero</param>
        private void AgregarPasaje(Pasajero unPasajero, Vuelo unVuelo, string clase)
        {
            if (DarDeAltaPasaje() && Aerolinea.EsPasajeroEnElVuelo(nuevoPasaje))
            {
                lbl_textoError.Text = "El cliente ya es pasajero en el vuelo seleccionado";
                lbl_textoError.Visible = true;
            }
            else
            {
                DescontarAsientosAvion(clase);
                unCliente.Cantidad_Viajes++;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool DarDeAltaPasaje()
        {
            unPasajero = new Pasajero(unCliente.Nombre, unCliente.Apellido, unCliente.Genero, unCliente.DNI, unCliente.Edad, bolsoMano, (int)numValijaUno.Value, (int)numValijaDos.Value);

            if (unPasajero is not null && unVuelo is not null)
            {
                nuevoPasaje = new Pasaje(unPasajero, unVuelo, clase, DarAltaAlojamiento());
                return true;
            }
            return false;
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
                lbl_vueloSeleccionado.Visible = true;
            }
        }

        /// <summary>
        /// Segun la clase que recibe por parametro, descuenta los asientos de ese tipo
        /// del avion relacionado con el vuelo seleccionado
        /// </summary>
        /// <param name="clase">Es la cadena que especifica que clase se eligió para el vuelo</param>
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

        private void rbAlojamientoSi_CheckedChanged(object sender, EventArgs e)
        {
            rbCabania.Enabled = true;
            rbHotel.Enabled = true;
            rbDesayunoNo.Enabled = true;
            rbDesayunoSi.Enabled = true;
            nudCantidadDias.Enabled = true;
        }

        private void rbAlojamientoNo_CheckedChanged(object sender, EventArgs e)
        {
            rbCabania.Enabled = false;
            rbHotel.Enabled = false;
            rbDesayunoNo.Enabled = false;
            rbDesayunoSi.Enabled = false;
            nudCantidadDias.Enabled = false;
        }

        private Alojamiento DarAltaAlojamiento()
        {
            if (rbAlojamientoSi.Checked == false)
            {
                return null;
            }

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
            else
            {
                alojamiento = new Cabania(desayuno, (int)nudCantidadDias.Value);
            }

            return alojamiento;
        }

        private void dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceCliente = dgv_clientes.CurrentRow.Index;
            unCliente = Aerolinea.listaClientes[indiceCliente];
            lbl_clienteSeleccionado.Text = Aerolinea.listaClientes[indiceCliente].Nombre + " " + Aerolinea.listaClientes[indiceCliente].Apellido;
            lbl_clienteSeleccionado.Visible = true;
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

        private double CalcularCostoAlojamiento()
        {
            AltaAlojamiento();

            if (alojamiento is not null)
            {
                return alojamiento.Costo_Total;
            }
            return 0;
        }

        private void btnCalcularCostos_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() && DarDeAltaPasaje())
            {
                lblImporteAlojamiento.Text = $"$ {CalcularCostoAlojamiento()}";
                lblImporteAlojamiento.Visible = true;
                lblImporteVuelo.Text = $"$ {nuevoPasaje.Costo}";
                lblImporteVuelo.Visible = true;
                lblImporteTotal.Text = $"$ {CalcularCostoAlojamiento() + nuevoPasaje.Costo}";
                lblImporteTotal.Visible = true;
            }
        }

        private void gbAlojamiento_Enter(object sender, EventArgs e)
        {

        }
    }
}
