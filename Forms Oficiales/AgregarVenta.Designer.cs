namespace IlkaPoint.Forms_Oficiales
{
    partial class AgregarVenta
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
            this.panelCompra = new System.Windows.Forms.Panel();
            this.lblNumVenta = new System.Windows.Forms.Label();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.lblTotalPrecio = new System.Windows.Forms.Label();
            this.lblMetPago = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.lblTextoCantidad = new System.Windows.Forms.Label();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.btnRegistrarVenta1 = new AntdUI.Button();
            this.flpListaProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.panelArriba = new System.Windows.Forms.Panel();
            this.btnCerrarPanel = new FontAwesome.Sharp.IconButton();
            this.txtBuscarProducto = new AntdUI.Input();
            this.lblNuevaV = new System.Windows.Forms.Label();
            this.panelCompra.SuspendLayout();
            this.panelArriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCompra
            // 
            this.panelCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCompra.BackColor = System.Drawing.Color.Transparent;
            this.panelCompra.Controls.Add(this.cmbMetodoPago);
            this.panelCompra.Controls.Add(this.lblNumVenta);
            this.panelCompra.Controls.Add(this.lblTotalProductos);
            this.panelCompra.Controls.Add(this.lblTotalPrecio);
            this.panelCompra.Controls.Add(this.lblMetPago);
            this.panelCompra.Controls.Add(this.txtTotal);
            this.panelCompra.Controls.Add(this.lblTextoCantidad);
            this.panelCompra.Location = new System.Drawing.Point(37, 688);
            this.panelCompra.Name = "panelCompra";
            this.panelCompra.Size = new System.Drawing.Size(410, 218);
            this.panelCompra.TabIndex = 4;
            // 
            // lblNumVenta
            // 
            this.lblNumVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumVenta.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumVenta.ForeColor = System.Drawing.Color.White;
            this.lblNumVenta.Location = new System.Drawing.Point(134, 11);
            this.lblNumVenta.Name = "lblNumVenta";
            this.lblNumVenta.Size = new System.Drawing.Size(152, 31);
            this.lblNumVenta.TabIndex = 7;
            this.lblNumVenta.Text = "Venta#0010";
            this.lblNumVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumVenta.Click += new System.EventHandler(this.lblNumVenta_Click);
            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalProductos.AutoSize = true;
            this.lblTotalProductos.Font = new System.Drawing.Font("Microsoft YaHei", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProductos.ForeColor = System.Drawing.Color.White;
            this.lblTotalProductos.Location = new System.Drawing.Point(349, 55);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(23, 30);
            this.lblTotalProductos.TabIndex = 5;
            this.lblTotalProductos.Text = "-";
            this.lblTotalProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPrecio
            // 
            this.lblTotalPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPrecio.Font = new System.Drawing.Font("Microsoft YaHei", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrecio.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrecio.Location = new System.Drawing.Point(200, 159);
            this.lblTotalPrecio.Name = "lblTotalPrecio";
            this.lblTotalPrecio.Size = new System.Drawing.Size(181, 31);
            this.lblTotalPrecio.TabIndex = 2;
            this.lblTotalPrecio.Text = "$0.00";
            this.lblTotalPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMetPago
            // 
            this.lblMetPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMetPago.AutoSize = true;
            this.lblMetPago.Font = new System.Drawing.Font("Microsoft YaHei", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetPago.ForeColor = System.Drawing.Color.White;
            this.lblMetPago.Location = new System.Drawing.Point(26, 105);
            this.lblMetPago.Name = "lblMetPago";
            this.lblMetPago.Size = new System.Drawing.Size(189, 30);
            this.lblMetPago.TabIndex = 6;
            this.lblMetPago.Text = "Forma de Pago:";
            this.lblMetPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft YaHei", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(24, 159);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(80, 31);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.Text = "Total:";
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTextoCantidad
            // 
            this.lblTextoCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTextoCantidad.AutoSize = true;
            this.lblTextoCantidad.Font = new System.Drawing.Font("Microsoft YaHei", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoCantidad.ForeColor = System.Drawing.Color.White;
            this.lblTextoCantidad.Location = new System.Drawing.Point(26, 55);
            this.lblTextoCantidad.Name = "lblTextoCantidad";
            this.lblTextoCantidad.Size = new System.Drawing.Size(275, 30);
            this.lblTextoCantidad.TabIndex = 4;
            this.lblTextoCantidad.Text = "Cantidad de Productos:";
            this.lblTextoCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMetodoPago.Font = new System.Drawing.Font("Microsoft YaHei", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Yappy",
            "Tarjeta"});
            this.cmbMetodoPago.Location = new System.Drawing.Point(200, 105);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(181, 38);
            this.cmbMetodoPago.TabIndex = 0;
            this.cmbMetodoPago.SelectedIndexChanged += new System.EventHandler(this.cmbMetodoPago_SelectedIndexChanged);
            // 
            // btnRegistrarVenta1
            // 
            this.btnRegistrarVenta1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarVenta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnRegistrarVenta1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRegistrarVenta1.Location = new System.Drawing.Point(67, 922);
            this.btnRegistrarVenta1.Name = "btnRegistrarVenta1";
            this.btnRegistrarVenta1.Radius = 0;
            this.btnRegistrarVenta1.Size = new System.Drawing.Size(351, 68);
            this.btnRegistrarVenta1.TabIndex = 3;
            this.btnRegistrarVenta1.Text = "Registrar Venta";
            this.btnRegistrarVenta1.Type = AntdUI.TTypeMini.Primary;
            this.btnRegistrarVenta1.Click += new System.EventHandler(this.btnRegistrarVenta1_Click);
            // 
            // flpListaProductos
            // 
            this.flpListaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpListaProductos.AutoScroll = true;
            this.flpListaProductos.BackColor = System.Drawing.Color.Transparent;
            this.flpListaProductos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpListaProductos.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpListaProductos.Location = new System.Drawing.Point(37, 195);
            this.flpListaProductos.Margin = new System.Windows.Forms.Padding(1);
            this.flpListaProductos.Name = "flpListaProductos";
            this.flpListaProductos.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.flpListaProductos.Size = new System.Drawing.Size(410, 479);
            this.flpListaProductos.TabIndex = 5;
            // 
            // panelArriba
            // 
            this.panelArriba.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelArriba.BackColor = System.Drawing.Color.Transparent;
            this.panelArriba.Controls.Add(this.btnCerrarPanel);
            this.panelArriba.Controls.Add(this.txtBuscarProducto);
            this.panelArriba.Controls.Add(this.lblNuevaV);
            this.panelArriba.Location = new System.Drawing.Point(37, 42);
            this.panelArriba.Name = "panelArriba";
            this.panelArriba.Size = new System.Drawing.Size(410, 149);
            this.panelArriba.TabIndex = 6;
            this.panelArriba.Paint += new System.Windows.Forms.PaintEventHandler(this.panelArriba_Paint);
            // 
            // btnCerrarPanel
            // 
            this.btnCerrarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarPanel.BackgroundImage = global::IlkaPoint.Properties.Resources.xmark;
            this.btnCerrarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarPanel.FlatAppearance.BorderSize = 0;
            this.btnCerrarPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPanel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCerrarPanel.IconColor = System.Drawing.Color.Black;
            this.btnCerrarPanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarPanel.Location = new System.Drawing.Point(354, 3);
            this.btnCerrarPanel.Name = "btnCerrarPanel";
            this.btnCerrarPanel.Size = new System.Drawing.Size(52, 52);
            this.btnCerrarPanel.TabIndex = 8;
            this.btnCerrarPanel.UseVisualStyleBackColor = false;
            this.btnCerrarPanel.Click += new System.EventHandler(this.btnCerrarPanel_Click);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarProducto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProducto.Location = new System.Drawing.Point(4, 70);
            this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.PlaceholderText = "Buscar producto...";
            this.txtBuscarProducto.PrefixFore = System.Drawing.Color.Black;
            this.txtBuscarProducto.PrefixFormat = AntdUI.FormatFlags.Left;
            this.txtBuscarProducto.PrefixSvg = "";
            this.txtBuscarProducto.Radius = 0;
            this.txtBuscarProducto.Size = new System.Drawing.Size(386, 75);
            this.txtBuscarProducto.Suffix = global::IlkaPoint.Properties.Resources.lupaimg;
            this.txtBuscarProducto.SuffixFore = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.txtBuscarProducto.SuffixFormat = AntdUI.FormatFlags.Left;
            this.txtBuscarProducto.SuffixSvg = "";
            this.txtBuscarProducto.SuffixWidth = 45;
            this.txtBuscarProducto.TabIndex = 3;
            // 
            // lblNuevaV
            // 
            this.lblNuevaV.AutoSize = true;
            this.lblNuevaV.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaV.ForeColor = System.Drawing.Color.White;
            this.lblNuevaV.Location = new System.Drawing.Point(3, 10);
            this.lblNuevaV.Name = "lblNuevaV";
            this.lblNuevaV.Size = new System.Drawing.Size(232, 44);
            this.lblNuevaV.TabIndex = 7;
            this.lblNuevaV.Text = "Nueva Venta";
            // 
            // AgregarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpListaProductos);
            this.Controls.Add(this.panelCompra);
            this.Controls.Add(this.btnRegistrarVenta1);
            this.Controls.Add(this.panelArriba);
            this.Name = "AgregarVenta";
            this.Size = new System.Drawing.Size(480, 1024);
            this.Load += new System.EventHandler(this.AgregarVenta_Load);
            this.panelCompra.ResumeLayout(false);
            this.panelCompra.PerformLayout();
            this.panelArriba.ResumeLayout(false);
            this.panelArriba.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCompra;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.Label lblTotalPrecio;
        private System.Windows.Forms.Label txtTotal;
        private AntdUI.Button btnRegistrarVenta1;
        private System.Windows.Forms.Label lblMetPago;
        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.Label lblTextoCantidad;
        private System.Windows.Forms.FlowLayoutPanel flpListaProductos;
        private System.Windows.Forms.Panel panelArriba;
        private FontAwesome.Sharp.IconButton btnCerrarPanel;
        private AntdUI.Input txtBuscarProducto;
        private System.Windows.Forms.Label lblNuevaV;
        private System.Windows.Forms.Label lblNumVenta;
    }
}
