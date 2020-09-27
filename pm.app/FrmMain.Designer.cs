namespace pm.app
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.stsInfo = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuarioNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPersonalNombres = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPC = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbbPerfil = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.stsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // stsInfo
            // 
            this.stsInfo.Font = new System.Drawing.Font("Roboto", 9F);
            this.stsInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuarioNombre,
            this.toolStripStatusLabel3,
            this.lblPersonalNombres,
            this.toolStripStatusLabel5,
            this.lblIP,
            this.toolStripStatusLabel7,
            this.lblPC,
            this.toolStripStatusLabel2,
            this.cbbPerfil});
            this.stsInfo.Location = new System.Drawing.Point(0, 428);
            this.stsInfo.Name = "stsInfo";
            this.stsInfo.Size = new System.Drawing.Size(907, 22);
            this.stsInfo.TabIndex = 0;
            this.stsInfo.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 17);
            this.toolStripStatusLabel1.Text = "Usuario: ";
            // 
            // lblUsuarioNombre
            // 
            this.lblUsuarioNombre.Name = "lblUsuarioNombre";
            this.lblUsuarioNombre.Size = new System.Drawing.Size(106, 17);
            this.lblUsuarioNombre.Text = "lblUsuarioNombre";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel3.Text = "Nombre(s) y Apellidos: ";
            // 
            // lblPersonalNombres
            // 
            this.lblPersonalNombres.Name = "lblPersonalNombres";
            this.lblPersonalNombres.Size = new System.Drawing.Size(118, 17);
            this.lblPersonalNombres.Text = "lblPersonalNombres";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(25, 17);
            this.toolStripStatusLabel5.Text = "IP: ";
            // 
            // lblIP
            // 
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(31, 17);
            this.lblIP.Text = "lblIP";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabel7.Text = "PC: ";
            // 
            // lblPC
            // 
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(36, 17);
            this.lblPC.Text = "lblPC";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel2.Text = "Perfil: ";
            // 
            // cbbPerfil
            // 
            this.cbbPerfil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cbbPerfil.Image = ((System.Drawing.Image)(resources.GetObject("cbbPerfil.Image")));
            this.cbbPerfil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cbbPerfil.Name = "cbbPerfil";
            this.cbbPerfil.Size = new System.Drawing.Size(48, 20);
            this.cbbPerfil.Text = "Perfil";
            // 
            // mnsMenu
            // 
            this.mnsMenu.Font = new System.Drawing.Font("Roboto", 9F);
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(907, 24);
            this.mnsMenu.TabIndex = 1;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.stsInfo);
            this.Controls.Add(this.mnsMenu);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "FrmMain";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pronto Moda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.stsInfo.ResumeLayout(false);
            this.stsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioNombre;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblPersonalNombres;
        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lblIP;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel lblPC;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripDropDownButton cbbPerfil;
    }
}