namespace pm.app
{
    partial class FrmReporteComisiones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFiltroFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFiltroFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.txtFiltroNombresPersonal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiltroNroDocIdentidadPersonal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerReporte = new System.Windows.Forms.Button();
            this.rpvReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtpFiltroFechaHasta);
            this.groupBox1.Controls.Add(this.dtpFiltroFechaDesde);
            this.groupBox1.Controls.Add(this.txtFiltroNombresPersonal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFiltroNroDocIdentidadPersonal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 62);
            this.groupBox1.TabIndex = 25;
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
            // txtFiltroNombresPersonal
            // 
            this.txtFiltroNombresPersonal.Location = new System.Drawing.Point(324, 33);
            this.txtFiltroNombresPersonal.Name = "txtFiltroNombresPersonal";
            this.txtFiltroNombresPersonal.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroNombresPersonal.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nombres";
            // 
            // txtFiltroNroDocIdentidadPersonal
            // 
            this.txtFiltroNroDocIdentidadPersonal.Location = new System.Drawing.Point(218, 33);
            this.txtFiltroNroDocIdentidadPersonal.Name = "txtFiltroNroDocIdentidadPersonal";
            this.txtFiltroNroDocIdentidadPersonal.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroNroDocIdentidadPersonal.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "N° Doc. Identidad";
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
            // btnVerReporte
            // 
            this.btnVerReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerReporte.Location = new System.Drawing.Point(625, 80);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(88, 23);
            this.btnVerReporte.TabIndex = 26;
            this.btnVerReporte.Text = "Ver Reporte";
            this.btnVerReporte.UseVisualStyleBackColor = true;
            this.btnVerReporte.Click += new System.EventHandler(this.btnVerReporte_Click);
            // 
            // rpvReporte
            // 
            this.rpvReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpvReporte.LocalReport.ReportEmbeddedResource = "pm.app.App_Data.rdlc.rptReporteComision.rdlc";
            this.rpvReporte.Location = new System.Drawing.Point(12, 109);
            this.rpvReporte.Name = "rpvReporte";
            this.rpvReporte.ServerReport.BearerToken = null;
            this.rpvReporte.Size = new System.Drawing.Size(701, 169);
            this.rpvReporte.TabIndex = 27;
            // 
            // FrmReporteComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 290);
            this.Controls.Add(this.rpvReporte);
            this.Controls.Add(this.btnVerReporte);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmReporteComisiones";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Reporte de Comisiones";
            this.Load += new System.EventHandler(this.FrmReporteComisiones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaDesde;
        private System.Windows.Forms.TextBox txtFiltroNombresPersonal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiltroNroDocIdentidadPersonal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerReporte;
        private Microsoft.Reporting.WinForms.ReportViewer rpvReporte;
    }
}