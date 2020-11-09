namespace pm.app
{
    partial class FrmComprobanteCompra
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
            this.lblResultados = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFiltroSerie = new System.Windows.Forms.TextBox();
            this.dtpFiltroFechaEmisionHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFiltroFechaEmisionDesde = new System.Windows.Forms.DateTimePicker();
            this.txtFiltroNombresProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiltroNroDocIdentidadProveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFiltroNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvResultados_CodigoComprobanteCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_TipoComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_FechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_TipoDocumentoIdentidadCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NroDocIdentidadCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NombresCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_TotalImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_FlagCompleto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvResultados_FlagActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(11, 87);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(0, 13);
            this.lblResultados.TabIndex = 33;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(553, 77);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 32;
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
            this.dgvResultados_CodigoComprobanteCompra,
            this.dgvResultados_Nro,
            this.dgvResultados_TipoComprobante,
            this.dgvResultados_Serie,
            this.dgvResultados_Numero,
            this.dgvResultados_FechaRegistro,
            this.dgvResultados_FechaCompra,
            this.dgvResultados_TipoDocumentoIdentidadCliente,
            this.dgvResultados_NroDocIdentidadCliente,
            this.dgvResultados_NombresCliente,
            this.dgvResultados_TotalImporte,
            this.dgvResultados_FlagCompleto,
            this.dgvResultados_FlagActivo});
            this.dgvResultados.Location = new System.Drawing.Point(8, 106);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(701, 167);
            this.dgvResultados.TabIndex = 31;
            this.dgvResultados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvResultados_MouseClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(634, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtFiltroSerie);
            this.groupBox1.Controls.Add(this.dtpFiltroFechaEmisionHasta);
            this.groupBox1.Controls.Add(this.dtpFiltroFechaEmisionDesde);
            this.groupBox1.Controls.Add(this.txtFiltroNombresProveedor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFiltroNroDocIdentidadProveedor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFiltroNumero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkActivo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 64);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // txtFiltroSerie
            // 
            this.txtFiltroSerie.Location = new System.Drawing.Point(218, 33);
            this.txtFiltroSerie.Name = "txtFiltroSerie";
            this.txtFiltroSerie.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroSerie.TabIndex = 25;
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
            // txtFiltroNombresProveedor
            // 
            this.txtFiltroNombresProveedor.Location = new System.Drawing.Point(536, 33);
            this.txtFiltroNombresProveedor.Name = "txtFiltroNombresProveedor";
            this.txtFiltroNombresProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroNombresProveedor.TabIndex = 22;
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
            // txtFiltroNroDocIdentidadProveedor
            // 
            this.txtFiltroNroDocIdentidadProveedor.Location = new System.Drawing.Point(430, 33);
            this.txtFiltroNroDocIdentidadProveedor.Name = "txtFiltroNroDocIdentidadProveedor";
            this.txtFiltroNroDocIdentidadProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroNroDocIdentidadProveedor.TabIndex = 20;
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
            // txtFiltroNumero
            // 
            this.txtFiltroNumero.Location = new System.Drawing.Point(324, 33);
            this.txtFiltroNumero.Name = "txtFiltroNumero";
            this.txtFiltroNumero.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroNumero.TabIndex = 18;
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
            // dgvResultados_CodigoComprobanteCompra
            // 
            this.dgvResultados_CodigoComprobanteCompra.DataPropertyName = "CodigoComprobanteCompra";
            this.dgvResultados_CodigoComprobanteCompra.HeaderText = "CodigoComprobanteCompra";
            this.dgvResultados_CodigoComprobanteCompra.Name = "dgvResultados_CodigoComprobanteCompra";
            this.dgvResultados_CodigoComprobanteCompra.ReadOnly = true;
            this.dgvResultados_CodigoComprobanteCompra.Visible = false;
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
            this.dgvResultados_Numero.DataPropertyName = "Numero";
            dataGridViewCellStyle1.Format = "00000000";
            this.dgvResultados_Numero.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultados_Numero.HeaderText = "Número";
            this.dgvResultados_Numero.Name = "dgvResultados_Numero";
            this.dgvResultados_Numero.ReadOnly = true;
            this.dgvResultados_Numero.Width = 80;
            // 
            // dgvResultados_FechaRegistro
            // 
            this.dgvResultados_FechaRegistro.DataPropertyName = "FechaHoraRegistro";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy hh:mm:ss";
            this.dgvResultados_FechaRegistro.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultados_FechaRegistro.HeaderText = "Fecha Registro";
            this.dgvResultados_FechaRegistro.Name = "dgvResultados_FechaRegistro";
            this.dgvResultados_FechaRegistro.ReadOnly = true;
            this.dgvResultados_FechaRegistro.Width = 120;
            // 
            // dgvResultados_FechaCompra
            // 
            this.dgvResultados_FechaCompra.DataPropertyName = "FechaCompra";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.dgvResultados_FechaCompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResultados_FechaCompra.HeaderText = "Fecha Compra";
            this.dgvResultados_FechaCompra.Name = "dgvResultados_FechaCompra";
            this.dgvResultados_FechaCompra.ReadOnly = true;
            this.dgvResultados_FechaCompra.Width = 126;
            // 
            // dgvResultados_TipoDocumentoIdentidadCliente
            // 
            this.dgvResultados_TipoDocumentoIdentidadCliente.DataPropertyName = "DescripcionTipoDocumentoIdentidadProveedor";
            this.dgvResultados_TipoDocumentoIdentidadCliente.HeaderText = "Tipo Doc. Identidad Proveedor";
            this.dgvResultados_TipoDocumentoIdentidadCliente.Name = "dgvResultados_TipoDocumentoIdentidadCliente";
            this.dgvResultados_TipoDocumentoIdentidadCliente.ReadOnly = true;
            this.dgvResultados_TipoDocumentoIdentidadCliente.Width = 200;
            // 
            // dgvResultados_NroDocIdentidadCliente
            // 
            this.dgvResultados_NroDocIdentidadCliente.DataPropertyName = "NroDocumentoIdentidadProveedor";
            this.dgvResultados_NroDocIdentidadCliente.HeaderText = "N° Doc. Identidad Proveedor";
            this.dgvResultados_NroDocIdentidadCliente.Name = "dgvResultados_NroDocIdentidadCliente";
            this.dgvResultados_NroDocIdentidadCliente.ReadOnly = true;
            this.dgvResultados_NroDocIdentidadCliente.Width = 200;
            // 
            // dgvResultados_NombresCliente
            // 
            this.dgvResultados_NombresCliente.DataPropertyName = "Proveedor";
            this.dgvResultados_NombresCliente.HeaderText = "Nombres Completos Proveedor";
            this.dgvResultados_NombresCliente.Name = "dgvResultados_NombresCliente";
            this.dgvResultados_NombresCliente.ReadOnly = true;
            this.dgvResultados_NombresCliente.Width = 250;
            // 
            // dgvResultados_TotalImporte
            // 
            this.dgvResultados_TotalImporte.DataPropertyName = "TotalImporte";
            dataGridViewCellStyle4.Format = "#,##0.00";
            this.dgvResultados_TotalImporte.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResultados_TotalImporte.HeaderText = "Total Importe";
            this.dgvResultados_TotalImporte.Name = "dgvResultados_TotalImporte";
            this.dgvResultados_TotalImporte.ReadOnly = true;
            // 
            // dgvResultados_FlagCompleto
            // 
            this.dgvResultados_FlagCompleto.DataPropertyName = "FlagCompleto";
            this.dgvResultados_FlagCompleto.HeaderText = "¿Está completo?";
            this.dgvResultados_FlagCompleto.Name = "dgvResultados_FlagCompleto";
            this.dgvResultados_FlagCompleto.ReadOnly = true;
            this.dgvResultados_FlagCompleto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultados_FlagCompleto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvResultados_FlagCompleto.Width = 120;
            // 
            // dgvResultados_FlagActivo
            // 
            this.dgvResultados_FlagActivo.DataPropertyName = "FlagActivo";
            this.dgvResultados_FlagActivo.HeaderText = "Activo";
            this.dgvResultados_FlagActivo.Name = "dgvResultados_FlagActivo";
            this.dgvResultados_FlagActivo.ReadOnly = true;
            this.dgvResultados_FlagActivo.Width = 80;
            // 
            // FrmComprobanteCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 281);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.Name = "FrmComprobanteCompra";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Comprobantes de Compra";
            this.Load += new System.EventHandler(this.FrmComprobanteCompra_Load);
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
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaEmisionHasta;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaEmisionDesde;
        private System.Windows.Forms.TextBox txtFiltroNombresProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiltroNroDocIdentidadProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFiltroNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltroSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_CodigoComprobanteCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_TipoComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_FechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_TipoDocumentoIdentidadCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NroDocIdentidadCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NombresCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_TotalImporte;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvResultados_FlagCompleto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvResultados_FlagActivo;
    }
}