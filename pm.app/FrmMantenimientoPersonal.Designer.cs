namespace pm.app
{
    partial class FrmMantenimientoPersonal
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
            this.lblErrorEstado = new System.Windows.Forms.Label();
            this.cbbCodigoArea = new System.Windows.Forms.ComboBox();
            this.lblErrorCodigoArea = new System.Windows.Forms.Label();
            this.lblErrorCorreoElectronico = new System.Windows.Forms.Label();
            this.lblErrorNombresCompletos = new System.Windows.Forms.Label();
            this.lblErrorNroDocumentoIdentidad = new System.Windows.Forms.Label();
            this.lblErrorCodigoTipoDocumentoIdentidad = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombresCompletos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroDocumentoIdentidad = new System.Windows.Forms.TextBox();
            this.cbbCodigoTipoDocumentoIdentidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tltPersonal = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(297, 251);
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
            this.groupBox1.Controls.Add(this.lblErrorEstado);
            this.groupBox1.Controls.Add(this.cbbCodigoArea);
            this.groupBox1.Controls.Add(this.lblErrorCodigoArea);
            this.groupBox1.Controls.Add(this.lblErrorCorreoElectronico);
            this.groupBox1.Controls.Add(this.lblErrorNombresCompletos);
            this.groupBox1.Controls.Add(this.lblErrorNroDocumentoIdentidad);
            this.groupBox1.Controls.Add(this.lblErrorCodigoTipoDocumentoIdentidad);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbbEstado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCorreoElectronico);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombresCompletos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNroDocumentoIdentidad);
            this.groupBox1.Controls.Add(this.cbbCodigoTipoDocumentoIdentidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // lblErrorEstado
            // 
            this.lblErrorEstado.AutoSize = true;
            this.lblErrorEstado.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEstado.Location = new System.Drawing.Point(6, 216);
            this.lblErrorEstado.Name = "lblErrorEstado";
            this.lblErrorEstado.Size = new System.Drawing.Size(0, 13);
            this.lblErrorEstado.TabIndex = 28;
            // 
            // cbbCodigoArea
            // 
            this.cbbCodigoArea.DisplayMember = "Descripcion";
            this.cbbCodigoArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoArea.FormattingEnabled = true;
            this.cbbCodigoArea.Location = new System.Drawing.Point(183, 139);
            this.cbbCodigoArea.Name = "cbbCodigoArea";
            this.cbbCodigoArea.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoArea.TabIndex = 4;
            this.cbbCodigoArea.ValueMember = "CodigoArea";
            // 
            // lblErrorCodigoArea
            // 
            this.lblErrorCodigoArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCodigoArea.AutoSize = true;
            this.lblErrorCodigoArea.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoArea.Location = new System.Drawing.Point(180, 163);
            this.lblErrorCodigoArea.Name = "lblErrorCodigoArea";
            this.lblErrorCodigoArea.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoArea.TabIndex = 25;
            // 
            // lblErrorCorreoElectronico
            // 
            this.lblErrorCorreoElectronico.AutoSize = true;
            this.lblErrorCorreoElectronico.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCorreoElectronico.Location = new System.Drawing.Point(6, 163);
            this.lblErrorCorreoElectronico.Name = "lblErrorCorreoElectronico";
            this.lblErrorCorreoElectronico.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCorreoElectronico.TabIndex = 22;
            // 
            // lblErrorNombresCompletos
            // 
            this.lblErrorNombresCompletos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorNombresCompletos.AutoSize = true;
            this.lblErrorNombresCompletos.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombresCompletos.Location = new System.Drawing.Point(6, 110);
            this.lblErrorNombresCompletos.Name = "lblErrorNombresCompletos";
            this.lblErrorNombresCompletos.Size = new System.Drawing.Size(0, 13);
            this.lblErrorNombresCompletos.TabIndex = 20;
            // 
            // lblErrorNroDocumentoIdentidad
            // 
            this.lblErrorNroDocumentoIdentidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorNroDocumentoIdentidad.AutoSize = true;
            this.lblErrorNroDocumentoIdentidad.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNroDocumentoIdentidad.Location = new System.Drawing.Point(180, 57);
            this.lblErrorNroDocumentoIdentidad.Name = "lblErrorNroDocumentoIdentidad";
            this.lblErrorNroDocumentoIdentidad.Size = new System.Drawing.Size(0, 13);
            this.lblErrorNroDocumentoIdentidad.TabIndex = 19;
            // 
            // lblErrorCodigoTipoDocumentoIdentidad
            // 
            this.lblErrorCodigoTipoDocumentoIdentidad.AutoSize = true;
            this.lblErrorCodigoTipoDocumentoIdentidad.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoTipoDocumentoIdentidad.Location = new System.Drawing.Point(6, 57);
            this.lblErrorCodigoTipoDocumentoIdentidad.Name = "lblErrorCodigoTipoDocumentoIdentidad";
            this.lblErrorCodigoTipoDocumentoIdentidad.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoTipoDocumentoIdentidad.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Estado";
            // 
            // cbbEstado
            // 
            this.cbbEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbEstado.DisplayMember = "Text";
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(9, 192);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(168, 21);
            this.cbbEstado.TabIndex = 5;
            this.cbbEstado.ValueMember = "Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Área";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(9, 139);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(168, 20);
            this.txtCorreoElectronico.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Correo Electrónico";
            // 
            // txtNombresCompletos
            // 
            this.txtNombresCompletos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombresCompletos.Location = new System.Drawing.Point(9, 86);
            this.txtNombresCompletos.Name = "txtNombresCompletos";
            this.txtNombresCompletos.Size = new System.Drawing.Size(342, 20);
            this.txtNombresCompletos.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombres completos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo documento identidad";
            // 
            // txtNroDocumentoIdentidad
            // 
            this.txtNroDocumentoIdentidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNroDocumentoIdentidad.Location = new System.Drawing.Point(183, 33);
            this.txtNroDocumentoIdentidad.Name = "txtNroDocumentoIdentidad";
            this.txtNroDocumentoIdentidad.Size = new System.Drawing.Size(168, 20);
            this.txtNroDocumentoIdentidad.TabIndex = 1;
            // 
            // cbbCodigoTipoDocumentoIdentidad
            // 
            this.cbbCodigoTipoDocumentoIdentidad.DisplayMember = "Descripcion";
            this.cbbCodigoTipoDocumentoIdentidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoTipoDocumentoIdentidad.FormattingEnabled = true;
            this.cbbCodigoTipoDocumentoIdentidad.Location = new System.Drawing.Point(9, 33);
            this.cbbCodigoTipoDocumentoIdentidad.Name = "cbbCodigoTipoDocumentoIdentidad";
            this.cbbCodigoTipoDocumentoIdentidad.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoTipoDocumentoIdentidad.TabIndex = 0;
            this.cbbCodigoTipoDocumentoIdentidad.ValueMember = "CodigoTipoDocumentoIdentidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N° documento identidad";
            // 
            // FrmMantenimientoPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 284);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMantenimientoPersonal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMantenimientoPersonal";
            this.Load += new System.EventHandler(this.FrmMantenimientoPersonal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblErrorCodigoArea;
        private System.Windows.Forms.Label lblErrorCorreoElectronico;
        private System.Windows.Forms.Label lblErrorNombresCompletos;
        private System.Windows.Forms.Label lblErrorNroDocumentoIdentidad;
        private System.Windows.Forms.Label lblErrorCodigoTipoDocumentoIdentidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombresCompletos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroDocumentoIdentidad;
        private System.Windows.Forms.ComboBox cbbCodigoTipoDocumentoIdentidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip tltPersonal;
        private System.Windows.Forms.ComboBox cbbCodigoArea;
        private System.Windows.Forms.Label lblErrorEstado;
    }
}