namespace pm.app
{
    partial class FrmMantenimientoUsuario
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
            this.lblErrorContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarPersonal = new System.Windows.Forms.Button();
            this.txtNombresPersonal = new System.Windows.Forms.TextBox();
            this.lblErrorPersonal = new System.Windows.Forms.Label();
            this.txtNroDocIdentidadPersonal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tvwPerfil = new System.Windows.Forms.TreeView();
            this.lblErrorListaPerfil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tltUsuario = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(297, 357);
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
            this.groupBox1.Controls.Add(this.lblErrorContraseña);
            this.groupBox1.Controls.Add(this.txtContraseña);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnBuscarPersonal);
            this.groupBox1.Controls.Add(this.txtNombresPersonal);
            this.groupBox1.Controls.Add(this.lblErrorPersonal);
            this.groupBox1.Controls.Add(this.txtNroDocIdentidadPersonal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tvwPerfil);
            this.groupBox1.Controls.Add(this.lblErrorListaPerfil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblErrorNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // lblErrorContraseña
            // 
            this.lblErrorContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorContraseña.AutoSize = true;
            this.lblErrorContraseña.ForeColor = System.Drawing.Color.Red;
            this.lblErrorContraseña.Location = new System.Drawing.Point(180, 56);
            this.lblErrorContraseña.Name = "lblErrorContraseña";
            this.lblErrorContraseña.Size = new System.Drawing.Size(0, 13);
            this.lblErrorContraseña.TabIndex = 32;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseña.Location = new System.Drawing.Point(183, 32);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(168, 20);
            this.txtContraseña.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Contraseña";
            // 
            // btnBuscarPersonal
            // 
            this.btnBuscarPersonal.Location = new System.Drawing.Point(293, 83);
            this.btnBuscarPersonal.Name = "btnBuscarPersonal";
            this.btnBuscarPersonal.Size = new System.Drawing.Size(58, 23);
            this.btnBuscarPersonal.TabIndex = 4;
            this.btnBuscarPersonal.Text = "Buscar";
            this.btnBuscarPersonal.UseVisualStyleBackColor = true;
            this.btnBuscarPersonal.Click += new System.EventHandler(this.btnBuscarPersonal_Click);
            // 
            // txtNombresPersonal
            // 
            this.txtNombresPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombresPersonal.Location = new System.Drawing.Point(70, 85);
            this.txtNombresPersonal.Name = "txtNombresPersonal";
            this.txtNombresPersonal.ReadOnly = true;
            this.txtNombresPersonal.Size = new System.Drawing.Size(217, 20);
            this.txtNombresPersonal.TabIndex = 3;
            // 
            // lblErrorPersonal
            // 
            this.lblErrorPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorPersonal.AutoSize = true;
            this.lblErrorPersonal.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPersonal.Location = new System.Drawing.Point(6, 109);
            this.lblErrorPersonal.Name = "lblErrorPersonal";
            this.lblErrorPersonal.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPersonal.TabIndex = 27;
            // 
            // txtNroDocIdentidadPersonal
            // 
            this.txtNroDocIdentidadPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNroDocIdentidadPersonal.Location = new System.Drawing.Point(9, 85);
            this.txtNroDocIdentidadPersonal.Name = "txtNroDocIdentidadPersonal";
            this.txtNroDocIdentidadPersonal.Size = new System.Drawing.Size(55, 20);
            this.txtNroDocIdentidadPersonal.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Personal";
            // 
            // tvwPerfil
            // 
            this.tvwPerfil.CheckBoxes = true;
            this.tvwPerfil.Location = new System.Drawing.Point(9, 138);
            this.tvwPerfil.Name = "tvwPerfil";
            this.tvwPerfil.Size = new System.Drawing.Size(342, 182);
            this.tvwPerfil.TabIndex = 5;
            // 
            // lblErrorListaPerfil
            // 
            this.lblErrorListaPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorListaPerfil.AutoSize = true;
            this.lblErrorListaPerfil.ForeColor = System.Drawing.Color.Red;
            this.lblErrorListaPerfil.Location = new System.Drawing.Point(6, 323);
            this.lblErrorListaPerfil.Name = "lblErrorListaPerfil";
            this.lblErrorListaPerfil.Size = new System.Drawing.Size(0, 13);
            this.lblErrorListaPerfil.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Asignación de perfiles";
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(6, 56);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(0, 13);
            this.lblErrorNombre.TabIndex = 20;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(9, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // FrmMantenimientoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 392);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMantenimientoUsuario";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMantenimientoUsuario";
            this.Load += new System.EventHandler(this.FrmMantenimientoUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarPersonal;
        private System.Windows.Forms.TextBox txtNombresPersonal;
        private System.Windows.Forms.Label lblErrorPersonal;
        private System.Windows.Forms.TextBox txtNroDocIdentidadPersonal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView tvwPerfil;
        private System.Windows.Forms.Label lblErrorListaPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblErrorContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip tltUsuario;
    }
}