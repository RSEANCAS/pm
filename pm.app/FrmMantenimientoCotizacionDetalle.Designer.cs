namespace pm.app
{
    partial class FrmMantenimientoCotizacionDetalle
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
            this.lblErrorCodigoUnidadMedida = new System.Windows.Forms.Label();
            this.cbbCodigoUnidadMedida = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoBarraProductoIndividual = new System.Windows.Forms.TextBox();
            this.lblErrorImporteTotal = new System.Windows.Forms.Label();
            this.txtImporteTotal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblErrorPrecioUnitario = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblErrorCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblErrorProductoIndividual = new System.Windows.Forms.Label();
            this.btnBuscarProductoIndividual = new System.Windows.Forms.Button();
            this.txtNombreProductoIndividual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblErrorProducto = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tltCotizacionDetalle = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(293, 245);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblErrorCodigoUnidadMedida);
            this.groupBox1.Controls.Add(this.cbbCodigoUnidadMedida);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodigoBarraProductoIndividual);
            this.groupBox1.Controls.Add(this.lblErrorImporteTotal);
            this.groupBox1.Controls.Add(this.txtImporteTotal);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lblErrorPrecioUnitario);
            this.groupBox1.Controls.Add(this.txtPrecioUnitario);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblErrorCantidad);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblErrorProductoIndividual);
            this.groupBox1.Controls.Add(this.btnBuscarProductoIndividual);
            this.groupBox1.Controls.Add(this.txtNombreProductoIndividual);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblErrorProducto);
            this.groupBox1.Controls.Add(this.btnBuscarProducto);
            this.groupBox1.Controls.Add(this.txtNombreProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Detalle";
            // 
            // lblErrorCodigoUnidadMedida
            // 
            this.lblErrorCodigoUnidadMedida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCodigoUnidadMedida.AutoSize = true;
            this.lblErrorCodigoUnidadMedida.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoUnidadMedida.Location = new System.Drawing.Point(8, 163);
            this.lblErrorCodigoUnidadMedida.Name = "lblErrorCodigoUnidadMedida";
            this.lblErrorCodigoUnidadMedida.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoUnidadMedida.TabIndex = 88;
            // 
            // cbbCodigoUnidadMedida
            // 
            this.cbbCodigoUnidadMedida.DisplayMember = "Descripcion";
            this.cbbCodigoUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoUnidadMedida.Enabled = false;
            this.cbbCodigoUnidadMedida.FormattingEnabled = true;
            this.cbbCodigoUnidadMedida.Location = new System.Drawing.Point(11, 139);
            this.cbbCodigoUnidadMedida.Name = "cbbCodigoUnidadMedida";
            this.cbbCodigoUnidadMedida.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoUnidadMedida.TabIndex = 5;
            this.cbbCodigoUnidadMedida.ValueMember = "CodigoUnidadMedida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Unidad Medida";
            // 
            // txtCodigoBarraProductoIndividual
            // 
            this.txtCodigoBarraProductoIndividual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoBarraProductoIndividual.Location = new System.Drawing.Point(11, 86);
            this.txtCodigoBarraProductoIndividual.Name = "txtCodigoBarraProductoIndividual";
            this.txtCodigoBarraProductoIndividual.Size = new System.Drawing.Size(55, 20);
            this.txtCodigoBarraProductoIndividual.TabIndex = 2;
            // 
            // lblErrorImporteTotal
            // 
            this.lblErrorImporteTotal.AutoSize = true;
            this.lblErrorImporteTotal.ForeColor = System.Drawing.Color.Red;
            this.lblErrorImporteTotal.Location = new System.Drawing.Point(182, 216);
            this.lblErrorImporteTotal.Name = "lblErrorImporteTotal";
            this.lblErrorImporteTotal.Size = new System.Drawing.Size(0, 13);
            this.lblErrorImporteTotal.TabIndex = 81;
            // 
            // txtImporteTotal
            // 
            this.txtImporteTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImporteTotal.Location = new System.Drawing.Point(185, 192);
            this.txtImporteTotal.Name = "txtImporteTotal";
            this.txtImporteTotal.ReadOnly = true;
            this.txtImporteTotal.Size = new System.Drawing.Size(168, 20);
            this.txtImporteTotal.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(182, 176);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 13);
            this.label17.TabIndex = 80;
            this.label17.Text = "Importe Total";
            // 
            // lblErrorPrecioUnitario
            // 
            this.lblErrorPrecioUnitario.AutoSize = true;
            this.lblErrorPrecioUnitario.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrecioUnitario.Location = new System.Drawing.Point(8, 216);
            this.lblErrorPrecioUnitario.Name = "lblErrorPrecioUnitario";
            this.lblErrorPrecioUnitario.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPrecioUnitario.TabIndex = 69;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(11, 192);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(168, 20);
            this.txtPrecioUnitario.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Precio Unitario";
            // 
            // lblErrorCantidad
            // 
            this.lblErrorCantidad.AutoSize = true;
            this.lblErrorCantidad.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCantidad.Location = new System.Drawing.Point(182, 163);
            this.lblErrorCantidad.Name = "lblErrorCantidad";
            this.lblErrorCantidad.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCantidad.TabIndex = 61;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.Location = new System.Drawing.Point(185, 139);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(168, 20);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Cantidad";
            // 
            // lblErrorProductoIndividual
            // 
            this.lblErrorProductoIndividual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorProductoIndividual.AutoSize = true;
            this.lblErrorProductoIndividual.ForeColor = System.Drawing.Color.Red;
            this.lblErrorProductoIndividual.Location = new System.Drawing.Point(6, 110);
            this.lblErrorProductoIndividual.Name = "lblErrorProductoIndividual";
            this.lblErrorProductoIndividual.Size = new System.Drawing.Size(0, 13);
            this.lblErrorProductoIndividual.TabIndex = 50;
            // 
            // btnBuscarProductoIndividual
            // 
            this.btnBuscarProductoIndividual.Location = new System.Drawing.Point(295, 84);
            this.btnBuscarProductoIndividual.Name = "btnBuscarProductoIndividual";
            this.btnBuscarProductoIndividual.Size = new System.Drawing.Size(58, 23);
            this.btnBuscarProductoIndividual.TabIndex = 4;
            this.btnBuscarProductoIndividual.Text = "Buscar";
            this.btnBuscarProductoIndividual.UseVisualStyleBackColor = true;
            this.btnBuscarProductoIndividual.Click += new System.EventHandler(this.btnBuscarProductoIndividual_Click);
            // 
            // txtNombreProductoIndividual
            // 
            this.txtNombreProductoIndividual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreProductoIndividual.Location = new System.Drawing.Point(70, 86);
            this.txtNombreProductoIndividual.Name = "txtNombreProductoIndividual";
            this.txtNombreProductoIndividual.ReadOnly = true;
            this.txtNombreProductoIndividual.Size = new System.Drawing.Size(221, 20);
            this.txtNombreProductoIndividual.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Producto Individual";
            // 
            // lblErrorProducto
            // 
            this.lblErrorProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorProducto.AutoSize = true;
            this.lblErrorProducto.ForeColor = System.Drawing.Color.Red;
            this.lblErrorProducto.Location = new System.Drawing.Point(6, 57);
            this.lblErrorProducto.Name = "lblErrorProducto";
            this.lblErrorProducto.Size = new System.Drawing.Size(0, 13);
            this.lblErrorProducto.TabIndex = 46;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(295, 31);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(58, 23);
            this.btnBuscarProducto.TabIndex = 1;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreProducto.Location = new System.Drawing.Point(11, 33);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.Size = new System.Drawing.Size(280, 20);
            this.txtNombreProducto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Producto";
            // 
            // FrmMantenimientoCotizacionDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 281);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMantenimientoCotizacionDetalle";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMantenimientoCotizacionDetalle";
            this.Load += new System.EventHandler(this.FrmMantenimientoCotizacionDetalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigoBarraProductoIndividual;
        private System.Windows.Forms.Label lblErrorImporteTotal;
        private System.Windows.Forms.TextBox txtImporteTotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblErrorPrecioUnitario;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblErrorCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblErrorProductoIndividual;
        private System.Windows.Forms.Button btnBuscarProductoIndividual;
        private System.Windows.Forms.TextBox txtNombreProductoIndividual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblErrorProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip tltCotizacionDetalle;
        private System.Windows.Forms.Label lblErrorCodigoUnidadMedida;
        private System.Windows.Forms.ComboBox cbbCodigoUnidadMedida;
        private System.Windows.Forms.Label label2;
    }
}