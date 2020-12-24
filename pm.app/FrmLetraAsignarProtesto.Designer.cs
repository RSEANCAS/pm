namespace pm.app
{
    partial class FrmLetraAsignarProtesto
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblErrorProtesto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProtesto = new System.Windows.Forms.TextBox();
            this.tltLetra = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(130, 64);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblErrorProtesto
            // 
            this.lblErrorProtesto.AutoSize = true;
            this.lblErrorProtesto.ForeColor = System.Drawing.Color.Red;
            this.lblErrorProtesto.Location = new System.Drawing.Point(12, 48);
            this.lblErrorProtesto.Name = "lblErrorProtesto";
            this.lblErrorProtesto.Size = new System.Drawing.Size(0, 13);
            this.lblErrorProtesto.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Monto a protestar";
            // 
            // txtProtesto
            // 
            this.txtProtesto.Location = new System.Drawing.Point(12, 25);
            this.txtProtesto.Name = "txtProtesto";
            this.txtProtesto.Size = new System.Drawing.Size(193, 20);
            this.txtProtesto.TabIndex = 18;
            // 
            // FrmLetraAsignarProtesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 97);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblErrorProtesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProtesto);
            this.Name = "FrmLetraAsignarProtesto";
            this.Text = "Asignar Protesto";
            this.Load += new System.EventHandler(this.FrmLetraAsignarProtesto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblErrorProtesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProtesto;
        private System.Windows.Forms.ToolTip tltLetra;
    }
}