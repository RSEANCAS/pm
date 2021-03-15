namespace pm.app
{
    partial class FrmLetra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblResultados = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.dgvResultados_CodigoLetra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NumeroLetraInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NombreBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_CodigoUnicoBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NombreTipoComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_SerialSerieComprobanteRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NroComprobanteComprobanteRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_FechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_DiasPorVencer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_DiasDeVencido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_TipoDocumentoIdentidadCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NroDocIdentidadCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NombresCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_StrMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Mora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Protesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_TotalLetraPadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_TotalLetraInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_StrEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_FlagCancelado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvResultados_FlagActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCancelado = new System.Windows.Forms.CheckBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFiltroFechaEmisionHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFiltroFechaEmisionDesde = new System.Windows.Forms.DateTimePicker();
            this.txtFiltroNombresCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiltroNroDocIdentidadCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFiltroNroComprobante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(15, 129);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(0, 13);
            this.lblResultados.TabIndex = 28;
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
            this.dgvResultados_CodigoLetra,
            this.dgvResultados_Nro,
            this.dgvResultados_Numero,
            this.dgvResultados_NumeroLetraInicial,
            this.dgvResultados_NombreBanco,
            this.dgvResultados_CodigoUnicoBanco,
            this.dgvResultados_NombreTipoComprobante,
            this.dgvResultados_SerialSerieComprobanteRef,
            this.dgvResultados_NroComprobanteComprobanteRef,
            this.dgvResultados_FechaEmision,
            this.dgvResultados_FechaVencimiento,
            this.dgvResultados_Dias,
            this.dgvResultados_DiasPorVencer,
            this.dgvResultados_DiasDeVencido,
            this.dgvResultados_TipoDocumentoIdentidadCliente,
            this.dgvResultados_NroDocIdentidadCliente,
            this.dgvResultados_NombresCliente,
            this.dgvResultados_StrMoneda,
            this.dgvResultados_Monto,
            this.dgvResultados_Mora,
            this.dgvResultados_Protesto,
            this.dgvResultados_Total,
            this.dgvResultados_TotalLetraPadre,
            this.dgvResultados_TotalLetraInicial,
            this.dgvResultados_Estado,
            this.dgvResultados_StrEstado,
            this.dgvResultados_FlagCancelado,
            this.dgvResultados_FlagActivo});
            this.dgvResultados.Location = new System.Drawing.Point(12, 148);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(701, 130);
            this.dgvResultados.TabIndex = 3;
            this.dgvResultados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvResultados_MouseClick);
            // 
            // dgvResultados_CodigoLetra
            // 
            this.dgvResultados_CodigoLetra.DataPropertyName = "CodigoLetra";
            this.dgvResultados_CodigoLetra.HeaderText = "CodigoLetra";
            this.dgvResultados_CodigoLetra.Name = "dgvResultados_CodigoLetra";
            this.dgvResultados_CodigoLetra.ReadOnly = true;
            this.dgvResultados_CodigoLetra.Visible = false;
            // 
            // dgvResultados_Nro
            // 
            this.dgvResultados_Nro.DataPropertyName = "Fila";
            this.dgvResultados_Nro.HeaderText = "N°";
            this.dgvResultados_Nro.Name = "dgvResultados_Nro";
            this.dgvResultados_Nro.ReadOnly = true;
            this.dgvResultados_Nro.Width = 44;
            // 
            // dgvResultados_Numero
            // 
            this.dgvResultados_Numero.DataPropertyName = "Numero";
            dataGridViewCellStyle1.Format = "00000000";
            this.dgvResultados_Numero.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultados_Numero.HeaderText = "N° Letra";
            this.dgvResultados_Numero.Name = "dgvResultados_Numero";
            this.dgvResultados_Numero.ReadOnly = true;
            // 
            // dgvResultados_NumeroLetraInicial
            // 
            this.dgvResultados_NumeroLetraInicial.DataPropertyName = "NumeroLetraInicial";
            dataGridViewCellStyle2.Format = "00000000";
            this.dgvResultados_NumeroLetraInicial.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultados_NumeroLetraInicial.HeaderText = "N° Letra Inicial";
            this.dgvResultados_NumeroLetraInicial.Name = "dgvResultados_NumeroLetraInicial";
            this.dgvResultados_NumeroLetraInicial.ReadOnly = true;
            this.dgvResultados_NumeroLetraInicial.Width = 120;
            // 
            // dgvResultados_NombreBanco
            // 
            this.dgvResultados_NombreBanco.DataPropertyName = "NombreBanco";
            this.dgvResultados_NombreBanco.HeaderText = "Banco";
            this.dgvResultados_NombreBanco.Name = "dgvResultados_NombreBanco";
            this.dgvResultados_NombreBanco.ReadOnly = true;
            // 
            // dgvResultados_CodigoUnicoBanco
            // 
            this.dgvResultados_CodigoUnicoBanco.DataPropertyName = "CodigoUnicoBanco";
            this.dgvResultados_CodigoUnicoBanco.HeaderText = "Código Único";
            this.dgvResultados_CodigoUnicoBanco.Name = "dgvResultados_CodigoUnicoBanco";
            this.dgvResultados_CodigoUnicoBanco.ReadOnly = true;
            this.dgvResultados_CodigoUnicoBanco.Width = 120;
            // 
            // dgvResultados_NombreTipoComprobante
            // 
            this.dgvResultados_NombreTipoComprobante.DataPropertyName = "NombreTipoComprobanteRef";
            this.dgvResultados_NombreTipoComprobante.HeaderText = "Tipo Comprobante";
            this.dgvResultados_NombreTipoComprobante.Name = "dgvResultados_NombreTipoComprobante";
            this.dgvResultados_NombreTipoComprobante.ReadOnly = true;
            this.dgvResultados_NombreTipoComprobante.Width = 150;
            // 
            // dgvResultados_SerialSerieComprobanteRef
            // 
            this.dgvResultados_SerialSerieComprobanteRef.DataPropertyName = "SerialSerieComprobanteRef";
            this.dgvResultados_SerialSerieComprobanteRef.HeaderText = "Serie";
            this.dgvResultados_SerialSerieComprobanteRef.Name = "dgvResultados_SerialSerieComprobanteRef";
            this.dgvResultados_SerialSerieComprobanteRef.ReadOnly = true;
            this.dgvResultados_SerialSerieComprobanteRef.Width = 50;
            // 
            // dgvResultados_NroComprobanteComprobanteRef
            // 
            this.dgvResultados_NroComprobanteComprobanteRef.DataPropertyName = "NroComprobanteComprobanteRef";
            dataGridViewCellStyle3.Format = "00000000";
            this.dgvResultados_NroComprobanteComprobanteRef.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResultados_NroComprobanteComprobanteRef.HeaderText = "Número";
            this.dgvResultados_NroComprobanteComprobanteRef.Name = "dgvResultados_NroComprobanteComprobanteRef";
            this.dgvResultados_NroComprobanteComprobanteRef.ReadOnly = true;
            this.dgvResultados_NroComprobanteComprobanteRef.Width = 80;
            // 
            // dgvResultados_FechaEmision
            // 
            this.dgvResultados_FechaEmision.DataPropertyName = "FechaHoraEmision";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy hh:mm:ss";
            this.dgvResultados_FechaEmision.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResultados_FechaEmision.HeaderText = "Fecha Emisión";
            this.dgvResultados_FechaEmision.Name = "dgvResultados_FechaEmision";
            this.dgvResultados_FechaEmision.ReadOnly = true;
            this.dgvResultados_FechaEmision.Width = 120;
            // 
            // dgvResultados_FechaVencimiento
            // 
            this.dgvResultados_FechaVencimiento.DataPropertyName = "FechaVencimiento";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            this.dgvResultados_FechaVencimiento.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResultados_FechaVencimiento.HeaderText = "Fecha Vencimiento";
            this.dgvResultados_FechaVencimiento.Name = "dgvResultados_FechaVencimiento";
            this.dgvResultados_FechaVencimiento.ReadOnly = true;
            this.dgvResultados_FechaVencimiento.Width = 140;
            // 
            // dgvResultados_Dias
            // 
            this.dgvResultados_Dias.DataPropertyName = "Dias";
            this.dgvResultados_Dias.HeaderText = "Días";
            this.dgvResultados_Dias.Name = "dgvResultados_Dias";
            this.dgvResultados_Dias.ReadOnly = true;
            this.dgvResultados_Dias.Width = 60;
            // 
            // dgvResultados_DiasPorVencer
            // 
            this.dgvResultados_DiasPorVencer.DataPropertyName = "DiasPorVencer";
            this.dgvResultados_DiasPorVencer.HeaderText = "Días por vencer";
            this.dgvResultados_DiasPorVencer.Name = "dgvResultados_DiasPorVencer";
            this.dgvResultados_DiasPorVencer.ReadOnly = true;
            this.dgvResultados_DiasPorVencer.Width = 120;
            // 
            // dgvResultados_DiasDeVencido
            // 
            this.dgvResultados_DiasDeVencido.DataPropertyName = "DiasDeVencido";
            this.dgvResultados_DiasDeVencido.HeaderText = "Días de vencido";
            this.dgvResultados_DiasDeVencido.Name = "dgvResultados_DiasDeVencido";
            this.dgvResultados_DiasDeVencido.ReadOnly = true;
            this.dgvResultados_DiasDeVencido.Width = 120;
            // 
            // dgvResultados_TipoDocumentoIdentidadCliente
            // 
            this.dgvResultados_TipoDocumentoIdentidadCliente.DataPropertyName = "DescripcionTipoDocumentoIdentidadCliente";
            this.dgvResultados_TipoDocumentoIdentidadCliente.HeaderText = "Tipo Doc. Identidad";
            this.dgvResultados_TipoDocumentoIdentidadCliente.Name = "dgvResultados_TipoDocumentoIdentidadCliente";
            this.dgvResultados_TipoDocumentoIdentidadCliente.ReadOnly = true;
            this.dgvResultados_TipoDocumentoIdentidadCliente.Width = 140;
            // 
            // dgvResultados_NroDocIdentidadCliente
            // 
            this.dgvResultados_NroDocIdentidadCliente.DataPropertyName = "NroDocumentoIdentidadCliente";
            this.dgvResultados_NroDocIdentidadCliente.HeaderText = "N° Doc. Identidad";
            this.dgvResultados_NroDocIdentidadCliente.Name = "dgvResultados_NroDocIdentidadCliente";
            this.dgvResultados_NroDocIdentidadCliente.ReadOnly = true;
            this.dgvResultados_NroDocIdentidadCliente.Width = 140;
            // 
            // dgvResultados_NombresCliente
            // 
            this.dgvResultados_NombresCliente.DataPropertyName = "NombresCliente";
            this.dgvResultados_NombresCliente.HeaderText = "Nombres Completos";
            this.dgvResultados_NombresCliente.Name = "dgvResultados_NombresCliente";
            this.dgvResultados_NombresCliente.ReadOnly = true;
            this.dgvResultados_NombresCliente.Width = 180;
            // 
            // dgvResultados_StrMoneda
            // 
            this.dgvResultados_StrMoneda.DataPropertyName = "StrMoneda";
            this.dgvResultados_StrMoneda.HeaderText = "Moneda";
            this.dgvResultados_StrMoneda.Name = "dgvResultados_StrMoneda";
            this.dgvResultados_StrMoneda.ReadOnly = true;
            // 
            // dgvResultados_Monto
            // 
            this.dgvResultados_Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#,##0.00";
            this.dgvResultados_Monto.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResultados_Monto.HeaderText = "Monto";
            this.dgvResultados_Monto.Name = "dgvResultados_Monto";
            this.dgvResultados_Monto.ReadOnly = true;
            // 
            // dgvResultados_Mora
            // 
            this.dgvResultados_Mora.DataPropertyName = "Mora";
            dataGridViewCellStyle7.Format = "#,##0.00";
            this.dgvResultados_Mora.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvResultados_Mora.HeaderText = "Mora";
            this.dgvResultados_Mora.Name = "dgvResultados_Mora";
            this.dgvResultados_Mora.ReadOnly = true;
            // 
            // dgvResultados_Protesto
            // 
            this.dgvResultados_Protesto.DataPropertyName = "Protesto";
            dataGridViewCellStyle8.Format = "#,##0.00";
            this.dgvResultados_Protesto.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvResultados_Protesto.HeaderText = "Protesto";
            this.dgvResultados_Protesto.Name = "dgvResultados_Protesto";
            this.dgvResultados_Protesto.ReadOnly = true;
            // 
            // dgvResultados_Total
            // 
            this.dgvResultados_Total.DataPropertyName = "Total";
            dataGridViewCellStyle9.Format = "#,##0.00";
            this.dgvResultados_Total.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvResultados_Total.HeaderText = "Total";
            this.dgvResultados_Total.Name = "dgvResultados_Total";
            this.dgvResultados_Total.ReadOnly = true;
            // 
            // dgvResultados_TotalLetraPadre
            // 
            this.dgvResultados_TotalLetraPadre.DataPropertyName = "TotalLetraPadre";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "#,##0.00";
            this.dgvResultados_TotalLetraPadre.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvResultados_TotalLetraPadre.HeaderText = "Total Anterior";
            this.dgvResultados_TotalLetraPadre.Name = "dgvResultados_TotalLetraPadre";
            this.dgvResultados_TotalLetraPadre.ReadOnly = true;
            // 
            // dgvResultados_TotalLetraInicial
            // 
            this.dgvResultados_TotalLetraInicial.DataPropertyName = "TotalLetraInicial";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "#,##0.00";
            this.dgvResultados_TotalLetraInicial.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvResultados_TotalLetraInicial.HeaderText = "Total Inicial";
            this.dgvResultados_TotalLetraInicial.Name = "dgvResultados_TotalLetraInicial";
            this.dgvResultados_TotalLetraInicial.ReadOnly = true;
            // 
            // dgvResultados_Estado
            // 
            this.dgvResultados_Estado.DataPropertyName = "Estado";
            this.dgvResultados_Estado.HeaderText = "Estado";
            this.dgvResultados_Estado.Name = "dgvResultados_Estado";
            this.dgvResultados_Estado.ReadOnly = true;
            this.dgvResultados_Estado.Visible = false;
            // 
            // dgvResultados_StrEstado
            // 
            this.dgvResultados_StrEstado.DataPropertyName = "StrEstado";
            this.dgvResultados_StrEstado.HeaderText = "Estado";
            this.dgvResultados_StrEstado.Name = "dgvResultados_StrEstado";
            this.dgvResultados_StrEstado.ReadOnly = true;
            // 
            // dgvResultados_FlagCancelado
            // 
            this.dgvResultados_FlagCancelado.DataPropertyName = "FlagCancelado";
            this.dgvResultados_FlagCancelado.HeaderText = "Cancelado";
            this.dgvResultados_FlagCancelado.Name = "dgvResultados_FlagCancelado";
            this.dgvResultados_FlagCancelado.ReadOnly = true;
            // 
            // dgvResultados_FlagActivo
            // 
            this.dgvResultados_FlagActivo.DataPropertyName = "FlagActivo";
            this.dgvResultados_FlagActivo.HeaderText = "Activo";
            this.dgvResultados_FlagActivo.Name = "dgvResultados_FlagActivo";
            this.dgvResultados_FlagActivo.ReadOnly = true;
            this.dgvResultados_FlagActivo.Width = 80;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(557, 119);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkCancelado);
            this.groupBox1.Controls.Add(this.cbbEstado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFiltroFechaEmisionHasta);
            this.groupBox1.Controls.Add(this.dtpFiltroFechaEmisionDesde);
            this.groupBox1.Controls.Add(this.txtFiltroNombresCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFiltroNroDocIdentidadCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFiltroNroComprobante);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkActivo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // chkCancelado
            // 
            this.chkCancelado.AutoSize = true;
            this.chkCancelado.Location = new System.Drawing.Point(536, 37);
            this.chkCancelado.Name = "chkCancelado";
            this.chkCancelado.Size = new System.Drawing.Size(80, 17);
            this.chkCancelado.TabIndex = 5;
            this.chkCancelado.Text = "Cancelado";
            this.chkCancelado.UseVisualStyleBackColor = true;
            // 
            // cbbEstado
            // 
            this.cbbEstado.DisplayMember = "Text";
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(6, 71);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(100, 21);
            this.cbbEstado.TabIndex = 7;
            this.cbbEstado.ValueMember = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Estado";
            // 
            // dtpFiltroFechaEmisionHasta
            // 
            this.dtpFiltroFechaEmisionHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroFechaEmisionHasta.Location = new System.Drawing.Point(112, 33);
            this.dtpFiltroFechaEmisionHasta.Name = "dtpFiltroFechaEmisionHasta";
            this.dtpFiltroFechaEmisionHasta.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltroFechaEmisionHasta.TabIndex = 1;
            // 
            // dtpFiltroFechaEmisionDesde
            // 
            this.dtpFiltroFechaEmisionDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroFechaEmisionDesde.Location = new System.Drawing.Point(6, 33);
            this.dtpFiltroFechaEmisionDesde.Name = "dtpFiltroFechaEmisionDesde";
            this.dtpFiltroFechaEmisionDesde.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltroFechaEmisionDesde.TabIndex = 0;
            // 
            // txtFiltroNombresCliente
            // 
            this.txtFiltroNombresCliente.Location = new System.Drawing.Point(430, 33);
            this.txtFiltroNombresCliente.Name = "txtFiltroNombresCliente";
            this.txtFiltroNombresCliente.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroNombresCliente.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nombres";
            // 
            // txtFiltroNroDocIdentidadCliente
            // 
            this.txtFiltroNroDocIdentidadCliente.Location = new System.Drawing.Point(324, 33);
            this.txtFiltroNroDocIdentidadCliente.Name = "txtFiltroNroDocIdentidadCliente";
            this.txtFiltroNroDocIdentidadCliente.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroNroDocIdentidadCliente.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "N° Doc. Identidad";
            // 
            // txtFiltroNroComprobante
            // 
            this.txtFiltroNroComprobante.Location = new System.Drawing.Point(218, 33);
            this.txtFiltroNroComprobante.Name = "txtFiltroNroComprobante";
            this.txtFiltroNroComprobante.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroNroComprobante.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fec. Emisión Hasta";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(622, 37);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(57, 17);
            this.chkActivo.TabIndex = 6;
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
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.Location = new System.Drawing.Point(638, 119);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // FrmLetra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 290);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmLetra";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Letras";
            this.Load += new System.EventHandler(this.FrmLetra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaEmisionHasta;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaEmisionDesde;
        private System.Windows.Forms.TextBox txtFiltroNombresCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiltroNroDocIdentidadCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFiltroNroComprobante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkCancelado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_CodigoLetra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NumeroLetraInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NombreBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_CodigoUnicoBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NombreTipoComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_SerialSerieComprobanteRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NroComprobanteComprobanteRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_FechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_DiasPorVencer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_DiasDeVencido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_TipoDocumentoIdentidadCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NroDocIdentidadCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NombresCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_StrMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Mora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Protesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_TotalLetraPadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_TotalLetraInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_StrEstado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvResultados_FlagCancelado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvResultados_FlagActivo;
        private System.Windows.Forms.Button btnExportar;
    }
}