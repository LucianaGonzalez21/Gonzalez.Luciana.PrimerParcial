
namespace Aerolineas
{
    partial class FrmAltaPasajeroTurista
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
            this.lbl_clientes = new System.Windows.Forms.Label();
            this.dgv_listaClientes = new System.Windows.Forms.DataGridView();
            this.grp_equipajeMano = new System.Windows.Forms.GroupBox();
            this.rd_equipajeManoNo = new System.Windows.Forms.RadioButton();
            this.rd_equipajeManoSi = new System.Windows.Forms.RadioButton();
            this.grp_equipajeBodega = new System.Windows.Forms.GroupBox();
            this.rd_equipajeBodegaNo = new System.Windows.Forms.RadioButton();
            this.rd_equipajeBodegaSi = new System.Windows.Forms.RadioButton();
            this.num_valijaUno = new System.Windows.Forms.NumericUpDown();
            this.num_valijaDos = new System.Windows.Forms.NumericUpDown();
            this.lbl_valijaUno = new System.Windows.Forms.Label();
            this.lbl_valijaDos = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_textoError = new System.Windows.Forms.Label();
            this.lbl_clienteSeleccionado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaClientes)).BeginInit();
            this.grp_equipajeMano.SuspendLayout();
            this.grp_equipajeBodega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_valijaUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_valijaDos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_clientes
            // 
            this.lbl_clientes.AutoSize = true;
            this.lbl_clientes.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_clientes.Location = new System.Drawing.Point(27, 43);
            this.lbl_clientes.Name = "lbl_clientes";
            this.lbl_clientes.Size = new System.Drawing.Size(66, 18);
            this.lbl_clientes.TabIndex = 0;
            this.lbl_clientes.Text = "Cliente";
            // 
            // dgv_listaClientes
            // 
            this.dgv_listaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaClientes.Location = new System.Drawing.Point(27, 76);
            this.dgv_listaClientes.Name = "dgv_listaClientes";
            this.dgv_listaClientes.RowHeadersWidth = 51;
            this.dgv_listaClientes.RowTemplate.Height = 29;
            this.dgv_listaClientes.Size = new System.Drawing.Size(507, 163);
            this.dgv_listaClientes.TabIndex = 2;
            this.dgv_listaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listaClientes_CellContentClick);
            // 
            // grp_equipajeMano
            // 
            this.grp_equipajeMano.Controls.Add(this.rd_equipajeManoNo);
            this.grp_equipajeMano.Controls.Add(this.rd_equipajeManoSi);
            this.grp_equipajeMano.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grp_equipajeMano.Location = new System.Drawing.Point(27, 259);
            this.grp_equipajeMano.Name = "grp_equipajeMano";
            this.grp_equipajeMano.Size = new System.Drawing.Size(204, 67);
            this.grp_equipajeMano.TabIndex = 3;
            this.grp_equipajeMano.TabStop = false;
            this.grp_equipajeMano.Text = "Equipaje de Mano";
            // 
            // rd_equipajeManoNo
            // 
            this.rd_equipajeManoNo.AutoSize = true;
            this.rd_equipajeManoNo.Location = new System.Drawing.Point(90, 26);
            this.rd_equipajeManoNo.Name = "rd_equipajeManoNo";
            this.rd_equipajeManoNo.Size = new System.Drawing.Size(52, 22);
            this.rd_equipajeManoNo.TabIndex = 1;
            this.rd_equipajeManoNo.TabStop = true;
            this.rd_equipajeManoNo.Text = "No";
            this.rd_equipajeManoNo.UseVisualStyleBackColor = true;
            this.rd_equipajeManoNo.CheckedChanged += new System.EventHandler(this.rd_equipajeManoNo_CheckedChanged);
            // 
            // rd_equipajeManoSi
            // 
            this.rd_equipajeManoSi.AutoSize = true;
            this.rd_equipajeManoSi.Location = new System.Drawing.Point(21, 26);
            this.rd_equipajeManoSi.Name = "rd_equipajeManoSi";
            this.rd_equipajeManoSi.Size = new System.Drawing.Size(45, 22);
            this.rd_equipajeManoSi.TabIndex = 0;
            this.rd_equipajeManoSi.TabStop = true;
            this.rd_equipajeManoSi.Text = "Si";
            this.rd_equipajeManoSi.UseVisualStyleBackColor = true;
            this.rd_equipajeManoSi.CheckedChanged += new System.EventHandler(this.rd_equipajeManoSi_CheckedChanged);
            // 
            // grp_equipajeBodega
            // 
            this.grp_equipajeBodega.Controls.Add(this.rd_equipajeBodegaNo);
            this.grp_equipajeBodega.Controls.Add(this.rd_equipajeBodegaSi);
            this.grp_equipajeBodega.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grp_equipajeBodega.Location = new System.Drawing.Point(295, 259);
            this.grp_equipajeBodega.Name = "grp_equipajeBodega";
            this.grp_equipajeBodega.Size = new System.Drawing.Size(239, 67);
            this.grp_equipajeBodega.TabIndex = 4;
            this.grp_equipajeBodega.TabStop = false;
            this.grp_equipajeBodega.Text = "Equipaje de Bodega";
            // 
            // rd_equipajeBodegaNo
            // 
            this.rd_equipajeBodegaNo.AutoSize = true;
            this.rd_equipajeBodegaNo.Location = new System.Drawing.Point(107, 26);
            this.rd_equipajeBodegaNo.Name = "rd_equipajeBodegaNo";
            this.rd_equipajeBodegaNo.Size = new System.Drawing.Size(52, 22);
            this.rd_equipajeBodegaNo.TabIndex = 1;
            this.rd_equipajeBodegaNo.TabStop = true;
            this.rd_equipajeBodegaNo.Text = "No";
            this.rd_equipajeBodegaNo.UseVisualStyleBackColor = true;
            this.rd_equipajeBodegaNo.CheckedChanged += new System.EventHandler(this.rd_equipajeBodegaNo_CheckedChanged);
            // 
            // rd_equipajeBodegaSi
            // 
            this.rd_equipajeBodegaSi.AutoSize = true;
            this.rd_equipajeBodegaSi.Location = new System.Drawing.Point(27, 26);
            this.rd_equipajeBodegaSi.Name = "rd_equipajeBodegaSi";
            this.rd_equipajeBodegaSi.Size = new System.Drawing.Size(45, 22);
            this.rd_equipajeBodegaSi.TabIndex = 0;
            this.rd_equipajeBodegaSi.TabStop = true;
            this.rd_equipajeBodegaSi.Text = "Si";
            this.rd_equipajeBodegaSi.UseVisualStyleBackColor = true;
            // 
            // num_valijaUno
            // 
            this.num_valijaUno.Location = new System.Drawing.Point(384, 342);
            this.num_valijaUno.Name = "num_valijaUno";
            this.num_valijaUno.Size = new System.Drawing.Size(150, 27);
            this.num_valijaUno.TabIndex = 5;
            // 
            // num_valijaDos
            // 
            this.num_valijaDos.Location = new System.Drawing.Point(384, 392);
            this.num_valijaDos.Name = "num_valijaDos";
            this.num_valijaDos.Size = new System.Drawing.Size(150, 27);
            this.num_valijaDos.TabIndex = 6;
            // 
            // lbl_valijaUno
            // 
            this.lbl_valijaUno.AutoSize = true;
            this.lbl_valijaUno.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_valijaUno.Location = new System.Drawing.Point(295, 351);
            this.lbl_valijaUno.Name = "lbl_valijaUno";
            this.lbl_valijaUno.Size = new System.Drawing.Size(72, 18);
            this.lbl_valijaUno.TabIndex = 7;
            this.lbl_valijaUno.Text = "Valija 1";
            // 
            // lbl_valijaDos
            // 
            this.lbl_valijaDos.AutoSize = true;
            this.lbl_valijaDos.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_valijaDos.Location = new System.Drawing.Point(295, 396);
            this.lbl_valijaDos.Name = "lbl_valijaDos";
            this.lbl_valijaDos.Size = new System.Drawing.Size(72, 18);
            this.lbl_valijaDos.TabIndex = 8;
            this.lbl_valijaDos.Text = "Valija 2";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_aceptar.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_aceptar.Location = new System.Drawing.Point(330, 461);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(94, 29);
            this.btn_aceptar.TabIndex = 9;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(440, 461);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 29);
            this.btn_cancelar.TabIndex = 10;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // lbl_textoError
            // 
            this.lbl_textoError.AutoSize = true;
            this.lbl_textoError.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_textoError.ForeColor = System.Drawing.Color.Red;
            this.lbl_textoError.Location = new System.Drawing.Point(27, 466);
            this.lbl_textoError.Name = "lbl_textoError";
            this.lbl_textoError.Size = new System.Drawing.Size(101, 18);
            this.lbl_textoError.TabIndex = 11;
            this.lbl_textoError.Text = "Texto Error";
            // 
            // lbl_clienteSeleccionado
            // 
            this.lbl_clienteSeleccionado.AutoSize = true;
            this.lbl_clienteSeleccionado.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_clienteSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_clienteSeleccionado.Location = new System.Drawing.Point(147, 43);
            this.lbl_clienteSeleccionado.Name = "lbl_clienteSeleccionado";
            this.lbl_clienteSeleccionado.Size = new System.Drawing.Size(176, 18);
            this.lbl_clienteSeleccionado.TabIndex = 12;
            this.lbl_clienteSeleccionado.Text = "Cliente seleccionado";
            // 
            // FrmAltaPasajeroTurista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(546, 502);
            this.Controls.Add(this.lbl_clienteSeleccionado);
            this.Controls.Add(this.lbl_textoError);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_valijaDos);
            this.Controls.Add(this.lbl_valijaUno);
            this.Controls.Add(this.num_valijaDos);
            this.Controls.Add(this.num_valijaUno);
            this.Controls.Add(this.grp_equipajeBodega);
            this.Controls.Add(this.grp_equipajeMano);
            this.Controls.Add(this.dgv_listaClientes);
            this.Controls.Add(this.lbl_clientes);
            this.Name = "FrmAltaPasajeroTurista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltaPasajeroTurista";
            this.Load += new System.EventHandler(this.FrmAltaPasajeroTurista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaClientes)).EndInit();
            this.grp_equipajeMano.ResumeLayout(false);
            this.grp_equipajeMano.PerformLayout();
            this.grp_equipajeBodega.ResumeLayout(false);
            this.grp_equipajeBodega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_valijaUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_valijaDos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_clientes;
        private System.Windows.Forms.DataGridView dgv_listaClientes;
        private System.Windows.Forms.GroupBox grp_equipajeMano;
        private System.Windows.Forms.RadioButton rd_equipajeManoNo;
        private System.Windows.Forms.RadioButton rd_equipajeManoSi;
        private System.Windows.Forms.GroupBox grp_equipajeBodega;
        private System.Windows.Forms.RadioButton rd_equipajeBodegaNo;
        private System.Windows.Forms.RadioButton rd_equipajeBodegaSi;
        private System.Windows.Forms.NumericUpDown num_valijaUno;
        private System.Windows.Forms.NumericUpDown num_valijaDos;
        private System.Windows.Forms.Label lbl_valijaUno;
        private System.Windows.Forms.Label lbl_valijaDos;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_textoError;
        private System.Windows.Forms.Label lbl_clienteSeleccionado;
    }
}