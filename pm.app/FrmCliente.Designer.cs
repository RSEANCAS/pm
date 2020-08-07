namespace pm.app
{
    partial class FrmCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtFiltroAreaContacto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiltroContacto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFiltroCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiltroDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltroNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltroNroDocIdentidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.lblResultados = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvResultados_CodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_TipoDocumentoIdentidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_NroDocumentoIdentidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_AreaContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_FlagActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkActivo);
            this.groupBox1.Controls.Add(this.txtFiltroAreaContacto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFiltroContacto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFiltroCorreo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFiltroDireccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFiltroNombres);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFiltroNroDocIdentidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(218, 77);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(57, 17);
            this.chkActivo.TabIndex = 12;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtFiltroAreaContacto
            // 
            this.txtFiltroAreaContacto.Location = new System.Drawing.Point(112, 73);
            this.txtFiltroAreaContacto.Name = "txtFiltroAreaContacto";
            this.txtFiltroAreaContacto.Size = new System.Drawing.Size(100, 21);
            this.txtFiltroAreaContacto.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Área de Contacto";
            // 
            // txtFiltroContacto
            // 
            this.txtFiltroContacto.Location = new System.Drawing.Point(6, 73);
            this.txtFiltroContacto.Name = "txtFiltroContacto";
            this.txtFiltroContacto.Size = new System.Drawing.Size(100, 21);
            this.txtFiltroContacto.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contacto";
            // 
            // txtFiltroCorreo
            // 
            this.txtFiltroCorreo.Location = new System.Drawing.Point(324, 33);
            this.txtFiltroCorreo.Name = "txtFiltroCorreo";
            this.txtFiltroCorreo.Size = new System.Drawing.Size(100, 21);
            this.txtFiltroCorreo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo";
            // 
            // txtFiltroDireccion
            // 
            this.txtFiltroDireccion.Location = new System.Drawing.Point(218, 33);
            this.txtFiltroDireccion.Name = "txtFiltroDireccion";
            this.txtFiltroDireccion.Size = new System.Drawing.Size(100, 21);
            this.txtFiltroDireccion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dirección";
            // 
            // txtFiltroNombres
            // 
            this.txtFiltroNombres.Location = new System.Drawing.Point(112, 33);
            this.txtFiltroNombres.Name = "txtFiltroNombres";
            this.txtFiltroNombres.Size = new System.Drawing.Size(100, 21);
            this.txtFiltroNombres.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres";
            // 
            // txtFiltroNroDocIdentidad
            // 
            this.txtFiltroNroDocIdentidad.Location = new System.Drawing.Point(6, 33);
            this.txtFiltroNroDocIdentidad.Name = "txtFiltroNroDocIdentidad";
            this.txtFiltroNroDocIdentidad.Size = new System.Drawing.Size(100, 21);
            this.txtFiltroNroDocIdentidad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Doc. Identidad";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(367, 121);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultados.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvResultados_CodigoCliente,
            this.dgvResultados_Nro,
            this.dgvResultados_TipoDocumentoIdentidad,
            this.dgvResultados_NroDocumentoIdentidad,
            this.dgvResultados_Nombres,
            this.dgvResultados_Direccion,
            this.dgvResultados_Correo,
            this.dgvResultados_Telefono,
            this.dgvResultados_Actividad,
            this.dgvResultados_Contacto,
            this.dgvResultados_AreaContacto,
            this.dgvResultados_FlagActivo});
            this.dgvResultados.Location = new System.Drawing.Point(12, 150);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(430, 288);
            this.dgvResultados.TabIndex = 2;
            this.dgvResultados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvResultados_MouseClick);
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(15, 126);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(0, 13);
            this.lblResultados.TabIndex = 3;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(286, 121);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvResultados_CodigoCliente
            // 
            this.dgvResultados_CodigoCliente.DataPropertyName = "CodigoCliente";
            this.dgvResultados_CodigoCliente.HeaderText = "CodigoCliente";
            this.dgvResultados_CodigoCliente.Name = "dgvResultados_CodigoCliente";
            this.dgvResultados_CodigoCliente.ReadOnly = true;
            this.dgvResultados_CodigoCliente.Visible = false;
            // 
            // dgvResultados_Nro
            // 
            this.dgvResultados_Nro.DataPropertyName = "Fila";
            this.dgvResultados_Nro.HeaderText = "N°";
            this.dgvResultados_Nro.Name = "dgvResultados_Nro";
            this.dgvResultados_Nro.ReadOnly = true;
            this.dgvResultados_Nro.Width = 44;
            // 
            // dgvResultados_TipoDocumentoIdentidad
            // 
            this.dgvResultados_TipoDocumentoIdentidad.DataPropertyName = "TipoDocumentoIdentidad";
            this.dgvResultados_TipoDocumentoIdentidad.HeaderText = "Tipo Doc. Identidad";
            this.dgvResultados_TipoDocumentoIdentidad.Name = "dgvResultados_TipoDocumentoIdentidad";
            this.dgvResultados_TipoDocumentoIdentidad.ReadOnly = true;
            this.dgvResultados_TipoDocumentoIdentidad.Width = 130;
            // 
            // dgvResultados_NroDocumentoIdentidad
            // 
            this.dgvResultados_NroDocumentoIdentidad.DataPropertyName = "NroDocumentoIdentidad";
            this.dgvResultados_NroDocumentoIdentidad.HeaderText = "N° Doc. Identidad";
            this.dgvResultados_NroDocumentoIdentidad.Name = "dgvResultados_NroDocumentoIdentidad";
            this.dgvResultados_NroDocumentoIdentidad.ReadOnly = true;
            this.dgvResultados_NroDocumentoIdentidad.Width = 120;
            // 
            // dgvResultados_Nombres
            // 
            this.dgvResultados_Nombres.DataPropertyName = "Nombres";
            this.dgvResultados_Nombres.HeaderText = "Nombres";
            this.dgvResultados_Nombres.Name = "dgvResultados_Nombres";
            this.dgvResultados_Nombres.ReadOnly = true;
            this.dgvResultados_Nombres.Width = 200;
            // 
            // dgvResultados_Direccion
            // 
            this.dgvResultados_Direccion.DataPropertyName = "Direccion";
            this.dgvResultados_Direccion.HeaderText = "Dirección";
            this.dgvResultados_Direccion.Name = "dgvResultados_Direccion";
            this.dgvResultados_Direccion.ReadOnly = true;
            this.dgvResultados_Direccion.Width = 200;
            // 
            // dgvResultados_Correo
            // 
            this.dgvResultados_Correo.DataPropertyName = "Correo";
            this.dgvResultados_Correo.HeaderText = "Correo Electrónico";
            this.dgvResultados_Correo.Name = "dgvResultados_Correo";
            this.dgvResultados_Correo.ReadOnly = true;
            this.dgvResultados_Correo.Width = 130;
            // 
            // dgvResultados_Telefono
            // 
            this.dgvResultados_Telefono.DataPropertyName = "Telefono";
            this.dgvResultados_Telefono.HeaderText = "Teléfono";
            this.dgvResultados_Telefono.Name = "dgvResultados_Telefono";
            this.dgvResultados_Telefono.ReadOnly = true;
            this.dgvResultados_Telefono.Width = 75;
            // 
            // dgvResultados_Actividad
            // 
            this.dgvResultados_Actividad.DataPropertyName = "ActividadPrincipal";
            this.dgvResultados_Actividad.HeaderText = "Actividad";
            this.dgvResultados_Actividad.Name = "dgvResultados_Actividad";
            this.dgvResultados_Actividad.ReadOnly = true;
            this.dgvResultados_Actividad.Width = 130;
            // 
            // dgvResultados_Contacto
            // 
            this.dgvResultados_Contacto.DataPropertyName = "Contacto";
            this.dgvResultados_Contacto.HeaderText = "Contacto";
            this.dgvResultados_Contacto.Name = "dgvResultados_Contacto";
            this.dgvResultados_Contacto.ReadOnly = true;
            this.dgvResultados_Contacto.Width = 150;
            // 
            // dgvResultados_AreaContacto
            // 
            this.dgvResultados_AreaContacto.DataPropertyName = "AreaContacto";
            this.dgvResultados_AreaContacto.HeaderText = "Área Contacto";
            this.dgvResultados_AreaContacto.Name = "dgvResultados_AreaContacto";
            this.dgvResultados_AreaContacto.ReadOnly = true;
            this.dgvResultados_AreaContacto.Width = 130;
            // 
            // dgvResultados_FlagActivo
            // 
            this.dgvResultados_FlagActivo.DataPropertyName = "FlagActivo";
            this.dgvResultados_FlagActivo.HeaderText = "Activo";
            this.dgvResultados_FlagActivo.Name = "dgvResultados_FlagActivo";
            this.dgvResultados_FlagActivo.ReadOnly = true;
            this.dgvResultados_FlagActivo.Width = 80;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtFiltroAreaContacto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiltroContacto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFiltroCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiltroDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltroNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltroNroDocIdentidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_CodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_TipoDocumentoIdentidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_NroDocumentoIdentidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_AreaContacto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvResultados_FlagActivo;
    }
}