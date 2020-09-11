namespace pm.app
{
    partial class FrmSerie
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
            this.lblResultados = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbFiltroCodigoTipoComprobante = new System.Windows.Forms.ComboBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtFiltroSerial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvResultados_CodigoSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultado_TipoComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultado_ValorInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultado_ValorActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultado_ValorFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_FlagActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(15, 92);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(0, 13);
            this.lblResultados.TabIndex = 18;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(557, 82);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.dgvResultados_CodigoSerie,
            this.dgvResultados_Nro,
            this.dgvResultado_TipoComprobante,
            this.dgvResultados_Serial,
            this.dgvResultado_ValorInicial,
            this.dgvResultado_ValorActual,
            this.dgvResultado_ValorFinal,
            this.dgvResultados_FlagActivo});
            this.dgvResultados.Location = new System.Drawing.Point(12, 111);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(701, 167);
            this.dgvResultados.TabIndex = 16;
            this.dgvResultados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvResultados_MouseClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(638, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbFiltroCodigoTipoComprobante);
            this.groupBox1.Controls.Add(this.chkActivo);
            this.groupBox1.Controls.Add(this.txtFiltroSerial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 64);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo Comprobante";
            // 
            // cbbFiltroCodigoTipoComprobante
            // 
            this.cbbFiltroCodigoTipoComprobante.DisplayMember = "Nombre";
            this.cbbFiltroCodigoTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFiltroCodigoTipoComprobante.FormattingEnabled = true;
            this.cbbFiltroCodigoTipoComprobante.Location = new System.Drawing.Point(112, 33);
            this.cbbFiltroCodigoTipoComprobante.Name = "cbbFiltroCodigoTipoComprobante";
            this.cbbFiltroCodigoTipoComprobante.Size = new System.Drawing.Size(100, 21);
            this.cbbFiltroCodigoTipoComprobante.TabIndex = 13;
            this.cbbFiltroCodigoTipoComprobante.ValueMember = "CodigoTipoComprobante";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(218, 37);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(57, 17);
            this.chkActivo.TabIndex = 12;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtFiltroSerial
            // 
            this.txtFiltroSerial.Location = new System.Drawing.Point(6, 33);
            this.txtFiltroSerial.Name = "txtFiltroSerial";
            this.txtFiltroSerial.Size = new System.Drawing.Size(100, 21);
            this.txtFiltroSerial.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Serial";
            // 
            // dgvResultados_CodigoSerie
            // 
            this.dgvResultados_CodigoSerie.DataPropertyName = "CodigoSerie";
            this.dgvResultados_CodigoSerie.HeaderText = "CodigoSerie";
            this.dgvResultados_CodigoSerie.Name = "dgvResultados_CodigoSerie";
            this.dgvResultados_CodigoSerie.ReadOnly = true;
            this.dgvResultados_CodigoSerie.Visible = false;
            // 
            // dgvResultados_Nro
            // 
            this.dgvResultados_Nro.DataPropertyName = "Fila";
            this.dgvResultados_Nro.HeaderText = "N°";
            this.dgvResultados_Nro.Name = "dgvResultados_Nro";
            this.dgvResultados_Nro.ReadOnly = true;
            this.dgvResultados_Nro.Width = 44;
            // 
            // dgvResultado_TipoComprobante
            // 
            this.dgvResultado_TipoComprobante.DataPropertyName = "TipoComprobante";
            this.dgvResultado_TipoComprobante.HeaderText = "Tipo Comprobante";
            this.dgvResultado_TipoComprobante.Name = "dgvResultado_TipoComprobante";
            this.dgvResultado_TipoComprobante.ReadOnly = true;
            this.dgvResultado_TipoComprobante.Width = 130;
            // 
            // dgvResultados_Serial
            // 
            this.dgvResultados_Serial.DataPropertyName = "Serial";
            this.dgvResultados_Serial.HeaderText = "Serial";
            this.dgvResultados_Serial.Name = "dgvResultados_Serial";
            this.dgvResultados_Serial.ReadOnly = true;
            // 
            // dgvResultado_ValorInicial
            // 
            this.dgvResultado_ValorInicial.DataPropertyName = "ValorInicial";
            this.dgvResultado_ValorInicial.HeaderText = "Valor Inicial";
            this.dgvResultado_ValorInicial.Name = "dgvResultado_ValorInicial";
            this.dgvResultado_ValorInicial.ReadOnly = true;
            // 
            // dgvResultado_ValorActual
            // 
            this.dgvResultado_ValorActual.DataPropertyName = "ValorActual";
            this.dgvResultado_ValorActual.HeaderText = "Valor Actual";
            this.dgvResultado_ValorActual.Name = "dgvResultado_ValorActual";
            this.dgvResultado_ValorActual.ReadOnly = true;
            // 
            // dgvResultado_ValorFinal
            // 
            this.dgvResultado_ValorFinal.DataPropertyName = "ValorFinal";
            this.dgvResultado_ValorFinal.HeaderText = "Valor Final";
            this.dgvResultado_ValorFinal.Name = "dgvResultado_ValorFinal";
            this.dgvResultado_ValorFinal.ReadOnly = true;
            // 
            // dgvResultados_FlagActivo
            // 
            this.dgvResultados_FlagActivo.DataPropertyName = "FlagActivo";
            this.dgvResultados_FlagActivo.HeaderText = "Activo";
            this.dgvResultados_FlagActivo.Name = "dgvResultados_FlagActivo";
            this.dgvResultados_FlagActivo.ReadOnly = true;
            this.dgvResultados_FlagActivo.Width = 80;
            // 
            // FrmSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 290);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.Name = "FrmSerie";
            this.Text = "Series";
            this.Load += new System.EventHandler(this.FrmSerie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtFiltroSerial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbFiltroCodigoTipoComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_CodigoSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultado_TipoComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultado_ValorInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultado_ValorActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultado_ValorFinal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvResultados_FlagActivo;
    }
}