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

        public FrmAltaGrupo()
        {
            InitializeComponent();
        }

        public string Clase
        {
            get
            {
                return clase;
            }
        }

        private void FrmAltaGrupo_Load(object sender, EventArgs e)
        {
            listaPasajeros = new List<Pasajero>();
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

                if(retorno == DialogResult.OK)
                {
                    unPasajero = frmAltaPasajero.Pasajero;
                    listaPasajeros.Add(unPasajero);
                    dgv_listaPasajeros.DataSource = null;
                    dgv_listaPasajeros.DataSource = listaPasajeros;
                }

            }
        }

        private void btn_seleccionarVuelo_Click(object sender, EventArgs e)
        {
            FrmElegirVuelo frmElegirVuelo = new FrmElegirVuelo();
            DialogResult retorno = frmElegirVuelo.ShowDialog();

            if(retorno == DialogResult.OK)
            {
                unVuelo = frmElegirVuelo.Vuelo;
                lbl_vueloSeleccionado.Text = unVuelo.ToString();
            }

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if(unPasajero != null && unVuelo != null)
            {
                foreach (Pasajero item in listaPasajeros)
                {
                    unPasaje = new Pasaje(item, unVuelo, clase);
                    Aerolinea.listaPasajes.Add(unPasaje);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lbl_textoError.Text = "Debe agregar al menos un cliente y seleccionar un vuelo";
            }
        }
    }
}
