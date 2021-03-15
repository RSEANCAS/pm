namespace pm.app
{
    partial class FrmLetraRegenerar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbCodigoMoneda = new System.Windows.Forms.ComboBox();
            this.lblErrorAval = new System.Windows.Forms.Label();
            this.txtAval = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHoraEmision = new System.Windows.Forms.DateTimePicker();
            this.lblErrorComprobanteRef = new System.Windows.Forms.Label();
            this.txtComprobanteRef = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblErrorMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbCodigoTipoComprobanteRef = new System.Windows.Forms.ComboBox();
            this.lblErrorFechaHoraEmision = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblErrorCodigoMoneda = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblErrorCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblErrorCodigoTipoComprobanteRef = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblErrorFechaVencimiento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tltLetra = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbCodigoMoneda);
            this.groupBox1.Controls.Add(this.lblErrorAval);
            this.groupBox1.Controls.Add(this.txtAval);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtpFechaVencimiento);
            this.groupBox1.Controls.Add(this.dtpFechaHoraEmision);
            this.groupBox1.Controls.Add(this.lblErrorComprobanteRef);
            this.groupBox1.Controls.Add(this.txtComprobanteRef);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblErrorMonto);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbCodigoTipoComprobanteRef);
            this.groupBox1.Controls.Add(this.lblErrorFechaHoraEmision);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblErrorCodigoMoneda);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblErrorCliente);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblErrorCodigoTipoComprobanteRef);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblErrorFechaVencimiento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Detalle";
            // 
            // cbbCodigoMoneda
            // 
            this.cbbCodigoMoneda.DisplayMember = "Text";
            this.cbbCodigoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoMoneda.Enabled = false;
            this.cbbCodigoMoneda.FormattingEnabled = true;
            this.cbbCodigoMoneda.Location = new System.Drawing.Point(9, 244);
            this.cbbCodigoMoneda.Name = "cbbCodigoMoneda";
            this.cbbCodigoMoneda.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoMoneda.TabIndex = 6;
            this.cbbCodigoMoneda.ValueMember = "Value";
            // 
            // lblErrorAval
            // 
            this.lblErrorAval.AutoSize = true;
            this.lblErrorAval.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAval.Location = new System.Drawing.Point(6, 215);
            this.lblErrorAval.Name = "lblErrorAval";
            this.lblErrorAval.Size = new System.Drawing.Size(0, 13);
            this.lblErrorAval.TabIndex = 143;
            // 
            // txtAval
            // 
            this.txtAval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAval.Location = new System.Drawing.Point(9, 191);
            this.txtAval.Name = "txtAval";
            this.txtAval.ReadOnly = true;
            this.txtAval.Size = new System.Drawing.Size(342, 20);
            this.txtAval.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 142;
            this.label10.Text = "Aval";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(183, 32);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(168, 20);
            this.dtpFechaVencimiento.TabIndex = 1;
            // 
            // dtpFechaHoraEmision
            // 
            this.dtpFechaHoraEmision.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpFechaHoraEmision.Enabled = false;
            this.dtpFechaHoraEmision.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHoraEmision.Location = new System.Drawing.Point(9, 32);
            this.dtpFechaHoraEmision.Name = "dtpFechaHoraEmision";
            this.dtpFechaHoraEmision.Size = new System.Drawing.Size(168, 20);
            this.dtpFechaHoraEmision.TabIndex = 0;
            // 
            // lblErrorComprobanteRef
            // 
            this.lblErrorComprobanteRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorComprobanteRef.AutoSize = true;
            this.lblErrorComprobanteRef.ForeColor = System.Drawing.Color.Red;
            this.lblErrorComprobanteRef.Location = new System.Drawing.Point(180, 109);
            this.lblErrorComprobanteRef.Name = "lblErrorComprobanteRef";
            this.lblErrorComprobanteRef.Size = new System.Drawing.Size(0, 13);
            this.lblErrorComprobanteRef.TabIndex = 132;
            // 
            // txtComprobanteRef
            // 
            this.txtComprobanteRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComprobanteRef.Location = new System.Drawing.Point(183, 85);
            this.txtComprobanteRef.Name = "txtComprobanteRef";
            this.txtComprobanteRef.ReadOnly = true;
            this.txtComprobanteRef.Size = new System.Drawing.Size(168, 20);
            this.txtComprobanteRef.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 131;
            this.label8.Text = "Comprobante";
            // 
            // lblErrorMonto
            // 
            this.lblErrorMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorMonto.AutoSize = true;
            this.lblErrorMonto.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMonto.Location = new System.Drawing.Point(180, 268);
            this.lblErrorMonto.Name = "lblErrorMonto";
            this.lblErrorMonto.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMonto.TabIndex = 129;
            // 
            // txtMonto
            // 
            this.txtMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMonto.Location = new System.Drawing.Point(183, 244);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(168, 20);
            this.txtMonto.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 128;
            this.label6.Text = "Monto";
            // 
            // cbbCodigoTipoComprobanteRef
            // 
            this.cbbCodigoTipoComprobanteRef.DisplayMember = "Text";
            this.cbbCodigoTipoComprobanteRef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoTipoComprobanteRef.Enabled = false;
            this.cbbCodigoTipoComprobanteRef.FormattingEnabled = true;
            this.cbbCodigoTipoComprobanteRef.Location = new System.Drawing.Point(9, 85);
            this.cbbCodigoTipoComprobanteRef.Name = "cbbCodigoTipoComprobanteRef";
            this.cbbCodigoTipoComprobanteRef.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoTipoComprobanteRef.TabIndex = 2;
            this.cbbCodigoTipoComprobanteRef.ValueMember = "Value";
            // 
            // lblErrorFechaHoraEmision
            // 
            this.lblErrorFechaHoraEmision.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorFechaHoraEmision.AutoSize = true;
            this.lblErrorFechaHoraEmision.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFechaHoraEmision.Location = new System.Drawing.Point(6, 56);
            this.lblErrorFechaHoraEmision.Name = "lblErrorFechaHoraEmision";
            this.lblErrorFechaHoraEmision.Size = new System.Drawing.Size(0, 13);
            this.lblErrorFechaHoraEmision.TabIndex = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 124;
            this.label4.Text = "Fecha y Hora de emisión";
            // 
            // lblErrorCodigoMoneda
            // 
            this.lblErrorCodigoMoneda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCodigoMoneda.AutoSize = true;
            this.lblErrorCodigoMoneda.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoMoneda.Location = new System.Drawing.Point(6, 268);
            this.lblErrorCodigoMoneda.Name = "lblErrorCodigoMoneda";
            this.lblErrorCodigoMoneda.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoMoneda.TabIndex = 119;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 117;
            this.label7.Text = "Moneda";
            // 
            // lblErrorCliente
            // 
            this.lblErrorCliente.AutoSize = true;
            this.lblErrorCliente.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCliente.Location = new System.Drawing.Point(6, 162);
            this.lblErrorCliente.Name = "lblErrorCliente";
            this.lblErrorCliente.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCliente.TabIndex = 103;
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.Location = new System.Drawing.Point(9, 138);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(342, 20);
            this.txtCliente.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 102;
            this.label9.Text = "Cliente";
            // 
            // lblErrorCodigoTipoComprobanteRef
            // 
            this.lblErrorCodigoTipoComprobanteRef.AutoSize = true;
            this.lblErrorCodigoTipoComprobanteRef.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoTipoComprobanteRef.Location = new System.Drawing.Point(6, 109);
            this.lblErrorCodigoTipoComprobanteRef.Name = "lblErrorCodigoTipoComprobanteRef";
            this.lblErrorCodigoTipoComprobanteRef.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoTipoComprobanteRef.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Tipo Comprobante";
            // 
            // lblErrorFechaVencimiento
            // 
            this.lblErrorFechaVencimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorFechaVencimiento.AutoSize = true;
            this.lblErrorFechaVencimiento.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFechaVencimiento.Location = new System.Drawing.Point(180, 56);
            this.lblErrorFechaVencimiento.Name = "lblErrorFechaVencimiento";
            this.lblErrorFechaVencimiento.Size = new System.Drawing.Size(0, 13);
            this.lblErrorFechaVencimiento.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Fecha de Vencimiento";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(293, 301);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmLetraRegenerar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 334);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.Name = "FrmLetraRegenerar";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmLetraRegenerar";
            this.Load += new System.EventHandler(this.FrmLetraRegenerar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraEmision;
        private System.Windows.Forms.Label lblErrorComprobanteRef;
        private System.Windows.Forms.TextBox txtComprobanteRef;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblErrorMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbCodigoTipoComprobanteRef;
        private System.Windows.Forms.Label lblErrorFechaHoraEmision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblErrorCodigoMoneda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblErrorCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblErrorCodigoTipoComprobanteRef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblErrorFechaVencimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorAval;
        private System.Windows.Forms.TextBox txtAval;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbbCodigoMoneda;
        private System.Windows.Forms.ToolTip tltLetra;
    }
}