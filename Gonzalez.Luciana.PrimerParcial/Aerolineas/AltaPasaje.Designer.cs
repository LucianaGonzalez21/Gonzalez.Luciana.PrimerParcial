﻿
namespace Aerolineas
{
    partial class AltaPasaje
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
            this.grpClase = new System.Windows.Forms.GroupBox();
            this.rdPremium = new System.Windows.Forms.RadioButton();
            this.rdTurista = new System.Windows.Forms.RadioButton();
            this.lblVuelo = new System.Windows.Forms.Label();
            this.lblPasaje = new System.Windows.Forms.Label();
            this.rdEquipajeManoSi = new System.Windows.Forms.RadioButton();
            this.rdEquipajeManoNo = new System.Windows.Forms.RadioButton();
            this.grpEquipajeMano = new System.Windows.Forms.GroupBox();
            this.grpEquipajeBodega = new System.Windows.Forms.GroupBox();
            this.numValijaDos = new System.Windows.Forms.NumericUpDown();
            this.numValijaUno = new System.Windows.Forms.NumericUpDown();
            this.lblValijaDos = new System.Windows.Forms.Label();
            this.lblValijaUno = new System.Windows.Forms.Label();
            this.rdEquipajeBodegaNo = new System.Windows.Forms.RadioButton();
            this.rdEquipajeBodegaSi = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lbl_clienteSeleccionado = new System.Windows.Forms.Label();
            this.lbl_vueloSeleccionado = new System.Windows.Forms.Label();
            this.lbl_textoError = new System.Windows.Forms.Label();
            this.btn_elegirVuelo = new System.Windows.Forms.Button();
            this.grpClase.SuspendLayout();
            this.grpEquipajeMano.SuspendLayout();
            this.grpEquipajeBodega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValijaDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValijaUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grpClase
            // 
            this.grpClase.Controls.Add(this.rdPremium);
            this.grpClase.Controls.Add(this.rdTurista);
            this.grpClase.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpClase.Location = new System.Drawing.Point(614, 22);
            this.grpClase.Name = "grpClase";
            this.grpClase.Size = new System.Drawing.Size(235, 72);
            this.grpClase.TabIndex = 0;
            this.grpClase.TabStop = false;
            this.grpClase.Text = "Clase";
            // 
            // rdPremium
            // 
            this.rdPremium.AutoSize = true;
            this.rdPremium.Location = new System.Drawing.Point(131, 38);
            this.rdPremium.Name = "rdPremium";
            this.rdPremium.Size = new System.Drawing.Size(99, 22);
            this.rdPremium.TabIndex = 1;
            this.rdPremium.TabStop = true;
            this.rdPremium.Text = "Premium";
            this.rdPremium.UseVisualStyleBackColor = true;
            this.rdPremium.CheckedChanged += new System.EventHandler(this.rdPremium_CheckedChanged);
            // 
            // rdTurista
            // 
            this.rdTurista.AutoSize = true;
            this.rdTurista.Location = new System.Drawing.Point(23, 38);
            this.rdTurista.Name = "rdTurista";
            this.rdTurista.Size = new System.Drawing.Size(86, 22);
            this.rdTurista.TabIndex = 0;
            this.rdTurista.TabStop = true;
            this.rdTurista.Text = "Turista";
            this.rdTurista.UseVisualStyleBackColor = true;
            this.rdTurista.CheckedChanged += new System.EventHandler(this.rdTurista_CheckedChanged);
            // 
            // lblVuelo
            // 
            this.lblVuelo.AutoSize = true;
            this.lblVuelo.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVuelo.Location = new System.Drawing.Point(38, 469);
            this.lblVuelo.Name = "lblVuelo";
            this.lblVuelo.Size = new System.Drawing.Size(56, 18);
            this.lblVuelo.TabIndex = 1;
            this.lblVuelo.Text = "Vuelo";
            // 
            // lblPasaje
            // 
            this.lblPasaje.AutoSize = true;
            this.lblPasaje.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPasaje.Location = new System.Drawing.Point(30, 22);
            this.lblPasaje.Name = "lblPasaje";
            this.lblPasaje.Size = new System.Drawing.Size(62, 20);
            this.lblPasaje.TabIndex = 3;
            this.lblPasaje.Text = "Pasaje";
            // 
            // rdEquipajeManoSi
            // 
            this.rdEquipajeManoSi.AutoSize = true;
            this.rdEquipajeManoSi.Location = new System.Drawing.Point(23, 26);
            this.rdEquipajeManoSi.Name = "rdEquipajeManoSi";
            this.rdEquipajeManoSi.Size = new System.Drawing.Size(45, 22);
            this.rdEquipajeManoSi.TabIndex = 5;
            this.rdEquipajeManoSi.TabStop = true;
            this.rdEquipajeManoSi.Text = "Si";
            this.rdEquipajeManoSi.UseVisualStyleBackColor = true;
            // 
            // rdEquipajeManoNo
            // 
            this.rdEquipajeManoNo.AutoSize = true;
            this.rdEquipajeManoNo.Location = new System.Drawing.Point(131, 26);
            this.rdEquipajeManoNo.Name = "rdEquipajeManoNo";
            this.rdEquipajeManoNo.Size = new System.Drawing.Size(52, 22);
            this.rdEquipajeManoNo.TabIndex = 6;
            this.rdEquipajeManoNo.TabStop = true;
            this.rdEquipajeManoNo.Text = "No";
            this.rdEquipajeManoNo.UseVisualStyleBackColor = true;
            // 
            // grpEquipajeMano
            // 
            this.grpEquipajeMano.Controls.Add(this.rdEquipajeManoSi);
            this.grpEquipajeMano.Controls.Add(this.rdEquipajeManoNo);
            this.grpEquipajeMano.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpEquipajeMano.Location = new System.Drawing.Point(32, 332);
            this.grpEquipajeMano.Name = "grpEquipajeMano";
            this.grpEquipajeMano.Size = new System.Drawing.Size(250, 65);
            this.grpEquipajeMano.TabIndex = 7;
            this.grpEquipajeMano.TabStop = false;
            this.grpEquipajeMano.Text = "Equipaje de Mano";
            // 
            // grpEquipajeBodega
            // 
            this.grpEquipajeBodega.Controls.Add(this.numValijaDos);
            this.grpEquipajeBodega.Controls.Add(this.numValijaUno);
            this.grpEquipajeBodega.Controls.Add(this.lblValijaDos);
            this.grpEquipajeBodega.Controls.Add(this.lblValijaUno);
            this.grpEquipajeBodega.Controls.Add(this.rdEquipajeBodegaNo);
            this.grpEquipajeBodega.Controls.Add(this.rdEquipajeBodegaSi);
            this.grpEquipajeBodega.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpEquipajeBodega.Location = new System.Drawing.Point(327, 332);
            this.grpEquipajeBodega.Name = "grpEquipajeBodega";
            this.grpEquipajeBodega.Size = new System.Drawing.Size(522, 100);
            this.grpEquipajeBodega.TabIndex = 8;
            this.grpEquipajeBodega.TabStop = false;
            this.grpEquipajeBodega.Text = "Equipaje de Bodega";
            // 
            // numValijaDos
            // 
            this.numValijaDos.Location = new System.Drawing.Point(346, 67);
            this.numValijaDos.Name = "numValijaDos";
            this.numValijaDos.Size = new System.Drawing.Size(150, 27);
            this.numValijaDos.TabIndex = 11;
            // 
            // numValijaUno
            // 
            this.numValijaUno.Location = new System.Drawing.Point(346, 21);
            this.numValijaUno.Name = "numValijaUno";
            this.numValijaUno.Size = new System.Drawing.Size(150, 27);
            this.numValijaUno.TabIndex = 10;
            // 
            // lblValijaDos
            // 
            this.lblValijaDos.AutoSize = true;
            this.lblValijaDos.Location = new System.Drawing.Point(252, 67);
            this.lblValijaDos.Name = "lblValijaDos";
            this.lblValijaDos.Size = new System.Drawing.Size(72, 18);
            this.lblValijaDos.TabIndex = 9;
            this.lblValijaDos.Text = "Valija 2";
            // 
            // lblValijaUno
            // 
            this.lblValijaUno.AutoSize = true;
            this.lblValijaUno.Location = new System.Drawing.Point(252, 28);
            this.lblValijaUno.Name = "lblValijaUno";
            this.lblValijaUno.Size = new System.Drawing.Size(72, 18);
            this.lblValijaUno.TabIndex = 8;
            this.lblValijaUno.Text = "Valija 1";
            // 
            // rdEquipajeBodegaNo
            // 
            this.rdEquipajeBodegaNo.AutoSize = true;
            this.rdEquipajeBodegaNo.Location = new System.Drawing.Point(146, 26);
            this.rdEquipajeBodegaNo.Name = "rdEquipajeBodegaNo";
            this.rdEquipajeBodegaNo.Size = new System.Drawing.Size(52, 22);
            this.rdEquipajeBodegaNo.TabIndex = 7;
            this.rdEquipajeBodegaNo.TabStop = true;
            this.rdEquipajeBodegaNo.Text = "No";
            this.rdEquipajeBodegaNo.UseVisualStyleBackColor = true;
            this.rdEquipajeBodegaNo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdEquipajeBodegaSi
            // 
            this.rdEquipajeBodegaSi.AutoSize = true;
            this.rdEquipajeBodegaSi.Location = new System.Drawing.Point(41, 26);
            this.rdEquipajeBodegaSi.Name = "rdEquipajeBodegaSi";
            this.rdEquipajeBodegaSi.Size = new System.Drawing.Size(45, 22);
            this.rdEquipajeBodegaSi.TabIndex = 6;
            this.rdEquipajeBodegaSi.TabStop = true;
            this.rdEquipajeBodegaSi.Text = "Si";
            this.rdEquipajeBodegaSi.UseVisualStyleBackColor = true;
            this.rdEquipajeBodegaSi.CheckedChanged += new System.EventHandler(this.rdEquipajeBodegaSi_CheckedChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.Location = new System.Drawing.Point(629, 524);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 29);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(754, 524);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(32, 118);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.RowHeadersWidth = 51;
            this.dgv_clientes.RowTemplate.Height = 29;
            this.dgv_clientes.Size = new System.Drawing.Size(817, 188);
            this.dgv_clientes.TabIndex = 11;
            this.dgv_clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellContentClick);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClientes.Location = new System.Drawing.Point(32, 74);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(74, 18);
            this.lblClientes.TabIndex = 12;
            this.lblClientes.Text = "Clientes";
            // 
            // lbl_clienteSeleccionado
            // 
            this.lbl_clienteSeleccionado.AutoSize = true;
            this.lbl_clienteSeleccionado.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_clienteSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_clienteSeleccionado.Location = new System.Drawing.Point(152, 74);
            this.lbl_clienteSeleccionado.Name = "lbl_clienteSeleccionado";
            this.lbl_clienteSeleccionado.Size = new System.Drawing.Size(176, 18);
            this.lbl_clienteSeleccionado.TabIndex = 13;
            this.lbl_clienteSeleccionado.Text = "Cliente seleccionado";
            // 
            // lbl_vueloSeleccionado
            // 
            this.lbl_vueloSeleccionado.AutoSize = true;
            this.lbl_vueloSeleccionado.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_vueloSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_vueloSeleccionado.Location = new System.Drawing.Point(327, 469);
            this.lbl_vueloSeleccionado.Name = "lbl_vueloSeleccionado";
            this.lbl_vueloSeleccionado.Size = new System.Drawing.Size(166, 18);
            this.lbl_vueloSeleccionado.TabIndex = 14;
            this.lbl_vueloSeleccionado.Text = "Vuelo seleccionado";
            // 
            // lbl_textoError
            // 
            this.lbl_textoError.AutoSize = true;
            this.lbl_textoError.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_textoError.ForeColor = System.Drawing.Color.Red;
            this.lbl_textoError.Location = new System.Drawing.Point(37, 535);
            this.lbl_textoError.Name = "lbl_textoError";
            this.lbl_textoError.Size = new System.Drawing.Size(99, 18);
            this.lbl_textoError.TabIndex = 15;
            this.lbl_textoError.Text = "Texto error";
            this.lbl_textoError.Visible = false;
            // 
            // btn_elegirVuelo
            // 
            this.btn_elegirVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_elegirVuelo.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_elegirVuelo.Location = new System.Drawing.Point(149, 464);
            this.btn_elegirVuelo.Name = "btn_elegirVuelo";
            this.btn_elegirVuelo.Size = new System.Drawing.Size(133, 29);
            this.btn_elegirVuelo.TabIndex = 17;
            this.btn_elegirVuelo.Text = "Elegir Vuelo";
            this.btn_elegirVuelo.UseVisualStyleBackColor = true;
            this.btn_elegirVuelo.Click += new System.EventHandler(this.btn_elegirVuelo_Click);
            // 
            // AltaPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(873, 578);
            this.Controls.Add(this.btn_elegirVuelo);
            this.Controls.Add(this.lbl_textoError);
            this.Controls.Add(this.lbl_vueloSeleccionado);
            this.Controls.Add(this.lbl_clienteSeleccionado);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpEquipajeBodega);
            this.Controls.Add(this.grpEquipajeMano);
            this.Controls.Add(this.lblPasaje);
            this.Controls.Add(this.lblVuelo);
            this.Controls.Add(this.grpClase);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaPasaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaPasaje";
            this.Load += new System.EventHandler(this.AltaPasaje_Load);
            this.grpClase.ResumeLayout(false);
            this.grpClase.PerformLayout();
            this.grpEquipajeMano.ResumeLayout(false);
            this.grpEquipajeMano.PerformLayout();
            this.grpEquipajeBodega.ResumeLayout(false);
            this.grpEquipajeBodega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValijaDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValijaUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClase;
        private System.Windows.Forms.RadioButton rdPremium;
        private System.Windows.Forms.RadioButton rdTurista;
        private System.Windows.Forms.Label lblVuelo;
        private System.Windows.Forms.Label lblPasaje;
        private System.Windows.Forms.RadioButton rdEquipajeManoSi;
        private System.Windows.Forms.RadioButton rdEquipajeManoNo;
        private System.Windows.Forms.GroupBox grpEquipajeMano;
        private System.Windows.Forms.GroupBox grpEquipajeBodega;
        private System.Windows.Forms.RadioButton rdEquipajeBodegaNo;
        private System.Windows.Forms.RadioButton rdEquipajeBodegaSi;
        private System.Windows.Forms.Label lblValijaDos;
        private System.Windows.Forms.Label lblValijaUno;
        private System.Windows.Forms.NumericUpDown numValijaDos;
        private System.Windows.Forms.NumericUpDown numValijaUno;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lbl_clienteSeleccionado;
        private System.Windows.Forms.Label lbl_vueloSeleccionado;
        private System.Windows.Forms.Label lbl_textoError;
        private System.Windows.Forms.Button btn_elegirVuelo;
    }
}