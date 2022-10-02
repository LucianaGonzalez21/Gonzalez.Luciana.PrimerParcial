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
    public partial class AltaCliente : Form
    {
        Cliente nuevoCliente;

        public Cliente Cliente
        {
            get
            {
                return nuevoCliente;
            }
        }

        public AltaCliente()
        {
            InitializeComponent();
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            cmbGenero.DataSource = Enum.GetValues(typeof(Generos));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta seguro que desea salir?", "Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                nuevoCliente = new Cliente(txtNombre.Text, txtApellido.Text, int.Parse(txtDNI.Text), cmbGenero.Text, Cliente.CalcularEdad(dtp_fechaNacimiento.Value.Date));
                //MessageBox.Show(nuevoCliente.MostrarCliente());
                if (Aerolinea.EsCliente(nuevoCliente))
                {
                    lblClienteRepetido.Text = "El cliente ya existe";
                    lblClienteRepetido.ForeColor = Color.Red;
                    lblClienteRepetido.Visible = true;
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private bool ValidarDatos()
        {
            bool esValido = true;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Los siguientes datos no son validos:");

            if (Validadora.ValidarCadenaSoloLetras(txtNombre.Text) == false)
            {
                sb.AppendLine("Nombre");
                esValido = false;
            }

            if (Validadora.ValidarCadenaSoloLetras(txtApellido.Text) == false)
            {
                sb.AppendLine("Apellido");
                esValido = false;
            }

            if (Validadora.ValidarCadenaSoloNumerosConRango(txtDNI.Text, 10000000, 45000000) == false)
            {
                sb.AppendLine("DNI");
                esValido = false;
            }

            if(Validadora.ValidarFechaNacimiento(dtp_fechaNacimiento.Value.Date) == false)
            {
                sb.AppendLine("Fecha de nacimiento");
                esValido = false;
            }

            if (!esValido)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return esValido;
        }
    }
}
