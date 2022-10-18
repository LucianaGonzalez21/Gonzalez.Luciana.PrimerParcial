
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
            this.components = new System.ComponentModel.Container();
            this.btnAgregarVuelo = new System.Windows.Forms.Button();
            this.dgv_principal = new System.Windows.Forms.DataGridView();
            this.btnVerPasajeros = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVentaPasaje = new System.Windows.Forms.Button();
            this.btnVerVuelos = new System.Windows.Forms.Button();
            this.btnVerClientes = new System.Windows.Forms.Button();
            this.lbl_tituloDataGridView = new System.Windows.Forms.Label();
            this.btnVerAviones = new System.Windows.Forms.Button();
            this.btnVerAlojamientos = new System.Windows.Forms.Button();
            this.ttAyuda = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarVuelo
            // 
            this.btnAgregarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarVuelo.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarVuelo.Location = new System.Drawing.Point(12, 158);
            this.btnAgregarVuelo.Name = "btnAgregarVuelo";
            this.btnAgregarVuelo.Size = new System.Drawing.Size(126, 84);
            this.btnAgregarVuelo.TabIndex = 0;
            this.btnAgregarVuelo.Text = "Agregar Vuelo";
            this.btnAgregarVuelo.UseVisualStyleBackColor = true;
            this.btnAgregarVuelo.Click += new System.EventHandler(this.btnAgregarVuelo_Click);
            // 
            // dgv_principal
            // 
            this.dgv_principal.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgv_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_principal.Location = new System.Drawing.Point(149, 190);
            this.dgv_principal.Name = "dgv_principal";
            this.dgv_principal.RowHeadersWidth = 51;
            this.dgv_principal.RowTemplate.Height = 29;
            this.dgv_principal.Size = new System.Drawing.Size(786, 264);
            this.dgv_principal.TabIndex = 1;
            // 
            // btnVerPasajeros
            // 
            this.btnVerPasajeros.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerPasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerPasajeros.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerPasajeros.Location = new System.Drawing.Point(282, 59);
            this.btnVerPasajeros.Name = "btnVerPasajeros";
            this.btnVerPasajeros.Size = new System.Drawing.Size(126, 84);
            this.btnVerPasajeros.TabIndex = 2;
            this.btnVerPasajeros.Text = "Ver Pasajeros";
            this.btnVerPasajeros.UseVisualStyleBackColor = true;
            this.btnVerPasajeros.Click += new System.EventHandler(this.btn_listaPasajeros_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstadisticas.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstadisticas.Location = new System.Drawing.Point(12, 363);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(126, 84);
            this.btnEstadisticas.TabIndex = 3;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btn_estadisticas_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.LightSalmon;
            this.lblBienvenido.CausesValidation = false;
            this.lblBienvenido.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenido.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBienvenido.Location = new System.Drawing.Point(12, 21);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(98, 19);
            this.lblBienvenido.TabIndex = 4;
            this.lblBienvenido.Text = "bienvenida";
            this.lblBienvenido.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarCliente.Location = new System.Drawing.Point(12, 59);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(126, 84);
            this.btnAgregarCliente.TabIndex = 5;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(841, 476);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVentaPasaje
            // 
            this.btnVentaPasaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVentaPasaje.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVentaPasaje.Location = new System.Drawing.Point(12, 259);
            this.btnVentaPasaje.Name = "btnVentaPasaje";
            this.btnVentaPasaje.Size = new System.Drawing.Size(126, 84);
            this.btnVentaPasaje.TabIndex = 9;
            this.btnVentaPasaje.Text = "Vender Pasajes ";
            this.btnVentaPasaje.UseVisualStyleBackColor = true;
            this.btnVentaPasaje.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVerVuelos
            // 
            this.btnVerVuelos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerVuelos.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerVuelos.Location = new System.Drawing.Point(550, 59);
            this.btnVerVuelos.Name = "btnVerVuelos";
            this.btnVerVuelos.Size = new System.Drawing.Size(126, 84);
            this.btnVerVuelos.TabIndex = 10;
            this.btnVerVuelos.Text = "Ver Vuelos";
            this.btnVerVuelos.UseVisualStyleBackColor = true;
            this.btnVerVuelos.Click += new System.EventHandler(this.btn_listaVuelos_Click);
            // 
            // btnVerClientes
            // 
            this.btnVerClientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerClientes.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerClientes.Location = new System.Drawing.Point(150, 59);
            this.btnVerClientes.Name = "btnVerClientes";
            this.btnVerClientes.Size = new System.Drawing.Size(126, 84);
            this.btnVerClientes.TabIndex = 11;
            this.btnVerClientes.Text = "Ver Clientes";
            this.btnVerClientes.UseVisualStyleBackColor = true;
            this.btnVerClientes.Click += new System.EventHandler(this.btn_listaClientes_Click);
            // 
            // lbl_tituloDataGridView
            // 
            this.lbl_tituloDataGridView.AutoSize = true;
            this.lbl_tituloDataGridView.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tituloDataGridView.Location = new System.Drawing.Point(469, 158);
            this.lbl_tituloDataGridView.Name = "lbl_tituloDataGridView";
            this.lbl_tituloDataGridView.Size = new System.Drawing.Size(133, 18);
            this.lbl_tituloDataGridView.TabIndex = 12;
            this.lbl_tituloDataGridView.Text = "Lista de Vuelos";
            this.lbl_tituloDataGridView.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnVerAviones
            // 
            this.btnVerAviones.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerAviones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerAviones.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerAviones.Location = new System.Drawing.Point(414, 59);
            this.btnVerAviones.Name = "btnVerAviones";
            this.btnVerAviones.Size = new System.Drawing.Size(126, 84);
            this.btnVerAviones.TabIndex = 13;
            this.btnVerAviones.Text = "Ver Aviones";
            this.btnVerAviones.UseVisualStyleBackColor = true;
            this.btnVerAviones.Click += new System.EventHandler(this.btn_listaAviones_Click);
            // 
            // btnVerAlojamientos
            // 
            this.btnVerAlojamientos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerAlojamientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerAlojamientos.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerAlojamientos.Location = new System.Drawing.Point(682, 59);
            this.btnVerAlojamientos.Name = "btnVerAlojamientos";
            this.btnVerAlojamientos.Size = new System.Drawing.Size(126, 84);
            this.btnVerAlojamientos.TabIndex = 14;
            this.btnVerAlojamientos.Text = "Ver Alojamientos";
            this.btnVerAlojamientos.UseVisualStyleBackColor = true;
            this.btnVerAlojamientos.Click += new System.EventHandler(this.btn_alojamientos_Click);
            // 
            // ttAyuda
            // 
            this.ttAyuda.IsBalloon = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(948, 513);
            this.ControlBox = false;
            this.Controls.Add(this.btnVerAlojamientos);
            this.Controls.Add(this.btnVerAviones);
            this.Controls.Add(this.lbl_tituloDataGridView);
            this.Controls.Add(this.btnVerClientes);
            this.Controls.Add(this.btnVerVuelos);
            this.Controls.Add(this.btnVentaPasaje);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnVerPasajeros);
            this.Controls.Add(this.dgv_principal);
            this.Controls.Add(this.btnAgregarVuelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aerolineas";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarVuelo;
        private System.Windows.Forms.DataGridView dgv_principal;
        private System.Windows.Forms.Button btnVerPasajeros;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVentaPasaje;
        private System.Windows.Forms.Button btnVerVuelos;
        private System.Windows.Forms.Button btnVerClientes;
        private System.Windows.Forms.Label lbl_tituloDataGridView;
        private System.Windows.Forms.Button btnVerAviones;
        private System.Windows.Forms.Button btnVerAlojamientos;
        private System.Windows.Forms.ToolTip ttAyuda;
    }
}