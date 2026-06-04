namespace IlkaPoint.Forms_Oficiales
{
    partial class VerFactura
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
            this.flpProductosFactura = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCerrarPanel = new FontAwesome.Sharp.IconButton();
            this.panelArriba = new System.Windows.Forms.Panel();
            this.lblFechaFactura = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNumVenta = new System.Windows.Forms.Label();
            this.avatarLogo = new AntdUI.Avatar();
            this.lblTituloIlca = new System.Windows.Forms.Label();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.lblTotalPrecio = new System.Windows.Forms.Label();
            this.lblMetPago = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.lblTextoCantidad = new System.Windows.Forms.Label();
            this.lblFormPago = new System.Windows.Forms.Label();
            this.panelArriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpProductosFactura
            // 
            this.flpProductosFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpProductosFactura.AutoScroll = true;
            this.flpProductosFactura.BackColor = System.Drawing.Color.Transparent;
            this.flpProductosFactura.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpProductosFactura.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpProductosFactura.Location = new System.Drawing.Point(35, 340);
            this.flpProductosFactura.Margin = new System.Windows.Forms.Padding(1);
            this.flpProductosFactura.Name = "flpProductosFactura";
            this.flpProductosFactura.Size = new System.Drawing.Size(410, 459);
            this.flpProductosFactura.TabIndex = 6;
            this.flpProductosFactura.WrapContents = false;
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
            // panelArriba
            // 
            this.panelArriba.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelArriba.BackColor = System.Drawing.Color.Transparent;
            this.panelArriba.Controls.Add(this.lblFechaFactura);
            this.panelArriba.Controls.Add(this.lblFecha);
            this.panelArriba.Controls.Add(this.lblNumVenta);
            this.panelArriba.Controls.Add(this.avatarLogo);
            this.panelArriba.Controls.Add(this.btnCerrarPanel);
            this.panelArriba.Controls.Add(this.lblTituloIlca);
            this.panelArriba.Location = new System.Drawing.Point(35, 37);
            this.panelArriba.Name = "panelArriba";
            this.panelArriba.Size = new System.Drawing.Size(410, 299);
            this.panelArriba.TabIndex = 7;
            this.panelArriba.Paint += new System.Windows.Forms.PaintEventHandler(this.panelArriba_Paint);
            // 
            // lblFechaFactura
            // 
            this.lblFechaFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaFactura.Font = new System.Drawing.Font("Microsoft YaHei", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFactura.ForeColor = System.Drawing.Color.White;
            this.lblFechaFactura.Location = new System.Drawing.Point(103, 206);
            this.lblFechaFactura.Name = "lblFechaFactura";
            this.lblFechaFactura.Size = new System.Drawing.Size(288, 30);
            this.lblFechaFactura.TabIndex = 15;
            this.lblFechaFactura.Text = "Fecha:";
            this.lblFechaFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft YaHei", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(14, 206);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(79, 30);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumVenta
            // 
            this.lblNumVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumVenta.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumVenta.ForeColor = System.Drawing.Color.White;
            this.lblNumVenta.Location = new System.Drawing.Point(59, 254);
            this.lblNumVenta.Name = "lblNumVenta";
            this.lblNumVenta.Size = new System.Drawing.Size(300, 33);
            this.lblNumVenta.TabIndex = 14;
            this.lblNumVenta.Text = "Factura#0010";
            this.lblNumVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumVenta.Click += new System.EventHandler(this.lblNumVenta_Click);
            // 
            // avatarLogo
            // 
            this.avatarLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.avatarLogo.BackColor = System.Drawing.Color.White;
            this.avatarLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.avatarLogo.BadgeAlign = AntdUI.TAlign.Top;
            this.avatarLogo.BorderColor = System.Drawing.Color.Transparent;
            this.avatarLogo.Image = global::IlkaPoint.Properties.Resources._2;
            this.avatarLogo.ImageFit = AntdUI.TFit.Fill;
            this.avatarLogo.Location = new System.Drawing.Point(138, 18);
            this.avatarLogo.Margin = new System.Windows.Forms.Padding(0);
            this.avatarLogo.Name = "avatarLogo";
            this.avatarLogo.Round = true;
            this.avatarLogo.Size = new System.Drawing.Size(140, 140);
            this.avatarLogo.TabIndex = 10;
            this.avatarLogo.Text = "";
            // 
            // lblTituloIlca
            // 
            this.lblTituloIlca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloIlca.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIlca.ForeColor = System.Drawing.Color.White;
            this.lblTituloIlca.Location = new System.Drawing.Point(3, 158);
            this.lblTituloIlca.Name = "lblTituloIlca";
            this.lblTituloIlca.Size = new System.Drawing.Size(400, 37);
            this.lblTituloIlca.TabIndex = 7;
            this.lblTituloIlca.Text = "Abarroteria Ilca";
            this.lblTituloIlca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalProductos.AutoSize = true;
            this.lblTotalProductos.Font = new System.Drawing.Font("Microsoft YaHei", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProductos.ForeColor = System.Drawing.Color.White;
            this.lblTotalProductos.Location = new System.Drawing.Point(403, 800);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(23, 30);
            this.lblTotalProductos.TabIndex = 11;
            this.lblTotalProductos.Text = "-";
            this.lblTotalProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPrecio
            // 
            this.lblTotalPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPrecio.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrecio.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrecio.Location = new System.Drawing.Point(306, 900);
            this.lblTotalPrecio.Name = "lblTotalPrecio";
            this.lblTotalPrecio.Size = new System.Drawing.Size(120, 31);
            this.lblTotalPrecio.TabIndex = 9;
            this.lblTotalPrecio.Text = "$0.00";
            this.lblTotalPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMetPago
            // 
            this.lblMetPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMetPago.AutoSize = true;
            this.lblMetPago.Font = new System.Drawing.Font("Microsoft YaHei", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetPago.ForeColor = System.Drawing.Color.White;
            this.lblMetPago.Location = new System.Drawing.Point(49, 849);
            this.lblMetPago.Name = "lblMetPago";
            this.lblMetPago.Size = new System.Drawing.Size(178, 30);
            this.lblMetPago.TabIndex = 12;
            this.lblMetPago.Text = "Forma de Pago:";
            this.lblMetPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(48, 900);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(80, 31);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.Text = "Total:";
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTextoCantidad
            // 
            this.lblTextoCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTextoCantidad.AutoSize = true;
            this.lblTextoCantidad.Font = new System.Drawing.Font("Microsoft YaHei", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoCantidad.ForeColor = System.Drawing.Color.White;
            this.lblTextoCantidad.Location = new System.Drawing.Point(49, 800);
            this.lblTextoCantidad.Name = "lblTextoCantidad";
            this.lblTextoCantidad.Size = new System.Drawing.Size(259, 30);
            this.lblTextoCantidad.TabIndex = 10;
            this.lblTextoCantidad.Text = "Cantidad de Productos:";
            this.lblTextoCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFormPago
            // 
            this.lblFormPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormPago.Font = new System.Drawing.Font("Microsoft YaHei", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormPago.ForeColor = System.Drawing.Color.White;
            this.lblFormPago.Location = new System.Drawing.Point(244, 849);
            this.lblFormPago.Name = "lblFormPago";
            this.lblFormPago.Size = new System.Drawing.Size(182, 30);
            this.lblFormPago.TabIndex = 13;
            this.lblFormPago.Text = "-";
            this.lblFormPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VerFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFormPago);
            this.Controls.Add(this.lblTotalProductos);
            this.Controls.Add(this.lblTotalPrecio);
            this.Controls.Add(this.lblMetPago);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTextoCantidad);
            this.Controls.Add(this.flpProductosFactura);
            this.Controls.Add(this.panelArriba);
            this.Name = "VerFactura";
            this.Size = new System.Drawing.Size(480, 1024);
            this.Load += new System.EventHandler(this.VerFactura_Load);
            this.panelArriba.ResumeLayout(false);
            this.panelArriba.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpProductosFactura;
        private FontAwesome.Sharp.IconButton btnCerrarPanel;
        private System.Windows.Forms.Panel panelArriba;
        private System.Windows.Forms.Label lblTituloIlca;
        private AntdUI.Avatar avatarLogo;
        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.Label lblTotalPrecio;
        private System.Windows.Forms.Label lblMetPago;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label lblTextoCantidad;
        private System.Windows.Forms.Label lblFormPago;
        private System.Windows.Forms.Label lblNumVenta;
        private System.Windows.Forms.Label lblFechaFactura;
        private System.Windows.Forms.Label lblFecha;
    }
}
