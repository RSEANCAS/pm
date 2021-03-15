namespace pm.app
{
    partial class FrmMantenimientoComprobanteCompra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSerieGuia = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblErrorNumeroGuia = new System.Windows.Forms.Label();
            this.lblErrorSerieGuia = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNumeroGuia = new System.Windows.Forms.TextBox();
            this.lblErrorCodigoTipoComprobante = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbCodigoTipoComprobante = new System.Windows.Forms.ComboBox();
            this.lblErrorFechaCompra = new System.Windows.Forms.Label();
            this.lblErrorNumero = new System.Windows.Forms.Label();
            this.lblErrorSerie = new System.Windows.Forms.Label();
            this.lblErrorFechaHoraRegistro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.dtpFechaHoraRegistro = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.lblErrorProveedor = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUbicacionProveedor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCorreoProveedor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombresProveedor = new System.Windows.Forms.TextBox();
            this.txtNroDocumentoIdentidadProveedor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbCodigoTipoDocumentoIdentidadProveedor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUnidades = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotalImporte = new System.Windows.Forms.TextBox();
            this.lblErrorDetalle = new System.Windows.Forms.Label();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.btnModificarDetalle = new System.Windows.Forms.Button();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.dgvDetalle_CodigoComprobanteCompraDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_Fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_ImporteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_FlagCompleto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tltComprobanteCompra = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSerieGuia);
            this.groupBox1.Controls.Add(this.txtSerie);
            this.groupBox1.Controls.Add(this.lblErrorNumeroGuia);
            this.groupBox1.Controls.Add(this.lblErrorSerieGuia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtNumeroGuia);
            this.groupBox1.Controls.Add(this.lblErrorCodigoTipoComprobante);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbCodigoTipoComprobante);
            this.groupBox1.Controls.Add(this.lblErrorFechaCompra);
            this.groupBox1.Controls.Add(this.lblErrorNumero);
            this.groupBox1.Controls.Add(this.lblErrorSerie);
            this.groupBox1.Controls.Add(this.lblErrorFechaHoraRegistro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaCompra);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.dtpFechaHoraRegistro);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Comprobante";
            // 
            // txtSerieGuia
            // 
            this.txtSerieGuia.Location = new System.Drawing.Point(6, 86);
            this.txtSerieGuia.Name = "txtSerieGuia";
            this.txtSerieGuia.Size = new System.Drawing.Size(168, 20);
            this.txtSerieGuia.TabIndex = 5;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(354, 33);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(168, 20);
            this.txtSerie.TabIndex = 2;
            // 
            // lblErrorNumeroGuia
            // 
            this.lblErrorNumeroGuia.AutoSize = true;
            this.lblErrorNumeroGuia.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNumeroGuia.Location = new System.Drawing.Point(177, 110);
            this.lblErrorNumeroGuia.Name = "lblErrorNumeroGuia";
            this.lblErrorNumeroGuia.Size = new System.Drawing.Size(0, 13);
            this.lblErrorNumeroGuia.TabIndex = 20;
            // 
            // lblErrorSerieGuia
            // 
            this.lblErrorSerieGuia.AutoSize = true;
            this.lblErrorSerieGuia.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSerieGuia.Location = new System.Drawing.Point(3, 110);
            this.lblErrorSerieGuia.Name = "lblErrorSerieGuia";
            this.lblErrorSerieGuia.Size = new System.Drawing.Size(0, 13);
            this.lblErrorSerieGuia.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "N° Comprobante Guía";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Serie Guía";
            // 
            // txtNumeroGuia
            // 
            this.txtNumeroGuia.Location = new System.Drawing.Point(180, 86);
            this.txtNumeroGuia.Name = "txtNumeroGuia";
            this.txtNumeroGuia.Size = new System.Drawing.Size(168, 20);
            this.txtNumeroGuia.TabIndex = 6;
            // 
            // lblErrorCodigoTipoComprobante
            // 
            this.lblErrorCodigoTipoComprobante.AutoSize = true;
            this.lblErrorCodigoTipoComprobante.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoTipoComprobante.Location = new System.Drawing.Point(177, 57);
            this.lblErrorCodigoTipoComprobante.Name = "lblErrorCodigoTipoComprobante";
            this.lblErrorCodigoTipoComprobante.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoTipoComprobante.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipo Comprobante";
            // 
            // cbbCodigoTipoComprobante
            // 
            this.cbbCodigoTipoComprobante.DisplayMember = "Nombre";
            this.cbbCodigoTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoTipoComprobante.FormattingEnabled = true;
            this.cbbCodigoTipoComprobante.Location = new System.Drawing.Point(180, 33);
            this.cbbCodigoTipoComprobante.Name = "cbbCodigoTipoComprobante";
            this.cbbCodigoTipoComprobante.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoTipoComprobante.TabIndex = 1;
            this.cbbCodigoTipoComprobante.ValueMember = "CodigoTipoComprobante";
            // 
            // lblErrorFechaCompra
            // 
            this.lblErrorFechaCompra.AutoSize = true;
            this.lblErrorFechaCompra.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFechaCompra.Location = new System.Drawing.Point(699, 57);
            this.lblErrorFechaCompra.Name = "lblErrorFechaCompra";
            this.lblErrorFechaCompra.Size = new System.Drawing.Size(0, 13);
            this.lblErrorFechaCompra.TabIndex = 11;
            // 
            // lblErrorNumero
            // 
            this.lblErrorNumero.AutoSize = true;
            this.lblErrorNumero.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNumero.Location = new System.Drawing.Point(525, 57);
            this.lblErrorNumero.Name = "lblErrorNumero";
            this.lblErrorNumero.Size = new System.Drawing.Size(0, 13);
            this.lblErrorNumero.TabIndex = 10;
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
            // lblErrorFechaHoraRegistro
            // 
            this.lblErrorFechaHoraRegistro.AutoSize = true;
            this.lblErrorFechaHoraRegistro.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFechaHoraRegistro.Location = new System.Drawing.Point(3, 57);
            this.lblErrorFechaHoraRegistro.Name = "lblErrorFechaHoraRegistro";
            this.lblErrorFechaHoraRegistro.Size = new System.Drawing.Size(0, 13);
            this.lblErrorFechaHoraRegistro.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(699, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "N° Comprobante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Serie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha y Hora de Registro";
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.CustomFormat = "";
            this.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCompra.Location = new System.Drawing.Point(702, 33);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(168, 20);
            this.dtpFechaCompra.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(528, 33);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(168, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // dtpFechaHoraRegistro
            // 
            this.dtpFechaHoraRegistro.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpFechaHoraRegistro.Enabled = false;
            this.dtpFechaHoraRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHoraRegistro.Location = new System.Drawing.Point(6, 33);
            this.dtpFechaHoraRegistro.Name = "dtpFechaHoraRegistro";
            this.dtpFechaHoraRegistro.Size = new System.Drawing.Size(168, 20);
            this.dtpFechaHoraRegistro.TabIndex = 0;
            this.dtpFechaHoraRegistro.ValueChanged += new System.EventHandler(this.dtpFechaHoraRegistro_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarProveedor);
            this.groupBox2.Controls.Add(this.lblErrorProveedor);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtUbicacionProveedor);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtDireccionProveedor);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtCorreoProveedor);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtNombresProveedor);
            this.groupBox2.Controls.Add(this.txtNroDocumentoIdentidadProveedor);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbbCodigoTipoDocumentoIdentidadProveedor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(8, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Proveedor";
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Location = new System.Drawing.Point(291, 32);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(57, 23);
            this.btnBuscarProveedor.TabIndex = 2;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // lblErrorProveedor
            // 
            this.lblErrorProveedor.AutoSize = true;
            this.lblErrorProveedor.ForeColor = System.Drawing.Color.Red;
            this.lblErrorProveedor.Location = new System.Drawing.Point(3, 97);
            this.lblErrorProveedor.Name = "lblErrorProveedor";
            this.lblErrorProveedor.Size = new System.Drawing.Size(0, 13);
            this.lblErrorProveedor.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(525, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Ubicación";
            // 
            // txtUbicacionProveedor
            // 
            this.txtUbicacionProveedor.Location = new System.Drawing.Point(528, 73);
            this.txtUbicacionProveedor.Name = "txtUbicacionProveedor";
            this.txtUbicacionProveedor.ReadOnly = true;
            this.txtUbicacionProveedor.Size = new System.Drawing.Size(342, 20);
            this.txtUbicacionProveedor.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Dirección";
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.Location = new System.Drawing.Point(6, 73);
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.ReadOnly = true;
            this.txtDireccionProveedor.Size = new System.Drawing.Size(516, 20);
            this.txtDireccionProveedor.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(699, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Correo Electrónico";
            // 
            // txtCorreoProveedor
            // 
            this.txtCorreoProveedor.Location = new System.Drawing.Point(702, 33);
            this.txtCorreoProveedor.Name = "txtCorreoProveedor";
            this.txtCorreoProveedor.ReadOnly = true;
            this.txtCorreoProveedor.Size = new System.Drawing.Size(168, 20);
            this.txtCorreoProveedor.TabIndex = 4;
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
            // txtNombresProveedor
            // 
            this.txtNombresProveedor.Location = new System.Drawing.Point(354, 33);
            this.txtNombresProveedor.Name = "txtNombresProveedor";
            this.txtNombresProveedor.ReadOnly = true;
            this.txtNombresProveedor.Size = new System.Drawing.Size(342, 20);
            this.txtNombresProveedor.TabIndex = 3;
            // 
            // txtNroDocumentoIdentidadProveedor
            // 
            this.txtNroDocumentoIdentidadProveedor.Location = new System.Drawing.Point(180, 33);
            this.txtNroDocumentoIdentidadProveedor.Name = "txtNroDocumentoIdentidadProveedor";
            this.txtNroDocumentoIdentidadProveedor.Size = new System.Drawing.Size(105, 20);
            this.txtNroDocumentoIdentidadProveedor.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "N° Doc. Identidad";
            // 
            // cbbCodigoTipoDocumentoIdentidadProveedor
            // 
            this.cbbCodigoTipoDocumentoIdentidadProveedor.DisplayMember = "Descripcion";
            this.cbbCodigoTipoDocumentoIdentidadProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoTipoDocumentoIdentidadProveedor.Enabled = false;
            this.cbbCodigoTipoDocumentoIdentidadProveedor.FormattingEnabled = true;
            this.cbbCodigoTipoDocumentoIdentidadProveedor.Location = new System.Drawing.Point(6, 33);
            this.cbbCodigoTipoDocumentoIdentidadProveedor.Name = "cbbCodigoTipoDocumentoIdentidadProveedor";
            this.cbbCodigoTipoDocumentoIdentidadProveedor.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoTipoDocumentoIdentidadProveedor.TabIndex = 0;
            this.cbbCodigoTipoDocumentoIdentidadProveedor.ValueMember = "CodigoTipoDocumentoIdentidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tipo Doc. Identidad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUnidades);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtTotalImporte);
            this.groupBox3.Controls.Add(this.lblErrorDetalle);
            this.groupBox3.Controls.Add(this.btnEliminarDetalle);
            this.groupBox3.Controls.Add(this.btnModificarDetalle);
            this.groupBox3.Controls.Add(this.btnAgregarDetalle);
            this.groupBox3.Controls.Add(this.dgvDetalle);
            this.groupBox3.Location = new System.Drawing.Point(8, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(876, 247);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle del Comprobante";
            // 
            // btnUnidades
            // 
            this.btnUnidades.Location = new System.Drawing.Point(795, 107);
            this.btnUnidades.Name = "btnUnidades";
            this.btnUnidades.Size = new System.Drawing.Size(75, 23);
            this.btnUnidades.TabIndex = 4;
            this.btnUnidades.Text = "Unidades";
            this.btnUnidades.UseVisualStyleBackColor = true;
            this.btnUnidades.Click += new System.EventHandler(this.btnUnidades_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(699, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Importe Total";
            // 
            // txtTotalImporte
            // 
            this.txtTotalImporte.Location = new System.Drawing.Point(702, 220);
            this.txtTotalImporte.Name = "txtTotalImporte";
            this.txtTotalImporte.ReadOnly = true;
            this.txtTotalImporte.Size = new System.Drawing.Size(168, 20);
            this.txtTotalImporte.TabIndex = 5;
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
            this.dgvDetalle_CodigoComprobanteCompraDetalle,
            this.dgvDetalle_Fila,
            this.dgvDetalle_Producto,
            this.dgvDetalle_Cantidad,
            this.dgvDetalle_PrecioUnitario,
            this.dgvDetalle_ImporteTotal,
            this.dgvDetalle_FlagCompleto});
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
            // dgvDetalle_CodigoComprobanteCompraDetalle
            // 
            this.dgvDetalle_CodigoComprobanteCompraDetalle.DataPropertyName = "CodigoComprobanteCompraDetalle";
            this.dgvDetalle_CodigoComprobanteCompraDetalle.HeaderText = "CodigoComprobanteCompraDetalle";
            this.dgvDetalle_CodigoComprobanteCompraDetalle.Name = "dgvDetalle_CodigoComprobanteCompraDetalle";
            this.dgvDetalle_CodigoComprobanteCompraDetalle.ReadOnly = true;
            this.dgvDetalle_CodigoComprobanteCompraDetalle.Visible = false;
            // 
            // dgvDetalle_Fila
            // 
            this.dgvDetalle_Fila.DataPropertyName = "Fila";
            this.dgvDetalle_Fila.HeaderText = "N°";
            this.dgvDetalle_Fila.Name = "dgvDetalle_Fila";
            this.dgvDetalle_Fila.ReadOnly = true;
            this.dgvDetalle_Fila.Width = 30;
            // 
            // dgvDetalle_Producto
            // 
            this.dgvDetalle_Producto.DataPropertyName = "Detalle";
            this.dgvDetalle_Producto.HeaderText = "Producto";
            this.dgvDetalle_Producto.Name = "dgvDetalle_Producto";
            this.dgvDetalle_Producto.ReadOnly = true;
            this.dgvDetalle_Producto.Width = 200;
            // 
            // dgvDetalle_Cantidad
            // 
            this.dgvDetalle_Cantidad.DataPropertyName = "Cantidad";
            this.dgvDetalle_Cantidad.HeaderText = "Cantidad";
            this.dgvDetalle_Cantidad.Name = "dgvDetalle_Cantidad";
            this.dgvDetalle_Cantidad.ReadOnly = true;
            this.dgvDetalle_Cantidad.Width = 150;
            // 
            // dgvDetalle_PrecioUnitario
            // 
            this.dgvDetalle_PrecioUnitario.DataPropertyName = "PrecioUnitario";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "#,##0.00";
            this.dgvDetalle_PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle_PrecioUnitario.HeaderText = "Precio Unit.";
            this.dgvDetalle_PrecioUnitario.Name = "dgvDetalle_PrecioUnitario";
            this.dgvDetalle_PrecioUnitario.ReadOnly = true;
            this.dgvDetalle_PrecioUnitario.Width = 150;
            // 
            // dgvDetalle_ImporteTotal
            // 
            this.dgvDetalle_ImporteTotal.DataPropertyName = "ImporteTotal";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "#,##0.00";
            this.dgvDetalle_ImporteTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalle_ImporteTotal.HeaderText = "Importe Total";
            this.dgvDetalle_ImporteTotal.Name = "dgvDetalle_ImporteTotal";
            this.dgvDetalle_ImporteTotal.ReadOnly = true;
            this.dgvDetalle_ImporteTotal.Width = 150;
            // 
            // dgvDetalle_FlagCompleto
            // 
            this.dgvDetalle_FlagCompleto.DataPropertyName = "FlagCompleto";
            this.dgvDetalle_FlagCompleto.HeaderText = "¿Está completo?";
            this.dgvDetalle_FlagCompleto.Name = "dgvDetalle_FlagCompleto";
            this.dgvDetalle_FlagCompleto.ReadOnly = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(809, 517);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmMantenimientoComprobanteCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 549);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMantenimientoComprobanteCompra";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMantenimientoComprobanteCompra";
            this.Load += new System.EventHandler(this.FrmMantenimientoComprobanteCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblErrorCodigoTipoComprobante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbCodigoTipoComprobante;
        private System.Windows.Forms.Label lblErrorFechaCompra;
        private System.Windows.Forms.Label lblErrorNumero;
        private System.Windows.Forms.Label lblErrorSerie;
        private System.Windows.Forms.Label lblErrorFechaHoraRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraRegistro;
        private System.Windows.Forms.Label lblErrorNumeroGuia;
        private System.Windows.Forms.Label lblErrorSerieGuia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNumeroGuia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.Label lblErrorProveedor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUbicacionProveedor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDireccionProveedor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCorreoProveedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombresProveedor;
        private System.Windows.Forms.TextBox txtNroDocumentoIdentidadProveedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbCodigoTipoDocumentoIdentidadProveedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotalImporte;
        private System.Windows.Forms.Label lblErrorDetalle;
        private System.Windows.Forms.Button btnEliminarDetalle;
        private System.Windows.Forms.Button btnModificarDetalle;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtSerieGuia;
        private System.Windows.Forms.ToolTip tltComprobanteCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_CodigoComprobanteCompraDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_Fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_ImporteTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvDetalle_FlagCompleto;
        private System.Windows.Forms.Button btnUnidades;
    }
}