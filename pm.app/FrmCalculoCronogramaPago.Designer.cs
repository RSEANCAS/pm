namespace pm.app
{
    partial class FrmCalculoCronogramaPago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.dgvResultados_Fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.tltCalculoCronogramaPago = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtImporteFactura = new System.Windows.Forms.TextBox();
            this.txtImporteTotalLetras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbAval = new System.Windows.Forms.GroupBox();
            this.btnBuscarAval = new System.Windows.Forms.Button();
            this.lblErrorCliente = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUbicacionAval = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDireccionAval = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCorreoAval = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombresAval = new System.Windows.Forms.TextBox();
            this.txtNroDocumentoIdentidadAval = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbCodigoTipoDocumentoIdentidadAval = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkTieneAval = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.gpbAval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultados.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvResultados_Fila,
            this.dgvResultados_Dias,
            this.dgvResultados_FechaVencimiento,
            this.dgvResultados_Monto});
            this.dgvResultados.Location = new System.Drawing.Point(12, 230);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(360, 160);
            this.dgvResultados.TabIndex = 2;
            this.dgvResultados.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellValueChanged);
            // 
            // dgvResultados_Fila
            // 
            this.dgvResultados_Fila.DataPropertyName = "Fila";
            this.dgvResultados_Fila.HeaderText = "N°";
            this.dgvResultados_Fila.Name = "dgvResultados_Fila";
            this.dgvResultados_Fila.ReadOnly = true;
            this.dgvResultados_Fila.Width = 30;
            // 
            // dgvResultados_Dias
            // 
            this.dgvResultados_Dias.DataPropertyName = "Dias";
            this.dgvResultados_Dias.HeaderText = "Días";
            this.dgvResultados_Dias.Name = "dgvResultados_Dias";
            // 
            // dgvResultados_FechaVencimiento
            // 
            this.dgvResultados_FechaVencimiento.DataPropertyName = "FechaVencimiento";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.dgvResultados_FechaVencimiento.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultados_FechaVencimiento.HeaderText = "Fecha Vencimiento";
            this.dgvResultados_FechaVencimiento.Name = "dgvResultados_FechaVencimiento";
            this.dgvResultados_FechaVencimiento.ReadOnly = true;
            this.dgvResultados_FechaVencimiento.Width = 127;
            // 
            // dgvResultados_Monto
            // 
            this.dgvResultados_Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle2.Format = "#,##0.00";
            this.dgvResultados_Monto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultados_Monto.HeaderText = "Monto";
            this.dgvResultados_Monto.Name = "dgvResultados_Monto";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(155, 435);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Importe Factura";
            // 
            // txtImporteFactura
            // 
            this.txtImporteFactura.Location = new System.Drawing.Point(12, 409);
            this.txtImporteFactura.Name = "txtImporteFactura";
            this.txtImporteFactura.ReadOnly = true;
            this.txtImporteFactura.Size = new System.Drawing.Size(150, 20);
            this.txtImporteFactura.TabIndex = 3;
            // 
            // txtImporteTotalLetras
            // 
            this.txtImporteTotalLetras.Location = new System.Drawing.Point(222, 409);
            this.txtImporteTotalLetras.Name = "txtImporteTotalLetras";
            this.txtImporteTotalLetras.ReadOnly = true;
            this.txtImporteTotalLetras.Size = new System.Drawing.Size(150, 20);
            this.txtImporteTotalLetras.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Monto de Letras";
            // 
            // gpbAval
            // 
            this.gpbAval.Controls.Add(this.btnBuscarAval);
            this.gpbAval.Controls.Add(this.lblErrorCliente);
            this.gpbAval.Controls.Add(this.label17);
            this.gpbAval.Controls.Add(this.txtUbicacionAval);
            this.gpbAval.Controls.Add(this.label14);
            this.gpbAval.Controls.Add(this.txtDireccionAval);
            this.gpbAval.Controls.Add(this.label12);
            this.gpbAval.Controls.Add(this.txtCorreoAval);
            this.gpbAval.Controls.Add(this.label11);
            this.gpbAval.Controls.Add(this.txtNombresAval);
            this.gpbAval.Controls.Add(this.txtNroDocumentoIdentidadAval);
            this.gpbAval.Controls.Add(this.label10);
            this.gpbAval.Controls.Add(this.cbbCodigoTipoDocumentoIdentidadAval);
            this.gpbAval.Controls.Add(this.label9);
            this.gpbAval.Enabled = false;
            this.gpbAval.Location = new System.Drawing.Point(12, 35);
            this.gpbAval.Name = "gpbAval";
            this.gpbAval.Size = new System.Drawing.Size(360, 189);
            this.gpbAval.TabIndex = 1;
            this.gpbAval.TabStop = false;
            this.gpbAval.Text = "Datos del Aval";
            // 
            // btnBuscarAval
            // 
            this.btnBuscarAval.Location = new System.Drawing.Point(297, 32);
            this.btnBuscarAval.Name = "btnBuscarAval";
            this.btnBuscarAval.Size = new System.Drawing.Size(57, 23);
            this.btnBuscarAval.TabIndex = 2;
            this.btnBuscarAval.Text = "Buscar";
            this.btnBuscarAval.UseVisualStyleBackColor = true;
            this.btnBuscarAval.Click += new System.EventHandler(this.btnBuscarAval_Click);
            // 
            // lblErrorCliente
            // 
            this.lblErrorCliente.AutoSize = true;
            this.lblErrorCliente.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCliente.Location = new System.Drawing.Point(3, 173);
            this.lblErrorCliente.Name = "lblErrorCliente";
            this.lblErrorCliente.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCliente.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 134);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Ubicación";
            // 
            // txtUbicacionAval
            // 
            this.txtUbicacionAval.Location = new System.Drawing.Point(6, 150);
            this.txtUbicacionAval.Name = "txtUbicacionAval";
            this.txtUbicacionAval.ReadOnly = true;
            this.txtUbicacionAval.Size = new System.Drawing.Size(348, 20);
            this.txtUbicacionAval.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Dirección";
            // 
            // txtDireccionAval
            // 
            this.txtDireccionAval.Location = new System.Drawing.Point(6, 111);
            this.txtDireccionAval.Name = "txtDireccionAval";
            this.txtDireccionAval.ReadOnly = true;
            this.txtDireccionAval.Size = new System.Drawing.Size(348, 20);
            this.txtDireccionAval.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(181, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Correo Electrónico";
            // 
            // txtCorreoAval
            // 
            this.txtCorreoAval.Location = new System.Drawing.Point(184, 73);
            this.txtCorreoAval.Name = "txtCorreoAval";
            this.txtCorreoAval.ReadOnly = true;
            this.txtCorreoAval.Size = new System.Drawing.Size(170, 20);
            this.txtCorreoAval.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Nombres";
            // 
            // txtNombresAval
            // 
            this.txtNombresAval.Location = new System.Drawing.Point(6, 73);
            this.txtNombresAval.Name = "txtNombresAval";
            this.txtNombresAval.ReadOnly = true;
            this.txtNombresAval.Size = new System.Drawing.Size(170, 20);
            this.txtNombresAval.TabIndex = 3;
            // 
            // txtNroDocumentoIdentidadAval
            // 
            this.txtNroDocumentoIdentidadAval.Location = new System.Drawing.Point(184, 33);
            this.txtNroDocumentoIdentidadAval.Name = "txtNroDocumentoIdentidadAval";
            this.txtNroDocumentoIdentidadAval.Size = new System.Drawing.Size(110, 20);
            this.txtNroDocumentoIdentidadAval.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "N° Doc. Identidad";
            // 
            // cbbCodigoTipoDocumentoIdentidadAval
            // 
            this.cbbCodigoTipoDocumentoIdentidadAval.DisplayMember = "Descripcion";
            this.cbbCodigoTipoDocumentoIdentidadAval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoTipoDocumentoIdentidadAval.Enabled = false;
            this.cbbCodigoTipoDocumentoIdentidadAval.FormattingEnabled = true;
            this.cbbCodigoTipoDocumentoIdentidadAval.Location = new System.Drawing.Point(6, 33);
            this.cbbCodigoTipoDocumentoIdentidadAval.Name = "cbbCodigoTipoDocumentoIdentidadAval";
            this.cbbCodigoTipoDocumentoIdentidadAval.Size = new System.Drawing.Size(170, 21);
            this.cbbCodigoTipoDocumentoIdentidadAval.TabIndex = 0;
            this.cbbCodigoTipoDocumentoIdentidadAval.ValueMember = "CodigoTipoDocumentoIdentidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tipo Doc. Identidad";
            // 
            // chkTieneAval
            // 
            this.chkTieneAval.AutoSize = true;
            this.chkTieneAval.Location = new System.Drawing.Point(12, 12);
            this.chkTieneAval.Name = "chkTieneAval";
            this.chkTieneAval.Size = new System.Drawing.Size(78, 17);
            this.chkTieneAval.TabIndex = 0;
            this.chkTieneAval.Text = "Tiene Aval";
            this.chkTieneAval.UseVisualStyleBackColor = true;
            this.chkTieneAval.CheckedChanged += new System.EventHandler(this.chkTieneAval_CheckedChanged);
            // 
            // FrmCalculoCronogramaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 470);
            this.Controls.Add(this.chkTieneAval);
            this.Controls.Add(this.gpbAval);
            this.Controls.Add(this.txtImporteTotalLetras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImporteFactura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dgvResultados);
            this.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.Name = "FrmCalculoCronogramaPago";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCalculoCronogramaPago";
            this.Load += new System.EventHandler(this.FrmCalculoCronogramaPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.gpbAval.ResumeLayout(false);
            this.gpbAval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ToolTip tltCalculoCronogramaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Monto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImporteFactura;
        private System.Windows.Forms.TextBox txtImporteTotalLetras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbAval;
        private System.Windows.Forms.Button btnBuscarAval;
        private System.Windows.Forms.Label lblErrorCliente;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUbicacionAval;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDireccionAval;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCorreoAval;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombresAval;
        private System.Windows.Forms.TextBox txtNroDocumentoIdentidadAval;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbCodigoTipoDocumentoIdentidadAval;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkTieneAval;
    }
}