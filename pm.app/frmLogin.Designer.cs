namespace pm.app
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkRecuperarContraseña = new System.Windows.Forms.LinkLabel();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.lblErrorUsuario = new System.Windows.Forms.Label();
            this.lblErrorContraseña = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pm.app.Properties.Resources.logo_pm;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(15, 97);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(176, 21);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(15, 154);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(176, 21);
            this.txtContraseña.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // lnkRecuperarContraseña
            // 
            this.lnkRecuperarContraseña.AutoSize = true;
            this.lnkRecuperarContraseña.Location = new System.Drawing.Point(55, 198);
            this.lnkRecuperarContraseña.Name = "lnkRecuperarContraseña";
            this.lnkRecuperarContraseña.Size = new System.Drawing.Size(136, 13);
            this.lnkRecuperarContraseña.TabIndex = 5;
            this.lnkRecuperarContraseña.TabStop = true;
            this.lnkRecuperarContraseña.Text = "¿Olvidaste tu contraseña?";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(56, 226);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(90, 23);
            this.btnIniciarSesion.TabIndex = 7;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // lblErrorUsuario
            // 
            this.lblErrorUsuario.AutoSize = true;
            this.lblErrorUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUsuario.Location = new System.Drawing.Point(12, 121);
            this.lblErrorUsuario.Name = "lblErrorUsuario";
            this.lblErrorUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblErrorUsuario.TabIndex = 8;
            // 
            // lblErrorContraseña
            // 
            this.lblErrorContraseña.AutoSize = true;
            this.lblErrorContraseña.ForeColor = System.Drawing.Color.Red;
            this.lblErrorContraseña.Location = new System.Drawing.Point(12, 178);
            this.lblErrorContraseña.Name = "lblErrorContraseña";
            this.lblErrorContraseña.Size = new System.Drawing.Size(0, 13);
            this.lblErrorContraseña.TabIndex = 9;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 261);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.lnkRecuperarContraseña);
            this.Controls.Add(this.lblErrorContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblErrorUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(219, 300);
            this.MinimumSize = new System.Drawing.Size(219, 300);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkRecuperarContraseña;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label lblErrorUsuario;
        private System.Windows.Forms.Label lblErrorContraseña;
    }
}

