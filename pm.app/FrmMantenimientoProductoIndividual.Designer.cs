namespace pm.app
{
    partial class FrmMantenimientoProductoIndividual
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNroDocIdentidadPersonalInspeccion = new System.Windows.Forms.TextBox();
            this.txtNroDocIdentidadProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscarPersonalInspeccion = new System.Windows.Forms.Button();
            this.txtNombresPersonalInspeccion = new System.Windows.Forms.TextBox();
            this.lblErrorPersonalInspeccion = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.txtNombresProveedor = new System.Windows.Forms.TextBox();
            this.lblErrorProveedor = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblErrorCodigoBarra = new System.Windows.Forms.Label();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblErrorProducto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorFechaEntrada = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.cbbCodigoUnidadMedida = new System.Windows.Forms.ComboBox();
            this.lblErrorCodigoUnidadMedida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErrorColor = new System.Windows.Forms.Label();
            this.lblErrorRollo = new System.Windows.Forms.Label();
            this.lblErrorBulto = new System.Windows.Forms.Label();
            this.lblErrorPeso = new System.Windows.Forms.Label();
            this.lblErrorCodigoInicial = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBulto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRollo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoInicial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tltProductoIndividual = new System.Windows.Forms.ToolTip(this.components);
            this.lblErrorMetraje = new System.Windows.Forms.Label();
            this.txtMetraje = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblErrorCodigoBarraProveedor = new System.Windows.Forms.Label();
            this.txtCodigoBarraProveedor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(297, 518);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblErrorCodigoBarraProveedor);
            this.groupBox1.Controls.Add(this.txtCodigoBarraProveedor);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lblErrorMetraje);
            this.groupBox1.Controls.Add(this.txtMetraje);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblErrorPersonalInspeccion);
            this.groupBox1.Controls.Add(this.btnBuscarPersonalInspeccion);
            this.groupBox1.Controls.Add(this.txtNombresPersonalInspeccion);
            this.groupBox1.Controls.Add(this.txtNroDocIdentidadPersonalInspeccion);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblErrorProveedor);
            this.groupBox1.Controls.Add(this.btnBuscarProveedor);
            this.groupBox1.Controls.Add(this.txtNombresProveedor);
            this.groupBox1.Controls.Add(this.txtNroDocIdentidadProveedor);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblErrorFechaEntrada);
            this.groupBox1.Controls.Add(this.dtpFechaEntrada);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblErrorColor);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblErrorBulto);
            this.groupBox1.Controls.Add(this.txtBulto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblErrorRollo);
            this.groupBox1.Controls.Add(this.txtRollo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblErrorPeso);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblErrorCodigoInicial);
            this.groupBox1.Controls.Add(this.txtCodigoInicial);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblErrorCodigoUnidadMedida);
            this.groupBox1.Controls.Add(this.cbbCodigoUnidadMedida);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblErrorProducto);
            this.groupBox1.Controls.Add(this.btnBuscarProducto);
            this.groupBox1.Controls.Add(this.txtNombreProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblErrorNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblErrorCodigoBarra);
            this.groupBox1.Controls.Add(this.txtCodigoBarra);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 501);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // txtNroDocIdentidadPersonalInspeccion
            // 
            this.txtNroDocIdentidadPersonalInspeccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNroDocIdentidadPersonalInspeccion.Location = new System.Drawing.Point(9, 457);
            this.txtNroDocIdentidadPersonalInspeccion.Name = "txtNroDocIdentidadPersonalInspeccion";
            this.txtNroDocIdentidadPersonalInspeccion.Size = new System.Drawing.Size(55, 21);
            this.txtNroDocIdentidadPersonalInspeccion.TabIndex = 16;
            // 
            // txtNroDocIdentidadProveedor
            // 
            this.txtNroDocIdentidadProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNroDocIdentidadProveedor.Location = new System.Drawing.Point(9, 404);
            this.txtNroDocIdentidadProveedor.Name = "txtNroDocIdentidadProveedor";
            this.txtNroDocIdentidadProveedor.Size = new System.Drawing.Size(55, 21);
            this.txtNroDocIdentidadProveedor.TabIndex = 13;
            // 
            // btnBuscarPersonalInspeccion
            // 
            this.btnBuscarPersonalInspeccion.Location = new System.Drawing.Point(293, 455);
            this.btnBuscarPersonalInspeccion.Name = "btnBuscarPersonalInspeccion";
            this.btnBuscarPersonalInspeccion.Size = new System.Drawing.Size(58, 23);
            this.btnBuscarPersonalInspeccion.TabIndex = 18;
            this.btnBuscarPersonalInspeccion.Text = "Buscar";
            this.btnBuscarPersonalInspeccion.UseVisualStyleBackColor = true;
            this.btnBuscarPersonalInspeccion.Click += new System.EventHandler(this.btnBuscarPersonalInspeccion_Click);
            // 
            // txtNombresPersonalInspeccion
            // 
            this.txtNombresPersonalInspeccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombresPersonalInspeccion.Location = new System.Drawing.Point(70, 457);
            this.txtNombresPersonalInspeccion.Name = "txtNombresPersonalInspeccion";
            this.txtNombresPersonalInspeccion.ReadOnly = true;
            this.txtNombresPersonalInspeccion.Size = new System.Drawing.Size(217, 21);
            this.txtNombresPersonalInspeccion.TabIndex = 17;
            // 
            // lblErrorPersonalInspeccion
            // 
            this.lblErrorPersonalInspeccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorPersonalInspeccion.AutoSize = true;
            this.lblErrorPersonalInspeccion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPersonalInspeccion.Location = new System.Drawing.Point(6, 481);
            this.lblErrorPersonalInspeccion.Name = "lblErrorPersonalInspeccion";
            this.lblErrorPersonalInspeccion.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPersonalInspeccion.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 441);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "Personal Inspección";
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Location = new System.Drawing.Point(293, 402);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(58, 23);
            this.btnBuscarProveedor.TabIndex = 15;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // txtNombresProveedor
            // 
            this.txtNombresProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombresProveedor.Location = new System.Drawing.Point(70, 404);
            this.txtNombresProveedor.Name = "txtNombresProveedor";
            this.txtNombresProveedor.ReadOnly = true;
            this.txtNombresProveedor.Size = new System.Drawing.Size(217, 21);
            this.txtNombresProveedor.TabIndex = 14;
            // 
            // lblErrorProveedor
            // 
            this.lblErrorProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorProveedor.AutoSize = true;
            this.lblErrorProveedor.ForeColor = System.Drawing.Color.Red;
            this.lblErrorProveedor.Location = new System.Drawing.Point(6, 428);
            this.lblErrorProveedor.Name = "lblErrorProveedor";
            this.lblErrorProveedor.Size = new System.Drawing.Size(0, 13);
            this.lblErrorProveedor.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Proveedor";
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrada.Location = new System.Drawing.Point(183, 298);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(168, 21);
            this.dtpFechaEntrada.TabIndex = 11;
            // 
            // lblErrorCodigoBarra
            // 
            this.lblErrorCodigoBarra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCodigoBarra.AutoSize = true;
            this.lblErrorCodigoBarra.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoBarra.Location = new System.Drawing.Point(6, 57);
            this.lblErrorCodigoBarra.Name = "lblErrorCodigoBarra";
            this.lblErrorCodigoBarra.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoBarra.TabIndex = 47;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoBarra.Location = new System.Drawing.Point(9, 33);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(168, 21);
            this.txtCodigoBarra.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Código Barra";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(293, 84);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(58, 23);
            this.btnBuscarProducto.TabIndex = 3;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreProducto.Location = new System.Drawing.Point(9, 86);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.Size = new System.Drawing.Size(278, 21);
            this.txtNombreProducto.TabIndex = 2;
            // 
            // lblErrorProducto
            // 
            this.lblErrorProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorProducto.AutoSize = true;
            this.lblErrorProducto.ForeColor = System.Drawing.Color.Red;
            this.lblErrorProducto.Location = new System.Drawing.Point(6, 110);
            this.lblErrorProducto.Name = "lblErrorProducto";
            this.lblErrorProducto.Size = new System.Drawing.Size(0, 13);
            this.lblErrorProducto.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Producto";
            // 
            // lblErrorFechaEntrada
            // 
            this.lblErrorFechaEntrada.AutoSize = true;
            this.lblErrorFechaEntrada.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFechaEntrada.Location = new System.Drawing.Point(180, 322);
            this.lblErrorFechaEntrada.Name = "lblErrorFechaEntrada";
            this.lblErrorFechaEntrada.Size = new System.Drawing.Size(0, 13);
            this.lblErrorFechaEntrada.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(180, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Fecha Entrada";
            // 
            // txtPeso
            // 
            this.txtPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPeso.Location = new System.Drawing.Point(183, 192);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(168, 21);
            this.txtPeso.TabIndex = 7;
            // 
            // cbbCodigoUnidadMedida
            // 
            this.cbbCodigoUnidadMedida.DisplayMember = "Descripcion";
            this.cbbCodigoUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoUnidadMedida.FormattingEnabled = true;
            this.cbbCodigoUnidadMedida.Location = new System.Drawing.Point(9, 139);
            this.cbbCodigoUnidadMedida.Name = "cbbCodigoUnidadMedida";
            this.cbbCodigoUnidadMedida.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoUnidadMedida.TabIndex = 4;
            this.cbbCodigoUnidadMedida.ValueMember = "CodigoUnidadMedida";
            // 
            // lblErrorCodigoUnidadMedida
            // 
            this.lblErrorCodigoUnidadMedida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCodigoUnidadMedida.AutoSize = true;
            this.lblErrorCodigoUnidadMedida.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoUnidadMedida.Location = new System.Drawing.Point(6, 163);
            this.lblErrorCodigoUnidadMedida.Name = "lblErrorCodigoUnidadMedida";
            this.lblErrorCodigoUnidadMedida.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoUnidadMedida.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Unidad Medida";
            // 
            // lblErrorColor
            // 
            this.lblErrorColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorColor.AutoSize = true;
            this.lblErrorColor.ForeColor = System.Drawing.Color.Red;
            this.lblErrorColor.Location = new System.Drawing.Point(6, 322);
            this.lblErrorColor.Name = "lblErrorColor";
            this.lblErrorColor.Size = new System.Drawing.Size(0, 13);
            this.lblErrorColor.TabIndex = 26;
            // 
            // lblErrorRollo
            // 
            this.lblErrorRollo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorRollo.AutoSize = true;
            this.lblErrorRollo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRollo.Location = new System.Drawing.Point(6, 269);
            this.lblErrorRollo.Name = "lblErrorRollo";
            this.lblErrorRollo.Size = new System.Drawing.Size(0, 13);
            this.lblErrorRollo.TabIndex = 25;
            // 
            // lblErrorBulto
            // 
            this.lblErrorBulto.AutoSize = true;
            this.lblErrorBulto.ForeColor = System.Drawing.Color.Red;
            this.lblErrorBulto.Location = new System.Drawing.Point(180, 269);
            this.lblErrorBulto.Name = "lblErrorBulto";
            this.lblErrorBulto.Size = new System.Drawing.Size(0, 13);
            this.lblErrorBulto.TabIndex = 23;
            // 
            // lblErrorPeso
            // 
            this.lblErrorPeso.AutoSize = true;
            this.lblErrorPeso.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPeso.Location = new System.Drawing.Point(180, 216);
            this.lblErrorPeso.Name = "lblErrorPeso";
            this.lblErrorPeso.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPeso.TabIndex = 22;
            // 
            // lblErrorCodigoInicial
            // 
            this.lblErrorCodigoInicial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCodigoInicial.AutoSize = true;
            this.lblErrorCodigoInicial.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoInicial.Location = new System.Drawing.Point(180, 163);
            this.lblErrorCodigoInicial.Name = "lblErrorCodigoInicial";
            this.lblErrorCodigoInicial.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoInicial.TabIndex = 21;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(180, 57);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(0, 13);
            this.lblErrorNombre.TabIndex = 20;
            // 
            // txtColor
            // 
            this.txtColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtColor.Location = new System.Drawing.Point(9, 298);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(168, 21);
            this.txtColor.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Color";
            // 
            // txtBulto
            // 
            this.txtBulto.Location = new System.Drawing.Point(183, 245);
            this.txtBulto.Name = "txtBulto";
            this.txtBulto.Size = new System.Drawing.Size(168, 21);
            this.txtBulto.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Bulto";
            // 
            // txtRollo
            // 
            this.txtRollo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRollo.Location = new System.Drawing.Point(9, 245);
            this.txtRollo.Name = "txtRollo";
            this.txtRollo.Size = new System.Drawing.Size(168, 21);
            this.txtRollo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rollo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Peso";
            // 
            // txtCodigoInicial
            // 
            this.txtCodigoInicial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoInicial.Location = new System.Drawing.Point(183, 139);
            this.txtCodigoInicial.Name = "txtCodigoInicial";
            this.txtCodigoInicial.Size = new System.Drawing.Size(168, 21);
            this.txtCodigoInicial.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Código Inicial";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(183, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // lblErrorMetraje
            // 
            this.lblErrorMetraje.AutoSize = true;
            this.lblErrorMetraje.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMetraje.Location = new System.Drawing.Point(6, 216);
            this.lblErrorMetraje.Name = "lblErrorMetraje";
            this.lblErrorMetraje.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMetraje.TabIndex = 57;
            // 
            // txtMetraje
            // 
            this.txtMetraje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMetraje.Location = new System.Drawing.Point(9, 192);
            this.txtMetraje.Name = "txtMetraje";
            this.txtMetraje.Size = new System.Drawing.Size(168, 21);
            this.txtMetraje.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Metraje";
            // 
            // lblErrorCodigoBarraProveedor
            // 
            this.lblErrorCodigoBarraProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCodigoBarraProveedor.AutoSize = true;
            this.lblErrorCodigoBarraProveedor.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoBarraProveedor.Location = new System.Drawing.Point(6, 375);
            this.lblErrorCodigoBarraProveedor.Name = "lblErrorCodigoBarraProveedor";
            this.lblErrorCodigoBarraProveedor.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoBarraProveedor.TabIndex = 60;
            // 
            // txtCodigoBarraProveedor
            // 
            this.txtCodigoBarraProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoBarraProveedor.Location = new System.Drawing.Point(9, 351);
            this.txtCodigoBarraProveedor.Name = "txtCodigoBarraProveedor";
            this.txtCodigoBarraProveedor.Size = new System.Drawing.Size(168, 21);
            this.txtCodigoBarraProveedor.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 335);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 13);
            this.label15.TabIndex = 59;
            this.label15.Text = "Codigo Barra Proveedor";
            // 
            // FrmMantenimientoProductoIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 553);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.Name = "FrmMantenimientoProductoIndividual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMantenimientoProductoIndividual";
            this.Load += new System.EventHandler(this.FrmMantenimientoProductoIndividual_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblErrorFechaEntrada;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.ComboBox cbbCodigoUnidadMedida;
        private System.Windows.Forms.Label lblErrorCodigoUnidadMedida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErrorColor;
        private System.Windows.Forms.Label lblErrorRollo;
        private System.Windows.Forms.Label lblErrorBulto;
        private System.Windows.Forms.Label lblErrorPeso;
        private System.Windows.Forms.Label lblErrorCodigoInicial;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBulto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRollo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblErrorProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorCodigoBarra;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscarPersonalInspeccion;
        private System.Windows.Forms.TextBox txtNombresPersonalInspeccion;
        private System.Windows.Forms.Label lblErrorPersonalInspeccion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.TextBox txtNombresProveedor;
        private System.Windows.Forms.Label lblErrorProveedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private System.Windows.Forms.TextBox txtNroDocIdentidadPersonalInspeccion;
        private System.Windows.Forms.TextBox txtNroDocIdentidadProveedor;
        private System.Windows.Forms.ToolTip tltProductoIndividual;
        private System.Windows.Forms.Label lblErrorCodigoBarraProveedor;
        private System.Windows.Forms.TextBox txtCodigoBarraProveedor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblErrorMetraje;
        private System.Windows.Forms.TextBox txtMetraje;
        private System.Windows.Forms.Label label13;
    }
}