namespace pm.app
{
    partial class FrmComprobanteCompraDetalleProductoIndividual
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
            this.lblResultados = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFiltroColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiltroCodigoProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltroCodigoBarra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltroCodigoProductoIndividual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblErrorDetalle = new System.Windows.Forms.Label();
            this.tltListaProductoIndividual = new System.Windows.Forms.ToolTip(this.components);
            this.dgvResultados_CodigoProductoIndividual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_CodigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Metraje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Rollo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Bulto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_CodigoInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultados_PersonalInspeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(11, 90);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(0, 13);
            this.lblResultados.TabIndex = 24;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(553, 77);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
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
            this.dgvResultados_CodigoProductoIndividual,
            this.dgvResultados_Nro,
            this.dgvResultados_CodigoBarra,
            this.dgvResultados_Nombre,
            this.dgvResultados_PrecioCompra,
            this.dgvResultados_PrecioVenta,
            this.dgvResultados_UnidadMedida,
            this.dgvResultados_Metraje,
            this.dgvResultados_Peso,
            this.dgvResultados_Rollo,
            this.dgvResultados_Bulto,
            this.dgvResultados_Color,
            this.dgvResultados_CodigoInicial,
            this.dgvResultados_Proveedor,
            this.dgvResultados_PersonalInspeccion});
            this.dgvResultados.Location = new System.Drawing.Point(8, 106);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(701, 172);
            this.dgvResultados.TabIndex = 3;
            this.dgvResultados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvResultados_MouseClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(634, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtFiltroColor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFiltroNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFiltroCodigoProducto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFiltroCodigoBarra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFiltroCodigoProductoIndividual);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // txtFiltroColor
            // 
            this.txtFiltroColor.Location = new System.Drawing.Point(430, 33);
            this.txtFiltroColor.Name = "txtFiltroColor";
            this.txtFiltroColor.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroColor.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Color";
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(324, 33);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroNombre.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre";
            // 
            // txtFiltroCodigoProducto
            // 
            this.txtFiltroCodigoProducto.Location = new System.Drawing.Point(218, 33);
            this.txtFiltroCodigoProducto.Name = "txtFiltroCodigoProducto";
            this.txtFiltroCodigoProducto.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroCodigoProducto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código Producto";
            // 
            // txtFiltroCodigoBarra
            // 
            this.txtFiltroCodigoBarra.Location = new System.Drawing.Point(112, 33);
            this.txtFiltroCodigoBarra.Name = "txtFiltroCodigoBarra";
            this.txtFiltroCodigoBarra.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroCodigoBarra.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código Barra";
            // 
            // txtFiltroCodigoProductoIndividual
            // 
            this.txtFiltroCodigoProductoIndividual.Location = new System.Drawing.Point(6, 33);
            this.txtFiltroCodigoProductoIndividual.Name = "txtFiltroCodigoProductoIndividual";
            this.txtFiltroCodigoProductoIndividual.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroCodigoProductoIndividual.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(630, 284);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblErrorDetalle
            // 
            this.lblErrorDetalle.AutoSize = true;
            this.lblErrorDetalle.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDetalle.Location = new System.Drawing.Point(11, 281);
            this.lblErrorDetalle.Name = "lblErrorDetalle";
            this.lblErrorDetalle.Size = new System.Drawing.Size(0, 13);
            this.lblErrorDetalle.TabIndex = 26;
            // 
            // dgvResultados_CodigoProductoIndividual
            // 
            this.dgvResultados_CodigoProductoIndividual.DataPropertyName = "CodigoProductoIndividual";
            this.dgvResultados_CodigoProductoIndividual.HeaderText = "CodigoProductoIndividual";
            this.dgvResultados_CodigoProductoIndividual.Name = "dgvResultados_CodigoProductoIndividual";
            this.dgvResultados_CodigoProductoIndividual.ReadOnly = true;
            this.dgvResultados_CodigoProductoIndividual.Visible = false;
            // 
            // dgvResultados_Nro
            // 
            this.dgvResultados_Nro.DataPropertyName = "Fila";
            this.dgvResultados_Nro.HeaderText = "N°";
            this.dgvResultados_Nro.Name = "dgvResultados_Nro";
            this.dgvResultados_Nro.ReadOnly = true;
            this.dgvResultados_Nro.Width = 44;
            // 
            // dgvResultados_CodigoBarra
            // 
            this.dgvResultados_CodigoBarra.DataPropertyName = "CodigoBarra";
            this.dgvResultados_CodigoBarra.HeaderText = "Codigo Barra";
            this.dgvResultados_CodigoBarra.Name = "dgvResultados_CodigoBarra";
            this.dgvResultados_CodigoBarra.ReadOnly = true;
            // 
            // dgvResultados_Nombre
            // 
            this.dgvResultados_Nombre.DataPropertyName = "Nombre";
            this.dgvResultados_Nombre.HeaderText = "Nombre";
            this.dgvResultados_Nombre.Name = "dgvResultados_Nombre";
            this.dgvResultados_Nombre.ReadOnly = true;
            this.dgvResultados_Nombre.Width = 200;
            // 
            // dgvResultados_PrecioCompra
            // 
            this.dgvResultados_PrecioCompra.DataPropertyName = "PrecioCompra";
            dataGridViewCellStyle1.Format = "#,##0.00";
            this.dgvResultados_PrecioCompra.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultados_PrecioCompra.HeaderText = "Precio Compra";
            this.dgvResultados_PrecioCompra.Name = "dgvResultados_PrecioCompra";
            this.dgvResultados_PrecioCompra.ReadOnly = true;
            this.dgvResultados_PrecioCompra.Width = 110;
            // 
            // dgvResultados_PrecioVenta
            // 
            this.dgvResultados_PrecioVenta.DataPropertyName = "PrecioVenta";
            dataGridViewCellStyle2.Format = "#,##0.00";
            this.dgvResultados_PrecioVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultados_PrecioVenta.HeaderText = "Precio Venta";
            this.dgvResultados_PrecioVenta.Name = "dgvResultados_PrecioVenta";
            this.dgvResultados_PrecioVenta.ReadOnly = true;
            // 
            // dgvResultados_UnidadMedida
            // 
            this.dgvResultados_UnidadMedida.DataPropertyName = "UnidadMedida";
            this.dgvResultados_UnidadMedida.HeaderText = "Unidad Medida";
            this.dgvResultados_UnidadMedida.Name = "dgvResultados_UnidadMedida";
            this.dgvResultados_UnidadMedida.ReadOnly = true;
            this.dgvResultados_UnidadMedida.Width = 130;
            // 
            // dgvResultados_Metraje
            // 
            this.dgvResultados_Metraje.DataPropertyName = "Metraje";
            this.dgvResultados_Metraje.HeaderText = "Metraje";
            this.dgvResultados_Metraje.Name = "dgvResultados_Metraje";
            this.dgvResultados_Metraje.ReadOnly = true;
            // 
            // dgvResultados_Peso
            // 
            this.dgvResultados_Peso.DataPropertyName = "Peso";
            this.dgvResultados_Peso.HeaderText = "Peso";
            this.dgvResultados_Peso.Name = "dgvResultados_Peso";
            this.dgvResultados_Peso.ReadOnly = true;
            // 
            // dgvResultados_Rollo
            // 
            this.dgvResultados_Rollo.DataPropertyName = "Rollo";
            this.dgvResultados_Rollo.HeaderText = "Rollo";
            this.dgvResultados_Rollo.Name = "dgvResultados_Rollo";
            this.dgvResultados_Rollo.ReadOnly = true;
            this.dgvResultados_Rollo.Width = 150;
            // 
            // dgvResultados_Bulto
            // 
            this.dgvResultados_Bulto.DataPropertyName = "Bulto";
            this.dgvResultados_Bulto.HeaderText = "Bulto";
            this.dgvResultados_Bulto.Name = "dgvResultados_Bulto";
            this.dgvResultados_Bulto.ReadOnly = true;
            // 
            // dgvResultados_Color
            // 
            this.dgvResultados_Color.DataPropertyName = "Color";
            this.dgvResultados_Color.HeaderText = "Color";
            this.dgvResultados_Color.Name = "dgvResultados_Color";
            this.dgvResultados_Color.ReadOnly = true;
            // 
            // dgvResultados_CodigoInicial
            // 
            this.dgvResultados_CodigoInicial.DataPropertyName = "CodigoInicial";
            this.dgvResultados_CodigoInicial.HeaderText = "Código Inicial";
            this.dgvResultados_CodigoInicial.Name = "dgvResultados_CodigoInicial";
            this.dgvResultados_CodigoInicial.ReadOnly = true;
            this.dgvResultados_CodigoInicial.Width = 130;
            // 
            // dgvResultados_Proveedor
            // 
            this.dgvResultados_Proveedor.DataPropertyName = "Proveedor";
            this.dgvResultados_Proveedor.HeaderText = "Proveedor";
            this.dgvResultados_Proveedor.Name = "dgvResultados_Proveedor";
            this.dgvResultados_Proveedor.ReadOnly = true;
            // 
            // dgvResultados_PersonalInspeccion
            // 
            this.dgvResultados_PersonalInspeccion.DataPropertyName = "PersonalInspeccion";
            this.dgvResultados_PersonalInspeccion.HeaderText = "Personal Inspección";
            this.dgvResultados_PersonalInspeccion.Name = "dgvResultados_PersonalInspeccion";
            this.dgvResultados_PersonalInspeccion.ReadOnly = true;
            this.dgvResultados_PersonalInspeccion.Width = 160;
            // 
            // FrmComprobanteCompraDetalleProductoIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 319);
            this.Controls.Add(this.lblErrorDetalle);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmComprobanteCompraDetalleProductoIndividual";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de Unidades";
            this.Load += new System.EventHandler(this.FrmComprobanteCompraDetalleProductoIndividual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFiltroColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiltroCodigoProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltroCodigoBarra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltroCodigoProductoIndividual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblErrorDetalle;
        private System.Windows.Forms.ToolTip tltListaProductoIndividual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_CodigoProductoIndividual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_CodigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Metraje;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Rollo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Bulto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_CodigoInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultados_PersonalInspeccion;
    }
}