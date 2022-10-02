
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_destinoMasElegido
            // 
            this.btn_destinoMasElegido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_destinoMasElegido.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_destinoMasElegido.Location = new System.Drawing.Point(98, 58);
            this.btn_destinoMasElegido.Name = "btn_destinoMasElegido";
            this.btn_destinoMasElegido.Size = new System.Drawing.Size(111, 90);
            this.btn_destinoMasElegido.TabIndex = 0;
            this.btn_destinoMasElegido.Text = "Ver Destino mas Elegido";
            this.btn_destinoMasElegido.UseVisualStyleBackColor = true;
            this.btn_destinoMasElegido.Click += new System.EventHandler(this.btn_destinoMasElegido_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.Location = new System.Drawing.Point(677, 378);
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
            this.lbl_informacion.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_informacion.Location = new System.Drawing.Point(98, 177);
            this.lbl_informacion.Name = "lbl_informacion";
            this.lbl_informacion.Size = new System.Drawing.Size(106, 18);
            this.lbl_informacion.TabIndex = 2;
            this.lbl_informacion.Text = "informacion";
            this.lbl_informacion.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(249, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 90);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ver horas de vuelo de cada avion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_informacion);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_destinoMasElegido);
            this.Name = "FrmEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEstadisticas";
            this.Load += new System.EventHandler(this.FrmEstadisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_destinoMasElegido;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_informacion;
        private System.Windows.Forms.Button button1;
    }
}