﻿
namespace Aerolineas
{
    partial class AltaVuelo
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
            this.lblDatosVuelo = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdNacional = new System.Windows.Forms.RadioButton();
            this.rdInternacional = new System.Windows.Forms.RadioButton();
            this.cmbDestinosNacionales = new System.Windows.Forms.ComboBox();
            this.cmbDestinosInternacionales = new System.Windows.Forms.ComboBox();
            this.dtp_fechaPartida = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPartida = new System.Windows.Forms.Label();
            this.lblAvion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgv_aviones = new System.Windows.Forms.DataGridView();
            this.lblAvionSeleccionado = new System.Windows.Forms.Label();
            this.lblMatriculaAvion = new System.Windows.Forms.Label();
            this.lblAvionRepetido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aviones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatosVuelo
            // 
            this.lblDatosVuelo.AutoSize = true;
            this.lblDatosVuelo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDatosVuelo.Location = new System.Drawing.Point(39, 33);
            this.lblDatosVuelo.Name = "lblDatosVuelo";
            this.lblDatosVuelo.Size = new System.Drawing.Size(146, 21);
            this.lblDatosVuelo.TabIndex = 0;
            this.lblDatosVuelo.Text = "Datos del vuelo";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(39, 427);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(54, 20);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Origen";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(212, 424);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(151, 28);
            this.cmbOrigen.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Destino";
            // 
            // rdNacional
            // 
            this.rdNacional.AutoSize = true;
            this.rdNacional.Location = new System.Drawing.Point(212, 323);
            this.rdNacional.Name = "rdNacional";
            this.rdNacional.Size = new System.Drawing.Size(89, 24);
            this.rdNacional.TabIndex = 6;
            this.rdNacional.TabStop = true;
            this.rdNacional.Text = "Nacional";
            this.rdNacional.UseVisualStyleBackColor = true;
            this.rdNacional.CheckedChanged += new System.EventHandler(this.rdNacional_CheckedChanged);
            // 
            // rdInternacional
            // 
            this.rdInternacional.AutoSize = true;
            this.rdInternacional.Location = new System.Drawing.Point(410, 321);
            this.rdInternacional.Name = "rdInternacional";
            this.rdInternacional.Size = new System.Drawing.Size(116, 24);
            this.rdInternacional.TabIndex = 7;
            this.rdInternacional.TabStop = true;
            this.rdInternacional.Text = "Internacional";
            this.rdInternacional.UseVisualStyleBackColor = true;
            this.rdInternacional.CheckedChanged += new System.EventHandler(this.rdInternacional_CheckedChanged);
            // 
            // cmbDestinosNacionales
            // 
            this.cmbDestinosNacionales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinosNacionales.FormattingEnabled = true;
            this.cmbDestinosNacionales.Location = new System.Drawing.Point(212, 362);
            this.cmbDestinosNacionales.Name = "cmbDestinosNacionales";
            this.cmbDestinosNacionales.Size = new System.Drawing.Size(151, 28);
            this.cmbDestinosNacionales.TabIndex = 8;
            // 
            // cmbDestinosInternacionales
            // 
            this.cmbDestinosInternacionales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinosInternacionales.FormattingEnabled = true;
            this.cmbDestinosInternacionales.Location = new System.Drawing.Point(410, 362);
            this.cmbDestinosInternacionales.Name = "cmbDestinosInternacionales";
            this.cmbDestinosInternacionales.Size = new System.Drawing.Size(151, 28);
            this.cmbDestinosInternacionales.TabIndex = 9;
            // 
            // dtp_fechaPartida
            // 
            this.dtp_fechaPartida.Location = new System.Drawing.Point(212, 499);
            this.dtp_fechaPartida.Name = "dtp_fechaPartida";
            this.dtp_fechaPartida.Size = new System.Drawing.Size(250, 27);
            this.dtp_fechaPartida.TabIndex = 10;
            // 
            // lblFechaPartida
            // 
            this.lblFechaPartida.AutoSize = true;
            this.lblFechaPartida.Location = new System.Drawing.Point(39, 506);
            this.lblFechaPartida.Name = "lblFechaPartida";
            this.lblFechaPartida.Size = new System.Drawing.Size(118, 20);
            this.lblFechaPartida.TabIndex = 11;
            this.lblFechaPartida.Text = "Fecha de Partida";
            // 
            // lblAvion
            // 
            this.lblAvion.AutoSize = true;
            this.lblAvion.Location = new System.Drawing.Point(39, 75);
            this.lblAvion.Name = "lblAvion";
            this.lblAvion.Size = new System.Drawing.Size(47, 20);
            this.lblAvion.TabIndex = 12;
            this.lblAvion.Text = "Avion";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(590, 509);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 29);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(707, 509);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgv_aviones
            // 
            this.dgv_aviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aviones.Location = new System.Drawing.Point(39, 110);
            this.dgv_aviones.Name = "dgv_aviones";
            this.dgv_aviones.RowHeadersWidth = 51;
            this.dgv_aviones.RowTemplate.Height = 29;
            this.dgv_aviones.Size = new System.Drawing.Size(762, 188);
            this.dgv_aviones.TabIndex = 16;
            this.dgv_aviones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_aviones_CellContentClick);
            // 
            // lblAvionSeleccionado
            // 
            this.lblAvionSeleccionado.AutoSize = true;
            this.lblAvionSeleccionado.Location = new System.Drawing.Point(254, 75);
            this.lblAvionSeleccionado.Name = "lblAvionSeleccionado";
            this.lblAvionSeleccionado.Size = new System.Drawing.Size(141, 20);
            this.lblAvionSeleccionado.TabIndex = 17;
            this.lblAvionSeleccionado.Text = "Avion seleccionado:";
            // 
            // lblMatriculaAvion
            // 
            this.lblMatriculaAvion.AutoSize = true;
            this.lblMatriculaAvion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMatriculaAvion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMatriculaAvion.Location = new System.Drawing.Point(420, 75);
            this.lblMatriculaAvion.Name = "lblMatriculaAvion";
            this.lblMatriculaAvion.Size = new System.Drawing.Size(72, 18);
            this.lblMatriculaAvion.TabIndex = 18;
            this.lblMatriculaAvion.Text = "matricula";
            this.lblMatriculaAvion.Visible = false;
            // 
            // lblAvionRepetido
            // 
            this.lblAvionRepetido.AutoSize = true;
            this.lblAvionRepetido.Location = new System.Drawing.Point(514, 464);
            this.lblAvionRepetido.Name = "lblAvionRepetido";
            this.lblAvionRepetido.Size = new System.Drawing.Size(202, 20);
            this.lblAvionRepetido.TabIndex = 19;
            this.lblAvionRepetido.Text = "error avion repetido en fecha";
            this.lblAvionRepetido.Visible = false;
            // 
            // AltaVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 554);
            this.Controls.Add(this.lblAvionRepetido);
            this.Controls.Add(this.lblMatriculaAvion);
            this.Controls.Add(this.lblAvionSeleccionado);
            this.Controls.Add(this.dgv_aviones);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblAvion);
            this.Controls.Add(this.lblFechaPartida);
            this.Controls.Add(this.dtp_fechaPartida);
            this.Controls.Add(this.cmbDestinosInternacionales);
            this.Controls.Add(this.cmbDestinosNacionales);
            this.Controls.Add(this.rdInternacional);
            this.Controls.Add(this.rdNacional);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblDatosVuelo);
            this.Name = "AltaVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaVuelo";
            this.Load += new System.EventHandler(this.AltaVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aviones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosVuelo;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdNacional;
        private System.Windows.Forms.RadioButton rdInternacional;
        private System.Windows.Forms.ComboBox cmbDestinosNacionales;
        private System.Windows.Forms.ComboBox cmbDestinosInternacionales;
        private System.Windows.Forms.DateTimePicker dtp_fechaPartida;
        private System.Windows.Forms.Label lblFechaPartida;
        private System.Windows.Forms.Label lblAvion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgv_aviones;
        private System.Windows.Forms.Label lblAvionSeleccionado;
        private System.Windows.Forms.Label lblMatriculaAvion;
        private System.Windows.Forms.Label lblAvionRepetido;
    }
}