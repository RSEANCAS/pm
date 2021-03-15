namespace pm.app
{
    partial class FrmMantenimientoSerie
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblErrorValorActual = new System.Windows.Forms.Label();
            this.txtValorActual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbCodigoTipoComprobante = new System.Windows.Forms.ComboBox();
            this.lblErrorCodigoTipoComprobante = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErrorValorFinal = new System.Windows.Forms.Label();
            this.lblErrorValorInicial = new System.Windows.Forms.Label();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorInicial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblErrorSerial = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tltSerie = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(297, 199);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblErrorValorActual);
            this.groupBox1.Controls.Add(this.txtValorActual);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbbCodigoTipoComprobante);
            this.groupBox1.Controls.Add(this.lblErrorCodigoTipoComprobante);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblErrorValorFinal);
            this.groupBox1.Controls.Add(this.lblErrorValorInicial);
            this.groupBox1.Controls.Add(this.txtValorFinal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtValorInicial);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblErrorSerial);
            this.groupBox1.Controls.Add(this.txtSerial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // lblErrorValorActual
            // 
            this.lblErrorValorActual.AutoSize = true;
            this.lblErrorValorActual.ForeColor = System.Drawing.Color.Red;
            this.lblErrorValorActual.Location = new System.Drawing.Point(6, 162);
            this.lblErrorValorActual.Name = "lblErrorValorActual";
            this.lblErrorValorActual.Size = new System.Drawing.Size(0, 13);
            this.lblErrorValorActual.TabIndex = 38;
            // 
            // txtValorActual
            // 
            this.txtValorActual.Location = new System.Drawing.Point(9, 138);
            this.txtValorActual.Name = "txtValorActual";
            this.txtValorActual.Size = new System.Drawing.Size(168, 20);
            this.txtValorActual.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Valor Actual";
            // 
            // cbbCodigoTipoComprobante
            // 
            this.cbbCodigoTipoComprobante.DisplayMember = "Nombre";
            this.cbbCodigoTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoTipoComprobante.FormattingEnabled = true;
            this.cbbCodigoTipoComprobante.Location = new System.Drawing.Point(9, 32);
            this.cbbCodigoTipoComprobante.Name = "cbbCodigoTipoComprobante";
            this.cbbCodigoTipoComprobante.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoTipoComprobante.TabIndex = 0;
            this.cbbCodigoTipoComprobante.ValueMember = "CodigoTipoComprobante";
            // 
            // lblErrorCodigoTipoComprobante
            // 
            this.lblErrorCodigoTipoComprobante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCodigoTipoComprobante.AutoSize = true;
            this.lblErrorCodigoTipoComprobante.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoTipoComprobante.Location = new System.Drawing.Point(6, 56);
            this.lblErrorCodigoTipoComprobante.Name = "lblErrorCodigoTipoComprobante";
            this.lblErrorCodigoTipoComprobante.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoTipoComprobante.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tipo Comprobante";
            // 
            // lblErrorValorFinal
            // 
            this.lblErrorValorFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorValorFinal.AutoSize = true;
            this.lblErrorValorFinal.ForeColor = System.Drawing.Color.Red;
            this.lblErrorValorFinal.Location = new System.Drawing.Point(180, 109);
            this.lblErrorValorFinal.Name = "lblErrorValorFinal";
            this.lblErrorValorFinal.Size = new System.Drawing.Size(0, 13);
            this.lblErrorValorFinal.TabIndex = 31;
            // 
            // lblErrorValorInicial
            // 
            this.lblErrorValorInicial.AutoSize = true;
            this.lblErrorValorInicial.ForeColor = System.Drawing.Color.Red;
            this.lblErrorValorInicial.Location = new System.Drawing.Point(6, 109);
            this.lblErrorValorInicial.Name = "lblErrorValorInicial";
            this.lblErrorValorInicial.Size = new System.Drawing.Size(0, 13);
            this.lblErrorValorInicial.TabIndex = 30;
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorFinal.Location = new System.Drawing.Point(183, 85);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.Size = new System.Drawing.Size(168, 20);
            this.txtValorFinal.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Valor Final";
            // 
            // txtValorInicial
            // 
            this.txtValorInicial.Location = new System.Drawing.Point(9, 85);
            this.txtValorInicial.Name = "txtValorInicial";
            this.txtValorInicial.Size = new System.Drawing.Size(168, 20);
            this.txtValorInicial.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Valor Inicial";
            // 
            // lblErrorSerial
            // 
            this.lblErrorSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorSerial.AutoSize = true;
            this.lblErrorSerial.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSerial.Location = new System.Drawing.Point(180, 56);
            this.lblErrorSerial.Name = "lblErrorSerial";
            this.lblErrorSerial.Size = new System.Drawing.Size(0, 13);
            this.lblErrorSerial.TabIndex = 20;
            // 
            // txtSerial
            // 
            this.txtSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerial.Location = new System.Drawing.Point(183, 32);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(168, 20);
            this.txtSerial.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Serial";
            // 
            // FrmMantenimientoSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 234);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMantenimientoSerie";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMantenimientoSerie";
            this.Load += new System.EventHandler(this.FrmMantenimientoSerie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblErrorSerial;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbCodigoTipoComprobante;
        private System.Windows.Forms.Label lblErrorCodigoTipoComprobante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErrorValorFinal;
        private System.Windows.Forms.Label lblErrorValorInicial;
        private System.Windows.Forms.TextBox txtValorFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblErrorValorActual;
        private System.Windows.Forms.TextBox txtValorActual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip tltSerie;
    }
}