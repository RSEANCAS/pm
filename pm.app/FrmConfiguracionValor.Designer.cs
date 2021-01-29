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
            this.components = new System.ComponentModel.Container();
            this.tbpGuiaRemision = new System.Windows.Forms.TabPage();
            this.btnBuscarTransportistaGuiaRemision = new System.Windows.Forms.Button();
            this.txtNombresTransportistaGuiaRemision = new System.Windows.Forms.TextBox();
            this.txtNroDocIdentidadTransportistaGuiaRemision = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbCodigoTipoComprobanteGuiaRemision = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbpSunat = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRutaCertificadoSunat = new System.Windows.Forms.TextBox();
            this.txtContraseñaCertificadoSunat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraseñaSOLSunat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuarioSOLSunat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tltConfiguracionValor = new System.Windows.Forms.ToolTip(this.components);
            this.lblErrorRutaCertificadoSunat = new System.Windows.Forms.Label();
            this.lblErrorContraseñaCertificadoSunat = new System.Windows.Forms.Label();
            this.lblErrorUsuarioSOLSunat = new System.Windows.Forms.Label();
            this.lblErrorContraseñaSOLSunat = new System.Windows.Forms.Label();
            this.lblErrorRutaFacturacionElectronicaSunat = new System.Windows.Forms.Label();
            this.txtRutaFacturacionElectronicaSunat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbpGuiaRemision.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpSunat.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Comprobante";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbpGuiaRemision);
            this.tabControl1.Controls.Add(this.tbpSunat);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(693, 243);
            this.tabControl1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(643, 261);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(58, 23);
            this.btnGuardar.TabIndex = 54;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbpSunat
            // 
            this.tbpSunat.Controls.Add(this.lblErrorRutaFacturacionElectronicaSunat);
            this.tbpSunat.Controls.Add(this.txtRutaFacturacionElectronicaSunat);
            this.tbpSunat.Controls.Add(this.label7);
            this.tbpSunat.Controls.Add(this.lblErrorContraseñaSOLSunat);
            this.tbpSunat.Controls.Add(this.lblErrorUsuarioSOLSunat);
            this.tbpSunat.Controls.Add(this.lblErrorContraseñaCertificadoSunat);
            this.tbpSunat.Controls.Add(this.lblErrorRutaCertificadoSunat);
            this.tbpSunat.Controls.Add(this.txtContraseñaSOLSunat);
            this.tbpSunat.Controls.Add(this.label4);
            this.tbpSunat.Controls.Add(this.txtUsuarioSOLSunat);
            this.tbpSunat.Controls.Add(this.label5);
            this.tbpSunat.Controls.Add(this.txtContraseñaCertificadoSunat);
            this.tbpSunat.Controls.Add(this.label3);
            this.tbpSunat.Controls.Add(this.txtRutaCertificadoSunat);
            this.tbpSunat.Controls.Add(this.label2);
            this.tbpSunat.Location = new System.Drawing.Point(4, 22);
            this.tbpSunat.Name = "tbpSunat";
            this.tbpSunat.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSunat.Size = new System.Drawing.Size(685, 217);
            this.tbpSunat.TabIndex = 1;
            this.tbpSunat.Text = "SUNAT";
            this.tbpSunat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ruta Certificado";
            // 
            // txtRutaCertificadoSunat
            // 
            this.txtRutaCertificadoSunat.Location = new System.Drawing.Point(18, 67);
            this.txtRutaCertificadoSunat.Name = "txtRutaCertificadoSunat";
            this.txtRutaCertificadoSunat.Size = new System.Drawing.Size(288, 20);
            this.txtRutaCertificadoSunat.TabIndex = 3;
            // 
            // txtContraseñaCertificadoSunat
            // 
            this.txtContraseñaCertificadoSunat.Location = new System.Drawing.Point(18, 106);
            this.txtContraseñaCertificadoSunat.Name = "txtContraseñaCertificadoSunat";
            this.txtContraseñaCertificadoSunat.Size = new System.Drawing.Size(288, 20);
            this.txtContraseñaCertificadoSunat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña Certificado";
            // 
            // txtContraseñaSOLSunat
            // 
            this.txtContraseñaSOLSunat.Location = new System.Drawing.Point(18, 184);
            this.txtContraseñaSOLSunat.Name = "txtContraseñaSOLSunat";
            this.txtContraseñaSOLSunat.Size = new System.Drawing.Size(288, 20);
            this.txtContraseñaSOLSunat.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña SOL";
            // 
            // txtUsuarioSOLSunat
            // 
            this.txtUsuarioSOLSunat.Location = new System.Drawing.Point(18, 145);
            this.txtUsuarioSOLSunat.Name = "txtUsuarioSOLSunat";
            this.txtUsuarioSOLSunat.Size = new System.Drawing.Size(288, 20);
            this.txtUsuarioSOLSunat.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Usuario SOL";
            // 
            // lblErrorRutaCertificadoSunat
            // 
            this.lblErrorRutaCertificadoSunat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorRutaCertificadoSunat.AutoSize = true;
            this.lblErrorRutaCertificadoSunat.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRutaCertificadoSunat.Location = new System.Drawing.Point(312, 70);
            this.lblErrorRutaCertificadoSunat.Name = "lblErrorRutaCertificadoSunat";
            this.lblErrorRutaCertificadoSunat.Size = new System.Drawing.Size(0, 13);
            this.lblErrorRutaCertificadoSunat.TabIndex = 51;
            // 
            // lblErrorContraseñaCertificadoSunat
            // 
            this.lblErrorContraseñaCertificadoSunat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorContraseñaCertificadoSunat.AutoSize = true;
            this.lblErrorContraseñaCertificadoSunat.ForeColor = System.Drawing.Color.Red;
            this.lblErrorContraseñaCertificadoSunat.Location = new System.Drawing.Point(312, 109);
            this.lblErrorContraseñaCertificadoSunat.Name = "lblErrorContraseñaCertificadoSunat";
            this.lblErrorContraseñaCertificadoSunat.Size = new System.Drawing.Size(0, 13);
            this.lblErrorContraseñaCertificadoSunat.TabIndex = 52;
            // 
            // lblErrorUsuarioSOLSunat
            // 
            this.lblErrorUsuarioSOLSunat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorUsuarioSOLSunat.AutoSize = true;
            this.lblErrorUsuarioSOLSunat.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUsuarioSOLSunat.Location = new System.Drawing.Point(312, 148);
            this.lblErrorUsuarioSOLSunat.Name = "lblErrorUsuarioSOLSunat";
            this.lblErrorUsuarioSOLSunat.Size = new System.Drawing.Size(0, 13);
            this.lblErrorUsuarioSOLSunat.TabIndex = 53;
            // 
            // lblErrorContraseñaSOLSunat
            // 
            this.lblErrorContraseñaSOLSunat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorContraseñaSOLSunat.AutoSize = true;
            this.lblErrorContraseñaSOLSunat.ForeColor = System.Drawing.Color.Red;
            this.lblErrorContraseñaSOLSunat.Location = new System.Drawing.Point(312, 187);
            this.lblErrorContraseñaSOLSunat.Name = "lblErrorContraseñaSOLSunat";
            this.lblErrorContraseñaSOLSunat.Size = new System.Drawing.Size(0, 13);
            this.lblErrorContraseñaSOLSunat.TabIndex = 54;
            // 
            // lblErrorRutaFacturacionElectronicaSunat
            // 
            this.lblErrorRutaFacturacionElectronicaSunat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorRutaFacturacionElectronicaSunat.AutoSize = true;
            this.lblErrorRutaFacturacionElectronicaSunat.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRutaFacturacionElectronicaSunat.Location = new System.Drawing.Point(312, 31);
            this.lblErrorRutaFacturacionElectronicaSunat.Name = "lblErrorRutaFacturacionElectronicaSunat";
            this.lblErrorRutaFacturacionElectronicaSunat.Size = new System.Drawing.Size(0, 13);
            this.lblErrorRutaFacturacionElectronicaSunat.TabIndex = 57;
            // 
            // txtRutaFacturacionElectronicaSunat
            // 
            this.txtRutaFacturacionElectronicaSunat.Location = new System.Drawing.Point(18, 28);
            this.txtRutaFacturacionElectronicaSunat.Name = "txtRutaFacturacionElectronicaSunat";
            this.txtRutaFacturacionElectronicaSunat.Size = new System.Drawing.Size(288, 20);
            this.txtRutaFacturacionElectronicaSunat.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Ruta Facturación Electrónica";
            // 
            // FrmConfiguracionValor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 296);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmConfiguracionValor";
            this.Text = "Configuración de Valores por defecto";
            this.Load += new System.EventHandler(this.FrmConfiguracionValor_Load);
            this.tbpGuiaRemision.ResumeLayout(false);
            this.tbpGuiaRemision.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbpSunat.ResumeLayout(false);
            this.tbpSunat.PerformLayout();
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
        private System.Windows.Forms.TabPage tbpSunat;
        private System.Windows.Forms.TextBox txtContraseñaSOLSunat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuarioSOLSunat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContraseñaCertificadoSunat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRutaCertificadoSunat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip tltConfiguracionValor;
        private System.Windows.Forms.Label lblErrorContraseñaSOLSunat;
        private System.Windows.Forms.Label lblErrorUsuarioSOLSunat;
        private System.Windows.Forms.Label lblErrorContraseñaCertificadoSunat;
        private System.Windows.Forms.Label lblErrorRutaCertificadoSunat;
        private System.Windows.Forms.Label lblErrorRutaFacturacionElectronicaSunat;
        private System.Windows.Forms.TextBox txtRutaFacturacionElectronicaSunat;
        private System.Windows.Forms.Label label7;
    }
}