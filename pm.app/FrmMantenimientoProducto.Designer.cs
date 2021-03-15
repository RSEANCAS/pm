namespace pm.app
{
    partial class FrmMantenimientoProducto
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
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.lblErrorEstado = new System.Windows.Forms.Label();
            this.lblErrorMetrajeTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMetrajeTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.cbbCodigoUnidadMedida = new System.Windows.Forms.ComboBox();
            this.lblErrorCodigoUnidadMedida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErrorColor = new System.Windows.Forms.Label();
            this.lblErrorValorVenta = new System.Windows.Forms.Label();
            this.lblErrorDescuentoMaximo = new System.Windows.Forms.Label();
            this.lblErrorValorCompra = new System.Windows.Forms.Label();
            this.lblErrorCantidad = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescuentoMaximo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorVenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tltProducto = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(297, 306);
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
            this.groupBox1.Controls.Add(this.cbbEstado);
            this.groupBox1.Controls.Add(this.lblErrorEstado);
            this.groupBox1.Controls.Add(this.lblErrorMetrajeTotal);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtMetrajeTotal);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtValorCompra);
            this.groupBox1.Controls.Add(this.cbbCodigoUnidadMedida);
            this.groupBox1.Controls.Add(this.lblErrorCodigoUnidadMedida);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblErrorColor);
            this.groupBox1.Controls.Add(this.lblErrorValorVenta);
            this.groupBox1.Controls.Add(this.lblErrorDescuentoMaximo);
            this.groupBox1.Controls.Add(this.lblErrorValorCompra);
            this.groupBox1.Controls.Add(this.lblErrorCantidad);
            this.groupBox1.Controls.Add(this.lblErrorNombre);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDescuentoMaximo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtValorVenta);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // cbbEstado
            // 
            this.cbbEstado.DisplayMember = "Text";
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(183, 245);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(168, 21);
            this.cbbEstado.TabIndex = 8;
            this.cbbEstado.ValueMember = "Value";
            // 
            // lblErrorEstado
            // 
            this.lblErrorEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorEstado.AutoSize = true;
            this.lblErrorEstado.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEstado.Location = new System.Drawing.Point(180, 269);
            this.lblErrorEstado.Name = "lblErrorEstado";
            this.lblErrorEstado.Size = new System.Drawing.Size(0, 13);
            this.lblErrorEstado.TabIndex = 38;
            // 
            // lblErrorMetrajeTotal
            // 
            this.lblErrorMetrajeTotal.AutoSize = true;
            this.lblErrorMetrajeTotal.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMetrajeTotal.Location = new System.Drawing.Point(6, 269);
            this.lblErrorMetrajeTotal.Name = "lblErrorMetrajeTotal";
            this.lblErrorMetrajeTotal.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMetrajeTotal.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(180, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Estado";
            // 
            // txtMetrajeTotal
            // 
            this.txtMetrajeTotal.Location = new System.Drawing.Point(9, 245);
            this.txtMetrajeTotal.Name = "txtMetrajeTotal";
            this.txtMetrajeTotal.Size = new System.Drawing.Size(168, 20);
            this.txtMetrajeTotal.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Metraje Total";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(9, 139);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(168, 20);
            this.txtValorCompra.TabIndex = 3;
            // 
            // cbbCodigoUnidadMedida
            // 
            this.cbbCodigoUnidadMedida.DisplayMember = "Descripcion";
            this.cbbCodigoUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodigoUnidadMedida.FormattingEnabled = true;
            this.cbbCodigoUnidadMedida.Location = new System.Drawing.Point(9, 86);
            this.cbbCodigoUnidadMedida.Name = "cbbCodigoUnidadMedida";
            this.cbbCodigoUnidadMedida.Size = new System.Drawing.Size(168, 21);
            this.cbbCodigoUnidadMedida.TabIndex = 1;
            this.cbbCodigoUnidadMedida.ValueMember = "CodigoUnidadMedida";
            // 
            // lblErrorCodigoUnidadMedida
            // 
            this.lblErrorCodigoUnidadMedida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCodigoUnidadMedida.AutoSize = true;
            this.lblErrorCodigoUnidadMedida.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigoUnidadMedida.Location = new System.Drawing.Point(6, 110);
            this.lblErrorCodigoUnidadMedida.Name = "lblErrorCodigoUnidadMedida";
            this.lblErrorCodigoUnidadMedida.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoUnidadMedida.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Unidad Medida";
            // 
            // lblErrorColor
            // 
            this.lblErrorColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorColor.AutoSize = true;
            this.lblErrorColor.ForeColor = System.Drawing.Color.Red;
            this.lblErrorColor.Location = new System.Drawing.Point(180, 216);
            this.lblErrorColor.Name = "lblErrorColor";
            this.lblErrorColor.Size = new System.Drawing.Size(0, 13);
            this.lblErrorColor.TabIndex = 26;
            // 
            // lblErrorValorVenta
            // 
            this.lblErrorValorVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorValorVenta.AutoSize = true;
            this.lblErrorValorVenta.ForeColor = System.Drawing.Color.Red;
            this.lblErrorValorVenta.Location = new System.Drawing.Point(180, 163);
            this.lblErrorValorVenta.Name = "lblErrorValorVenta";
            this.lblErrorValorVenta.Size = new System.Drawing.Size(0, 13);
            this.lblErrorValorVenta.TabIndex = 25;
            // 
            // lblErrorDescuentoMaximo
            // 
            this.lblErrorDescuentoMaximo.AutoSize = true;
            this.lblErrorDescuentoMaximo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDescuentoMaximo.Location = new System.Drawing.Point(6, 216);
            this.lblErrorDescuentoMaximo.Name = "lblErrorDescuentoMaximo";
            this.lblErrorDescuentoMaximo.Size = new System.Drawing.Size(0, 13);
            this.lblErrorDescuentoMaximo.TabIndex = 23;
            // 
            // lblErrorValorCompra
            // 
            this.lblErrorValorCompra.AutoSize = true;
            this.lblErrorValorCompra.ForeColor = System.Drawing.Color.Red;
            this.lblErrorValorCompra.Location = new System.Drawing.Point(6, 163);
            this.lblErrorValorCompra.Name = "lblErrorValorCompra";
            this.lblErrorValorCompra.Size = new System.Drawing.Size(0, 13);
            this.lblErrorValorCompra.TabIndex = 22;
            // 
            // lblErrorCantidad
            // 
            this.lblErrorCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCantidad.AutoSize = true;
            this.lblErrorCantidad.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCantidad.Location = new System.Drawing.Point(180, 110);
            this.lblErrorCantidad.Name = "lblErrorCantidad";
            this.lblErrorCantidad.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCantidad.TabIndex = 21;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(6, 57);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(0, 13);
            this.lblErrorNombre.TabIndex = 20;
            // 
            // txtColor
            // 
            this.txtColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtColor.Location = new System.Drawing.Point(183, 192);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(168, 20);
            this.txtColor.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Color";
            // 
            // txtDescuentoMaximo
            // 
            this.txtDescuentoMaximo.Location = new System.Drawing.Point(9, 192);
            this.txtDescuentoMaximo.Name = "txtDescuentoMaximo";
            this.txtDescuentoMaximo.Size = new System.Drawing.Size(168, 20);
            this.txtDescuentoMaximo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Descuento Máximo";
            // 
            // txtValorVenta
            // 
            this.txtValorVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorVenta.Location = new System.Drawing.Point(183, 139);
            this.txtValorVenta.Name = "txtValorVenta";
            this.txtValorVenta.Size = new System.Drawing.Size(168, 20);
            this.txtValorVenta.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor Venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor Compra";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.Location = new System.Drawing.Point(183, 86);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(168, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(9, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(342, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombres";
            // 
            // FrmMantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 340);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMantenimientoProducto";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMantenimientoProducto";
            this.Load += new System.EventHandler(this.FrmMantenimientoProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblErrorColor;
        private System.Windows.Forms.Label lblErrorValorVenta;
        private System.Windows.Forms.Label lblErrorDescuentoMaximo;
        private System.Windows.Forms.Label lblErrorValorCompra;
        private System.Windows.Forms.Label lblErrorCantidad;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescuentoMaximo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbCodigoUnidadMedida;
        private System.Windows.Forms.Label lblErrorCodigoUnidadMedida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label lblErrorEstado;
        private System.Windows.Forms.Label lblErrorMetrajeTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMetrajeTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.ToolTip tltProducto;
    }
}