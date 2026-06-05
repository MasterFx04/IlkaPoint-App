namespace IlkaPoint.Forms_Oficiales
{
    partial class InfoProducto
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCantidad = new AntdUI.Input();
            this.picref = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picref)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombre.AutoEllipsis = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(124, 20);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(177, 24);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "label1";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrecio.AutoEllipsis = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(124, 49);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(173, 24);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "label2";
            this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(311, 10);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(0);
            this.txtCantidad.MaximumSize = new System.Drawing.Size(70, 70);
            this.txtCantidad.MinimumSize = new System.Drawing.Size(70, 70);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Radius = 0;
            this.txtCantidad.Size = new System.Drawing.Size(70, 70);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.Text = "0";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged_1);
            // 
            // picref
            // 
            this.picref.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picref.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picref.Location = new System.Drawing.Point(15, 3);
            this.picref.Margin = new System.Windows.Forms.Padding(0);
            this.picref.MaximumSize = new System.Drawing.Size(85, 85);
            this.picref.MinimumSize = new System.Drawing.Size(85, 85);
            this.picref.Name = "picref";
            this.picref.Size = new System.Drawing.Size(85, 85);
            this.picref.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picref.TabIndex = 0;
            this.picref.TabStop = false;
            // 
            // InfoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.picref);
            this.Name = "InfoProducto";
            this.Size = new System.Drawing.Size(400, 90);
            this.Load += new System.EventHandler(this.InfoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picref)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picref;
        private System.Windows.Forms.Label lblPrecio;
        public AntdUI.Input txtCantidad;
        public System.Windows.Forms.Label lblNombre;
    }
}
