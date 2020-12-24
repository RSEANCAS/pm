namespace pm.app
{
    partial class FrmMantenimientoTipoCambio
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
            this.lblErrorValorCompra = new System.Windows.Forms.Label();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblErrorValorVenta = new System.Windows.Forms.Label();
            this.txtValorVenta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblErrorFechaCambio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaCambio = new System.Windows.Forms.DateTimePicker();
            this.tltTipoCambio = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtpFechaCambio);
            this.groupBox1.Controls.Add(this.lblErrorFechaCambio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblErrorValorCompra);
            this.groupBox1.Controls.Add(this.txtValorCompra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblErrorValorVenta);
            this.groupBox1.Controls.Add(this.txtValorVenta);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 127);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // lblErrorValorCompra
            // 
            this.lblErrorValorCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorValorCompra.AutoSize = true;
            this.lblErrorValorCompra.ForeColor = System.Drawing.Color.Red;
            this.lblErrorValorCompra.Location = new System.Drawing.Point(180, 109);
            this.lblErrorValorCompra.Name = "lblErrorValorCompra";
            this.lblErrorValorCompra.Size = new System.Drawing.Size(0, 13);
            this.lblErrorValorCompra.TabIndex = 20;
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorCompra.Location = new System.Drawing.Point(183, 85);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(168, 20);
            this.txtValorCompra.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor de Compra";
            // 
            // lblErrorValorVenta
            // 
            this.lblErrorValorVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorValorVenta.AutoSize = true;
            this.lblErrorValorVenta.ForeColor = System.Drawing.Color.Red;
            this.lblErrorValorVenta.Location = new System.Drawing.Point(6, 109);
            this.lblErrorValorVenta.Name = "lblErrorValorVenta";
            this.lblErrorValorVenta.Size = new System.Drawing.Size(0, 13);
            this.lblErrorValorVenta.TabIndex = 47;
            // 
            // txtValorVenta
            // 
            this.txtValorVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorVenta.Location = new System.Drawing.Point(9, 85);
            this.txtValorVenta.Name = "txtValorVenta";
            this.txtValorVenta.Size = new System.Drawing.Size(168, 20);
            this.txtValorVenta.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Valor de Venta";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(289, 144);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblErrorFechaCambio
            // 
            this.lblErrorFechaCambio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorFechaCambio.AutoSize = true;
            this.lblErrorFechaCambio.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFechaCambio.Location = new System.Drawing.Point(6, 56);
            this.lblErrorFechaCambio.Name = "lblErrorFechaCambio";
            this.lblErrorFechaCambio.Size = new System.Drawing.Size(0, 13);
            this.lblErrorFechaCambio.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Fecha de Cambio";
            // 
            // dtpFechaCambio
            // 
            this.dtpFechaCambio.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaCambio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCambio.Location = new System.Drawing.Point(9, 32);
            this.dtpFechaCambio.Name = "dtpFechaCambio";
            this.dtpFechaCambio.Size = new System.Drawing.Size(168, 20);
            this.dtpFechaCambio.TabIndex = 51;
            // 
            // FrmMantenimientoTipoCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 179);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMantenimientoTipoCambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMantenimientoTipoCambio";
            this.Load += new System.EventHandler(this.FrmMantenimientoTipoCambio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblErrorValorCompra;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblErrorValorVenta;
        private System.Windows.Forms.TextBox txtValorVenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtpFechaCambio;
        private System.Windows.Forms.Label lblErrorFechaCambio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip tltTipoCambio;
    }
}