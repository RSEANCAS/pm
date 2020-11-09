namespace pm.app
{
    partial class FrmMantenimientoProveedor
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
            this.cbbCodigoProvincia = new System.Windows.Forms.ComboBox();
            this.cbbCodigoDistrito = new System.Windows.Forms.ComboBox();
            this.lblErrorCodigoDistrito = new System.Windows.Forms.Label();
            this.lblErrorCodigoProvincia = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbbCodigoDepartamento = new System.Windows.Forms.ComboBox();
            this.lblErrorCodigoDepartamento = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbCodigoPais = new System.Windows.Forms.ComboBox();
            this.lblErrorContacto = new System.Windows.Forms.Label();
            this.lblErrorCorreoElectronico = new System.Windows.Forms.Label();
            this.lblErrorTelefono = new System.Windows.Forms.Label();
            this.lblErrorCodigoPais = new System.Windows.Forms.Label();
            this.lblErrorDireccion = new System.Windows.Forms.Label();
            this.lblErrorNombresCompletos = new System.Windows.Forms.Label();
            this.lblErrorNroDocumentoIdentidad = new System.Windows.Forms.Label();
            this.lblErrorCodigoTipoDocumentoIdentidad = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombresCompletos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroDocumentoIdentidad = new System.Windows.Forms.TextBox();
            this.cbbCodigoTipoDocumentoIdentidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tltProveedor = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(297, 407);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbbCodigoProvincia);
            this.groupBox1.Controls.Add(this.cbbCodigoDistrito);
            this.groupBox1.Controls.Add(this.lblErrorCodigoDistrito);
            this.groupBox1.Controls.Add(this.lblErrorCodigoProvincia);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cbbCodigoDepartamento);
            this.groupBox1.Controls.Add(this.lblErrorCodigoDepartamento);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbbCodigoPais);
            this.groupBox1.Controls.Add(this.lblErrorContacto);
            this.groupBox1.Controls.Add(this.lblErrorCorreoElectronico);
            this.groupBox1.Controls.Add(this.lblErrorTelefono);
            this.groupBox1.Controls.Add(this.lblErrorCodigoPais);
            this.groupBox1.Controls.Add(this.lblErrorDireccion);
            this.groupBox1.Controls.Add(this.lblErrorNombresCompletos);
            this.groupBox1.Controls.Add(this.lblErrorNroDocumentoIdentidad);
            this.groupBox1.Controls.Add(this.lblErrorCodigoTipoDocumentoIdentidad);
            this.groupBox1.Controls.Add(this.txtContacto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCorreoElectronico);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombresCompletos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNroDocumentoIdentidad);
            this.groupBox1.Controls.Add(this.cbbCodigoTipoDocumentoIdentidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 391);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // cbbCodigoProvincia
            // 
            this.cbbCodigoProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCodigoProvincia.DisplayMember = "Nombre";
            this.cbbCodigoProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoProvincia.FormattingEnabled = true;
            this.cbbCodigoProvincia.Location = new System.Drawing.Point(9, 245);
            this.cbbCodigoProvincia.Name = "cbbCodigoProvincia";
            this.cbbCodigoProvincia.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoProvincia.TabIndex = 51;
            this.cbbCodigoProvincia.ValueMember = "CodigoProvincia";
            this.cbbCodigoProvincia.SelectedIndexChanged += new System.EventHandler(this.cbbCodigoProvincia_SelectedIndexChanged);
            // 
            // cbbCodigoDistrito
            // 
            this.cbbCodigoDistrito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCodigoDistrito.DisplayMember = "Nombre";
            this.cbbCodigoDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoDistrito.FormattingEnabled = true;
            this.cbbCodigoDistrito.Location = new System.Drawing.Point(183, 245);
            this.cbbCodigoDistrito.Name = "cbbCodigoDistrito";
            this.cbbCodigoDistrito.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoDistrito.TabIndex = 50;
            this.cbbCodigoDistrito.ValueMember = "CodigoDistrito";
            // 
            // lblErrorCodigoDistrito
            // 
            this.lblErrorCodigoDistrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCodigoDistrito.AutoSize = true;
            this.lblErrorCodigoDistrito.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoDistrito.Location = new System.Drawing.Point(180, 269);
            this.lblErrorCodigoDistrito.Name = "lblErrorCodigoDistrito";
            this.lblErrorCodigoDistrito.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoDistrito.TabIndex = 49;
            // 
            // lblErrorCodigoProvincia
            // 
            this.lblErrorCodigoProvincia.AutoSize = true;
            this.lblErrorCodigoProvincia.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoProvincia.Location = new System.Drawing.Point(6, 269);
            this.lblErrorCodigoProvincia.Name = "lblErrorCodigoProvincia";
            this.lblErrorCodigoProvincia.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoProvincia.TabIndex = 48;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(180, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "Distrito";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 229);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "Provincia";
            // 
            // cbbCodigoDepartamento
            // 
            this.cbbCodigoDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCodigoDepartamento.DisplayMember = "Nombre";
            this.cbbCodigoDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoDepartamento.FormattingEnabled = true;
            this.cbbCodigoDepartamento.Location = new System.Drawing.Point(183, 192);
            this.cbbCodigoDepartamento.Name = "cbbCodigoDepartamento";
            this.cbbCodigoDepartamento.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoDepartamento.TabIndex = 45;
            this.cbbCodigoDepartamento.ValueMember = "CodigoDepartamento";
            this.cbbCodigoDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbbCodigoDepartamento_SelectedIndexChanged);
            // 
            // lblErrorCodigoDepartamento
            // 
            this.lblErrorCodigoDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCodigoDepartamento.AutoSize = true;
            this.lblErrorCodigoDepartamento.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoDepartamento.Location = new System.Drawing.Point(180, 216);
            this.lblErrorCodigoDepartamento.Name = "lblErrorCodigoDepartamento";
            this.lblErrorCodigoDepartamento.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoDepartamento.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(180, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Departamento";
            // 
            // cbbCodigoPais
            // 
            this.cbbCodigoPais.DisplayMember = "Nombre";
            this.cbbCodigoPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoPais.FormattingEnabled = true;
            this.cbbCodigoPais.Location = new System.Drawing.Point(9, 192);
            this.cbbCodigoPais.Name = "cbbCodigoPais";
            this.cbbCodigoPais.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoPais.TabIndex = 27;
            this.cbbCodigoPais.ValueMember = "CodigoPais";
            this.cbbCodigoPais.SelectedIndexChanged += new System.EventHandler(this.cbbCodigoPais_SelectedIndexChanged);
            // 
            // lblErrorContacto
            // 
            this.lblErrorContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorContacto.AutoSize = true;
            this.lblErrorContacto.ForeColor = System.Drawing.Color.Red;
            this.lblErrorContacto.Location = new System.Drawing.Point(6, 375);
            this.lblErrorContacto.Name = "lblErrorContacto";
            this.lblErrorContacto.Size = new System.Drawing.Size(0, 13);
            this.lblErrorContacto.TabIndex = 26;
            // 
            // lblErrorCorreoElectronico
            // 
            this.lblErrorCorreoElectronico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCorreoElectronico.AutoSize = true;
            this.lblErrorCorreoElectronico.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCorreoElectronico.Location = new System.Drawing.Point(6, 322);
            this.lblErrorCorreoElectronico.Name = "lblErrorCorreoElectronico";
            this.lblErrorCorreoElectronico.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCorreoElectronico.TabIndex = 25;
            // 
            // lblErrorTelefono
            // 
            this.lblErrorTelefono.AutoSize = true;
            this.lblErrorTelefono.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTelefono.Location = new System.Drawing.Point(180, 322);
            this.lblErrorTelefono.Name = "lblErrorTelefono";
            this.lblErrorTelefono.Size = new System.Drawing.Size(0, 13);
            this.lblErrorTelefono.TabIndex = 23;
            // 
            // lblErrorCodigoPais
            // 
            this.lblErrorCodigoPais.AutoSize = true;
            this.lblErrorCodigoPais.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoPais.Location = new System.Drawing.Point(6, 216);
            this.lblErrorCodigoPais.Name = "lblErrorCodigoPais";
            this.lblErrorCodigoPais.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoPais.TabIndex = 22;
            // 
            // lblErrorDireccion
            // 
            this.lblErrorDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorDireccion.AutoSize = true;
            this.lblErrorDireccion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDireccion.Location = new System.Drawing.Point(6, 163);
            this.lblErrorDireccion.Name = "lblErrorDireccion";
            this.lblErrorDireccion.Size = new System.Drawing.Size(0, 13);
            this.lblErrorDireccion.TabIndex = 21;
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
            // txtContacto
            // 
            this.txtContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContacto.Location = new System.Drawing.Point(9, 351);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(168, 20);
            this.txtContacto.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Contacto";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(183, 298);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(168, 20);
            this.txtTelefono.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Teléfono";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreoElectronico.Location = new System.Drawing.Point(9, 298);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(168, 20);
            this.txtCorreoElectronico.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo Electrónico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "País";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Location = new System.Drawing.Point(9, 139);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(342, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dirección";
            // 
            // txtNombresCompletos
            // 
            this.txtNombresCompletos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombresCompletos.Location = new System.Drawing.Point(9, 86);
            this.txtNombresCompletos.Name = "txtNombresCompletos";
            this.txtNombresCompletos.Size = new System.Drawing.Size(342, 20);
            this.txtNombresCompletos.TabIndex = 5;
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
            this.txtNroDocumentoIdentidad.TabIndex = 3;
            // 
            // cbbCodigoTipoDocumentoIdentidad
            // 
            this.cbbCodigoTipoDocumentoIdentidad.DisplayMember = "Descripcion";
            this.cbbCodigoTipoDocumentoIdentidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoTipoDocumentoIdentidad.FormattingEnabled = true;
            this.cbbCodigoTipoDocumentoIdentidad.Location = new System.Drawing.Point(9, 33);
            this.cbbCodigoTipoDocumentoIdentidad.Name = "cbbCodigoTipoDocumentoIdentidad";
            this.cbbCodigoTipoDocumentoIdentidad.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoTipoDocumentoIdentidad.TabIndex = 1;
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
            // FrmMantenimientoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 442);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMantenimientoProveedor";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMantenimientoProveedor";
            this.Load += new System.EventHandler(this.FrmMantenimientoProveedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblErrorContacto;
        private System.Windows.Forms.Label lblErrorCorreoElectronico;
        private System.Windows.Forms.Label lblErrorTelefono;
        private System.Windows.Forms.Label lblErrorCodigoPais;
        private System.Windows.Forms.Label lblErrorDireccion;
        private System.Windows.Forms.Label lblErrorNombresCompletos;
        private System.Windows.Forms.Label lblErrorNroDocumentoIdentidad;
        private System.Windows.Forms.Label lblErrorCodigoTipoDocumentoIdentidad;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombresCompletos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroDocumentoIdentidad;
        private System.Windows.Forms.ComboBox cbbCodigoTipoDocumentoIdentidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbCodigoPais;
        private System.Windows.Forms.ToolTip tltProveedor;
        private System.Windows.Forms.ComboBox cbbCodigoDepartamento;
        private System.Windows.Forms.Label lblErrorCodigoDepartamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbCodigoProvincia;
        private System.Windows.Forms.ComboBox cbbCodigoDistrito;
        private System.Windows.Forms.Label lblErrorCodigoDistrito;
        private System.Windows.Forms.Label lblErrorCodigoProvincia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}