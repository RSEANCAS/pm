namespace pm.app
{
    partial class FrmCotizacion
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
            this.lblResultados = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.dgvResultados_CodigoCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_FechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_TipoDocumentoIdentidadCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NroDocIdentidadCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NombresCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_TipoDocumentoIdentidadVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NroDocIdentidadVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NombresVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_TipoDocumentoIdentidadSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NroDocIdentidadSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NombresSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_StrMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_TotalImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_FlagActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.lblResultados.TabIndex = 28;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(553, 77);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
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
            this.dgvResultados_CodigoCotizacion,
            this.dgvResultados_Nro,
            this.dgvResultados_Numero,
            this.dgvResultados_FechaEmision,
            this.dgvResultados_NroPedido,
            this.dgvResultados_TipoDocumentoIdentidadCliente,
            this.dgvResultados_NroDocIdentidadCliente,
            this.dgvResultados_NombresCliente,
            this.dgvResultados_TipoDocumentoIdentidadVendedor,
            this.dgvResultados_NroDocIdentidadVendedor,
            this.dgvResultados_NombresVendedor,
            this.dgvResultados_TipoDocumentoIdentidadSupervisor,
            this.dgvResultados_NroDocIdentidadSupervisor,
            this.dgvResultados_NombresSupervisor,
            this.dgvResultados_StrMoneda,
            this.dgvResultados_TotalImporte,
            this.dgvResultados_FlagActivo});
            this.dgvResultados.Location = new System.Drawing.Point(8, 106);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(701, 167);
            this.dgvResultados.TabIndex = 3;
            this.dgvResultados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvResultados_MouseClick);
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
            // dgvResultados_NroPedido
            // 
            this.dgvResultados_NroPedido.DataPropertyName = "NroPedido";
            this.dgvResultados_NroPedido.HeaderText = "N° Pedido";
            this.dgvResultados_NroPedido.Name = "dgvResultados_NroPedido";
            this.dgvResultados_NroPedido.ReadOnly = true;
            // 
            // dgvResultados_TipoDocumentoIdentidadCliente
            // 
            this.dgvResultados_TipoDocumentoIdentidadCliente.DataPropertyName = "DescripcionTipoDocumentoIdentidadCliente";
            this.dgvResultados_TipoDocumentoIdentidadCliente.HeaderText = "Tipo Doc. Identidad Cliente";
            this.dgvResultados_TipoDocumentoIdentidadCliente.Name = "dgvResultados_TipoDocumentoIdentidadCliente";
            this.dgvResultados_TipoDocumentoIdentidadCliente.ReadOnly = true;
            this.dgvResultados_TipoDocumentoIdentidadCliente.Width = 180;
            // 
            // dgvResultados_NroDocIdentidadCliente
            // 
            this.dgvResultados_NroDocIdentidadCliente.DataPropertyName = "NroDocumentoIdentidadCliente";
            this.dgvResultados_NroDocIdentidadCliente.HeaderText = "N° Doc. Identidad Cliente";
            this.dgvResultados_NroDocIdentidadCliente.Name = "dgvResultados_NroDocIdentidadCliente";
            this.dgvResultados_NroDocIdentidadCliente.ReadOnly = true;
            this.dgvResultados_NroDocIdentidadCliente.Width = 170;
            // 
            // dgvResultados_NombresCliente
            // 
            this.dgvResultados_NombresCliente.DataPropertyName = "Cliente";
            this.dgvResultados_NombresCliente.HeaderText = "Nombres Completos Cliente";
            this.dgvResultados_NombresCliente.Name = "dgvResultados_NombresCliente";
            this.dgvResultados_NombresCliente.ReadOnly = true;
            this.dgvResultados_NombresCliente.Width = 230;
            // 
            // dgvResultados_TipoDocumentoIdentidadVendedor
            // 
            this.dgvResultados_TipoDocumentoIdentidadVendedor.DataPropertyName = "DescripcionTipoDocumentoIdentidadVendedor";
            this.dgvResultados_TipoDocumentoIdentidadVendedor.HeaderText = "Tipo Doc. Identidad Vendedor";
            this.dgvResultados_TipoDocumentoIdentidadVendedor.Name = "dgvResultados_TipoDocumentoIdentidadVendedor";
            this.dgvResultados_TipoDocumentoIdentidadVendedor.ReadOnly = true;
            this.dgvResultados_TipoDocumentoIdentidadVendedor.Width = 190;
            // 
            // dgvResultados_NroDocIdentidadVendedor
            // 
            this.dgvResultados_NroDocIdentidadVendedor.DataPropertyName = "NroDocumentoIdentidadVendedor";
            this.dgvResultados_NroDocIdentidadVendedor.HeaderText = "N° Doc. Identidad Vendedor";
            this.dgvResultados_NroDocIdentidadVendedor.Name = "dgvResultados_NroDocIdentidadVendedor";
            this.dgvResultados_NroDocIdentidadVendedor.ReadOnly = true;
            this.dgvResultados_NroDocIdentidadVendedor.Width = 180;
            // 
            // dgvResultados_NombresVendedor
            // 
            this.dgvResultados_NombresVendedor.DataPropertyName = "Vendedor";
            this.dgvResultados_NombresVendedor.HeaderText = "Nombres Completos Vendedor";
            this.dgvResultados_NombresVendedor.Name = "dgvResultados_NombresVendedor";
            this.dgvResultados_NombresVendedor.ReadOnly = true;
            this.dgvResultados_NombresVendedor.Width = 230;
            // 
            // dgvResultados_TipoDocumentoIdentidadSupervisor
            // 
            this.dgvResultados_TipoDocumentoIdentidadSupervisor.DataPropertyName = "DescripcionTipoDocumentoIdentidadSupervisor";
            this.dgvResultados_TipoDocumentoIdentidadSupervisor.HeaderText = "Tipo Doc. Identidad Supervisor";
            this.dgvResultados_TipoDocumentoIdentidadSupervisor.Name = "dgvResultados_TipoDocumentoIdentidadSupervisor";
            this.dgvResultados_TipoDocumentoIdentidadSupervisor.ReadOnly = true;
            this.dgvResultados_TipoDocumentoIdentidadSupervisor.Width = 190;
            // 
            // dgvResultados_NroDocIdentidadSupervisor
            // 
            this.dgvResultados_NroDocIdentidadSupervisor.DataPropertyName = "NroDocumentoIdentidadSupervisor";
            this.dgvResultados_NroDocIdentidadSupervisor.HeaderText = "N° Doc. Identidad Supervisor";
            this.dgvResultados_NroDocIdentidadSupervisor.Name = "dgvResultados_NroDocIdentidadSupervisor";
            this.dgvResultados_NroDocIdentidadSupervisor.ReadOnly = true;
            this.dgvResultados_NroDocIdentidadSupervisor.Width = 180;
            // 
            // dgvResultados_NombresSupervisor
            // 
            this.dgvResultados_NombresSupervisor.DataPropertyName = "Supervisor";
            this.dgvResultados_NombresSupervisor.HeaderText = "Nombres Completos Supervisor";
            this.dgvResultados_NombresSupervisor.Name = "dgvResultados_NombresSupervisor";
            this.dgvResultados_NombresSupervisor.ReadOnly = true;
            this.dgvResultados_NombresSupervisor.Width = 230;
            // 
            // dgvResultados_StrMoneda
            // 
            this.dgvResultados_StrMoneda.DataPropertyName = "StrMoneda";
            this.dgvResultados_StrMoneda.HeaderText = "Moneda";
            this.dgvResultados_StrMoneda.Name = "dgvResultados_StrMoneda";
            this.dgvResultados_StrMoneda.ReadOnly = true;
            // 
            // dgvResultados_TotalImporte
            // 
            this.dgvResultados_TotalImporte.DataPropertyName = "TotalImporte";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,##0.00";
            this.dgvResultados_TotalImporte.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResultados_TotalImporte.HeaderText = "Importe Total";
            this.dgvResultados_TotalImporte.Name = "dgvResultados_TotalImporte";
            this.dgvResultados_TotalImporte.ReadOnly = true;
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
            this.btnBuscar.Location = new System.Drawing.Point(634, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
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
            this.chkActivo.Location = new System.Drawing.Point(536, 37);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(57, 17);
            this.chkActivo.TabIndex = 5;
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
            // FrmCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 281);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCotizacion";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Cotizaciones";
            this.Load += new System.EventHandler(this.FrmCotizacion_Load);
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
        private System.Windows.Forms.TextBox txtFiltroNombresCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiltroNroDocIdentidadCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFiltroNroComprobante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_CodigoCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_FechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_TipoDocumentoIdentidadCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NroDocIdentidadCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NombresCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_TipoDocumentoIdentidadVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NroDocIdentidadVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NombresVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_TipoDocumentoIdentidadSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NroDocIdentidadSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NombresSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_StrMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_TotalImporte;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvResultados_FlagActivo;
    }
}