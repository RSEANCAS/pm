namespace pm.app
{
    partial class FrmMantenimientoFacturaVentaDetalle
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
            this.tltFacturaVentaDetalle = new System.Windows.Forms.ToolTip(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoBarraProductoIndividual = new System.Windows.Forms.TextBox();
            this.rdbDescuento = new System.Windows.Forms.RadioButton();
            this.rdbPorcentajeDescuento = new System.Windows.Forms.RadioButton();
            this.lblErrorIgv = new System.Windows.Forms.Label();
            this.txtIgv = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblErrorImporteTotal = new System.Windows.Forms.Label();
            this.txtImporteTotal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblErrorPorcentajeDescuento = new System.Windows.Forms.Label();
            this.txtPorcentajeDescuento = new System.Windows.Forms.TextBox();
            this.lblErrorDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblErrorValorUnitario = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblErrorPrecioUnitario = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbTipoCalculoTotalImporte = new System.Windows.Forms.RadioButton();
            this.rdbTipoCalculoPrecioUnitario = new System.Windows.Forms.RadioButton();
            this.rdbTipoCalculoValoUnitario = new System.Windows.Forms.RadioButton();
            this.cbbCodigoUnidadMedida = new System.Windows.Forms.ComboBox();
            this.lblErrorUnidadMedida = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblErrorCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblErrorProductoIndividual = new System.Windows.Forms.Label();
            this.btnBuscarProductoIndividual = new System.Windows.Forms.Button();
            this.txtNombreProductoIndividual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblErrorProducto = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(297, 413);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigoBarraProductoIndividual);
            this.groupBox1.Controls.Add(this.rdbDescuento);
            this.groupBox1.Controls.Add(this.rdbPorcentajeDescuento);
            this.groupBox1.Controls.Add(this.lblErrorIgv);
            this.groupBox1.Controls.Add(this.txtIgv);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lblErrorImporteTotal);
            this.groupBox1.Controls.Add(this.txtImporteTotal);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lblErrorPorcentajeDescuento);
            this.groupBox1.Controls.Add(this.txtPorcentajeDescuento);
            this.groupBox1.Controls.Add(this.lblErrorDescuento);
            this.groupBox1.Controls.Add(this.txtDescuento);
            this.groupBox1.Controls.Add(this.lblErrorValorUnitario);
            this.groupBox1.Controls.Add(this.txtValorUnitario);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblErrorPrecioUnitario);
            this.groupBox1.Controls.Add(this.txtPrecioUnitario);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cbbCodigoUnidadMedida);
            this.groupBox1.Controls.Add(this.lblErrorUnidadMedida);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblErrorCantidad);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblErrorProductoIndividual);
            this.groupBox1.Controls.Add(this.btnBuscarProductoIndividual);
            this.groupBox1.Controls.Add(this.txtNombreProductoIndividual);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblErrorProducto);
            this.groupBox1.Controls.Add(this.btnBuscarProducto);
            this.groupBox1.Controls.Add(this.txtNombreProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Detalle";
            // 
            // txtCodigoBarraProductoIndividual
            // 
            this.txtCodigoBarraProductoIndividual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoBarraProductoIndividual.Location = new System.Drawing.Point(11, 86);
            this.txtCodigoBarraProductoIndividual.Name = "txtCodigoBarraProductoIndividual";
            this.txtCodigoBarraProductoIndividual.Size = new System.Drawing.Size(55, 20);
            this.txtCodigoBarraProductoIndividual.TabIndex = 2;
            // 
            // rdbDescuento
            // 
            this.rdbDescuento.AutoSize = true;
            this.rdbDescuento.Enabled = false;
            this.rdbDescuento.Location = new System.Drawing.Point(185, 279);
            this.rdbDescuento.Name = "rdbDescuento";
            this.rdbDescuento.Size = new System.Drawing.Size(78, 17);
            this.rdbDescuento.TabIndex = 10;
            this.rdbDescuento.Text = "Descuento";
            this.rdbDescuento.UseVisualStyleBackColor = true;
            this.rdbDescuento.CheckedChanged += new System.EventHandler(this.rdbDescuento_CheckedChanged);
            // 
            // rdbPorcentajeDescuento
            // 
            this.rdbPorcentajeDescuento.AutoSize = true;
            this.rdbPorcentajeDescuento.Checked = true;
            this.rdbPorcentajeDescuento.Location = new System.Drawing.Point(12, 279);
            this.rdbPorcentajeDescuento.Name = "rdbPorcentajeDescuento";
            this.rdbPorcentajeDescuento.Size = new System.Drawing.Size(135, 17);
            this.rdbPorcentajeDescuento.TabIndex = 10;
            this.rdbPorcentajeDescuento.TabStop = true;
            this.rdbPorcentajeDescuento.Text = "Porcentaje Descuento";
            this.rdbPorcentajeDescuento.UseVisualStyleBackColor = true;
            this.rdbPorcentajeDescuento.CheckedChanged += new System.EventHandler(this.rdbPorcentajeDescuento_CheckedChanged);
            // 
            // lblErrorIgv
            // 
            this.lblErrorIgv.AutoSize = true;
            this.lblErrorIgv.ForeColor = System.Drawing.Color.Red;
            this.lblErrorIgv.Location = new System.Drawing.Point(8, 374);
            this.lblErrorIgv.Name = "lblErrorIgv";
            this.lblErrorIgv.Size = new System.Drawing.Size(0, 13);
            this.lblErrorIgv.TabIndex = 83;
            // 
            // txtIgv
            // 
            this.txtIgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIgv.Location = new System.Drawing.Point(11, 350);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.ReadOnly = true;
            this.txtIgv.Size = new System.Drawing.Size(168, 20);
            this.txtIgv.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 334);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 82;
            this.label15.Text = "Igv";
            // 
            // lblErrorImporteTotal
            // 
            this.lblErrorImporteTotal.AutoSize = true;
            this.lblErrorImporteTotal.ForeColor = System.Drawing.Color.Red;
            this.lblErrorImporteTotal.Location = new System.Drawing.Point(182, 374);
            this.lblErrorImporteTotal.Name = "lblErrorImporteTotal";
            this.lblErrorImporteTotal.Size = new System.Drawing.Size(0, 13);
            this.lblErrorImporteTotal.TabIndex = 81;
            // 
            // txtImporteTotal
            // 
            this.txtImporteTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImporteTotal.Location = new System.Drawing.Point(185, 350);
            this.txtImporteTotal.Name = "txtImporteTotal";
            this.txtImporteTotal.ReadOnly = true;
            this.txtImporteTotal.Size = new System.Drawing.Size(168, 20);
            this.txtImporteTotal.TabIndex = 14;
            this.txtImporteTotal.Validated += new System.EventHandler(this.txtImporteTotal_Validated);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(182, 334);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 80;
            this.label17.Text = "Importe Total";
            // 
            // lblErrorPorcentajeDescuento
            // 
            this.lblErrorPorcentajeDescuento.AutoSize = true;
            this.lblErrorPorcentajeDescuento.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPorcentajeDescuento.Location = new System.Drawing.Point(8, 321);
            this.lblErrorPorcentajeDescuento.Name = "lblErrorPorcentajeDescuento";
            this.lblErrorPorcentajeDescuento.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPorcentajeDescuento.TabIndex = 77;
            // 
            // txtPorcentajeDescuento
            // 
            this.txtPorcentajeDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPorcentajeDescuento.Location = new System.Drawing.Point(11, 297);
            this.txtPorcentajeDescuento.Name = "txtPorcentajeDescuento";
            this.txtPorcentajeDescuento.Size = new System.Drawing.Size(168, 20);
            this.txtPorcentajeDescuento.TabIndex = 11;
            this.txtPorcentajeDescuento.Validated += new System.EventHandler(this.txtPorcentajeDescuento_Validated);
            // 
            // lblErrorDescuento
            // 
            this.lblErrorDescuento.AutoSize = true;
            this.lblErrorDescuento.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDescuento.Location = new System.Drawing.Point(182, 321);
            this.lblErrorDescuento.Name = "lblErrorDescuento";
            this.lblErrorDescuento.Size = new System.Drawing.Size(0, 13);
            this.lblErrorDescuento.TabIndex = 75;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescuento.Location = new System.Drawing.Point(185, 297);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(168, 20);
            this.txtDescuento.TabIndex = 12;
            this.txtDescuento.Validated += new System.EventHandler(this.txtDescuento_Validated);
            // 
            // lblErrorValorUnitario
            // 
            this.lblErrorValorUnitario.AutoSize = true;
            this.lblErrorValorUnitario.ForeColor = System.Drawing.Color.Red;
            this.lblErrorValorUnitario.Location = new System.Drawing.Point(8, 268);
            this.lblErrorValorUnitario.Name = "lblErrorValorUnitario";
            this.lblErrorValorUnitario.Size = new System.Drawing.Size(0, 13);
            this.lblErrorValorUnitario.TabIndex = 71;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorUnitario.Location = new System.Drawing.Point(11, 244);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(168, 20);
            this.txtValorUnitario.TabIndex = 8;
            this.txtValorUnitario.Validated += new System.EventHandler(this.txtValorUnitario_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Valor Unitario";
            // 
            // lblErrorPrecioUnitario
            // 
            this.lblErrorPrecioUnitario.AutoSize = true;
            this.lblErrorPrecioUnitario.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrecioUnitario.Location = new System.Drawing.Point(182, 268);
            this.lblErrorPrecioUnitario.Name = "lblErrorPrecioUnitario";
            this.lblErrorPrecioUnitario.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPrecioUnitario.TabIndex = 69;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(185, 244);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(168, 20);
            this.txtPrecioUnitario.TabIndex = 9;
            this.txtPrecioUnitario.Validated += new System.EventHandler(this.txtPrecioUnitario_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Precio Unitario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbTipoCalculoTotalImporte);
            this.groupBox2.Controls.Add(this.rdbTipoCalculoPrecioUnitario);
            this.groupBox2.Controls.Add(this.rdbTipoCalculoValoUnitario);
            this.groupBox2.Location = new System.Drawing.Point(6, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 46);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de cálculo";
            // 
            // rdbTipoCalculoTotalImporte
            // 
            this.rdbTipoCalculoTotalImporte.AutoSize = true;
            this.rdbTipoCalculoTotalImporte.Enabled = false;
            this.rdbTipoCalculoTotalImporte.Location = new System.Drawing.Point(210, 20);
            this.rdbTipoCalculoTotalImporte.Name = "rdbTipoCalculoTotalImporte";
            this.rdbTipoCalculoTotalImporte.Size = new System.Drawing.Size(92, 17);
            this.rdbTipoCalculoTotalImporte.TabIndex = 2;
            this.rdbTipoCalculoTotalImporte.Text = "Importe Total";
            this.rdbTipoCalculoTotalImporte.UseVisualStyleBackColor = true;
            this.rdbTipoCalculoTotalImporte.CheckedChanged += new System.EventHandler(this.rdbTipoCalculoTotalImporte_CheckedChanged);
            // 
            // rdbTipoCalculoPrecioUnitario
            // 
            this.rdbTipoCalculoPrecioUnitario.AutoSize = true;
            this.rdbTipoCalculoPrecioUnitario.Location = new System.Drawing.Point(105, 20);
            this.rdbTipoCalculoPrecioUnitario.Name = "rdbTipoCalculoPrecioUnitario";
            this.rdbTipoCalculoPrecioUnitario.Size = new System.Drawing.Size(99, 17);
            this.rdbTipoCalculoPrecioUnitario.TabIndex = 1;
            this.rdbTipoCalculoPrecioUnitario.Text = "Precio Unitario";
            this.rdbTipoCalculoPrecioUnitario.UseVisualStyleBackColor = true;
            this.rdbTipoCalculoPrecioUnitario.CheckedChanged += new System.EventHandler(this.rdbTipoCalculoPrecioUnitario_CheckedChanged);
            // 
            // rdbTipoCalculoValoUnitario
            // 
            this.rdbTipoCalculoValoUnitario.AutoSize = true;
            this.rdbTipoCalculoValoUnitario.Checked = true;
            this.rdbTipoCalculoValoUnitario.Location = new System.Drawing.Point(6, 20);
            this.rdbTipoCalculoValoUnitario.Name = "rdbTipoCalculoValoUnitario";
            this.rdbTipoCalculoValoUnitario.Size = new System.Drawing.Size(93, 17);
            this.rdbTipoCalculoValoUnitario.TabIndex = 0;
            this.rdbTipoCalculoValoUnitario.TabStop = true;
            this.rdbTipoCalculoValoUnitario.Text = "Valor Unitario";
            this.rdbTipoCalculoValoUnitario.UseVisualStyleBackColor = true;
            this.rdbTipoCalculoValoUnitario.CheckedChanged += new System.EventHandler(this.rdbTipoCalculoValoUnitario_CheckedChanged);
            // 
            // cbbCodigoUnidadMedida
            // 
            this.cbbCodigoUnidadMedida.DisplayMember = "Descripcion";
            this.cbbCodigoUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoUnidadMedida.Enabled = false;
            this.cbbCodigoUnidadMedida.FormattingEnabled = true;
            this.cbbCodigoUnidadMedida.Location = new System.Drawing.Point(9, 139);
            this.cbbCodigoUnidadMedida.Name = "cbbCodigoUnidadMedida";
            this.cbbCodigoUnidadMedida.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoUnidadMedida.TabIndex = 5;
            this.cbbCodigoUnidadMedida.ValueMember = "CodigoUnidadMedida";
            // 
            // lblErrorUnidadMedida
            // 
            this.lblErrorUnidadMedida.AutoSize = true;
            this.lblErrorUnidadMedida.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUnidadMedida.Location = new System.Drawing.Point(6, 163);
            this.lblErrorUnidadMedida.Name = "lblErrorUnidadMedida";
            this.lblErrorUnidadMedida.Size = new System.Drawing.Size(0, 13);
            this.lblErrorUnidadMedida.TabIndex = 63;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 62;
            this.label13.Text = "Unidad Medida";
            // 
            // lblErrorCantidad
            // 
            this.lblErrorCantidad.AutoSize = true;
            this.lblErrorCantidad.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCantidad.Location = new System.Drawing.Point(180, 163);
            this.lblErrorCantidad.Name = "lblErrorCantidad";
            this.lblErrorCantidad.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCantidad.TabIndex = 61;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.Location = new System.Drawing.Point(183, 139);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(168, 20);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.Validated += new System.EventHandler(this.txtCantidad_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Cantidad";
            // 
            // lblErrorProductoIndividual
            // 
            this.lblErrorProductoIndividual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorProductoIndividual.AutoSize = true;
            this.lblErrorProductoIndividual.ForeColor = System.Drawing.Color.Red;
            this.lblErrorProductoIndividual.Location = new System.Drawing.Point(6, 110);
            this.lblErrorProductoIndividual.Name = "lblErrorProductoIndividual";
            this.lblErrorProductoIndividual.Size = new System.Drawing.Size(0, 13);
            this.lblErrorProductoIndividual.TabIndex = 50;
            // 
            // btnBuscarProductoIndividual
            // 
            this.btnBuscarProductoIndividual.Location = new System.Drawing.Point(295, 84);
            this.btnBuscarProductoIndividual.Name = "btnBuscarProductoIndividual";
            this.btnBuscarProductoIndividual.Size = new System.Drawing.Size(58, 23);
            this.btnBuscarProductoIndividual.TabIndex = 4;
            this.btnBuscarProductoIndividual.Text = "Buscar";
            this.btnBuscarProductoIndividual.UseVisualStyleBackColor = true;
            this.btnBuscarProductoIndividual.Click += new System.EventHandler(this.btnBuscarProductoIndividual_Click);
            // 
            // txtNombreProductoIndividual
            // 
            this.txtNombreProductoIndividual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreProductoIndividual.Location = new System.Drawing.Point(70, 86);
            this.txtNombreProductoIndividual.Name = "txtNombreProductoIndividual";
            this.txtNombreProductoIndividual.ReadOnly = true;
            this.txtNombreProductoIndividual.Size = new System.Drawing.Size(221, 20);
            this.txtNombreProductoIndividual.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Producto Individual";
            // 
            // lblErrorProducto
            // 
            this.lblErrorProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorProducto.AutoSize = true;
            this.lblErrorProducto.ForeColor = System.Drawing.Color.Red;
            this.lblErrorProducto.Location = new System.Drawing.Point(6, 57);
            this.lblErrorProducto.Name = "lblErrorProducto";
            this.lblErrorProducto.Size = new System.Drawing.Size(0, 13);
            this.lblErrorProducto.TabIndex = 46;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(295, 31);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(58, 23);
            this.btnBuscarProducto.TabIndex = 1;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreProducto.Location = new System.Drawing.Point(11, 33);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.Size = new System.Drawing.Size(280, 20);
            this.txtNombreProducto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Producto";
            // 
            // FrmMantenimientoFacturaVentaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 448);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMantenimientoFacturaVentaDetalle";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMantenimientoFacturaVentaDetalle";
            this.Load += new System.EventHandler(this.FrmMantenimientoFacturaVentaDetalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip tltFacturaVentaDetalle;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigoBarraProductoIndividual;
        private System.Windows.Forms.RadioButton rdbDescuento;
        private System.Windows.Forms.RadioButton rdbPorcentajeDescuento;
        private System.Windows.Forms.Label lblErrorIgv;
        private System.Windows.Forms.TextBox txtIgv;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblErrorImporteTotal;
        private System.Windows.Forms.TextBox txtImporteTotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblErrorPorcentajeDescuento;
        private System.Windows.Forms.TextBox txtPorcentajeDescuento;
        private System.Windows.Forms.Label lblErrorDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblErrorValorUnitario;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblErrorPrecioUnitario;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbTipoCalculoTotalImporte;
        private System.Windows.Forms.RadioButton rdbTipoCalculoPrecioUnitario;
        private System.Windows.Forms.RadioButton rdbTipoCalculoValoUnitario;
        private System.Windows.Forms.ComboBox cbbCodigoUnidadMedida;
        private System.Windows.Forms.Label lblErrorUnidadMedida;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblErrorCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblErrorProductoIndividual;
        private System.Windows.Forms.Button btnBuscarProductoIndividual;
        private System.Windows.Forms.TextBox txtNombreProductoIndividual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblErrorProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label1;
    }
}