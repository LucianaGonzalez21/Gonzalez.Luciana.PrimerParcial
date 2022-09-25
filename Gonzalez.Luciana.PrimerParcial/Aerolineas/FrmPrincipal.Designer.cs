
namespace Aerolineas
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarVuelo = new System.Windows.Forms.Button();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.btnListaPasajeros = new System.Windows.Forms.Button();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.lblVuelos = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVenderPasaje = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarVuelo
            // 
            this.btnAgregarVuelo.Location = new System.Drawing.Point(150, 68);
            this.btnAgregarVuelo.Name = "btnAgregarVuelo";
            this.btnAgregarVuelo.Size = new System.Drawing.Size(126, 84);
            this.btnAgregarVuelo.TabIndex = 0;
            this.btnAgregarVuelo.Text = "Agregar Vuelo";
            this.btnAgregarVuelo.UseVisualStyleBackColor = true;
            this.btnAgregarVuelo.Click += new System.EventHandler(this.btnAgregarVuelo_Click);
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(150, 218);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.RowHeadersWidth = 51;
            this.dgv_clientes.RowTemplate.Height = 29;
            this.dgv_clientes.Size = new System.Drawing.Size(786, 200);
            this.dgv_clientes.TabIndex = 1;
            // 
            // btnListaPasajeros
            // 
            this.btnListaPasajeros.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListaPasajeros.Location = new System.Drawing.Point(12, 244);
            this.btnListaPasajeros.Name = "btnListaPasajeros";
            this.btnListaPasajeros.Size = new System.Drawing.Size(126, 84);
            this.btnListaPasajeros.TabIndex = 2;
            this.btnListaPasajeros.Text = "Ver pasajeros";
            this.btnListaPasajeros.UseVisualStyleBackColor = true;
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.Location = new System.Drawing.Point(12, 334);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(126, 84);
            this.btnEstadistica.TabIndex = 3;
            this.btnEstadistica.Text = "Estadisticas";
            this.btnEstadistica.UseVisualStyleBackColor = true;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenido.Location = new System.Drawing.Point(12, 28);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(44, 18);
            this.lblBienvenido.TabIndex = 4;
            this.lblBienvenido.Text = "texto";
            this.lblBienvenido.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Location = new System.Drawing.Point(282, 68);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(126, 84);
            this.btnAgregarCliente.TabIndex = 5;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // lblVuelos
            // 
            this.lblVuelos.AutoSize = true;
            this.lblVuelos.Location = new System.Drawing.Point(150, 176);
            this.lblVuelos.Name = "lblVuelos";
            this.lblVuelos.Size = new System.Drawing.Size(53, 20);
            this.lblVuelos.TabIndex = 6;
            this.lblVuelos.Text = "Vuelos";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(842, 438);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVenderPasaje
            // 
            this.btnVenderPasaje.Location = new System.Drawing.Point(414, 68);
            this.btnVenderPasaje.Name = "btnVenderPasaje";
            this.btnVenderPasaje.Size = new System.Drawing.Size(114, 84);
            this.btnVenderPasaje.TabIndex = 8;
            this.btnVenderPasaje.Text = "Vender Pasaje Individual";
            this.btnVenderPasaje.UseVisualStyleBackColor = true;
            this.btnVenderPasaje.Click += new System.EventHandler(this.btnVenderPasaje_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 84);
            this.button1.TabIndex = 9;
            this.button1.Text = "Vender Pasajes (Grupo familiar)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVenderPasaje);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblVuelos);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.btnEstadistica);
            this.Controls.Add(this.btnListaPasajeros);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.btnAgregarVuelo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarVuelo;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.Button btnListaPasajeros;
        private System.Windows.Forms.Button btnEstadistica;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Label lblVuelos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVenderPasaje;
        private System.Windows.Forms.Button button1;
    }
}