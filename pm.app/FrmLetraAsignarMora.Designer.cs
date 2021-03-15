namespace pm.app
{
    partial class FrmLetraAsignarMora
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
            this.lblErrorMora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMora = new System.Windows.Forms.TextBox();
            this.tltLetra = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(130, 64);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblErrorMora
            // 
            this.lblErrorMora.AutoSize = true;
            this.lblErrorMora.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMora.Location = new System.Drawing.Point(12, 48);
            this.lblErrorMora.Name = "lblErrorMora";
            this.lblErrorMora.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMora.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mora";
            // 
            // txtMora
            // 
            this.txtMora.Location = new System.Drawing.Point(12, 25);
            this.txtMora.Name = "txtMora";
            this.txtMora.Size = new System.Drawing.Size(193, 20);
            this.txtMora.TabIndex = 0;
            // 
            // FrmLetraAsignarMora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 97);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblErrorMora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMora);
            this.Name = "FrmLetraAsignarMora";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Asignar Mora";
            this.Load += new System.EventHandler(this.FrmLetraAsignarMora_Load);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblErrorMora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMora;
        private System.Windows.Forms.ToolTip tltLetra;
    }
}