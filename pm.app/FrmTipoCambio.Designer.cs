namespace pm.app
{
    partial class FrmTipoCambio
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFiltroFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFiltroFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvResultados_CodigoTipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_FechaCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_ValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_ValorVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblResultados.TabIndex = 38;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(557, 82);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 37;
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
            this.dgvResultados_CodigoTipoCambio,
            this.dgvResultados_FechaCambio,
            this.dgvResultados_ValorCompra,
            this.dgvResultados_ValorVenta});
            this.dgvResultados.Location = new System.Drawing.Point(12, 111);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(701, 167);
            this.dgvResultados.TabIndex = 36;
            this.dgvResultados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvResultados_MouseClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(638, 82);
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
            this.groupBox1.Controls.Add(this.dtpFiltroFechaHasta);
            this.groupBox1.Controls.Add(this.dtpFiltroFechaDesde);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 64);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // dtpFiltroFechaHasta
            // 
            this.dtpFiltroFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroFechaHasta.Location = new System.Drawing.Point(112, 33);
            this.dtpFiltroFechaHasta.Name = "dtpFiltroFechaHasta";
            this.dtpFiltroFechaHasta.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltroFechaHasta.TabIndex = 24;
            // 
            // dtpFiltroFechaDesde
            // 
            this.dtpFiltroFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroFechaDesde.Location = new System.Drawing.Point(6, 33);
            this.dtpFiltroFechaDesde.Name = "dtpFiltroFechaDesde";
            this.dtpFiltroFechaDesde.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltroFechaDesde.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Desde";
            // 
            // dgvResultados_CodigoTipoCambio
            // 
            this.dgvResultados_CodigoTipoCambio.DataPropertyName = "CodigoTipoCambio";
            this.dgvResultados_CodigoTipoCambio.HeaderText = "CodigoTipoCambio";
            this.dgvResultados_CodigoTipoCambio.Name = "dgvResultados_CodigoTipoCambio";
            this.dgvResultados_CodigoTipoCambio.ReadOnly = true;
            this.dgvResultados_CodigoTipoCambio.Visible = false;
            // 
            // dgvResultados_FechaCambio
            // 
            this.dgvResultados_FechaCambio.DataPropertyName = "FechaCambio";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy hh:mm:ss";
            this.dgvResultados_FechaCambio.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultados_FechaCambio.HeaderText = "Fecha";
            this.dgvResultados_FechaCambio.Name = "dgvResultados_FechaCambio";
            this.dgvResultados_FechaCambio.ReadOnly = true;
            // 
            // dgvResultados_ValorCompra
            // 
            this.dgvResultados_ValorCompra.DataPropertyName = "ValorCompra";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "#,##0.00";
            this.dgvResultados_ValorCompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultados_ValorCompra.HeaderText = "Valor Compra";
            this.dgvResultados_ValorCompra.Name = "dgvResultados_ValorCompra";
            this.dgvResultados_ValorCompra.ReadOnly = true;
            // 
            // dgvResultados_ValorVenta
            // 
            this.dgvResultados_ValorVenta.DataPropertyName = "ValorVenta";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,##0.00";
            this.dgvResultados_ValorVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResultados_ValorVenta.HeaderText = "Valor Venta";
            this.dgvResultados_ValorVenta.Name = "dgvResultados_ValorVenta";
            this.dgvResultados_ValorVenta.ReadOnly = true;
            // 
            // FrmTipoCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 290);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTipoCambio";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmTipoCambio";
            this.Load += new System.EventHandler(this.FrmTipoCambio_Load);
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
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_CodigoTipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_FechaCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_ValorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_ValorVenta;
    }
}