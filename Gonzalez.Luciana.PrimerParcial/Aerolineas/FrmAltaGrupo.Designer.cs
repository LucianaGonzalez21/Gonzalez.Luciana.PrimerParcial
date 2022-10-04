
namespace Aerolineas
{
    partial class FrmAltaGrupo
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
            this.lbl_pasajeros = new System.Windows.Forms.Label();
            this.btn_AgregarPasajero = new System.Windows.Forms.Button();
            this.lbl_vuelo = new System.Windows.Forms.Label();
            this.btn_seleccionarVuelo = new System.Windows.Forms.Button();
            this.gpr_Clase = new System.Windows.Forms.GroupBox();
            this.rd_premium = new System.Windows.Forms.RadioButton();
            this.rd_turista = new System.Windows.Forms.RadioButton();
            this.dgv_listaPasajeros = new System.Windows.Forms.DataGridView();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_textoError = new System.Windows.Forms.Label();
            this.lbl_vueloSeleccionado = new System.Windows.Forms.Label();
            this.lbl_costoBruto = new System.Windows.Forms.Label();
            this.lbl_importeBruto = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.gpr_Clase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pasajeros
            // 
            this.lbl_pasajeros.AutoSize = true;
            this.lbl_pasajeros.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_pasajeros.Location = new System.Drawing.Point(26, 158);
            this.lbl_pasajeros.Name = "lbl_pasajeros";
            this.lbl_pasajeros.Size = new System.Drawing.Size(84, 18);
            this.lbl_pasajeros.TabIndex = 0;
            this.lbl_pasajeros.Text = "Pasajeros";
            // 
            // btn_AgregarPasajero
            // 
            this.btn_AgregarPasajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AgregarPasajero.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AgregarPasajero.Location = new System.Drawing.Point(292, 153);
            this.btn_AgregarPasajero.Name = "btn_AgregarPasajero";
            this.btn_AgregarPasajero.Size = new System.Drawing.Size(159, 29);
            this.btn_AgregarPasajero.TabIndex = 1;
            this.btn_AgregarPasajero.Text = "Agregar Pasajero";
            this.btn_AgregarPasajero.UseVisualStyleBackColor = true;
            this.btn_AgregarPasajero.Click += new System.EventHandler(this.btn_AgregarPasajero_Click);
            // 
            // lbl_vuelo
            // 
            this.lbl_vuelo.AutoSize = true;
            this.lbl_vuelo.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_vuelo.Location = new System.Drawing.Point(493, 158);
            this.lbl_vuelo.Name = "lbl_vuelo";
            this.lbl_vuelo.Size = new System.Drawing.Size(56, 18);
            this.lbl_vuelo.TabIndex = 4;
            this.lbl_vuelo.Text = "Vuelo";
            // 
            // btn_seleccionarVuelo
            // 
            this.btn_seleccionarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_seleccionarVuelo.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_seleccionarVuelo.Location = new System.Drawing.Point(720, 153);
            this.btn_seleccionarVuelo.Name = "btn_seleccionarVuelo";
            this.btn_seleccionarVuelo.Size = new System.Drawing.Size(198, 29);
            this.btn_seleccionarVuelo.TabIndex = 5;
            this.btn_seleccionarVuelo.Text = "Seleccionar Vuelo";
            this.btn_seleccionarVuelo.UseVisualStyleBackColor = true;
            this.btn_seleccionarVuelo.Click += new System.EventHandler(this.btn_seleccionarVuelo_Click);
            // 
            // gpr_Clase
            // 
            this.gpr_Clase.Controls.Add(this.rd_premium);
            this.gpr_Clase.Controls.Add(this.rd_turista);
            this.gpr_Clase.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpr_Clase.Location = new System.Drawing.Point(26, 37);
            this.gpr_Clase.Name = "gpr_Clase";
            this.gpr_Clase.Size = new System.Drawing.Size(219, 80);
            this.gpr_Clase.TabIndex = 10;
            this.gpr_Clase.TabStop = false;
            this.gpr_Clase.Text = "Clase";
            // 
            // rd_premium
            // 
            this.rd_premium.AutoSize = true;
            this.rd_premium.Location = new System.Drawing.Point(115, 35);
            this.rd_premium.Name = "rd_premium";
            this.rd_premium.Size = new System.Drawing.Size(99, 22);
            this.rd_premium.TabIndex = 1;
            this.rd_premium.TabStop = true;
            this.rd_premium.Text = "Premium";
            this.rd_premium.UseVisualStyleBackColor = true;
            this.rd_premium.CheckedChanged += new System.EventHandler(this.rd_premium_CheckedChanged);
            // 
            // rd_turista
            // 
            this.rd_turista.AutoSize = true;
            this.rd_turista.Location = new System.Drawing.Point(22, 35);
            this.rd_turista.Name = "rd_turista";
            this.rd_turista.Size = new System.Drawing.Size(86, 22);
            this.rd_turista.TabIndex = 0;
            this.rd_turista.TabStop = true;
            this.rd_turista.Text = "Turista";
            this.rd_turista.UseVisualStyleBackColor = true;
            this.rd_turista.CheckedChanged += new System.EventHandler(this.rd_turista_CheckedChanged);
            // 
            // dgv_listaPasajeros
            // 
            this.dgv_listaPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaPasajeros.Location = new System.Drawing.Point(26, 214);
            this.dgv_listaPasajeros.Name = "dgv_listaPasajeros";
            this.dgv_listaPasajeros.RowHeadersWidth = 51;
            this.dgv_listaPasajeros.RowTemplate.Height = 29;
            this.dgv_listaPasajeros.Size = new System.Drawing.Size(425, 135);
            this.dgv_listaPasajeros.TabIndex = 11;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_aceptar.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_aceptar.Location = new System.Drawing.Point(641, 470);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(131, 29);
            this.btn_aceptar.TabIndex = 12;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(787, 470);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(129, 29);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_textoError
            // 
            this.lbl_textoError.AutoSize = true;
            this.lbl_textoError.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_textoError.ForeColor = System.Drawing.Color.Red;
            this.lbl_textoError.Location = new System.Drawing.Point(35, 475);
            this.lbl_textoError.Name = "lbl_textoError";
            this.lbl_textoError.Size = new System.Drawing.Size(99, 18);
            this.lbl_textoError.TabIndex = 15;
            this.lbl_textoError.Text = "Texto error";
            this.lbl_textoError.Visible = false;
            // 
            // lbl_vueloSeleccionado
            // 
            this.lbl_vueloSeleccionado.AutoSize = true;
            this.lbl_vueloSeleccionado.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_vueloSeleccionado.Location = new System.Drawing.Point(493, 214);
            this.lbl_vueloSeleccionado.Name = "lbl_vueloSeleccionado";
            this.lbl_vueloSeleccionado.Size = new System.Drawing.Size(91, 18);
            this.lbl_vueloSeleccionado.TabIndex = 16;
            this.lbl_vueloSeleccionado.Text = "info vuelo";
            this.lbl_vueloSeleccionado.Visible = false;
            // 
            // lbl_costoBruto
            // 
            this.lbl_costoBruto.AutoSize = true;
            this.lbl_costoBruto.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_costoBruto.Location = new System.Drawing.Point(493, 374);
            this.lbl_costoBruto.Name = "lbl_costoBruto";
            this.lbl_costoBruto.Size = new System.Drawing.Size(187, 18);
            this.lbl_costoBruto.TabIndex = 6;
            this.lbl_costoBruto.Text = "Costo Bruto del Vuelo";
            // 
            // lbl_importeBruto
            // 
            this.lbl_importeBruto.AutoSize = true;
            this.lbl_importeBruto.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_importeBruto.Location = new System.Drawing.Point(848, 374);
            this.lbl_importeBruto.Name = "lbl_importeBruto";
            this.lbl_importeBruto.Size = new System.Drawing.Size(70, 18);
            this.lbl_importeBruto.TabIndex = 7;
            this.lbl_importeBruto.Text = "importe";
            this.lbl_importeBruto.Visible = false;
            // 
            // btn_calcular
            // 
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_calcular.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_calcular.Location = new System.Drawing.Point(787, 416);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(131, 29);
            this.btn_calcular.TabIndex = 17;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // FrmAltaGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(928, 517);
            this.ControlBox = false;
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_vueloSeleccionado);
            this.Controls.Add(this.lbl_textoError);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.dgv_listaPasajeros);
            this.Controls.Add(this.gpr_Clase);
            this.Controls.Add(this.lbl_importeBruto);
            this.Controls.Add(this.lbl_costoBruto);
            this.Controls.Add(this.btn_seleccionarVuelo);
            this.Controls.Add(this.lbl_vuelo);
            this.Controls.Add(this.btn_AgregarPasajero);
            this.Controls.Add(this.lbl_pasajeros);
            this.Name = "FrmAltaGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta grupo familiar";
            this.Load += new System.EventHandler(this.FrmAltaGrupo_Load);
            this.gpr_Clase.ResumeLayout(false);
            this.gpr_Clase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaPasajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pasajeros;
        private System.Windows.Forms.Button btn_AgregarPasajero;
        private System.Windows.Forms.Label lbl_vuelo;
        private System.Windows.Forms.Button btn_seleccionarVuelo;
        private System.Windows.Forms.GroupBox gpr_Clase;
        private System.Windows.Forms.RadioButton rd_premium;
        private System.Windows.Forms.RadioButton rd_turista;
        private System.Windows.Forms.DataGridView dgv_listaPasajeros;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_textoError;
        private System.Windows.Forms.Label lbl_vueloSeleccionado;
        private System.Windows.Forms.Label lbl_costoBruto;
        private System.Windows.Forms.Label lbl_importeBruto;
        private System.Windows.Forms.Button btn_calcular;
    }
}