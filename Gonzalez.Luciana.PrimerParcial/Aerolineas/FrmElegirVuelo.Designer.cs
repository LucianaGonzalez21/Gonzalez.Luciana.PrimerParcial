
namespace Aerolineas
{
    partial class FrmElegirVuelo
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
            this.lbl_origen = new System.Windows.Forms.Label();
            this.lbl_destino = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rd_nacional = new System.Windows.Forms.RadioButton();
            this.rd_internacional = new System.Windows.Forms.RadioButton();
            this.cmb_origen = new System.Windows.Forms.ComboBox();
            this.cmb_nacional = new System.Windows.Forms.ComboBox();
            this.cmb_internacional = new System.Windows.Forms.ComboBox();
            this.dgv_listaVuelos = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.cb_wifi = new System.Windows.Forms.CheckBox();
            this.cb_comida = new System.Windows.Forms.CheckBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_origen
            // 
            this.lbl_origen.AutoSize = true;
            this.lbl_origen.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_origen.Location = new System.Drawing.Point(37, 40);
            this.lbl_origen.Name = "lbl_origen";
            this.lbl_origen.Size = new System.Drawing.Size(63, 18);
            this.lbl_origen.TabIndex = 0;
            this.lbl_origen.Text = "Origen";
            // 
            // lbl_destino
            // 
            this.lbl_destino.AutoSize = true;
            this.lbl_destino.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_destino.Location = new System.Drawing.Point(37, 90);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(70, 18);
            this.lbl_destino.TabIndex = 1;
            this.lbl_destino.Text = "Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destino";
            // 
            // rd_nacional
            // 
            this.rd_nacional.AutoSize = true;
            this.rd_nacional.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rd_nacional.Location = new System.Drawing.Point(162, 90);
            this.rd_nacional.Name = "rd_nacional";
            this.rd_nacional.Size = new System.Drawing.Size(101, 22);
            this.rd_nacional.TabIndex = 3;
            this.rd_nacional.TabStop = true;
            this.rd_nacional.Text = "Nacional";
            this.rd_nacional.UseVisualStyleBackColor = true;
            this.rd_nacional.CheckedChanged += new System.EventHandler(this.rd_nacional_CheckedChanged);
            // 
            // rd_internacional
            // 
            this.rd_internacional.AutoSize = true;
            this.rd_internacional.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rd_internacional.Location = new System.Drawing.Point(335, 90);
            this.rd_internacional.Name = "rd_internacional";
            this.rd_internacional.Size = new System.Drawing.Size(137, 22);
            this.rd_internacional.TabIndex = 4;
            this.rd_internacional.TabStop = true;
            this.rd_internacional.Text = "Internacional";
            this.rd_internacional.UseVisualStyleBackColor = true;
            this.rd_internacional.CheckedChanged += new System.EventHandler(this.rd_internacional_CheckedChanged);
            // 
            // cmb_origen
            // 
            this.cmb_origen.FormattingEnabled = true;
            this.cmb_origen.Location = new System.Drawing.Point(162, 32);
            this.cmb_origen.Name = "cmb_origen";
            this.cmb_origen.Size = new System.Drawing.Size(151, 28);
            this.cmb_origen.TabIndex = 5;
            // 
            // cmb_nacional
            // 
            this.cmb_nacional.FormattingEnabled = true;
            this.cmb_nacional.Location = new System.Drawing.Point(162, 146);
            this.cmb_nacional.Name = "cmb_nacional";
            this.cmb_nacional.Size = new System.Drawing.Size(151, 28);
            this.cmb_nacional.TabIndex = 6;
            // 
            // cmb_internacional
            // 
            this.cmb_internacional.FormattingEnabled = true;
            this.cmb_internacional.Location = new System.Drawing.Point(335, 146);
            this.cmb_internacional.Name = "cmb_internacional";
            this.cmb_internacional.Size = new System.Drawing.Size(151, 28);
            this.cmb_internacional.TabIndex = 7;
            // 
            // dgv_listaVuelos
            // 
            this.dgv_listaVuelos.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgv_listaVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaVuelos.Location = new System.Drawing.Point(37, 250);
            this.dgv_listaVuelos.Name = "dgv_listaVuelos";
            this.dgv_listaVuelos.RowHeadersWidth = 51;
            this.dgv_listaVuelos.RowTemplate.Height = 29;
            this.dgv_listaVuelos.Size = new System.Drawing.Size(751, 188);
            this.dgv_listaVuelos.TabIndex = 8;
            this.dgv_listaVuelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listaVuelos_CellContentClick);
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_buscar.Location = new System.Drawing.Point(694, 198);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(94, 29);
            this.btn_buscar.TabIndex = 9;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // cb_wifi
            // 
            this.cb_wifi.AutoSize = true;
            this.cb_wifi.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_wifi.Location = new System.Drawing.Point(37, 201);
            this.cb_wifi.Name = "cb_wifi";
            this.cb_wifi.Size = new System.Drawing.Size(66, 22);
            this.cb_wifi.TabIndex = 10;
            this.cb_wifi.Text = "Wifi";
            this.cb_wifi.UseVisualStyleBackColor = true;
            // 
            // cb_comida
            // 
            this.cb_comida.AutoSize = true;
            this.cb_comida.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_comida.Location = new System.Drawing.Point(162, 201);
            this.cb_comida.Name = "cb_comida";
            this.cb_comida.Size = new System.Drawing.Size(91, 22);
            this.cb_comida.TabIndex = 11;
            this.cb_comida.Text = "Comida";
            this.cb_comida.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(694, 463);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 29);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_aceptar.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_aceptar.Location = new System.Drawing.Point(582, 463);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(94, 29);
            this.btn_aceptar.TabIndex = 13;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // FrmElegirVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(808, 504);
            this.ControlBox = false;
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.cb_comida);
            this.Controls.Add(this.cb_wifi);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.dgv_listaVuelos);
            this.Controls.Add(this.cmb_internacional);
            this.Controls.Add(this.cmb_nacional);
            this.Controls.Add(this.cmb_origen);
            this.Controls.Add(this.rd_internacional);
            this.Controls.Add(this.rd_nacional);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_destino);
            this.Controls.Add(this.lbl_origen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmElegirVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar vuelo";
            this.Load += new System.EventHandler(this.FrmElegirVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_origen;
        private System.Windows.Forms.Label lbl_destino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rd_nacional;
        private System.Windows.Forms.RadioButton rd_internacional;
        private System.Windows.Forms.ComboBox cmb_origen;
        private System.Windows.Forms.ComboBox cmb_nacional;
        private System.Windows.Forms.ComboBox cmb_internacional;
        private System.Windows.Forms.DataGridView dgv_listaVuelos;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.CheckBox cb_wifi;
        private System.Windows.Forms.CheckBox cb_comida;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
    }
}