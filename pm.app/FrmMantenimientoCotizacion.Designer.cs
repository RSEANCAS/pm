﻿namespace pm.app
{
    partial class FrmMantenimientoCotizacion
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalImporte = new System.Windows.Forms.TextBox();
            this.lblErrorDetalle = new System.Windows.Forms.Label();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.btnModificarDetalle = new System.Windows.Forms.Button();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.dgvDetalle_CodigoCotizacionDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_Fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_ProductoIndividual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_TotalImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblErrorNroPedido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNroPedido = new System.Windows.Forms.TextBox();
            this.lblErrorCodigoMoneda = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbbCodigoMoneda = new System.Windows.Forms.ComboBox();
            this.lblErrorNroComprobante = new System.Windows.Forms.Label();
            this.lblErrorFechaHoraEmision = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroComprobante = new System.Windows.Forms.TextBox();
            this.dtpFechaHoraEmision = new System.Windows.Forms.DateTimePicker();
            this.tltCotizacion = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscarVendedor = new System.Windows.Forms.Button();
            this.lblErrorVendedor = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCorreoVendedor = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNombresVendedor = new System.Windows.Forms.TextBox();
            this.txtNroDocumentoIdentidadVendedor = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbbCodigoTipoDocumentoIdentidadVendedor = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.gpbSupervisor = new System.Windows.Forms.GroupBox();
            this.btnBuscarSupervisor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreoSupervisor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombresSupervisor = new System.Windows.Forms.TextBox();
            this.txtNroDocumentoIdentidadSupervisor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbCodigoTipoDocumentoIdentidadSupervisor = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.chkTieneSupervisor = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gpbSupervisor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(805, 560);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtTotalImporte);
            this.groupBox3.Controls.Add(this.lblErrorDetalle);
            this.groupBox3.Controls.Add(this.btnEliminarDetalle);
            this.groupBox3.Controls.Add(this.btnModificarDetalle);
            this.groupBox3.Controls.Add(this.btnAgregarDetalle);
            this.groupBox3.Controls.Add(this.dgvDetalle);
            this.groupBox3.Location = new System.Drawing.Point(8, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(876, 193);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle del Comprobante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(699, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Importe Total";
            // 
            // txtTotalImporte
            // 
            this.txtTotalImporte.Location = new System.Drawing.Point(702, 167);
            this.txtTotalImporte.Name = "txtTotalImporte";
            this.txtTotalImporte.ReadOnly = true;
            this.txtTotalImporte.Size = new System.Drawing.Size(168, 20);
            this.txtTotalImporte.TabIndex = 4;
            // 
            // lblErrorDetalle
            // 
            this.lblErrorDetalle.AutoSize = true;
            this.lblErrorDetalle.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDetalle.Location = new System.Drawing.Point(3, 151);
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
            this.dgvDetalle_CodigoCotizacionDetalle,
            this.dgvDetalle_Fila,
            this.dgvDetalle_Producto,
            this.dgvDetalle_ProductoIndividual,
            this.dgvDetalle_Cantidad,
            this.dgvDetalle_PrecioUnitario,
            this.dgvDetalle_TotalImporte});
            this.dgvDetalle.Location = new System.Drawing.Point(6, 20);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(783, 128);
            this.dgvDetalle.TabIndex = 0;
            this.dgvDetalle.SelectionChanged += new System.EventHandler(this.dgvDetalle_SelectionChanged);
            // 
            // dgvDetalle_CodigoCotizacionDetalle
            // 
            this.dgvDetalle_CodigoCotizacionDetalle.DataPropertyName = "CodigoCotizacionDetalle";
            this.dgvDetalle_CodigoCotizacionDetalle.HeaderText = "CodigoCotizacionDetalle";
            this.dgvDetalle_CodigoCotizacionDetalle.Name = "dgvDetalle_CodigoCotizacionDetalle";
            this.dgvDetalle_CodigoCotizacionDetalle.ReadOnly = true;
            this.dgvDetalle_CodigoCotizacionDetalle.Visible = false;
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
            this.dgvDetalle_Producto.DataPropertyName = "Producto";
            this.dgvDetalle_Producto.HeaderText = "Producto";
            this.dgvDetalle_Producto.Name = "dgvDetalle_Producto";
            this.dgvDetalle_Producto.ReadOnly = true;
            this.dgvDetalle_Producto.Width = 150;
            // 
            // dgvDetalle_ProductoIndividual
            // 
            this.dgvDetalle_ProductoIndividual.DataPropertyName = "ProductoIndividual";
            this.dgvDetalle_ProductoIndividual.HeaderText = "Producto Individual";
            this.dgvDetalle_ProductoIndividual.Name = "dgvDetalle_ProductoIndividual";
            this.dgvDetalle_ProductoIndividual.ReadOnly = true;
            this.dgvDetalle_ProductoIndividual.Width = 200;
            // 
            // dgvDetalle_Cantidad
            // 
            this.dgvDetalle_Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "#,##0.00";
            this.dgvDetalle_Cantidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle_Cantidad.HeaderText = "Cantidad";
            this.dgvDetalle_Cantidad.Name = "dgvDetalle_Cantidad";
            this.dgvDetalle_Cantidad.ReadOnly = true;
            this.dgvDetalle_Cantidad.Width = 70;
            // 
            // dgvDetalle_PrecioUnitario
            // 
            this.dgvDetalle_PrecioUnitario.DataPropertyName = "PrecioUnitario";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "#,##0.00";
            this.dgvDetalle_PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalle_PrecioUnitario.HeaderText = "P. Unit.";
            this.dgvDetalle_PrecioUnitario.Name = "dgvDetalle_PrecioUnitario";
            this.dgvDetalle_PrecioUnitario.ReadOnly = true;
            this.dgvDetalle_PrecioUnitario.Width = 70;
            // 
            // dgvDetalle_TotalImporte
            // 
            this.dgvDetalle_TotalImporte.DataPropertyName = "Importe";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,##0.00";
            this.dgvDetalle_TotalImporte.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalle_TotalImporte.HeaderText = "Importe Total";
            this.dgvDetalle_TotalImporte.Name = "dgvDetalle_TotalImporte";
            this.dgvDetalle_TotalImporte.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.Controls.Add(this.lblErrorCliente);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtUbicacionCliente);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtDireccionCliente);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtCorreoCliente);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtNombresCliente);
            this.groupBox2.Controls.Add(this.txtNroDocumentoIdentidadCliente);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbbCodigoTipoDocumentoIdentidadCliente);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(8, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cliente";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblErrorNroPedido);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNroPedido);
            this.groupBox1.Controls.Add(this.lblErrorCodigoMoneda);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cbbCodigoMoneda);
            this.groupBox1.Controls.Add(this.lblErrorNroComprobante);
            this.groupBox1.Controls.Add(this.lblErrorFechaHoraEmision);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNroComprobante);
            this.groupBox1.Controls.Add(this.dtpFechaHoraEmision);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Comprobante";
            // 
            // lblErrorNroPedido
            // 
            this.lblErrorNroPedido.AutoSize = true;
            this.lblErrorNroPedido.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNroPedido.Location = new System.Drawing.Point(351, 57);
            this.lblErrorNroPedido.Name = "lblErrorNroPedido";
            this.lblErrorNroPedido.Size = new System.Drawing.Size(0, 13);
            this.lblErrorNroPedido.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "N° Pedido";
            // 
            // txtNroPedido
            // 
            this.txtNroPedido.Location = new System.Drawing.Point(354, 33);
            this.txtNroPedido.Name = "txtNroPedido";
            this.txtNroPedido.Size = new System.Drawing.Size(168, 20);
            this.txtNroPedido.TabIndex = 2;
            // 
            // lblErrorCodigoMoneda
            // 
            this.lblErrorCodigoMoneda.AutoSize = true;
            this.lblErrorCodigoMoneda.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoMoneda.Location = new System.Drawing.Point(525, 57);
            this.lblErrorCodigoMoneda.Name = "lblErrorCodigoMoneda";
            this.lblErrorCodigoMoneda.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoMoneda.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(525, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Moneda";
            // 
            // cbbCodigoMoneda
            // 
            this.cbbCodigoMoneda.DisplayMember = "Text";
            this.cbbCodigoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoMoneda.FormattingEnabled = true;
            this.cbbCodigoMoneda.Location = new System.Drawing.Point(528, 33);
            this.cbbCodigoMoneda.Name = "cbbCodigoMoneda";
            this.cbbCodigoMoneda.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoMoneda.TabIndex = 3;
            this.cbbCodigoMoneda.ValueMember = "Value";
            // 
            // lblErrorNroComprobante
            // 
            this.lblErrorNroComprobante.AutoSize = true;
            this.lblErrorNroComprobante.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNroComprobante.Location = new System.Drawing.Point(177, 57);
            this.lblErrorNroComprobante.Name = "lblErrorNroComprobante";
            this.lblErrorNroComprobante.Size = new System.Drawing.Size(0, 13);
            this.lblErrorNroComprobante.TabIndex = 10;
            // 
            // lblErrorFechaHoraEmision
            // 
            this.lblErrorFechaHoraEmision.AutoSize = true;
            this.lblErrorFechaHoraEmision.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFechaHoraEmision.Location = new System.Drawing.Point(3, 57);
            this.lblErrorFechaHoraEmision.Name = "lblErrorFechaHoraEmision";
            this.lblErrorFechaHoraEmision.Size = new System.Drawing.Size(0, 13);
            this.lblErrorFechaHoraEmision.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 17);
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
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha y Hora de Emisión";
            // 
            // txtNroComprobante
            // 
            this.txtNroComprobante.Location = new System.Drawing.Point(180, 33);
            this.txtNroComprobante.Name = "txtNroComprobante";
            this.txtNroComprobante.ReadOnly = true;
            this.txtNroComprobante.Size = new System.Drawing.Size(168, 20);
            this.txtNroComprobante.TabIndex = 1;
            // 
            // dtpFechaHoraEmision
            // 
            this.dtpFechaHoraEmision.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpFechaHoraEmision.Enabled = false;
            this.dtpFechaHoraEmision.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHoraEmision.Location = new System.Drawing.Point(6, 33);
            this.dtpFechaHoraEmision.Name = "dtpFechaHoraEmision";
            this.dtpFechaHoraEmision.Size = new System.Drawing.Size(168, 20);
            this.dtpFechaHoraEmision.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBuscarVendedor);
            this.groupBox4.Controls.Add(this.lblErrorVendedor);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtCorreoVendedor);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtNombresVendedor);
            this.groupBox4.Controls.Add(this.txtNroDocumentoIdentidadVendedor);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.cbbCodigoTipoDocumentoIdentidadVendedor);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Location = new System.Drawing.Point(8, 205);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(876, 72);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos del Vendedor";
            // 
            // btnBuscarVendedor
            // 
            this.btnBuscarVendedor.Location = new System.Drawing.Point(291, 32);
            this.btnBuscarVendedor.Name = "btnBuscarVendedor";
            this.btnBuscarVendedor.Size = new System.Drawing.Size(57, 23);
            this.btnBuscarVendedor.TabIndex = 2;
            this.btnBuscarVendedor.Text = "Buscar";
            this.btnBuscarVendedor.UseVisualStyleBackColor = true;
            this.btnBuscarVendedor.Click += new System.EventHandler(this.btnBuscarVendedor_Click);
            // 
            // lblErrorVendedor
            // 
            this.lblErrorVendedor.AutoSize = true;
            this.lblErrorVendedor.ForeColor = System.Drawing.Color.Red;
            this.lblErrorVendedor.Location = new System.Drawing.Point(4, 57);
            this.lblErrorVendedor.Name = "lblErrorVendedor";
            this.lblErrorVendedor.Size = new System.Drawing.Size(0, 13);
            this.lblErrorVendedor.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(699, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Correo Electrónico";
            // 
            // txtCorreoVendedor
            // 
            this.txtCorreoVendedor.Location = new System.Drawing.Point(702, 33);
            this.txtCorreoVendedor.Name = "txtCorreoVendedor";
            this.txtCorreoVendedor.ReadOnly = true;
            this.txtCorreoVendedor.Size = new System.Drawing.Size(168, 20);
            this.txtCorreoVendedor.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(351, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Nombres";
            // 
            // txtNombresVendedor
            // 
            this.txtNombresVendedor.Location = new System.Drawing.Point(354, 33);
            this.txtNombresVendedor.Name = "txtNombresVendedor";
            this.txtNombresVendedor.ReadOnly = true;
            this.txtNombresVendedor.Size = new System.Drawing.Size(342, 20);
            this.txtNombresVendedor.TabIndex = 3;
            // 
            // txtNroDocumentoIdentidadVendedor
            // 
            this.txtNroDocumentoIdentidadVendedor.Location = new System.Drawing.Point(180, 33);
            this.txtNroDocumentoIdentidadVendedor.Name = "txtNroDocumentoIdentidadVendedor";
            this.txtNroDocumentoIdentidadVendedor.Size = new System.Drawing.Size(105, 20);
            this.txtNroDocumentoIdentidadVendedor.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(177, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "N° Doc. Identidad";
            // 
            // cbbCodigoTipoDocumentoIdentidadVendedor
            // 
            this.cbbCodigoTipoDocumentoIdentidadVendedor.DisplayMember = "Descripcion";
            this.cbbCodigoTipoDocumentoIdentidadVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoTipoDocumentoIdentidadVendedor.Enabled = false;
            this.cbbCodigoTipoDocumentoIdentidadVendedor.FormattingEnabled = true;
            this.cbbCodigoTipoDocumentoIdentidadVendedor.Location = new System.Drawing.Point(6, 33);
            this.cbbCodigoTipoDocumentoIdentidadVendedor.Name = "cbbCodigoTipoDocumentoIdentidadVendedor";
            this.cbbCodigoTipoDocumentoIdentidadVendedor.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoTipoDocumentoIdentidadVendedor.TabIndex = 0;
            this.cbbCodigoTipoDocumentoIdentidadVendedor.ValueMember = "CodigoTipoDocumentoIdentidad";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Tipo Doc. Identidad";
            // 
            // gpbSupervisor
            // 
            this.gpbSupervisor.Controls.Add(this.btnBuscarSupervisor);
            this.gpbSupervisor.Controls.Add(this.label2);
            this.gpbSupervisor.Controls.Add(this.label4);
            this.gpbSupervisor.Controls.Add(this.txtCorreoSupervisor);
            this.gpbSupervisor.Controls.Add(this.label7);
            this.gpbSupervisor.Controls.Add(this.txtNombresSupervisor);
            this.gpbSupervisor.Controls.Add(this.txtNroDocumentoIdentidadSupervisor);
            this.gpbSupervisor.Controls.Add(this.label8);
            this.gpbSupervisor.Controls.Add(this.cbbCodigoTipoDocumentoIdentidadSupervisor);
            this.gpbSupervisor.Controls.Add(this.label20);
            this.gpbSupervisor.Enabled = false;
            this.gpbSupervisor.Location = new System.Drawing.Point(8, 283);
            this.gpbSupervisor.Name = "gpbSupervisor";
            this.gpbSupervisor.Size = new System.Drawing.Size(876, 72);
            this.gpbSupervisor.TabIndex = 4;
            this.gpbSupervisor.TabStop = false;
            this.gpbSupervisor.Text = "Datos del Supervisor";
            // 
            // btnBuscarSupervisor
            // 
            this.btnBuscarSupervisor.Location = new System.Drawing.Point(291, 32);
            this.btnBuscarSupervisor.Name = "btnBuscarSupervisor";
            this.btnBuscarSupervisor.Size = new System.Drawing.Size(57, 23);
            this.btnBuscarSupervisor.TabIndex = 2;
            this.btnBuscarSupervisor.Text = "Buscar";
            this.btnBuscarSupervisor.UseVisualStyleBackColor = true;
            this.btnBuscarSupervisor.Click += new System.EventHandler(this.btnBuscarSupervisor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(699, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Correo Electrónico";
            // 
            // txtCorreoSupervisor
            // 
            this.txtCorreoSupervisor.Location = new System.Drawing.Point(702, 33);
            this.txtCorreoSupervisor.Name = "txtCorreoSupervisor";
            this.txtCorreoSupervisor.ReadOnly = true;
            this.txtCorreoSupervisor.Size = new System.Drawing.Size(168, 20);
            this.txtCorreoSupervisor.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nombres";
            // 
            // txtNombresSupervisor
            // 
            this.txtNombresSupervisor.Location = new System.Drawing.Point(354, 33);
            this.txtNombresSupervisor.Name = "txtNombresSupervisor";
            this.txtNombresSupervisor.ReadOnly = true;
            this.txtNombresSupervisor.Size = new System.Drawing.Size(342, 20);
            this.txtNombresSupervisor.TabIndex = 3;
            // 
            // txtNroDocumentoIdentidadSupervisor
            // 
            this.txtNroDocumentoIdentidadSupervisor.Location = new System.Drawing.Point(180, 33);
            this.txtNroDocumentoIdentidadSupervisor.Name = "txtNroDocumentoIdentidadSupervisor";
            this.txtNroDocumentoIdentidadSupervisor.Size = new System.Drawing.Size(105, 20);
            this.txtNroDocumentoIdentidadSupervisor.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "N° Doc. Identidad";
            // 
            // cbbCodigoTipoDocumentoIdentidadSupervisor
            // 
            this.cbbCodigoTipoDocumentoIdentidadSupervisor.DisplayMember = "Descripcion";
            this.cbbCodigoTipoDocumentoIdentidadSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoTipoDocumentoIdentidadSupervisor.Enabled = false;
            this.cbbCodigoTipoDocumentoIdentidadSupervisor.FormattingEnabled = true;
            this.cbbCodigoTipoDocumentoIdentidadSupervisor.Location = new System.Drawing.Point(6, 33);
            this.cbbCodigoTipoDocumentoIdentidadSupervisor.Name = "cbbCodigoTipoDocumentoIdentidadSupervisor";
            this.cbbCodigoTipoDocumentoIdentidadSupervisor.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoTipoDocumentoIdentidadSupervisor.TabIndex = 0;
            this.cbbCodigoTipoDocumentoIdentidadSupervisor.ValueMember = "CodigoTipoDocumentoIdentidad";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Tipo Doc. Identidad";
            // 
            // chkTieneSupervisor
            // 
            this.chkTieneSupervisor.AutoSize = true;
            this.chkTieneSupervisor.Location = new System.Drawing.Point(128, 284);
            this.chkTieneSupervisor.Name = "chkTieneSupervisor";
            this.chkTieneSupervisor.Size = new System.Drawing.Size(15, 14);
            this.chkTieneSupervisor.TabIndex = 3;
            this.chkTieneSupervisor.UseVisualStyleBackColor = true;
            this.chkTieneSupervisor.CheckedChanged += new System.EventHandler(this.chkTieneSupervisor_CheckedChanged);
            // 
            // FrmMantenimientoCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 592);
            this.Controls.Add(this.chkTieneSupervisor);
            this.Controls.Add(this.gpbSupervisor);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMantenimientoCotizacion";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cotizaciones";
            this.Load += new System.EventHandler(this.FrmMantenimientoCotizacion_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gpbSupervisor.ResumeLayout(false);
            this.gpbSupervisor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalImporte;
        private System.Windows.Forms.Label lblErrorDetalle;
        private System.Windows.Forms.Button btnEliminarDetalle;
        private System.Windows.Forms.Button btnModificarDetalle;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblErrorCodigoMoneda;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbbCodigoMoneda;
        private System.Windows.Forms.Label lblErrorNroComprobante;
        private System.Windows.Forms.Label lblErrorFechaHoraEmision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroComprobante;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_CodigoCotizacionDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_Fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_ProductoIndividual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_TotalImporte;
        private System.Windows.Forms.ToolTip tltCotizacion;
        private System.Windows.Forms.Label lblErrorNroPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNroPedido;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBuscarVendedor;
        private System.Windows.Forms.Label lblErrorVendedor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCorreoVendedor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNombresVendedor;
        private System.Windows.Forms.TextBox txtNroDocumentoIdentidadVendedor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbbCodigoTipoDocumentoIdentidadVendedor;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox gpbSupervisor;
        private System.Windows.Forms.CheckBox chkTieneSupervisor;
        private System.Windows.Forms.Button btnBuscarSupervisor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreoSupervisor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombresSupervisor;
        private System.Windows.Forms.TextBox txtNroDocumentoIdentidadSupervisor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbCodigoTipoDocumentoIdentidadSupervisor;
        private System.Windows.Forms.Label label20;
    }
}