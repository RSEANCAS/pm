namespace pm.app
{
    partial class FrmProducto
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.dgvResultados_CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_ValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_ValorVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_DescuentoMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_MetrajeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_EstadoStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiltroColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltroNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltroCodigoProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(557, 82);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 13;
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
            this.dgvResultados_CodigoProducto,
            this.dgvResultados_Nro,
            this.dgvResultados_Nombre,
            this.dgvResultados_UnidadMedida,
            this.dgvResultados_Cantidad,
            this.dgvResultados_ValorCompra,
            this.dgvResultados_ValorVenta,
            this.dgvResultados_DescuentoMaximo,
            this.dgvResultados_Color,
            this.dgvResultados_MetrajeTotal,
            this.dgvResultados_Estado,
            this.dgvResultados_EstadoStr});
            this.dgvResultados.Location = new System.Drawing.Point(12, 111);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(701, 167);
            this.dgvResultados.TabIndex = 12;
            this.dgvResultados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvResultados_MouseClick);
            // 
            // dgvResultados_CodigoProducto
            // 
            this.dgvResultados_CodigoProducto.DataPropertyName = "CodigoProducto";
            this.dgvResultados_CodigoProducto.HeaderText = "CodigoProducto";
            this.dgvResultados_CodigoProducto.Name = "dgvResultados_CodigoProducto";
            this.dgvResultados_CodigoProducto.ReadOnly = true;
            this.dgvResultados_CodigoProducto.Visible = false;
            // 
            // dgvResultados_Nro
            // 
            this.dgvResultados_Nro.DataPropertyName = "Fila";
            this.dgvResultados_Nro.HeaderText = "N°";
            this.dgvResultados_Nro.Name = "dgvResultados_Nro";
            this.dgvResultados_Nro.ReadOnly = true;
            this.dgvResultados_Nro.Width = 44;
            // 
            // dgvResultados_Nombre
            // 
            this.dgvResultados_Nombre.DataPropertyName = "Nombre";
            this.dgvResultados_Nombre.HeaderText = "Nombre";
            this.dgvResultados_Nombre.Name = "dgvResultados_Nombre";
            this.dgvResultados_Nombre.ReadOnly = true;
            this.dgvResultados_Nombre.Width = 200;
            // 
            // dgvResultados_UnidadMedida
            // 
            this.dgvResultados_UnidadMedida.DataPropertyName = "UnidadMedida";
            this.dgvResultados_UnidadMedida.HeaderText = "Unidad Medida";
            this.dgvResultados_UnidadMedida.Name = "dgvResultados_UnidadMedida";
            this.dgvResultados_UnidadMedida.ReadOnly = true;
            this.dgvResultados_UnidadMedida.Width = 120;
            // 
            // dgvResultados_Cantidad
            // 
            this.dgvResultados_Cantidad.DataPropertyName = "Cantidad";
            this.dgvResultados_Cantidad.HeaderText = "Cantidad";
            this.dgvResultados_Cantidad.Name = "dgvResultados_Cantidad";
            this.dgvResultados_Cantidad.ReadOnly = true;
            // 
            // dgvResultados_ValorCompra
            // 
            this.dgvResultados_ValorCompra.DataPropertyName = "ValorCompra";
            this.dgvResultados_ValorCompra.HeaderText = "V. Compra";
            this.dgvResultados_ValorCompra.Name = "dgvResultados_ValorCompra";
            this.dgvResultados_ValorCompra.ReadOnly = true;
            // 
            // dgvResultados_ValorVenta
            // 
            this.dgvResultados_ValorVenta.DataPropertyName = "ValorVenta";
            this.dgvResultados_ValorVenta.HeaderText = "V. Venta";
            this.dgvResultados_ValorVenta.Name = "dgvResultados_ValorVenta";
            this.dgvResultados_ValorVenta.ReadOnly = true;
            // 
            // dgvResultados_DescuentoMaximo
            // 
            this.dgvResultados_DescuentoMaximo.DataPropertyName = "DescuentoMaximo";
            this.dgvResultados_DescuentoMaximo.HeaderText = "Desc. Máx.";
            this.dgvResultados_DescuentoMaximo.Name = "dgvResultados_DescuentoMaximo";
            this.dgvResultados_DescuentoMaximo.ReadOnly = true;
            this.dgvResultados_DescuentoMaximo.Width = 150;
            // 
            // dgvResultados_Color
            // 
            this.dgvResultados_Color.DataPropertyName = "Color";
            this.dgvResultados_Color.HeaderText = "Color";
            this.dgvResultados_Color.Name = "dgvResultados_Color";
            this.dgvResultados_Color.ReadOnly = true;
            // 
            // dgvResultados_MetrajeTotal
            // 
            this.dgvResultados_MetrajeTotal.DataPropertyName = "MetrajeTotal";
            this.dgvResultados_MetrajeTotal.HeaderText = "Metraje Total";
            this.dgvResultados_MetrajeTotal.Name = "dgvResultados_MetrajeTotal";
            this.dgvResultados_MetrajeTotal.ReadOnly = true;
            // 
            // dgvResultados_Estado
            // 
            this.dgvResultados_Estado.DataPropertyName = "Estado";
            this.dgvResultados_Estado.HeaderText = "Estado";
            this.dgvResultados_Estado.Name = "dgvResultados_Estado";
            this.dgvResultados_Estado.ReadOnly = true;
            this.dgvResultados_Estado.Visible = false;
            // 
            // dgvResultados_EstadoStr
            // 
            this.dgvResultados_EstadoStr.DataPropertyName = "EstadoStr";
            this.dgvResultados_EstadoStr.HeaderText = "Estado";
            this.dgvResultados_EstadoStr.Name = "dgvResultados_EstadoStr";
            this.dgvResultados_EstadoStr.ReadOnly = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(638, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbbEstado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFiltroColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFiltroNombres);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFiltroCodigoProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 64);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // cbbEstado
            // 
            this.cbbEstado.DisplayMember = "Text";
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(327, 33);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(100, 21);
            this.cbbEstado.TabIndex = 8;
            this.cbbEstado.ValueMember = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado";
            // 
            // txtFiltroColor
            // 
            this.txtFiltroColor.Location = new System.Drawing.Point(218, 33);
            this.txtFiltroColor.Name = "txtFiltroColor";
            this.txtFiltroColor.Size = new System.Drawing.Size(100, 21);
            this.txtFiltroColor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Color";
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
            // txtFiltroCodigoProducto
            // 
            this.txtFiltroCodigoProducto.Location = new System.Drawing.Point(6, 33);
            this.txtFiltroCodigoProducto.Name = "txtFiltroCodigoProducto";
            this.txtFiltroCodigoProducto.Size = new System.Drawing.Size(100, 21);
            this.txtFiltroCodigoProducto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(15, 92);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(0, 13);
            this.lblResultados.TabIndex = 14;
            // 
            // FrmProducto
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
            this.Name = "FrmProducto";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFiltroColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltroNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltroCodigoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_ValorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_ValorVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_DescuentoMaximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_MetrajeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_EstadoStr;
    }
}