namespace pm.app
{
    partial class FrmConfiguracionValor
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
            this.tbpGuiaRemision = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCodigoTipoComprobanteGuiaRemision = new System.Windows.Forms.ComboBox();
            this.btnBuscarTransportistaGuiaRemision = new System.Windows.Forms.Button();
            this.txtNombresTransportistaGuiaRemision = new System.Windows.Forms.TextBox();
            this.txtNroDocIdentidadTransportistaGuiaRemision = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbpGuiaRemision.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpGuiaRemision
            // 
            this.tbpGuiaRemision.Controls.Add(this.btnBuscarTransportistaGuiaRemision);
            this.tbpGuiaRemision.Controls.Add(this.txtNombresTransportistaGuiaRemision);
            this.tbpGuiaRemision.Controls.Add(this.txtNroDocIdentidadTransportistaGuiaRemision);
            this.tbpGuiaRemision.Controls.Add(this.label11);
            this.tbpGuiaRemision.Controls.Add(this.cbbCodigoTipoComprobanteGuiaRemision);
            this.tbpGuiaRemision.Controls.Add(this.label1);
            this.tbpGuiaRemision.Location = new System.Drawing.Point(4, 22);
            this.tbpGuiaRemision.Name = "tbpGuiaRemision";
            this.tbpGuiaRemision.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGuiaRemision.Size = new System.Drawing.Size(685, 202);
            this.tbpGuiaRemision.TabIndex = 0;
            this.tbpGuiaRemision.Text = "Guía Remisión";
            this.tbpGuiaRemision.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbpGuiaRemision);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(693, 228);
            this.tabControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Comprobante";
            // 
            // cbbCodigoTipoComprobanteGuiaRemision
            // 
            this.cbbCodigoTipoComprobanteGuiaRemision.DisplayMember = "Descripcion";
            this.cbbCodigoTipoComprobanteGuiaRemision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoTipoComprobanteGuiaRemision.FormattingEnabled = true;
            this.cbbCodigoTipoComprobanteGuiaRemision.Location = new System.Drawing.Point(18, 28);
            this.cbbCodigoTipoComprobanteGuiaRemision.Name = "cbbCodigoTipoComprobanteGuiaRemision";
            this.cbbCodigoTipoComprobanteGuiaRemision.Size = new System.Drawing.Size(100, 21);
            this.cbbCodigoTipoComprobanteGuiaRemision.TabIndex = 1;
            this.cbbCodigoTipoComprobanteGuiaRemision.ValueMember = "CodigoTipoComprobante";
            // 
            // btnBuscarTransportistaGuiaRemision
            // 
            this.btnBuscarTransportistaGuiaRemision.Location = new System.Drawing.Point(272, 66);
            this.btnBuscarTransportistaGuiaRemision.Name = "btnBuscarTransportistaGuiaRemision";
            this.btnBuscarTransportistaGuiaRemision.Size = new System.Drawing.Size(58, 23);
            this.btnBuscarTransportistaGuiaRemision.TabIndex = 52;
            this.btnBuscarTransportistaGuiaRemision.Text = "Buscar";
            this.btnBuscarTransportistaGuiaRemision.UseVisualStyleBackColor = true;
            this.btnBuscarTransportistaGuiaRemision.Click += new System.EventHandler(this.btnBuscarTransportistaGuiaRemision_Click);
            // 
            // txtNombresTransportistaGuiaRemision
            // 
            this.txtNombresTransportistaGuiaRemision.Location = new System.Drawing.Point(79, 68);
            this.txtNombresTransportistaGuiaRemision.Name = "txtNombresTransportistaGuiaRemision";
            this.txtNombresTransportistaGuiaRemision.ReadOnly = true;
            this.txtNombresTransportistaGuiaRemision.Size = new System.Drawing.Size(187, 20);
            this.txtNombresTransportistaGuiaRemision.TabIndex = 51;
            // 
            // txtNroDocIdentidadTransportistaGuiaRemision
            // 
            this.txtNroDocIdentidadTransportistaGuiaRemision.Location = new System.Drawing.Point(18, 68);
            this.txtNroDocIdentidadTransportistaGuiaRemision.Name = "txtNroDocIdentidadTransportistaGuiaRemision";
            this.txtNroDocIdentidadTransportistaGuiaRemision.Size = new System.Drawing.Size(55, 20);
            this.txtNroDocIdentidadTransportistaGuiaRemision.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Transportista";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(643, 246);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(58, 23);
            this.btnGuardar.TabIndex = 54;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmConfiguracionValor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 281);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmConfiguracionValor";
            this.Text = "Configuración de Valores por defecto";
            this.Load += new System.EventHandler(this.FrmConfiguracionValor_Load);
            this.tbpGuiaRemision.ResumeLayout(false);
            this.tbpGuiaRemision.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpGuiaRemision;
        private System.Windows.Forms.ComboBox cbbCodigoTipoComprobanteGuiaRemision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnBuscarTransportistaGuiaRemision;
        private System.Windows.Forms.TextBox txtNombresTransportistaGuiaRemision;
        private System.Windows.Forms.TextBox txtNroDocIdentidadTransportistaGuiaRemision;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGuardar;
    }
}