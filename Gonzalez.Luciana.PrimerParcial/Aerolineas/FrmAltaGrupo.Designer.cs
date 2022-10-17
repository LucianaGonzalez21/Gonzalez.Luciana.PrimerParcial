
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
            this.lblImporteBruto = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lblCostoTotalVuelos = new System.Windows.Forms.Label();
            this.lblImporteTotalVuelos = new System.Windows.Forms.Label();
            this.gbAlojamiento = new System.Windows.Forms.GroupBox();
            this.rbAlojamientoNo = new System.Windows.Forms.RadioButton();
            this.rbAlojamientoSi = new System.Windows.Forms.RadioButton();
            this.gbTipoAlojamiento = new System.Windows.Forms.GroupBox();
            this.rbCabania = new System.Windows.Forms.RadioButton();
            this.rbHotel = new System.Windows.Forms.RadioButton();
            this.gbDesayuno = new System.Windows.Forms.GroupBox();
            this.rbDesayunoNo = new System.Windows.Forms.RadioButton();
            this.rbDesayunoSi = new System.Windows.Forms.RadioButton();
            this.nudCantidadDias = new System.Windows.Forms.NumericUpDown();
            this.lblCostoAlojamiento = new System.Windows.Forms.Label();
            this.lblImporteAlojamiento = new System.Windows.Forms.Label();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.lblCostoTotalAlojamiento = new System.Windows.Forms.Label();
            this.lblImporteTotalAlojamiento = new System.Windows.Forms.Label();
            this.gpr_Clase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaPasajeros)).BeginInit();
            this.gbAlojamiento.SuspendLayout();
            this.gbTipoAlojamiento.SuspendLayout();
            this.gbDesayuno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadDias)).BeginInit();
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
            this.btn_AgregarPasajero.Location = new System.Drawing.Point(311, 153);
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
            this.lbl_vuelo.Location = new System.Drawing.Point(26, 401);
            this.lbl_vuelo.Name = "lbl_vuelo";
            this.lbl_vuelo.Size = new System.Drawing.Size(56, 18);
            this.lbl_vuelo.TabIndex = 4;
            this.lbl_vuelo.Text = "Vuelo";
            // 
            // btn_seleccionarVuelo
            // 
            this.btn_seleccionarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_seleccionarVuelo.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_seleccionarVuelo.Location = new System.Drawing.Point(272, 396);
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
            this.dgv_listaPasajeros.Size = new System.Drawing.Size(444, 135);
            this.dgv_listaPasajeros.TabIndex = 11;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_aceptar.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_aceptar.Location = new System.Drawing.Point(662, 604);
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
            this.btn_cancelar.Location = new System.Drawing.Point(808, 604);
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
            this.lbl_textoError.Location = new System.Drawing.Point(26, 609);
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
            this.lbl_vueloSeleccionado.Location = new System.Drawing.Point(26, 457);
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
            this.lbl_costoBruto.Location = new System.Drawing.Point(497, 404);
            this.lbl_costoBruto.Name = "lbl_costoBruto";
            this.lbl_costoBruto.Size = new System.Drawing.Size(207, 18);
            this.lbl_costoBruto.TabIndex = 6;
            this.lbl_costoBruto.Text = "Costo Vuelo por persona";
            // 
            // lblImporteBruto
            // 
            this.lblImporteBruto.AutoSize = true;
            this.lblImporteBruto.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImporteBruto.Location = new System.Drawing.Point(821, 404);
            this.lblImporteBruto.Name = "lblImporteBruto";
            this.lblImporteBruto.Size = new System.Drawing.Size(118, 18);
            this.lblImporteBruto.TabIndex = 7;
            this.lblImporteBruto.Text = "importe bruto";
            this.lblImporteBruto.Visible = false;
            // 
            // btn_calcular
            // 
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_calcular.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_calcular.Location = new System.Drawing.Point(808, 550);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(131, 29);
            this.btn_calcular.TabIndex = 17;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lblCostoTotalVuelos
            // 
            this.lblCostoTotalVuelos.AutoSize = true;
            this.lblCostoTotalVuelos.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostoTotalVuelos.Location = new System.Drawing.Point(497, 470);
            this.lblCostoTotalVuelos.Name = "lblCostoTotalVuelos";
            this.lblCostoTotalVuelos.Size = new System.Drawing.Size(307, 18);
            this.lblCostoTotalVuelos.TabIndex = 18;
            this.lblCostoTotalVuelos.Text = "Costo Total de Vuelos con Impuestos";
            // 
            // lblImporteTotalVuelos
            // 
            this.lblImporteTotalVuelos.AutoSize = true;
            this.lblImporteTotalVuelos.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImporteTotalVuelos.Location = new System.Drawing.Point(823, 470);
            this.lblImporteTotalVuelos.Name = "lblImporteTotalVuelos";
            this.lblImporteTotalVuelos.Size = new System.Drawing.Size(112, 18);
            this.lblImporteTotalVuelos.TabIndex = 19;
            this.lblImporteTotalVuelos.Text = "importe total";
            this.lblImporteTotalVuelos.Visible = false;
            // 
            // gbAlojamiento
            // 
            this.gbAlojamiento.Controls.Add(this.rbAlojamientoNo);
            this.gbAlojamiento.Controls.Add(this.rbAlojamientoSi);
            this.gbAlojamiento.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbAlojamiento.Location = new System.Drawing.Point(495, 158);
            this.gbAlojamiento.Name = "gbAlojamiento";
            this.gbAlojamiento.Size = new System.Drawing.Size(219, 80);
            this.gbAlojamiento.TabIndex = 21;
            this.gbAlojamiento.TabStop = false;
            this.gbAlojamiento.Text = "Alojamiento";
            // 
            // rbAlojamientoNo
            // 
            this.rbAlojamientoNo.AutoSize = true;
            this.rbAlojamientoNo.Location = new System.Drawing.Point(115, 35);
            this.rbAlojamientoNo.Name = "rbAlojamientoNo";
            this.rbAlojamientoNo.Size = new System.Drawing.Size(52, 22);
            this.rbAlojamientoNo.TabIndex = 1;
            this.rbAlojamientoNo.TabStop = true;
            this.rbAlojamientoNo.Text = "No";
            this.rbAlojamientoNo.UseVisualStyleBackColor = true;
            this.rbAlojamientoNo.CheckedChanged += new System.EventHandler(this.rbAlojamientoNo_CheckedChanged);
            // 
            // rbAlojamientoSi
            // 
            this.rbAlojamientoSi.AutoSize = true;
            this.rbAlojamientoSi.Location = new System.Drawing.Point(22, 35);
            this.rbAlojamientoSi.Name = "rbAlojamientoSi";
            this.rbAlojamientoSi.Size = new System.Drawing.Size(45, 22);
            this.rbAlojamientoSi.TabIndex = 0;
            this.rbAlojamientoSi.TabStop = true;
            this.rbAlojamientoSi.Text = "Si";
            this.rbAlojamientoSi.UseVisualStyleBackColor = true;
            this.rbAlojamientoSi.CheckedChanged += new System.EventHandler(this.rbAlojamientoSi_CheckedChanged);
            // 
            // gbTipoAlojamiento
            // 
            this.gbTipoAlojamiento.Controls.Add(this.rbCabania);
            this.gbTipoAlojamiento.Controls.Add(this.rbHotel);
            this.gbTipoAlojamiento.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbTipoAlojamiento.Location = new System.Drawing.Point(495, 269);
            this.gbTipoAlojamiento.Name = "gbTipoAlojamiento";
            this.gbTipoAlojamiento.Size = new System.Drawing.Size(219, 80);
            this.gbTipoAlojamiento.TabIndex = 22;
            this.gbTipoAlojamiento.TabStop = false;
            this.gbTipoAlojamiento.Text = "Tipo Alojamiento";
            // 
            // rbCabania
            // 
            this.rbCabania.AutoSize = true;
            this.rbCabania.Location = new System.Drawing.Point(115, 35);
            this.rbCabania.Name = "rbCabania";
            this.rbCabania.Size = new System.Drawing.Size(94, 22);
            this.rbCabania.TabIndex = 1;
            this.rbCabania.TabStop = true;
            this.rbCabania.Text = "Cabania";
            this.rbCabania.UseVisualStyleBackColor = true;
            // 
            // rbHotel
            // 
            this.rbHotel.AutoSize = true;
            this.rbHotel.Location = new System.Drawing.Point(23, 35);
            this.rbHotel.Name = "rbHotel";
            this.rbHotel.Size = new System.Drawing.Size(73, 22);
            this.rbHotel.TabIndex = 0;
            this.rbHotel.TabStop = true;
            this.rbHotel.Text = "Hotel";
            this.rbHotel.UseVisualStyleBackColor = true;
            // 
            // gbDesayuno
            // 
            this.gbDesayuno.Controls.Add(this.rbDesayunoNo);
            this.gbDesayuno.Controls.Add(this.rbDesayunoSi);
            this.gbDesayuno.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbDesayuno.Location = new System.Drawing.Point(720, 269);
            this.gbDesayuno.Name = "gbDesayuno";
            this.gbDesayuno.Size = new System.Drawing.Size(219, 80);
            this.gbDesayuno.TabIndex = 23;
            this.gbDesayuno.TabStop = false;
            this.gbDesayuno.Text = "Desayuno";
            // 
            // rbDesayunoNo
            // 
            this.rbDesayunoNo.AutoSize = true;
            this.rbDesayunoNo.Location = new System.Drawing.Point(115, 35);
            this.rbDesayunoNo.Name = "rbDesayunoNo";
            this.rbDesayunoNo.Size = new System.Drawing.Size(52, 22);
            this.rbDesayunoNo.TabIndex = 1;
            this.rbDesayunoNo.TabStop = true;
            this.rbDesayunoNo.Text = "No";
            this.rbDesayunoNo.UseVisualStyleBackColor = true;
            // 
            // rbDesayunoSi
            // 
            this.rbDesayunoSi.AutoSize = true;
            this.rbDesayunoSi.Location = new System.Drawing.Point(22, 35);
            this.rbDesayunoSi.Name = "rbDesayunoSi";
            this.rbDesayunoSi.Size = new System.Drawing.Size(45, 22);
            this.rbDesayunoSi.TabIndex = 0;
            this.rbDesayunoSi.TabStop = true;
            this.rbDesayunoSi.Text = "Si";
            this.rbDesayunoSi.UseVisualStyleBackColor = true;
            // 
            // nudCantidadDias
            // 
            this.nudCantidadDias.Location = new System.Drawing.Point(789, 193);
            this.nudCantidadDias.Name = "nudCantidadDias";
            this.nudCantidadDias.Size = new System.Drawing.Size(150, 27);
            this.nudCantidadDias.TabIndex = 24;
            // 
            // lblCostoAlojamiento
            // 
            this.lblCostoAlojamiento.AutoSize = true;
            this.lblCostoAlojamiento.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostoAlojamiento.Location = new System.Drawing.Point(497, 370);
            this.lblCostoAlojamiento.Name = "lblCostoAlojamiento";
            this.lblCostoAlojamiento.Size = new System.Drawing.Size(258, 18);
            this.lblCostoAlojamiento.TabIndex = 25;
            this.lblCostoAlojamiento.Text = "Costo Alojamiento por persona";
            // 
            // lblImporteAlojamiento
            // 
            this.lblImporteAlojamiento.AutoSize = true;
            this.lblImporteAlojamiento.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImporteAlojamiento.Location = new System.Drawing.Point(821, 370);
            this.lblImporteAlojamiento.Name = "lblImporteAlojamiento";
            this.lblImporteAlojamiento.Size = new System.Drawing.Size(170, 18);
            this.lblImporteAlojamiento.TabIndex = 26;
            this.lblImporteAlojamiento.Text = "importe alojamiento";
            this.lblImporteAlojamiento.Visible = false;
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostoTotal.Location = new System.Drawing.Point(497, 507);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(106, 18);
            this.lblCostoTotal.TabIndex = 27;
            this.lblCostoTotal.Text = "Costo Total ";
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImporteTotal.Location = new System.Drawing.Point(821, 507);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(112, 18);
            this.lblImporteTotal.TabIndex = 28;
            this.lblImporteTotal.Text = "importe total";
            this.lblImporteTotal.Visible = false;
            // 
            // lblCostoTotalAlojamiento
            // 
            this.lblCostoTotalAlojamiento.AutoSize = true;
            this.lblCostoTotalAlojamiento.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostoTotalAlojamiento.Location = new System.Drawing.Point(497, 436);
            this.lblCostoTotalAlojamiento.Name = "lblCostoTotalAlojamiento";
            this.lblCostoTotalAlojamiento.Size = new System.Drawing.Size(205, 18);
            this.lblCostoTotalAlojamiento.TabIndex = 29;
            this.lblCostoTotalAlojamiento.Text = "Costo Total Alojamiento";
            // 
            // lblImporteTotalAlojamiento
            // 
            this.lblImporteTotalAlojamiento.AutoSize = true;
            this.lblImporteTotalAlojamiento.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImporteTotalAlojamiento.Location = new System.Drawing.Point(821, 436);
            this.lblImporteTotalAlojamiento.Name = "lblImporteTotalAlojamiento";
            this.lblImporteTotalAlojamiento.Size = new System.Drawing.Size(112, 18);
            this.lblImporteTotalAlojamiento.TabIndex = 30;
            this.lblImporteTotalAlojamiento.Text = "importe total";
            this.lblImporteTotalAlojamiento.Visible = false;
            // 
            // FrmAltaGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(951, 645);
            this.ControlBox = false;
            this.Controls.Add(this.lblImporteTotalAlojamiento);
            this.Controls.Add(this.lblCostoTotalAlojamiento);
            this.Controls.Add(this.lblImporteTotal);
            this.Controls.Add(this.lblCostoTotal);
            this.Controls.Add(this.lblImporteAlojamiento);
            this.Controls.Add(this.lblCostoAlojamiento);
            this.Controls.Add(this.nudCantidadDias);
            this.Controls.Add(this.gbDesayuno);
            this.Controls.Add(this.gbTipoAlojamiento);
            this.Controls.Add(this.gbAlojamiento);
            this.Controls.Add(this.lblImporteTotalVuelos);
            this.Controls.Add(this.lblCostoTotalVuelos);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_vueloSeleccionado);
            this.Controls.Add(this.lbl_textoError);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.dgv_listaPasajeros);
            this.Controls.Add(this.gpr_Clase);
            this.Controls.Add(this.lblImporteBruto);
            this.Controls.Add(this.lbl_costoBruto);
            this.Controls.Add(this.btn_seleccionarVuelo);
            this.Controls.Add(this.lbl_vuelo);
            this.Controls.Add(this.btn_AgregarPasajero);
            this.Controls.Add(this.lbl_pasajeros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAltaGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta grupo familiar";
            this.Load += new System.EventHandler(this.FrmAltaGrupo_Load);
            this.gpr_Clase.ResumeLayout(false);
            this.gpr_Clase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaPasajeros)).EndInit();
            this.gbAlojamiento.ResumeLayout(false);
            this.gbAlojamiento.PerformLayout();
            this.gbTipoAlojamiento.ResumeLayout(false);
            this.gbTipoAlojamiento.PerformLayout();
            this.gbDesayuno.ResumeLayout(false);
            this.gbDesayuno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadDias)).EndInit();
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
        private System.Windows.Forms.Label lblImporteBruto;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lblCostoTotalVuelos;
        private System.Windows.Forms.Label lblImporteTotalVuelos;
        private System.Windows.Forms.GroupBox gbAlojamiento;
        private System.Windows.Forms.RadioButton rbAlojamientoNo;
        private System.Windows.Forms.RadioButton rbAlojamientoSi;
        private System.Windows.Forms.GroupBox gbTipoAlojamiento;
        private System.Windows.Forms.RadioButton rbCabania;
        private System.Windows.Forms.RadioButton rbHotel;
        private System.Windows.Forms.GroupBox gbDesayuno;
        private System.Windows.Forms.RadioButton rbDesayunoNo;
        private System.Windows.Forms.RadioButton rbDesayunoSi;
        private System.Windows.Forms.NumericUpDown nudCantidadDias;
        private System.Windows.Forms.Label lblCostoAlojamiento;
        private System.Windows.Forms.Label lblImporteAlojamiento;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.Label lblCostoTotalAlojamiento;
        private System.Windows.Forms.Label lblImporteTotalAlojamiento;
    }
}