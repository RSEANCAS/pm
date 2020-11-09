namespace pm.app
{
    partial class FrmGuiaRemision
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblResultados = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbFiltroCodigoSerie = new System.Windows.Forms.ComboBox();
            this.dtpFiltroFechaEmisionHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFiltroFechaEmisionDesde = new System.Windows.Forms.DateTimePicker();
            this.txtFiltroNombresCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiltroNroDocIdentidadCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFiltroNroComprobante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvResultados_CodigoGuiaRemision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_CodigoCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_TipoComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_FechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_FechaTraslado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_TipoDocumentoIdentidadCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NroDocIdentidadCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NombresCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_TipoDocumentoIdentidadTransportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NroDocIdentidadTransportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NombresTransportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_MotivoTraslado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NroComprobanteCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NroPedidoCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_FechaHoraEmisionCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_FlagEmitido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvResultados_FlagActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(15, 92);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(0, 13);
            this.lblResultados.TabIndex = 28;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(557, 82);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 27;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultados.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvResultados_CodigoGuiaRemision,
            this.dgvResultados_CodigoCotizacion,
            this.dgvResultados_Nro,
            this.dgvResultados_TipoComprobante,
            this.dgvResultados_Serie,
            this.dgvResultados_Numero,
            this.dgvResultados_FechaEmision,
            this.dgvResultados_FechaTraslado,
            this.dgvResultados_TipoDocumentoIdentidadCliente,
            this.dgvResultados_NroDocIdentidadCliente,
            this.dgvResultados_NombresCliente,
            this.dgvResultados_TipoDocumentoIdentidadTransportista,
            this.dgvResultados_NroDocIdentidadTransportista,
            this.dgvResultados_NombresTransportista,
            this.dgvResultados_MotivoTraslado,
            this.dgvResultados_NroComprobanteCotizacion,
            this.dgvResultados_NroPedidoCotizacion,
            this.dgvResultados_FechaHoraEmisionCotizacion,
            this.dgvResultados_FlagEmitido,
            this.dgvResultados_FlagActivo});
            this.dgvResultados.Location = new System.Drawing.Point(12, 111);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(701, 167);
            this.dgvResultados.TabIndex = 26;
            this.dgvResultados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvResultados_MouseClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(638, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbbFiltroCodigoSerie);
            this.groupBox1.Controls.Add(this.dtpFiltroFechaEmisionHasta);
            this.groupBox1.Controls.Add(this.dtpFiltroFechaEmisionDesde);
            this.groupBox1.Controls.Add(this.txtFiltroNombresCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFiltroNroDocIdentidadCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFiltroNroComprobante);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkActivo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 64);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // cbbFiltroCodigoSerie
            // 
            this.cbbFiltroCodigoSerie.DisplayMember = "Serial";
            this.cbbFiltroCodigoSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFiltroCodigoSerie.FormattingEnabled = true;
            this.cbbFiltroCodigoSerie.Location = new System.Drawing.Point(218, 33);
            this.cbbFiltroCodigoSerie.Name = "cbbFiltroCodigoSerie";
            this.cbbFiltroCodigoSerie.Size = new System.Drawing.Size(100, 21);
            this.cbbFiltroCodigoSerie.TabIndex = 25;
            this.cbbFiltroCodigoSerie.ValueMember = "CodigoSerie";
            // 
            // dtpFiltroFechaEmisionHasta
            // 
            this.dtpFiltroFechaEmisionHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroFechaEmisionHasta.Location = new System.Drawing.Point(112, 33);
            this.dtpFiltroFechaEmisionHasta.Name = "dtpFiltroFechaEmisionHasta";
            this.dtpFiltroFechaEmisionHasta.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltroFechaEmisionHasta.TabIndex = 24;
            // 
            // dtpFiltroFechaEmisionDesde
            // 
            this.dtpFiltroFechaEmisionDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroFechaEmisionDesde.Location = new System.Drawing.Point(6, 33);
            this.dtpFiltroFechaEmisionDesde.Name = "dtpFiltroFechaEmisionDesde";
            this.dtpFiltroFechaEmisionDesde.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltroFechaEmisionDesde.TabIndex = 23;
            // 
            // txtFiltroNombresCliente
            // 
            this.txtFiltroNombresCliente.Location = new System.Drawing.Point(536, 33);
            this.txtFiltroNombresCliente.Name = "txtFiltroNombresCliente";
            this.txtFiltroNombresCliente.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroNombresCliente.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nombres";
            // 
            // txtFiltroNroDocIdentidadCliente
            // 
            this.txtFiltroNroDocIdentidadCliente.Location = new System.Drawing.Point(430, 33);
            this.txtFiltroNroDocIdentidadCliente.Name = "txtFiltroNroDocIdentidadCliente";
            this.txtFiltroNroDocIdentidadCliente.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroNroDocIdentidadCliente.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "N° Doc. Identidad";
            // 
            // txtFiltroNroComprobante
            // 
            this.txtFiltroNroComprobante.Location = new System.Drawing.Point(324, 33);
            this.txtFiltroNroComprobante.Name = "txtFiltroNroComprobante";
            this.txtFiltroNroComprobante.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroNroComprobante.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Serie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fec. Emisión Hasta";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(642, 37);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(57, 17);
            this.chkActivo.TabIndex = 12;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fec. Emisión Desde";
            // 
            // dgvResultados_CodigoGuiaRemision
            // 
            this.dgvResultados_CodigoGuiaRemision.DataPropertyName = "CodigoGuiaRemision";
            this.dgvResultados_CodigoGuiaRemision.HeaderText = "CodigoGuiaRemision";
            this.dgvResultados_CodigoGuiaRemision.Name = "dgvResultados_CodigoGuiaRemision";
            this.dgvResultados_CodigoGuiaRemision.ReadOnly = true;
            this.dgvResultados_CodigoGuiaRemision.Visible = false;
            // 
            // dgvResultados_CodigoCotizacion
            // 
            this.dgvResultados_CodigoCotizacion.DataPropertyName = "CodigoCotizacion";
            this.dgvResultados_CodigoCotizacion.HeaderText = "CodigoCotizacion";
            this.dgvResultados_CodigoCotizacion.Name = "dgvResultados_CodigoCotizacion";
            this.dgvResultados_CodigoCotizacion.ReadOnly = true;
            this.dgvResultados_CodigoCotizacion.Visible = false;
            // 
            // dgvResultados_Nro
            // 
            this.dgvResultados_Nro.DataPropertyName = "Fila";
            this.dgvResultados_Nro.HeaderText = "N°";
            this.dgvResultados_Nro.Name = "dgvResultados_Nro";
            this.dgvResultados_Nro.ReadOnly = true;
            this.dgvResultados_Nro.Width = 44;
            // 
            // dgvResultados_TipoComprobante
            // 
            this.dgvResultados_TipoComprobante.DataPropertyName = "TipoComprobante";
            this.dgvResultados_TipoComprobante.HeaderText = "Tipo Comprobante";
            this.dgvResultados_TipoComprobante.Name = "dgvResultados_TipoComprobante";
            this.dgvResultados_TipoComprobante.ReadOnly = true;
            this.dgvResultados_TipoComprobante.Width = 150;
            // 
            // dgvResultados_Serie
            // 
            this.dgvResultados_Serie.DataPropertyName = "Serie";
            this.dgvResultados_Serie.HeaderText = "Serie";
            this.dgvResultados_Serie.Name = "dgvResultados_Serie";
            this.dgvResultados_Serie.ReadOnly = true;
            this.dgvResultados_Serie.Width = 50;
            // 
            // dgvResultados_Numero
            // 
            this.dgvResultados_Numero.DataPropertyName = "NroComprobante";
            dataGridViewCellStyle1.Format = "00000000";
            this.dgvResultados_Numero.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultados_Numero.HeaderText = "Número";
            this.dgvResultados_Numero.Name = "dgvResultados_Numero";
            this.dgvResultados_Numero.ReadOnly = true;
            this.dgvResultados_Numero.Width = 80;
            // 
            // dgvResultados_FechaEmision
            // 
            this.dgvResultados_FechaEmision.DataPropertyName = "FechaHoraEmision";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy hh:mm:ss";
            this.dgvResultados_FechaEmision.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultados_FechaEmision.HeaderText = "Fecha Emisión";
            this.dgvResultados_FechaEmision.Name = "dgvResultados_FechaEmision";
            this.dgvResultados_FechaEmision.ReadOnly = true;
            this.dgvResultados_FechaEmision.Width = 120;
            // 
            // dgvResultados_FechaTraslado
            // 
            this.dgvResultados_FechaTraslado.DataPropertyName = "FechaHoraTraslado";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.dgvResultados_FechaTraslado.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResultados_FechaTraslado.HeaderText = "Fecha Traslado";
            this.dgvResultados_FechaTraslado.Name = "dgvResultados_FechaTraslado";
            this.dgvResultados_FechaTraslado.ReadOnly = true;
            this.dgvResultados_FechaTraslado.Width = 126;
            // 
            // dgvResultados_TipoDocumentoIdentidadCliente
            // 
            this.dgvResultados_TipoDocumentoIdentidadCliente.DataPropertyName = "DescripcionTipoDocumentoIdentidadCliente";
            this.dgvResultados_TipoDocumentoIdentidadCliente.HeaderText = "Tipo Doc. Identidad Cliente";
            this.dgvResultados_TipoDocumentoIdentidadCliente.Name = "dgvResultados_TipoDocumentoIdentidadCliente";
            this.dgvResultados_TipoDocumentoIdentidadCliente.ReadOnly = true;
            this.dgvResultados_TipoDocumentoIdentidadCliente.Width = 200;
            // 
            // dgvResultados_NroDocIdentidadCliente
            // 
            this.dgvResultados_NroDocIdentidadCliente.DataPropertyName = "NroDocumentoIdentidadCliente";
            this.dgvResultados_NroDocIdentidadCliente.HeaderText = "N° Doc. Identidad Cliente";
            this.dgvResultados_NroDocIdentidadCliente.Name = "dgvResultados_NroDocIdentidadCliente";
            this.dgvResultados_NroDocIdentidadCliente.ReadOnly = true;
            this.dgvResultados_NroDocIdentidadCliente.Width = 200;
            // 
            // dgvResultados_NombresCliente
            // 
            this.dgvResultados_NombresCliente.DataPropertyName = "Cliente";
            this.dgvResultados_NombresCliente.HeaderText = "Nombres Completos Cliente";
            this.dgvResultados_NombresCliente.Name = "dgvResultados_NombresCliente";
            this.dgvResultados_NombresCliente.ReadOnly = true;
            this.dgvResultados_NombresCliente.Width = 250;
            // 
            // dgvResultados_TipoDocumentoIdentidadTransportista
            // 
            this.dgvResultados_TipoDocumentoIdentidadTransportista.DataPropertyName = "DescripcionTipoDocumentoIdentidadTransportista";
            this.dgvResultados_TipoDocumentoIdentidadTransportista.HeaderText = "Tipo Doc. Identidad Transportista";
            this.dgvResultados_TipoDocumentoIdentidadTransportista.Name = "dgvResultados_TipoDocumentoIdentidadTransportista";
            this.dgvResultados_TipoDocumentoIdentidadTransportista.ReadOnly = true;
            this.dgvResultados_TipoDocumentoIdentidadTransportista.Width = 200;
            // 
            // dgvResultados_NroDocIdentidadTransportista
            // 
            this.dgvResultados_NroDocIdentidadTransportista.DataPropertyName = "NroDocumentoIdentidadTransportista";
            this.dgvResultados_NroDocIdentidadTransportista.HeaderText = "N° Doc. Identidad Transportista";
            this.dgvResultados_NroDocIdentidadTransportista.Name = "dgvResultados_NroDocIdentidadTransportista";
            this.dgvResultados_NroDocIdentidadTransportista.ReadOnly = true;
            this.dgvResultados_NroDocIdentidadTransportista.Width = 200;
            // 
            // dgvResultados_NombresTransportista
            // 
            this.dgvResultados_NombresTransportista.DataPropertyName = "Transportista";
            this.dgvResultados_NombresTransportista.HeaderText = "Nombres Completos Transportista";
            this.dgvResultados_NombresTransportista.Name = "dgvResultados_NombresTransportista";
            this.dgvResultados_NombresTransportista.ReadOnly = true;
            this.dgvResultados_NombresTransportista.Width = 250;
            // 
            // dgvResultados_MotivoTraslado
            // 
            this.dgvResultados_MotivoTraslado.DataPropertyName = "MotivoTraslado";
            this.dgvResultados_MotivoTraslado.HeaderText = "Motivo Traslado";
            this.dgvResultados_MotivoTraslado.Name = "dgvResultados_MotivoTraslado";
            this.dgvResultados_MotivoTraslado.ReadOnly = true;
            this.dgvResultados_MotivoTraslado.Width = 200;
            // 
            // dgvResultados_NroComprobanteCotizacion
            // 
            this.dgvResultados_NroComprobanteCotizacion.DataPropertyName = "NroComprobanteCotizacion";
            dataGridViewCellStyle4.Format = "00000000";
            this.dgvResultados_NroComprobanteCotizacion.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResultados_NroComprobanteCotizacion.HeaderText = "N° Cot.";
            this.dgvResultados_NroComprobanteCotizacion.Name = "dgvResultados_NroComprobanteCotizacion";
            this.dgvResultados_NroComprobanteCotizacion.ReadOnly = true;
            // 
            // dgvResultados_NroPedidoCotizacion
            // 
            this.dgvResultados_NroPedidoCotizacion.DataPropertyName = "NroPedidoCotizacion";
            this.dgvResultados_NroPedidoCotizacion.HeaderText = "N° Pedido Cot.";
            this.dgvResultados_NroPedidoCotizacion.Name = "dgvResultados_NroPedidoCotizacion";
            this.dgvResultados_NroPedidoCotizacion.ReadOnly = true;
            this.dgvResultados_NroPedidoCotizacion.Width = 120;
            // 
            // dgvResultados_FechaHoraEmisionCotizacion
            // 
            this.dgvResultados_FechaHoraEmisionCotizacion.DataPropertyName = "FechaHoraEmisionCotizacion";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            this.dgvResultados_FechaHoraEmisionCotizacion.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResultados_FechaHoraEmisionCotizacion.HeaderText = "Fecha Emisión Cot.";
            this.dgvResultados_FechaHoraEmisionCotizacion.Name = "dgvResultados_FechaHoraEmisionCotizacion";
            this.dgvResultados_FechaHoraEmisionCotizacion.ReadOnly = true;
            this.dgvResultados_FechaHoraEmisionCotizacion.Width = 140;
            // 
            // dgvResultados_FlagEmitido
            // 
            this.dgvResultados_FlagEmitido.DataPropertyName = "FlagEmitido";
            this.dgvResultados_FlagEmitido.HeaderText = "Emitido";
            this.dgvResultados_FlagEmitido.Name = "dgvResultados_FlagEmitido";
            this.dgvResultados_FlagEmitido.ReadOnly = true;
            // 
            // dgvResultados_FlagActivo
            // 
            this.dgvResultados_FlagActivo.DataPropertyName = "FlagActivo";
            this.dgvResultados_FlagActivo.HeaderText = "Activo";
            this.dgvResultados_FlagActivo.Name = "dgvResultados_FlagActivo";
            this.dgvResultados_FlagActivo.ReadOnly = true;
            this.dgvResultados_FlagActivo.Width = 80;
            // 
            // FrmGuiaRemision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 290);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.Name = "FrmGuiaRemision";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Guías de Remisión";
            this.Load += new System.EventHandler(this.FrmGuiaRemision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbFiltroCodigoSerie;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaEmisionHasta;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaEmisionDesde;
        private System.Windows.Forms.TextBox txtFiltroNombresCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiltroNroDocIdentidadCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFiltroNroComprobante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_CodigoGuiaRemision;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_CodigoCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_TipoComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_FechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_FechaTraslado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_TipoDocumentoIdentidadCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NroDocIdentidadCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NombresCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_TipoDocumentoIdentidadTransportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NroDocIdentidadTransportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NombresTransportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_MotivoTraslado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NroComprobanteCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NroPedidoCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_FechaHoraEmisionCotizacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvResultados_FlagEmitido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvResultados_FlagActivo;
    }
}