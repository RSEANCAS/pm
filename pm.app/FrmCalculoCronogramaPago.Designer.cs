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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbCodigoBanco = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvResultados_Fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblErrorCodigoBanco = new System.Windows.Forms.Label();
            this.tltCalculoCronogramaPago = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.dgvResultados.Location = new System.Drawing.Point(12, 90);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(360, 209);
            this.dgvResultados.TabIndex = 0;
            this.dgvResultados.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblErrorCodigoBanco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbCodigoBanco);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // cbbCodigoBanco
            // 
            this.cbbCodigoBanco.DisplayMember = "Nombre";
            this.cbbCodigoBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoBanco.FormattingEnabled = true;
            this.cbbCodigoBanco.Location = new System.Drawing.Point(9, 32);
            this.cbbCodigoBanco.Name = "cbbCodigoBanco";
            this.cbbCodigoBanco.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoBanco.TabIndex = 0;
            this.cbbCodigoBanco.ValueMember = "CodigoBanco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Banco";
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
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            this.dgvResultados_FechaVencimiento.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResultados_FechaVencimiento.HeaderText = "Fecha Vencimiento";
            this.dgvResultados_FechaVencimiento.Name = "dgvResultados_FechaVencimiento";
            this.dgvResultados_FechaVencimiento.ReadOnly = true;
            this.dgvResultados_FechaVencimiento.Width = 127;
            // 
            // dgvResultados_Monto
            // 
            this.dgvResultados_Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle6.Format = "#,##0.00";
            this.dgvResultados_Monto.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResultados_Monto.HeaderText = "Monto";
            this.dgvResultados_Monto.Name = "dgvResultados_Monto";
            this.dgvResultados_Monto.ReadOnly = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(155, 305);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblErrorCodigoBanco
            // 
            this.lblErrorCodigoBanco.AutoSize = true;
            this.lblErrorCodigoBanco.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoBanco.Location = new System.Drawing.Point(6, 56);
            this.lblErrorCodigoBanco.Name = "lblErrorCodigoBanco";
            this.lblErrorCodigoBanco.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoBanco.TabIndex = 10;
            // 
            // FrmCalculoCronogramaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 340);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvResultados);
            this.Name = "FrmCalculoCronogramaPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCalculoCronogramaPago";
            this.Load += new System.EventHandler(this.FrmCalculoCronogramaPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCodigoBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Monto;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblErrorCodigoBanco;
        private System.Windows.Forms.ToolTip tltCalculoCronogramaPago;
    }
}