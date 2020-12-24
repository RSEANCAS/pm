namespace pm.app
{
    partial class FrmComprobantePago
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblResultados = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbFiltroCodigoSerie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFiltroFechaPagoHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFiltroFechaPagoDesde = new System.Windows.Forms.DateTimePicker();
            this.txtFiltroNombresCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiltroNroDocIdentidadCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFiltroNroComprobante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAnulado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvResultados_CodigoComprobantePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_FechaHoraPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_SerialSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NroComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_TipoDocumentoIdentidadCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NroDocIdentidadCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NombresCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_StrMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(557, 77);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 38;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(15, 87);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(0, 13);
            this.lblResultados.TabIndex = 37;
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
            this.dgvResultados_CodigoComprobantePago,
            this.dgvResultados_Nro,
            this.dgvResultados_FechaHoraPago,
            this.dgvResultados_SerialSerie,
            this.dgvResultados_NroComprobante,
            this.dgvResultados_TipoDocumentoIdentidadCliente,
            this.dgvResultados_NroDocIdentidadCliente,
            this.dgvResultados_NombresCliente,
            this.dgvResultados_StrMoneda,
            this.dgvResultados_Monto});
            this.dgvResultados.Location = new System.Drawing.Point(12, 106);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(701, 172);
            this.dgvResultados.TabIndex = 36;
            this.dgvResultados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvResultados_MouseClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(638, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbbFiltroCodigoSerie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFiltroFechaPagoHasta);
            this.groupBox1.Controls.Add(this.dtpFiltroFechaPagoDesde);
            this.groupBox1.Controls.Add(this.txtFiltroNombresCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFiltroNroDocIdentidadCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFiltroNroComprobante);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkAnulado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 59);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // cbbFiltroCodigoSerie
            // 
            this.cbbFiltroCodigoSerie.DisplayMember = "Serial";
            this.cbbFiltroCodigoSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFiltroCodigoSerie.FormattingEnabled = true;
            this.cbbFiltroCodigoSerie.Location = new System.Drawing.Point(218, 32);
            this.cbbFiltroCodigoSerie.Name = "cbbFiltroCodigoSerie";
            this.cbbFiltroCodigoSerie.Size = new System.Drawing.Size(100, 21);
            this.cbbFiltroCodigoSerie.TabIndex = 27;
            this.cbbFiltroCodigoSerie.ValueMember = "CodigoSerie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Serie";
            // 
            // dtpFiltroFechaPagoHasta
            // 
            this.dtpFiltroFechaPagoHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroFechaPagoHasta.Location = new System.Drawing.Point(112, 33);
            this.dtpFiltroFechaPagoHasta.Name = "dtpFiltroFechaPagoHasta";
            this.dtpFiltroFechaPagoHasta.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltroFechaPagoHasta.TabIndex = 24;
            // 
            // dtpFiltroFechaPagoDesde
            // 
            this.dtpFiltroFechaPagoDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroFechaPagoDesde.Location = new System.Drawing.Point(6, 33);
            this.dtpFiltroFechaPagoDesde.Name = "dtpFiltroFechaPagoDesde";
            this.dtpFiltroFechaPagoDesde.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltroFechaPagoDesde.TabIndex = 23;
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
            this.label5.Size = new System.Drawing.Size(98, 13);
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
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fec. Pago Hasta";
            // 
            // chkAnulado
            // 
            this.chkAnulado.AutoSize = true;
            this.chkAnulado.Location = new System.Drawing.Point(638, 37);
            this.chkAnulado.Name = "chkAnulado";
            this.chkAnulado.Size = new System.Drawing.Size(70, 17);
            this.chkAnulado.TabIndex = 12;
            this.chkAnulado.Text = "Anulado";
            this.chkAnulado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fec. Pago Desde";
            // 
            // dgvResultados_CodigoComprobantePago
            // 
            this.dgvResultados_CodigoComprobantePago.DataPropertyName = "CodigoComprobantePago";
            this.dgvResultados_CodigoComprobantePago.HeaderText = "CodigoComprobantePago";
            this.dgvResultados_CodigoComprobantePago.Name = "dgvResultados_CodigoComprobantePago";
            this.dgvResultados_CodigoComprobantePago.ReadOnly = true;
            this.dgvResultados_CodigoComprobantePago.Visible = false;
            // 
            // dgvResultados_Nro
            // 
            this.dgvResultados_Nro.DataPropertyName = "Fila";
            this.dgvResultados_Nro.HeaderText = "N°";
            this.dgvResultados_Nro.Name = "dgvResultados_Nro";
            this.dgvResultados_Nro.ReadOnly = true;
            this.dgvResultados_Nro.Width = 44;
            // 
            // dgvResultados_FechaHoraPago
            // 
            this.dgvResultados_FechaHoraPago.DataPropertyName = "FechaHoraPago";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.dgvResultados_FechaHoraPago.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultados_FechaHoraPago.HeaderText = "Fecha Pago";
            this.dgvResultados_FechaHoraPago.Name = "dgvResultados_FechaHoraPago";
            this.dgvResultados_FechaHoraPago.ReadOnly = true;
            // 
            // dgvResultados_SerialSerie
            // 
            this.dgvResultados_SerialSerie.DataPropertyName = "SerialSerie";
            this.dgvResultados_SerialSerie.HeaderText = "Serie";
            this.dgvResultados_SerialSerie.Name = "dgvResultados_SerialSerie";
            this.dgvResultados_SerialSerie.ReadOnly = true;
            // 
            // dgvResultados_NroComprobante
            // 
            this.dgvResultados_NroComprobante.DataPropertyName = "NroComprobante";
            this.dgvResultados_NroComprobante.HeaderText = "N° Comprobante";
            this.dgvResultados_NroComprobante.Name = "dgvResultados_NroComprobante";
            this.dgvResultados_NroComprobante.ReadOnly = true;
            this.dgvResultados_NroComprobante.Width = 120;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "#,##0.00";
            this.dgvResultados_Monto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultados_Monto.HeaderText = "Monto";
            this.dgvResultados_Monto.Name = "dgvResultados_Monto";
            this.dgvResultados_Monto.ReadOnly = true;
            // 
            // FrmComprobantePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 290);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmComprobantePago";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Comprobantes de Pago";
            this.Load += new System.EventHandler(this.FrmComprobantePago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbFiltroCodigoSerie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaPagoHasta;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaPagoDesde;
        private System.Windows.Forms.TextBox txtFiltroNombresCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiltroNroDocIdentidadCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFiltroNroComprobante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAnulado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_CodigoComprobantePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_FechaHoraPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_SerialSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NroComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_TipoDocumentoIdentidadCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NroDocIdentidadCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NombresCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_StrMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Monto;
    }
}