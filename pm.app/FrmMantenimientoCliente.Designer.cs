﻿namespace pm.app
{
    partial class FrmMantenimientoCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCodigoTipoDocumentoIdentidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNroDocumentoIdentidad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblErrorAreaContacto = new System.Windows.Forms.Label();
            this.lblErrorTelefono = new System.Windows.Forms.Label();
            this.lblErrorContacto = new System.Windows.Forms.Label();
            this.lblErrorCorreoElectronico = new System.Windows.Forms.Label();
            this.lblErrorDireccion = new System.Windows.Forms.Label();
            this.lblErrorNombresCompletos = new System.Windows.Forms.Label();
            this.lblErrorNroDocumentoIdentidad = new System.Windows.Forms.Label();
            this.lblErrorCodigoTipoDocumentoIdentidad = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbCodigoActividadPrincipal = new System.Windows.Forms.ComboBox();
            this.txtAreaContacto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombresCompletos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tltCliente = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // txtNroDocumentoIdentidad
            // 
            this.txtNroDocumentoIdentidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNroDocumentoIdentidad.Location = new System.Drawing.Point(183, 33);
            this.txtNroDocumentoIdentidad.Name = "txtNroDocumentoIdentidad";
            this.txtNroDocumentoIdentidad.Size = new System.Drawing.Size(168, 21);
            this.txtNroDocumentoIdentidad.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblErrorAreaContacto);
            this.groupBox1.Controls.Add(this.lblErrorTelefono);
            this.groupBox1.Controls.Add(this.lblErrorContacto);
            this.groupBox1.Controls.Add(this.lblErrorCorreoElectronico);
            this.groupBox1.Controls.Add(this.lblErrorDireccion);
            this.groupBox1.Controls.Add(this.lblErrorNombresCompletos);
            this.groupBox1.Controls.Add(this.lblErrorNroDocumentoIdentidad);
            this.groupBox1.Controls.Add(this.lblErrorCodigoTipoDocumentoIdentidad);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbbCodigoActividadPrincipal);
            this.groupBox1.Controls.Add(this.txtAreaContacto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtContacto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCorreoElectronico);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombresCompletos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNroDocumentoIdentidad);
            this.groupBox1.Controls.Add(this.cbbCodigoTipoDocumentoIdentidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 341);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // lblErrorAreaContacto
            // 
            this.lblErrorAreaContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorAreaContacto.AutoSize = true;
            this.lblErrorAreaContacto.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAreaContacto.Location = new System.Drawing.Point(180, 269);
            this.lblErrorAreaContacto.Name = "lblErrorAreaContacto";
            this.lblErrorAreaContacto.Size = new System.Drawing.Size(0, 13);
            this.lblErrorAreaContacto.TabIndex = 26;
            // 
            // lblErrorTelefono
            // 
            this.lblErrorTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorTelefono.AutoSize = true;
            this.lblErrorTelefono.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTelefono.Location = new System.Drawing.Point(180, 216);
            this.lblErrorTelefono.Name = "lblErrorTelefono";
            this.lblErrorTelefono.Size = new System.Drawing.Size(0, 13);
            this.lblErrorTelefono.TabIndex = 25;
            // 
            // lblErrorContacto
            // 
            this.lblErrorContacto.AutoSize = true;
            this.lblErrorContacto.ForeColor = System.Drawing.Color.Red;
            this.lblErrorContacto.Location = new System.Drawing.Point(6, 269);
            this.lblErrorContacto.Name = "lblErrorContacto";
            this.lblErrorContacto.Size = new System.Drawing.Size(0, 13);
            this.lblErrorContacto.TabIndex = 23;
            // 
            // lblErrorCorreoElectronico
            // 
            this.lblErrorCorreoElectronico.AutoSize = true;
            this.lblErrorCorreoElectronico.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCorreoElectronico.Location = new System.Drawing.Point(6, 216);
            this.lblErrorCorreoElectronico.Name = "lblErrorCorreoElectronico";
            this.lblErrorCorreoElectronico.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCorreoElectronico.TabIndex = 22;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Actividad principal";
            // 
            // cbbCodigoActividadPrincipal
            // 
            this.cbbCodigoActividadPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCodigoActividadPrincipal.DisplayMember = "Nombre";
            this.cbbCodigoActividadPrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoActividadPrincipal.FormattingEnabled = true;
            this.cbbCodigoActividadPrincipal.Location = new System.Drawing.Point(9, 298);
            this.cbbCodigoActividadPrincipal.Name = "cbbCodigoActividadPrincipal";
            this.cbbCodigoActividadPrincipal.Size = new System.Drawing.Size(198, 21);
            this.cbbCodigoActividadPrincipal.TabIndex = 17;
            this.cbbCodigoActividadPrincipal.ValueMember = "CodigoActividad";
            // 
            // txtAreaContacto
            // 
            this.txtAreaContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAreaContacto.Location = new System.Drawing.Point(183, 245);
            this.txtAreaContacto.Name = "txtAreaContacto";
            this.txtAreaContacto.Size = new System.Drawing.Size(168, 21);
            this.txtAreaContacto.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Área de contacto";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(9, 245);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(168, 21);
            this.txtContacto.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Contacto";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.Location = new System.Drawing.Point(183, 192);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(168, 21);
            this.txtTelefono.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Teléfono";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(9, 192);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(168, 21);
            this.txtCorreoElectronico.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Correo Electrónico";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Location = new System.Drawing.Point(9, 139);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(342, 21);
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
            this.txtNombresCompletos.Size = new System.Drawing.Size(342, 21);
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
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(297, 359);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmMantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 392);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMantenimientoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMantenimientoCliente";
            this.Load += new System.EventHandler(this.FrmMantenimientoCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCodigoTipoDocumentoIdentidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNroDocumentoIdentidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbCodigoActividadPrincipal;
        private System.Windows.Forms.TextBox txtAreaContacto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombresCompletos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblErrorContacto;
        private System.Windows.Forms.Label lblErrorCorreoElectronico;
        private System.Windows.Forms.Label lblErrorDireccion;
        private System.Windows.Forms.Label lblErrorNombresCompletos;
        private System.Windows.Forms.Label lblErrorNroDocumentoIdentidad;
        private System.Windows.Forms.Label lblErrorCodigoTipoDocumentoIdentidad;
        private System.Windows.Forms.Label lblErrorTelefono;
        private System.Windows.Forms.Label lblErrorAreaContacto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ToolTip tltCliente;
    }
}