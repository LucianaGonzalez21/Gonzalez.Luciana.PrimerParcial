
namespace Aerolineas
{
    partial class FrmEstadisticas
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
            this.btn_destinoMasElegido = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_informacion = new System.Windows.Forms.Label();
            this.btn_horasPorAvion = new System.Windows.Forms.Button();
            this.btn_facturacionDestinos = new System.Windows.Forms.Button();
            this.btn_cantidadVuelos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_destinoMasElegido
            // 
            this.btn_destinoMasElegido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_destinoMasElegido.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_destinoMasElegido.Location = new System.Drawing.Point(1, 0);
            this.btn_destinoMasElegido.Name = "btn_destinoMasElegido";
            this.btn_destinoMasElegido.Size = new System.Drawing.Size(156, 148);
            this.btn_destinoMasElegido.TabIndex = 0;
            this.btn_destinoMasElegido.Text = "Ver Destino mas Elegido";
            this.btn_destinoMasElegido.UseVisualStyleBackColor = true;
            this.btn_destinoMasElegido.Click += new System.EventHandler(this.btn_destinoMasElegido_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.Location = new System.Drawing.Point(677, 485);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(111, 60);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_informacion
            // 
            this.lbl_informacion.AutoSize = true;
            this.lbl_informacion.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_informacion.Location = new System.Drawing.Point(98, 177);
            this.lbl_informacion.Name = "lbl_informacion";
            this.lbl_informacion.Size = new System.Drawing.Size(108, 19);
            this.lbl_informacion.TabIndex = 2;
            this.lbl_informacion.Text = "informacion";
            this.lbl_informacion.Visible = false;
            // 
            // btn_horasPorAvion
            // 
            this.btn_horasPorAvion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_horasPorAvion.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_horasPorAvion.Location = new System.Drawing.Point(163, 0);
            this.btn_horasPorAvion.Name = "btn_horasPorAvion";
            this.btn_horasPorAvion.Size = new System.Drawing.Size(156, 148);
            this.btn_horasPorAvion.TabIndex = 3;
            this.btn_horasPorAvion.Text = "Ver horas de vuelo de cada avion";
            this.btn_horasPorAvion.UseVisualStyleBackColor = true;
            this.btn_horasPorAvion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_facturacionDestinos
            // 
            this.btn_facturacionDestinos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_facturacionDestinos.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_facturacionDestinos.Location = new System.Drawing.Point(325, 0);
            this.btn_facturacionDestinos.Name = "btn_facturacionDestinos";
            this.btn_facturacionDestinos.Size = new System.Drawing.Size(156, 148);
            this.btn_facturacionDestinos.TabIndex = 4;
            this.btn_facturacionDestinos.Text = "Ver listado de Destinos por Facturacion";
            this.btn_facturacionDestinos.UseVisualStyleBackColor = true;
            this.btn_facturacionDestinos.Click += new System.EventHandler(this.btn_facturacionDestinos_Click);
            // 
            // btn_cantidadVuelos
            // 
            this.btn_cantidadVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cantidadVuelos.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cantidadVuelos.Location = new System.Drawing.Point(487, 0);
            this.btn_cantidadVuelos.Name = "btn_cantidadVuelos";
            this.btn_cantidadVuelos.Size = new System.Drawing.Size(156, 148);
            this.btn_cantidadVuelos.TabIndex = 5;
            this.btn_cantidadVuelos.Text = "Ver cantidad de Vuelos de un Pasajero";
            this.btn_cantidadVuelos.UseVisualStyleBackColor = true;
            this.btn_cantidadVuelos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cantidadVuelos);
            this.Controls.Add(this.btn_facturacionDestinos);
            this.Controls.Add(this.btn_horasPorAvion);
            this.Controls.Add(this.lbl_informacion);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_destinoMasElegido);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.FrmEstadisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_destinoMasElegido;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_informacion;
        private System.Windows.Forms.Button btn_horasPorAvion;
        private System.Windows.Forms.Button btn_facturacionDestinos;
        private System.Windows.Forms.Button btn_cantidadVuelos;
    }
}