namespace pm.app
{
    partial class FrmFormatoLetra
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
            this.rpvReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvReporte
            // 
            this.rpvReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvReporte.LocalReport.ReportEmbeddedResource = "pm.app.App_Data.rdlc.rptFormatoLetra.rdlc";
            this.rpvReporte.Location = new System.Drawing.Point(0, 0);
            this.rpvReporte.Name = "rpvReporte";
            this.rpvReporte.ServerReport.BearerToken = null;
            this.rpvReporte.Size = new System.Drawing.Size(717, 281);
            this.rpvReporte.TabIndex = 0;
            // 
            // FrmFormatoLetra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 281);
            this.Controls.Add(this.rpvReporte);
            this.Name = "FrmFormatoLetra";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmFormatoLetra";
            this.Load += new System.EventHandler(this.FrmFormatoLetra_Load);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvReporte;
    }
}