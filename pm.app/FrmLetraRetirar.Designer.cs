namespace pm.app
{
    partial class FrmLetraRetirar
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
            this.chkRegenerar = new System.Windows.Forms.CheckBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErrorObservacion = new System.Windows.Forms.Label();
            this.tltLetra = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // chkRegenerar
            // 
            this.chkRegenerar.AutoSize = true;
            this.chkRegenerar.Location = new System.Drawing.Point(12, 12);
            this.chkRegenerar.Name = "chkRegenerar";
            this.chkRegenerar.Size = new System.Drawing.Size(79, 17);
            this.chkRegenerar.TabIndex = 0;
            this.chkRegenerar.Text = "Regenerar";
            this.chkRegenerar.UseVisualStyleBackColor = true;
            this.chkRegenerar.CheckedChanged += new System.EventHandler(this.chkRegenerar_CheckedChanged);
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaVencimiento.Enabled = false;
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(12, 48);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(193, 20);
            this.dtpFechaVencimiento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de Vencimiento";
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(130, 195);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(75, 23);
            this.btnRetirar.TabIndex = 3;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(12, 87);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(193, 89);
            this.txtObservacion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Observación";
            // 
            // lblErrorObservacion
            // 
            this.lblErrorObservacion.AutoSize = true;
            this.lblErrorObservacion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorObservacion.Location = new System.Drawing.Point(12, 179);
            this.lblErrorObservacion.Name = "lblErrorObservacion";
            this.lblErrorObservacion.Size = new System.Drawing.Size(0, 13);
            this.lblErrorObservacion.TabIndex = 25;
            // 
            // FrmLetraRetirar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 230);
            this.Controls.Add(this.lblErrorObservacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.chkRegenerar);
            this.Name = "FrmLetraRetirar";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Retirar Letra";
            this.Load += new System.EventHandler(this.FrmLetraRetirar_Load);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkRegenerar;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErrorObservacion;
        private System.Windows.Forms.ToolTip tltLetra;
    }
}