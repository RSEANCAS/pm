namespace pm.app
{
    partial class FrmMantenimientoComprobantePago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblErrorDetalle = new System.Windows.Forms.Label();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.btnModificarDetalle = new System.Windows.Forms.Button();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.dgvDetalle_CodigoComprobantePagoDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_Fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_TipoDocumentoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_DocumentoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_Mora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_Protesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_ImportePagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblErrorCodigoMoneda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbCodigoMoneda = new System.Windows.Forms.ComboBox();
            this.lblErrorCodigoSerie = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbCodigoSerie = new System.Windows.Forms.ComboBox();
            this.lblErrorNroComprobante = new System.Windows.Forms.Label();
            this.lblErrorSerie = new System.Windows.Forms.Label();
            this.lblErrorFechaHoraPago = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroComprobante = new System.Windows.Forms.TextBox();
            this.dtpFechaHoraPago = new System.Windows.Forms.DateTimePicker();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblErrorCliente = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUbicacionCliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombresCliente = new System.Windows.Forms.TextBox();
            this.txtNroDocumentoIdentidadCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbCodigoTipoDocumentoIdentidadCliente = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tltComprobantePago = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gpbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(809, 460);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtMonto);
            this.groupBox3.Controls.Add(this.lblErrorDetalle);
            this.groupBox3.Controls.Add(this.btnEliminarDetalle);
            this.groupBox3.Controls.Add(this.btnModificarDetalle);
            this.groupBox3.Controls.Add(this.btnAgregarDetalle);
            this.groupBox3.Controls.Add(this.dgvDetalle);
            this.groupBox3.Location = new System.Drawing.Point(8, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(876, 247);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle del Comprobante";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(699, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Importe Total";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(702, 220);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(168, 20);
            this.txtMonto.TabIndex = 4;
            // 
            // lblErrorDetalle
            // 
            this.lblErrorDetalle.AutoSize = true;
            this.lblErrorDetalle.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDetalle.Location = new System.Drawing.Point(3, 204);
            this.lblErrorDetalle.Name = "lblErrorDetalle";
            this.lblErrorDetalle.Size = new System.Drawing.Size(0, 13);
            this.lblErrorDetalle.TabIndex = 35;
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.Location = new System.Drawing.Point(795, 78);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarDetalle.TabIndex = 3;
            this.btnEliminarDetalle.Text = "Eliminar";
            this.btnEliminarDetalle.UseVisualStyleBackColor = true;
            this.btnEliminarDetalle.Click += new System.EventHandler(this.btnEliminarDetalle_Click);
            // 
            // btnModificarDetalle
            // 
            this.btnModificarDetalle.Location = new System.Drawing.Point(795, 49);
            this.btnModificarDetalle.Name = "btnModificarDetalle";
            this.btnModificarDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnModificarDetalle.TabIndex = 2;
            this.btnModificarDetalle.Text = "Modificar";
            this.btnModificarDetalle.UseVisualStyleBackColor = true;
            this.btnModificarDetalle.Click += new System.EventHandler(this.btnModificarDetalle_Click);
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Location = new System.Drawing.Point(795, 20);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDetalle.TabIndex = 1;
            this.btnAgregarDetalle.Text = "Agregar";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDetalle_CodigoComprobantePagoDetalle,
            this.dgvDetalle_Fila,
            this.dgvDetalle_TipoDocumentoPago,
            this.dgvDetalle_DocumentoPago,
            this.dgvDetalle_Monto,
            this.dgvDetalle_Mora,
            this.dgvDetalle_Protesto,
            this.dgvDetalle_Total,
            this.dgvResultados_ImportePagar});
            this.dgvDetalle.Location = new System.Drawing.Point(6, 20);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(783, 181);
            this.dgvDetalle.TabIndex = 0;
            this.dgvDetalle.SelectionChanged += new System.EventHandler(this.dgvDetalle_SelectionChanged);
            // 
            // dgvDetalle_CodigoComprobantePagoDetalle
            // 
            this.dgvDetalle_CodigoComprobantePagoDetalle.DataPropertyName = "CodigoComprobantePagoDetalle";
            this.dgvDetalle_CodigoComprobantePagoDetalle.HeaderText = "CodigoComprobantePagoDetalle";
            this.dgvDetalle_CodigoComprobantePagoDetalle.Name = "dgvDetalle_CodigoComprobantePagoDetalle";
            this.dgvDetalle_CodigoComprobantePagoDetalle.ReadOnly = true;
            this.dgvDetalle_CodigoComprobantePagoDetalle.Visible = false;
            // 
            // dgvDetalle_Fila
            // 
            this.dgvDetalle_Fila.DataPropertyName = "Fila";
            this.dgvDetalle_Fila.HeaderText = "N°";
            this.dgvDetalle_Fila.Name = "dgvDetalle_Fila";
            this.dgvDetalle_Fila.ReadOnly = true;
            this.dgvDetalle_Fila.Width = 30;
            // 
            // dgvDetalle_TipoDocumentoPago
            // 
            this.dgvDetalle_TipoDocumentoPago.DataPropertyName = "StrTipoDocumentoPago";
            this.dgvDetalle_TipoDocumentoPago.HeaderText = "Tipo Doc. Pago";
            this.dgvDetalle_TipoDocumentoPago.Name = "dgvDetalle_TipoDocumentoPago";
            this.dgvDetalle_TipoDocumentoPago.ReadOnly = true;
            this.dgvDetalle_TipoDocumentoPago.Width = 200;
            // 
            // dgvDetalle_DocumentoPago
            // 
            this.dgvDetalle_DocumentoPago.DataPropertyName = "StrDocumentoPago";
            this.dgvDetalle_DocumentoPago.HeaderText = "Doc. Pago";
            this.dgvDetalle_DocumentoPago.Name = "dgvDetalle_DocumentoPago";
            this.dgvDetalle_DocumentoPago.ReadOnly = true;
            // 
            // dgvDetalle_Monto
            // 
            this.dgvDetalle_Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "#,##0.00";
            this.dgvDetalle_Monto.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle_Monto.HeaderText = "Monto";
            this.dgvDetalle_Monto.Name = "dgvDetalle_Monto";
            this.dgvDetalle_Monto.ReadOnly = true;
            this.dgvDetalle_Monto.Width = 150;
            // 
            // dgvDetalle_Mora
            // 
            this.dgvDetalle_Mora.DataPropertyName = "Mora";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "#,##0.00";
            this.dgvDetalle_Mora.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalle_Mora.HeaderText = "Mora";
            this.dgvDetalle_Mora.Name = "dgvDetalle_Mora";
            this.dgvDetalle_Mora.ReadOnly = true;
            this.dgvDetalle_Mora.Width = 150;
            // 
            // dgvDetalle_Protesto
            // 
            this.dgvDetalle_Protesto.DataPropertyName = "Protesto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,##0.00";
            this.dgvDetalle_Protesto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalle_Protesto.HeaderText = "Protesto";
            this.dgvDetalle_Protesto.Name = "dgvDetalle_Protesto";
            this.dgvDetalle_Protesto.ReadOnly = true;
            // 
            // dgvDetalle_Total
            // 
            this.dgvDetalle_Total.DataPropertyName = "Total";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "#,##0.00";
            this.dgvDetalle_Total.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalle_Total.HeaderText = "Total";
            this.dgvDetalle_Total.Name = "dgvDetalle_Total";
            this.dgvDetalle_Total.ReadOnly = true;
            this.dgvDetalle_Total.Width = 150;
            // 
            // dgvResultados_ImportePagar
            // 
            this.dgvResultados_ImportePagar.DataPropertyName = "ImportePagar";
            this.dgvResultados_ImportePagar.HeaderText = "Importe a Pagar";
            this.dgvResultados_ImportePagar.Name = "dgvResultados_ImportePagar";
            this.dgvResultados_ImportePagar.ReadOnly = true;
            this.dgvResultados_ImportePagar.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblErrorCodigoMoneda);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbCodigoMoneda);
            this.groupBox1.Controls.Add(this.lblErrorCodigoSerie);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbCodigoSerie);
            this.groupBox1.Controls.Add(this.lblErrorNroComprobante);
            this.groupBox1.Controls.Add(this.lblErrorSerie);
            this.groupBox1.Controls.Add(this.lblErrorFechaHoraPago);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNroComprobante);
            this.groupBox1.Controls.Add(this.dtpFechaHoraPago);
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Comprobante";
            // 
            // lblErrorCodigoMoneda
            // 
            this.lblErrorCodigoMoneda.AutoSize = true;
            this.lblErrorCodigoMoneda.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoMoneda.Location = new System.Drawing.Point(525, 56);
            this.lblErrorCodigoMoneda.Name = "lblErrorCodigoMoneda";
            this.lblErrorCodigoMoneda.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoMoneda.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Moneda";
            // 
            // cbbCodigoMoneda
            // 
            this.cbbCodigoMoneda.DisplayMember = "Text";
            this.cbbCodigoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoMoneda.FormattingEnabled = true;
            this.cbbCodigoMoneda.Location = new System.Drawing.Point(528, 32);
            this.cbbCodigoMoneda.Name = "cbbCodigoMoneda";
            this.cbbCodigoMoneda.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoMoneda.TabIndex = 3;
            this.cbbCodigoMoneda.ValueMember = "Value";
            // 
            // lblErrorCodigoSerie
            // 
            this.lblErrorCodigoSerie.AutoSize = true;
            this.lblErrorCodigoSerie.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoSerie.Location = new System.Drawing.Point(177, 57);
            this.lblErrorCodigoSerie.Name = "lblErrorCodigoSerie";
            this.lblErrorCodigoSerie.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoSerie.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Serie";
            // 
            // cbbCodigoSerie
            // 
            this.cbbCodigoSerie.DisplayMember = "Serial";
            this.cbbCodigoSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoSerie.FormattingEnabled = true;
            this.cbbCodigoSerie.Location = new System.Drawing.Point(180, 33);
            this.cbbCodigoSerie.Name = "cbbCodigoSerie";
            this.cbbCodigoSerie.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoSerie.TabIndex = 1;
            this.cbbCodigoSerie.ValueMember = "CodigoSerie";
            // 
            // lblErrorNroComprobante
            // 
            this.lblErrorNroComprobante.AutoSize = true;
            this.lblErrorNroComprobante.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNroComprobante.Location = new System.Drawing.Point(351, 57);
            this.lblErrorNroComprobante.Name = "lblErrorNroComprobante";
            this.lblErrorNroComprobante.Size = new System.Drawing.Size(0, 13);
            this.lblErrorNroComprobante.TabIndex = 10;
            // 
            // lblErrorSerie
            // 
            this.lblErrorSerie.AutoSize = true;
            this.lblErrorSerie.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSerie.Location = new System.Drawing.Point(351, 57);
            this.lblErrorSerie.Name = "lblErrorSerie";
            this.lblErrorSerie.Size = new System.Drawing.Size(0, 13);
            this.lblErrorSerie.TabIndex = 9;
            // 
            // lblErrorFechaHoraPago
            // 
            this.lblErrorFechaHoraPago.AutoSize = true;
            this.lblErrorFechaHoraPago.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFechaHoraPago.Location = new System.Drawing.Point(3, 57);
            this.lblErrorFechaHoraPago.Name = "lblErrorFechaHoraPago";
            this.lblErrorFechaHoraPago.Size = new System.Drawing.Size(0, 13);
            this.lblErrorFechaHoraPago.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "N° Comprobante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha y Hora de Registro";
            // 
            // txtNroComprobante
            // 
            this.txtNroComprobante.Location = new System.Drawing.Point(354, 33);
            this.txtNroComprobante.Name = "txtNroComprobante";
            this.txtNroComprobante.ReadOnly = true;
            this.txtNroComprobante.Size = new System.Drawing.Size(168, 20);
            this.txtNroComprobante.TabIndex = 2;
            // 
            // dtpFechaHoraPago
            // 
            this.dtpFechaHoraPago.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpFechaHoraPago.Enabled = false;
            this.dtpFechaHoraPago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHoraPago.Location = new System.Drawing.Point(6, 33);
            this.dtpFechaHoraPago.Name = "dtpFechaHoraPago";
            this.dtpFechaHoraPago.Size = new System.Drawing.Size(168, 20);
            this.dtpFechaHoraPago.TabIndex = 0;
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.btnBuscarCliente);
            this.gpbCliente.Controls.Add(this.lblErrorCliente);
            this.gpbCliente.Controls.Add(this.label17);
            this.gpbCliente.Controls.Add(this.txtUbicacionCliente);
            this.gpbCliente.Controls.Add(this.label14);
            this.gpbCliente.Controls.Add(this.txtDireccionCliente);
            this.gpbCliente.Controls.Add(this.label12);
            this.gpbCliente.Controls.Add(this.txtCorreoCliente);
            this.gpbCliente.Controls.Add(this.label11);
            this.gpbCliente.Controls.Add(this.txtNombresCliente);
            this.gpbCliente.Controls.Add(this.txtNroDocumentoIdentidadCliente);
            this.gpbCliente.Controls.Add(this.label10);
            this.gpbCliente.Controls.Add(this.cbbCodigoTipoDocumentoIdentidadCliente);
            this.gpbCliente.Controls.Add(this.label9);
            this.gpbCliente.Location = new System.Drawing.Point(8, 88);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(876, 113);
            this.gpbCliente.TabIndex = 1;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Datos del Cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(291, 32);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(57, 23);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblErrorCliente
            // 
            this.lblErrorCliente.AutoSize = true;
            this.lblErrorCliente.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCliente.Location = new System.Drawing.Point(3, 97);
            this.lblErrorCliente.Name = "lblErrorCliente";
            this.lblErrorCliente.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCliente.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(525, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Ubicación";
            // 
            // txtUbicacionCliente
            // 
            this.txtUbicacionCliente.Location = new System.Drawing.Point(528, 73);
            this.txtUbicacionCliente.Name = "txtUbicacionCliente";
            this.txtUbicacionCliente.ReadOnly = true;
            this.txtUbicacionCliente.Size = new System.Drawing.Size(342, 20);
            this.txtUbicacionCliente.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Dirección";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(6, 73);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(516, 20);
            this.txtDireccionCliente.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(699, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Correo Electrónico";
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Location = new System.Drawing.Point(702, 33);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.ReadOnly = true;
            this.txtCorreoCliente.Size = new System.Drawing.Size(168, 20);
            this.txtCorreoCliente.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(351, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Nombres";
            // 
            // txtNombresCliente
            // 
            this.txtNombresCliente.Location = new System.Drawing.Point(354, 33);
            this.txtNombresCliente.Name = "txtNombresCliente";
            this.txtNombresCliente.ReadOnly = true;
            this.txtNombresCliente.Size = new System.Drawing.Size(342, 20);
            this.txtNombresCliente.TabIndex = 3;
            // 
            // txtNroDocumentoIdentidadCliente
            // 
            this.txtNroDocumentoIdentidadCliente.Location = new System.Drawing.Point(180, 33);
            this.txtNroDocumentoIdentidadCliente.Name = "txtNroDocumentoIdentidadCliente";
            this.txtNroDocumentoIdentidadCliente.Size = new System.Drawing.Size(105, 20);
            this.txtNroDocumentoIdentidadCliente.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "N° Doc. Identidad";
            // 
            // cbbCodigoTipoDocumentoIdentidadCliente
            // 
            this.cbbCodigoTipoDocumentoIdentidadCliente.DisplayMember = "Descripcion";
            this.cbbCodigoTipoDocumentoIdentidadCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoTipoDocumentoIdentidadCliente.Enabled = false;
            this.cbbCodigoTipoDocumentoIdentidadCliente.FormattingEnabled = true;
            this.cbbCodigoTipoDocumentoIdentidadCliente.Location = new System.Drawing.Point(6, 33);
            this.cbbCodigoTipoDocumentoIdentidadCliente.Name = "cbbCodigoTipoDocumentoIdentidadCliente";
            this.cbbCodigoTipoDocumentoIdentidadCliente.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoTipoDocumentoIdentidadCliente.TabIndex = 0;
            this.cbbCodigoTipoDocumentoIdentidadCliente.ValueMember = "CodigoTipoDocumentoIdentidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tipo Doc. Identidad";
            // 
            // FrmMantenimientoComprobantePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 495);
            this.Controls.Add(this.gpbCliente);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMantenimientoComprobantePago";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMantenimientoComprobantePago";
            this.Load += new System.EventHandler(this.FrmMantenimientoComprobantePago_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblErrorDetalle;
        private System.Windows.Forms.Button btnEliminarDetalle;
        private System.Windows.Forms.Button btnModificarDetalle;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblErrorCodigoSerie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbCodigoSerie;
        private System.Windows.Forms.Label lblErrorFechaHoraPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroComprobante;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraPago;
        private System.Windows.Forms.Label lblErrorCodigoMoneda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbCodigoMoneda;
        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblErrorCliente;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUbicacionCliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombresCliente;
        private System.Windows.Forms.TextBox txtNroDocumentoIdentidadCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbCodigoTipoDocumentoIdentidadCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblErrorNroComprobante;
        private System.Windows.Forms.Label lblErrorSerie;
        private System.Windows.Forms.ToolTip tltComprobantePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_CodigoComprobantePagoDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_Fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_TipoDocumentoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_DocumentoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_Mora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_Protesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_ImportePagar;
    }
}