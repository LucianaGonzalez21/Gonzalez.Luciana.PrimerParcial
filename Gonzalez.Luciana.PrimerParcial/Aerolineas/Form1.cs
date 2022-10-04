using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerolineas
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtClave.Clear();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (Validadora.ValidarCadena(txtUsuario.Text) && Validadora.ValidarCadena(txtClave.Text))
            {
                Usuario auxUsuario = Aerolinea.ValidarUsuario(txtUsuario.Text, txtClave.Text);
                if (auxUsuario != null)
                {
                    FrmPrincipal frmPrincipal = new FrmPrincipal(auxUsuario, this);
                    this.Hide();
                    frmPrincipal.Show();
                }
            }
            else
            {
                lblMensajeError.Visible = true;
                lblMensajeError.ForeColor = Color.Red;
                lblMensajeError.Text = "Error, datos no validos";
            }
        }

        private void btnAutocompletar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "lucas";
            txtClave.Text = "1234";
        }
    }
}
