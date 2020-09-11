namespace pm.app
{
    partial class FrmMantenimientoBoletaVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblErrorCodigoMoneda = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbbCodigoMoneda = new System.Windows.Forms.ComboBox();
            this.lblErrorFechaHoraVencimiento = new System.Windows.Forms.Label();
            this.lblErrorNroComprobante = new System.Windows.Forms.Label();
            this.lblErrorCodigoSerie = new System.Windows.Forms.Label();
            this.lblErrorFechaHoraEmision = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaHoraVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNroComprobante = new System.Windows.Forms.TextBox();
            this.cbbCodigoSerie = new System.Windows.Forms.ComboBox();
            this.dtpFechaHoraEmision = new System.Windows.Forms.DateTimePicker();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalBaseImponible = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalIgv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalImporte = new System.Windows.Forms.TextBox();
            this.lblErrorDetalle = new System.Windows.Forms.Label();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.btnModificarDetalle = new System.Windows.Forms.Button();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.dgvDetalle_CodigoBoletaVentaDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_Fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_ProductoIndividual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_PorcentajeDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_Igv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle_TotalImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnGuardarEmitir = new System.Windows.Forms.Button();
            this.tltBoletaVenta = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblErrorCodigoMoneda);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cbbCodigoMoneda);
            this.groupBox1.Controls.Add(this.lblErrorFechaHoraVencimiento);
            this.groupBox1.Controls.Add(this.lblErrorNroComprobante);
            this.groupBox1.Controls.Add(this.lblErrorCodigoSerie);
            this.groupBox1.Controls.Add(this.lblErrorFechaHoraEmision);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaHoraVencimiento);
            this.groupBox1.Controls.Add(this.txtNroComprobante);
            this.groupBox1.Controls.Add(this.cbbCodigoSerie);
            this.groupBox1.Controls.Add(this.dtpFechaHoraEmision);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Comprobante";
            // 
            // lblErrorCodigoMoneda
            // 
            this.lblErrorCodigoMoneda.AutoSize = true;
            this.lblErrorCodigoMoneda.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoMoneda.Location = new System.Drawing.Point(699, 57);
            this.lblErrorCodigoMoneda.Name = "lblErrorCodigoMoneda";
            this.lblErrorCodigoMoneda.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoMoneda.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(699, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Moneda";
            // 
            // cbbCodigoMoneda
            // 
            this.cbbCodigoMoneda.DisplayMember = "Text";
            this.cbbCodigoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoMoneda.FormattingEnabled = true;
            this.cbbCodigoMoneda.Location = new System.Drawing.Point(702, 33);
            this.cbbCodigoMoneda.Name = "cbbCodigoMoneda";
            this.cbbCodigoMoneda.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoMoneda.TabIndex = 12;
            this.cbbCodigoMoneda.ValueMember = "Value";
            // 
            // lblErrorFechaHoraVencimiento
            // 
            this.lblErrorFechaHoraVencimiento.AutoSize = true;
            this.lblErrorFechaHoraVencimiento.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFechaHoraVencimiento.Location = new System.Drawing.Point(525, 57);
            this.lblErrorFechaHoraVencimiento.Name = "lblErrorFechaHoraVencimiento";
            this.lblErrorFechaHoraVencimiento.Size = new System.Drawing.Size(0, 13);
            this.lblErrorFechaHoraVencimiento.TabIndex = 11;
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
            // lblErrorCodigoSerie
            // 
            this.lblErrorCodigoSerie.AutoSize = true;
            this.lblErrorCodigoSerie.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoSerie.Location = new System.Drawing.Point(177, 57);
            this.lblErrorCodigoSerie.Name = "lblErrorCodigoSerie";
            this.lblErrorCodigoSerie.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoSerie.TabIndex = 9;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha Vencimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "N° Comprobante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 17);
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
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha y Hora de Emisión";
            // 
            // dtpFechaHoraVencimiento
            // 
            this.dtpFechaHoraVencimiento.CustomFormat = "";
            this.dtpFechaHoraVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHoraVencimiento.Location = new System.Drawing.Point(528, 33);
            this.dtpFechaHoraVencimiento.Name = "dtpFechaHoraVencimiento";
            this.dtpFechaHoraVencimiento.Size = new System.Drawing.Size(168, 21);
            this.dtpFechaHoraVencimiento.TabIndex = 3;
            // 
            // txtNroComprobante
            // 
            this.txtNroComprobante.Location = new System.Drawing.Point(354, 33);
            this.txtNroComprobante.Name = "txtNroComprobante";
            this.txtNroComprobante.ReadOnly = true;
            this.txtNroComprobante.Size = new System.Drawing.Size(168, 21);
            this.txtNroComprobante.TabIndex = 2;
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
            // dtpFechaHoraEmision
            // 
            this.dtpFechaHoraEmision.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpFechaHoraEmision.Enabled = false;
            this.dtpFechaHoraEmision.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHoraEmision.Location = new System.Drawing.Point(6, 33);
            this.dtpFechaHoraEmision.Name = "dtpFechaHoraEmision";
            this.dtpFechaHoraEmision.Size = new System.Drawing.Size(168, 21);
            this.dtpFechaHoraEmision.TabIndex = 0;
            this.dtpFechaHoraEmision.ValueChanged += new System.EventHandler(this.dtpFechaHoraEmision_ValueChanged);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
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
            this.btnBuscarCliente.TabIndex = 35;
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
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Ubicación";
            // 
            // txtUbicacionCliente
            // 
            this.txtUbicacionCliente.Location = new System.Drawing.Point(528, 73);
            this.txtUbicacionCliente.Name = "txtUbicacionCliente";
            this.txtUbicacionCliente.ReadOnly = true;
            this.txtUbicacionCliente.Size = new System.Drawing.Size(342, 21);
            this.txtUbicacionCliente.TabIndex = 32;
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
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(6, 73);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(516, 21);
            this.txtDireccionCliente.TabIndex = 20;
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
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Location = new System.Drawing.Point(702, 33);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.ReadOnly = true;
            this.txtCorreoCliente.Size = new System.Drawing.Size(168, 21);
            this.txtCorreoCliente.TabIndex = 17;
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
            this.txtNombresCliente.Size = new System.Drawing.Size(342, 21);
            this.txtNombresCliente.TabIndex = 15;
            // 
            // txtNroDocumentoIdentidadCliente
            // 
            this.txtNroDocumentoIdentidadCliente.Location = new System.Drawing.Point(180, 33);
            this.txtNroDocumentoIdentidadCliente.Name = "txtNroDocumentoIdentidadCliente";
            this.txtNroDocumentoIdentidadCliente.Size = new System.Drawing.Size(105, 21);
            this.txtNroDocumentoIdentidadCliente.TabIndex = 14;
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
            // cbbCodigoTipoDocumentoIdentidadCliente
            // 
            this.cbbCodigoTipoDocumentoIdentidadCliente.DisplayMember = "Descripcion";
            this.cbbCodigoTipoDocumentoIdentidadCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoTipoDocumentoIdentidadCliente.Enabled = false;
            this.cbbCodigoTipoDocumentoIdentidadCliente.FormattingEnabled = true;
            this.cbbCodigoTipoDocumentoIdentidadCliente.Location = new System.Drawing.Point(6, 33);
            this.cbbCodigoTipoDocumentoIdentidadCliente.Name = "cbbCodigoTipoDocumentoIdentidadCliente";
            this.cbbCodigoTipoDocumentoIdentidadCliente.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoTipoDocumentoIdentidadCliente.TabIndex = 12;
            this.cbbCodigoTipoDocumentoIdentidadCliente.ValueMember = "CodigoTipoDocumentoIdentidad";
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
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtTotalBaseImponible);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtTotalIgv);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtTotalImporte);
            this.groupBox3.Controls.Add(this.lblErrorDetalle);
            this.groupBox3.Controls.Add(this.btnEliminarDetalle);
            this.groupBox3.Controls.Add(this.btnModificarDetalle);
            this.groupBox3.Controls.Add(this.btnAgregarDetalle);
            this.groupBox3.Controls.Add(this.dgvDetalle);
            this.groupBox3.Location = new System.Drawing.Point(12, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(876, 247);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle del Comprobante";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "SubTotal";
            // 
            // txtTotalBaseImponible
            // 
            this.txtTotalBaseImponible.Location = new System.Drawing.Point(354, 220);
            this.txtTotalBaseImponible.Name = "txtTotalBaseImponible";
            this.txtTotalBaseImponible.ReadOnly = true;
            this.txtTotalBaseImponible.Size = new System.Drawing.Size(168, 21);
            this.txtTotalBaseImponible.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Igv";
            // 
            // txtTotalIgv
            // 
            this.txtTotalIgv.Location = new System.Drawing.Point(528, 220);
            this.txtTotalIgv.Name = "txtTotalIgv";
            this.txtTotalIgv.ReadOnly = true;
            this.txtTotalIgv.Size = new System.Drawing.Size(168, 21);
            this.txtTotalIgv.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(699, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Importe Total";
            // 
            // txtTotalImporte
            // 
            this.txtTotalImporte.Location = new System.Drawing.Point(702, 220);
            this.txtTotalImporte.Name = "txtTotalImporte";
            this.txtTotalImporte.ReadOnly = true;
            this.txtTotalImporte.Size = new System.Drawing.Size(168, 21);
            this.txtTotalImporte.TabIndex = 36;
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
            this.dgvDetalle_CodigoBoletaVentaDetalle,
            this.dgvDetalle_Fila,
            this.dgvDetalle_Producto,
            this.dgvDetalle_ProductoIndividual,
            this.dgvDetalle_Cantidad,
            this.dgvDetalle_ValorUnitario,
            this.dgvDetalle_PrecioUnitario,
            this.dgvDetalle_PorcentajeDescuento,
            this.dgvDetalle_Descuento,
            this.dgvDetalle_Igv,
            this.dgvDetalle_TotalImporte});
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
            // dgvDetalle_CodigoBoletaVentaDetalle
            // 
            this.dgvDetalle_CodigoBoletaVentaDetalle.DataPropertyName = "CodigoBoletaVentaDetalle";
            this.dgvDetalle_CodigoBoletaVentaDetalle.HeaderText = "CodigoBoletaVentaDetalle";
            this.dgvDetalle_CodigoBoletaVentaDetalle.Name = "dgvDetalle_CodigoBoletaVentaDetalle";
            this.dgvDetalle_CodigoBoletaVentaDetalle.ReadOnly = true;
            this.dgvDetalle_CodigoBoletaVentaDetalle.Visible = false;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "#,##0.00";
            this.dgvDetalle_Cantidad.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDetalle_Cantidad.HeaderText = "Cantidad";
            this.dgvDetalle_Cantidad.Name = "dgvDetalle_Cantidad";
            this.dgvDetalle_Cantidad.ReadOnly = true;
            this.dgvDetalle_Cantidad.Width = 70;
            // 
            // dgvDetalle_ValorUnitario
            // 
            this.dgvDetalle_ValorUnitario.DataPropertyName = "ValorUnitario";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "#,##0.00";
            this.dgvDetalle_ValorUnitario.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDetalle_ValorUnitario.HeaderText = "V. Unit.";
            this.dgvDetalle_ValorUnitario.Name = "dgvDetalle_ValorUnitario";
            this.dgvDetalle_ValorUnitario.ReadOnly = true;
            this.dgvDetalle_ValorUnitario.Width = 70;
            // 
            // dgvDetalle_PrecioUnitario
            // 
            this.dgvDetalle_PrecioUnitario.DataPropertyName = "PrecioUnitario";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "#,##0.00";
            this.dgvDetalle_PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDetalle_PrecioUnitario.HeaderText = "P. Unit.";
            this.dgvDetalle_PrecioUnitario.Name = "dgvDetalle_PrecioUnitario";
            this.dgvDetalle_PrecioUnitario.ReadOnly = true;
            this.dgvDetalle_PrecioUnitario.Width = 70;
            // 
            // dgvDetalle_PorcentajeDescuento
            // 
            this.dgvDetalle_PorcentajeDescuento.DataPropertyName = "PorcentajeDescuento";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "#,##0.00";
            this.dgvDetalle_PorcentajeDescuento.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDetalle_PorcentajeDescuento.HeaderText = "% Dscto";
            this.dgvDetalle_PorcentajeDescuento.Name = "dgvDetalle_PorcentajeDescuento";
            this.dgvDetalle_PorcentajeDescuento.ReadOnly = true;
            this.dgvDetalle_PorcentajeDescuento.Width = 70;
            // 
            // dgvDetalle_Descuento
            // 
            this.dgvDetalle_Descuento.DataPropertyName = "Descuento";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "#,##0.00";
            this.dgvDetalle_Descuento.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDetalle_Descuento.HeaderText = "Dscto";
            this.dgvDetalle_Descuento.Name = "dgvDetalle_Descuento";
            this.dgvDetalle_Descuento.ReadOnly = true;
            this.dgvDetalle_Descuento.Width = 70;
            // 
            // dgvDetalle_Igv
            // 
            this.dgvDetalle_Igv.DataPropertyName = "Igv";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "#,##0.00";
            this.dgvDetalle_Igv.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDetalle_Igv.HeaderText = "Igv";
            this.dgvDetalle_Igv.Name = "dgvDetalle_Igv";
            this.dgvDetalle_Igv.ReadOnly = true;
            this.dgvDetalle_Igv.Width = 70;
            // 
            // dgvDetalle_TotalImporte
            // 
            this.dgvDetalle_TotalImporte.DataPropertyName = "Importe";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "#,##0.00";
            this.dgvDetalle_TotalImporte.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDetalle_TotalImporte.HeaderText = "Importe Total";
            this.dgvDetalle_TotalImporte.Name = "dgvDetalle_TotalImporte";
            this.dgvDetalle_TotalImporte.ReadOnly = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(691, 463);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnGuardarEmitir
            // 
            this.btnGuardarEmitir.Location = new System.Drawing.Point(772, 463);
            this.btnGuardarEmitir.Name = "btnGuardarEmitir";
            this.btnGuardarEmitir.Size = new System.Drawing.Size(116, 23);
            this.btnGuardarEmitir.TabIndex = 4;
            this.btnGuardarEmitir.Text = "Guardar y Emitir";
            this.btnGuardarEmitir.UseVisualStyleBackColor = true;
            this.btnGuardarEmitir.Click += new System.EventHandler(this.btnGuardarEmitir_Click);
            // 
            // FrmMantenimientoBoletaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(900, 498);
            this.Controls.Add(this.btnGuardarEmitir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.Name = "FrmMantenimientoBoletaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMantenimientoBoletaVenta";
            this.Load += new System.EventHandler(this.FrmMantenimientoBoletaVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraEmision;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraVencimiento;
        private System.Windows.Forms.TextBox txtNroComprobante;
        private System.Windows.Forms.ComboBox cbbCodigoSerie;
        private System.Windows.Forms.Label lblErrorFechaHoraVencimiento;
        private System.Windows.Forms.Label lblErrorNroComprobante;
        private System.Windows.Forms.Label lblErrorCodigoSerie;
        private System.Windows.Forms.Label lblErrorFechaHoraEmision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label lblErrorCodigoMoneda;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbbCodigoMoneda;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnEliminarDetalle;
        private System.Windows.Forms.Button btnModificarDetalle;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.Label lblErrorDetalle;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnGuardarEmitir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalBaseImponible;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalIgv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalImporte;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_CodigoBoletaVentaDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_Fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_ProductoIndividual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_PorcentajeDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_Igv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle_TotalImporte;
        private System.Windows.Forms.ToolTip tltBoletaVenta;
    }
}