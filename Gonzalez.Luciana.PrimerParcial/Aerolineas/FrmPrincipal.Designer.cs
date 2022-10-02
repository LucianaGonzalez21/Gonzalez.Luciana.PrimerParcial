
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
            this.dgv_principal = new System.Windows.Forms.DataGridView();
            this.btn_listaPasajeros = new System.Windows.Forms.Button();
            this.btn_estadisticas = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVenderPasaje = new System.Windows.Forms.Button();
            this.btn_ventaGrupo = new System.Windows.Forms.Button();
            this.btn_listaVuelos = new System.Windows.Forms.Button();
            this.btn_listaClientes = new System.Windows.Forms.Button();
            this.lbl_tituloDataGridView = new System.Windows.Forms.Label();
            this.btn_listaAviones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarVuelo
            // 
            this.btnAgregarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarVuelo.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarVuelo.Location = new System.Drawing.Point(280, 61);
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
            this.dgv_principal.Location = new System.Drawing.Point(150, 214);
            this.dgv_principal.Name = "dgv_principal";
            this.dgv_principal.RowHeadersWidth = 51;
            this.dgv_principal.RowTemplate.Height = 29;
            this.dgv_principal.Size = new System.Drawing.Size(786, 200);
            this.dgv_principal.TabIndex = 1;
            // 
            // btn_listaPasajeros
            // 
            this.btn_listaPasajeros.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_listaPasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_listaPasajeros.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_listaPasajeros.Location = new System.Drawing.Point(12, 151);
            this.btn_listaPasajeros.Name = "btn_listaPasajeros";
            this.btn_listaPasajeros.Size = new System.Drawing.Size(126, 84);
            this.btn_listaPasajeros.TabIndex = 2;
            this.btn_listaPasajeros.Text = "Ver Pasajeros";
            this.btn_listaPasajeros.UseVisualStyleBackColor = true;
            this.btn_listaPasajeros.Click += new System.EventHandler(this.btn_listaPasajeros_Click);
            // 
            // btn_estadisticas
            // 
            this.btn_estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_estadisticas.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_estadisticas.Location = new System.Drawing.Point(652, 61);
            this.btn_estadisticas.Name = "btn_estadisticas";
            this.btn_estadisticas.Size = new System.Drawing.Size(126, 84);
            this.btn_estadisticas.TabIndex = 3;
            this.btn_estadisticas.Text = "Estadisticas";
            this.btn_estadisticas.UseVisualStyleBackColor = true;
            this.btn_estadisticas.Click += new System.EventHandler(this.btn_estadisticas_Click);
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
            this.btnAgregarCliente.Location = new System.Drawing.Point(148, 61);
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
            this.btnVenderPasaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVenderPasaje.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVenderPasaje.Location = new System.Drawing.Point(412, 61);
            this.btnVenderPasaje.Name = "btnVenderPasaje";
            this.btnVenderPasaje.Size = new System.Drawing.Size(114, 84);
            this.btnVenderPasaje.TabIndex = 8;
            this.btnVenderPasaje.Text = "Vender Pasaje Individual";
            this.btnVenderPasaje.UseVisualStyleBackColor = true;
            this.btnVenderPasaje.Click += new System.EventHandler(this.btnVenderPasaje_Click);
            // 
            // btn_ventaGrupo
            // 
            this.btn_ventaGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ventaGrupo.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ventaGrupo.Location = new System.Drawing.Point(532, 61);
            this.btn_ventaGrupo.Name = "btn_ventaGrupo";
            this.btn_ventaGrupo.Size = new System.Drawing.Size(114, 84);
            this.btn_ventaGrupo.TabIndex = 9;
            this.btn_ventaGrupo.Text = "Vender Pasajes (Grupo familiar)";
            this.btn_ventaGrupo.UseVisualStyleBackColor = true;
            this.btn_ventaGrupo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_listaVuelos
            // 
            this.btn_listaVuelos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_listaVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_listaVuelos.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_listaVuelos.Location = new System.Drawing.Point(12, 330);
            this.btn_listaVuelos.Name = "btn_listaVuelos";
            this.btn_listaVuelos.Size = new System.Drawing.Size(126, 84);
            this.btn_listaVuelos.TabIndex = 10;
            this.btn_listaVuelos.Text = "Ver Vuelos";
            this.btn_listaVuelos.UseVisualStyleBackColor = true;
            this.btn_listaVuelos.Click += new System.EventHandler(this.btn_listaVuelos_Click);
            // 
            // btn_listaClientes
            // 
            this.btn_listaClientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_listaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_listaClientes.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_listaClientes.Location = new System.Drawing.Point(12, 61);
            this.btn_listaClientes.Name = "btn_listaClientes";
            this.btn_listaClientes.Size = new System.Drawing.Size(126, 84);
            this.btn_listaClientes.TabIndex = 11;
            this.btn_listaClientes.Text = "Ver Clientes";
            this.btn_listaClientes.UseVisualStyleBackColor = true;
            this.btn_listaClientes.Click += new System.EventHandler(this.btn_listaClientes_Click);
            // 
            // lbl_tituloDataGridView
            // 
            this.lbl_tituloDataGridView.AutoSize = true;
            this.lbl_tituloDataGridView.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tituloDataGridView.Location = new System.Drawing.Point(468, 183);
            this.lbl_tituloDataGridView.Name = "lbl_tituloDataGridView";
            this.lbl_tituloDataGridView.Size = new System.Drawing.Size(133, 18);
            this.lbl_tituloDataGridView.TabIndex = 12;
            this.lbl_tituloDataGridView.Text = "Lista de Vuelos";
            this.lbl_tituloDataGridView.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn_listaAviones
            // 
            this.btn_listaAviones.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_listaAviones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_listaAviones.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_listaAviones.Location = new System.Drawing.Point(12, 240);
            this.btn_listaAviones.Name = "btn_listaAviones";
            this.btn_listaAviones.Size = new System.Drawing.Size(126, 84);
            this.btn_listaAviones.TabIndex = 13;
            this.btn_listaAviones.Text = "Ver Aviones";
            this.btn_listaAviones.UseVisualStyleBackColor = true;
            this.btn_listaAviones.Click += new System.EventHandler(this.btn_listaAviones_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(948, 479);
            this.ControlBox = false;
            this.Controls.Add(this.btn_listaAviones);
            this.Controls.Add(this.lbl_tituloDataGridView);
            this.Controls.Add(this.btn_listaClientes);
            this.Controls.Add(this.btn_listaVuelos);
            this.Controls.Add(this.btn_ventaGrupo);
            this.Controls.Add(this.btnVenderPasaje);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.btn_estadisticas);
            this.Controls.Add(this.btn_listaPasajeros);
            this.Controls.Add(this.dgv_principal);
            this.Controls.Add(this.btnAgregarVuelo);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarVuelo;
        private System.Windows.Forms.DataGridView dgv_principal;
        private System.Windows.Forms.Button btn_listaPasajeros;
        private System.Windows.Forms.Button btn_estadisticas;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVenderPasaje;
        private System.Windows.Forms.Button btn_ventaGrupo;
        private System.Windows.Forms.Button btn_listaVuelos;
        private System.Windows.Forms.Button btn_listaClientes;
        private System.Windows.Forms.Label lbl_tituloDataGridView;
        private System.Windows.Forms.Button btn_listaAviones;
    }
}