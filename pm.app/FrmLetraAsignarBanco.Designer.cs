namespace pm.app
{
    partial class FrmLetraAsignarBanco
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
            this.cbbCodigoBanco = new System.Windows.Forms.ComboBox();
            this.txtCodigoUnico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErrorCodigoBanco = new System.Windows.Forms.Label();
            this.lblErrorCodigoUnico = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tltLetra = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbCodigoBanco
            // 
            this.cbbCodigoBanco.DisplayMember = "Nombre";
            this.cbbCodigoBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoBanco.FormattingEnabled = true;
            this.cbbCodigoBanco.Location = new System.Drawing.Point(12, 25);
            this.cbbCodigoBanco.Name = "cbbCodigoBanco";
            this.cbbCodigoBanco.Size = new System.Drawing.Size(193, 21);
            this.cbbCodigoBanco.TabIndex = 0;
            this.cbbCodigoBanco.ValueMember = "CodigoBanco";
            // 
            // txtCodigoUnico
            // 
            this.txtCodigoUnico.Location = new System.Drawing.Point(12, 78);
            this.txtCodigoUnico.Name = "txtCodigoUnico";
            this.txtCodigoUnico.Size = new System.Drawing.Size(193, 20);
            this.txtCodigoUnico.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Banco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código Único Pago";
            // 
            // lblErrorCodigoBanco
            // 
            this.lblErrorCodigoBanco.AutoSize = true;
            this.lblErrorCodigoBanco.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoBanco.Location = new System.Drawing.Point(12, 49);
            this.lblErrorCodigoBanco.Name = "lblErrorCodigoBanco";
            this.lblErrorCodigoBanco.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoBanco.TabIndex = 15;
            // 
            // lblErrorCodigoUnico
            // 
            this.lblErrorCodigoUnico.AutoSize = true;
            this.lblErrorCodigoUnico.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoUnico.Location = new System.Drawing.Point(12, 101);
            this.lblErrorCodigoUnico.Name = "lblErrorCodigoUnico";
            this.lblErrorCodigoUnico.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoUnico.TabIndex = 16;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(130, 117);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmLetraAsignarBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 151);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblErrorCodigoUnico);
            this.Controls.Add(this.lblErrorCodigoBanco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoUnico);
            this.Controls.Add(this.cbbCodigoBanco);
            this.Name = "FrmLetraAsignarBanco";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Asignar Banco";
            this.Load += new System.EventHandler(this.FrmLetraAsignarBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCodigoBanco;
        private System.Windows.Forms.TextBox txtCodigoUnico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErrorCodigoBanco;
        private System.Windows.Forms.Label lblErrorCodigoUnico;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ToolTip tltLetra;
    }
}