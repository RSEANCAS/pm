namespace pm.app
{
    partial class FrmMantenimientoGuiaRemisionDetalle
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
            this.cbbCodigoUnidadMedidaPeso = new System.Windows.Forms.ComboBox();
            this.lblErrorUnidadMedidaPeso = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblErrorPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoBarraProductoIndividual = new System.Windows.Forms.TextBox();
            this.cbbCodigoUnidadMedida = new System.Windows.Forms.ComboBox();
            this.lblErrorUnidadMedida = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            this.tltGuiaRemisionDetalle = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(297, 249);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbCodigoUnidadMedidaPeso);
            this.groupBox1.Controls.Add(this.lblErrorUnidadMedidaPeso);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblErrorPeso);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCodigoBarraProductoIndividual);
            this.groupBox1.Controls.Add(this.cbbCodigoUnidadMedida);
            this.groupBox1.Controls.Add(this.lblErrorUnidadMedida);
            this.groupBox1.Controls.Add(this.label13);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Detalle";
            // 
            // cbbCodigoUnidadMedidaPeso
            // 
            this.cbbCodigoUnidadMedidaPeso.DisplayMember = "Descripcion";
            this.cbbCodigoUnidadMedidaPeso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoUnidadMedidaPeso.FormattingEnabled = true;
            this.cbbCodigoUnidadMedidaPeso.Location = new System.Drawing.Point(9, 192);
            this.cbbCodigoUnidadMedidaPeso.Name = "cbbCodigoUnidadMedidaPeso";
            this.cbbCodigoUnidadMedidaPeso.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoUnidadMedidaPeso.TabIndex = 7;
            this.cbbCodigoUnidadMedidaPeso.ValueMember = "CodigoUnidadMedida";
            // 
            // lblErrorUnidadMedidaPeso
            // 
            this.lblErrorUnidadMedidaPeso.AutoSize = true;
            this.lblErrorUnidadMedidaPeso.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUnidadMedidaPeso.Location = new System.Drawing.Point(6, 216);
            this.lblErrorUnidadMedidaPeso.Name = "lblErrorUnidadMedidaPeso";
            this.lblErrorUnidadMedidaPeso.Size = new System.Drawing.Size(0, 13);
            this.lblErrorUnidadMedidaPeso.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Unidad Medida Peso";
            // 
            // lblErrorPeso
            // 
            this.lblErrorPeso.AutoSize = true;
            this.lblErrorPeso.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPeso.Location = new System.Drawing.Point(180, 216);
            this.lblErrorPeso.Name = "lblErrorPeso";
            this.lblErrorPeso.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPeso.TabIndex = 88;
            // 
            // txtPeso
            // 
            this.txtPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPeso.Location = new System.Drawing.Point(183, 192);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(168, 20);
            this.txtPeso.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Peso";
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
            // cbbCodigoUnidadMedida
            // 
            this.cbbCodigoUnidadMedida.DisplayMember = "Descripcion";
            this.cbbCodigoUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoUnidadMedida.FormattingEnabled = true;
            this.cbbCodigoUnidadMedida.Location = new System.Drawing.Point(9, 139);
            this.cbbCodigoUnidadMedida.Name = "cbbCodigoUnidadMedida";
            this.cbbCodigoUnidadMedida.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoUnidadMedida.TabIndex = 5;
            this.cbbCodigoUnidadMedida.ValueMember = "CodigoUnidadMedida";
            // 
            // lblErrorUnidadMedida
            // 
            this.lblErrorUnidadMedida.AutoSize = true;
            this.lblErrorUnidadMedida.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUnidadMedida.Location = new System.Drawing.Point(6, 163);
            this.lblErrorUnidadMedida.Name = "lblErrorUnidadMedida";
            this.lblErrorUnidadMedida.Size = new System.Drawing.Size(0, 13);
            this.lblErrorUnidadMedida.TabIndex = 63;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 62;
            this.label13.Text = "Unidad Medida";
            // 
            // lblErrorCantidad
            // 
            this.lblErrorCantidad.AutoSize = true;
            this.lblErrorCantidad.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCantidad.Location = new System.Drawing.Point(180, 163);
            this.lblErrorCantidad.Name = "lblErrorCantidad";
            this.lblErrorCantidad.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCantidad.TabIndex = 61;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.Location = new System.Drawing.Point(183, 139);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(168, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
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
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
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
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Producto";
            // 
            // FrmMantenimientoGuiaRemisionDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 284);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMantenimientoGuiaRemisionDetalle";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMantenimientoGuiaRemisionDetalle";
            this.Load += new System.EventHandler(this.FrmMantenimientoGuiaRemisionDetalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbCodigoUnidadMedidaPeso;
        private System.Windows.Forms.Label lblErrorUnidadMedidaPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblErrorPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoBarraProductoIndividual;
        private System.Windows.Forms.ComboBox cbbCodigoUnidadMedida;
        private System.Windows.Forms.Label lblErrorUnidadMedida;
        private System.Windows.Forms.Label label13;
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
        private System.Windows.Forms.ToolTip tltGuiaRemisionDetalle;
    }
}