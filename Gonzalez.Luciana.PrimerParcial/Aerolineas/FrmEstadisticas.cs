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
    public partial class FrmEstadisticas : Form
    {
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {

        }

        private void btn_destinoMasElegido_Click(object sender, EventArgs e)
        {
            rtbInformacion.Text = Aerolinea.CalcularDestinosMasElegidos();
            lbl_informacion.Visible = true;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta seguro que desea salir?", "Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbInformacion.Text = Aerolinea.InformarHorasDeVueloPorAvion();
            lbl_informacion.Visible = true;
        }

        private void btn_facturacionDestinos_Click(object sender, EventArgs e)
        {
            rtbInformacion.Text = Aerolinea.InformarDestinosConFacturacion();
            lbl_informacion.Visible = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            rtbInformacion.Text = Aerolinea.InformarCantidadDeVuelosPorPasajero();
            lbl_informacion.Visible = true; 
        }
    }
}
