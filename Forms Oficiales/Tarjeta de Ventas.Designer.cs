namespace IlkaPoint.Clases
{
    partial class Tarjeta_de_Ventas
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
            this.lblNumVenta1 = new System.Windows.Forms.Label();
            this.lblVenta1 = new System.Windows.Forms.Label();
            this.btnVerFactura = new AntdUI.Button();
            this.lblDayVenta = new System.Windows.Forms.Label();
            this.lblPaidMet = new System.Windows.Forms.Label();
            this.lblTotalVenta = new System.Windows.Forms.Label();
            this.icnMoney = new System.Windows.Forms.PictureBox();
            this.icnUser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.icnCalendar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icnMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumVenta1
            // 
            this.lblNumVenta1.AutoSize = true;
            this.lblNumVenta1.BackColor = System.Drawing.Color.Transparent;
            this.lblNumVenta1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumVenta1.Location = new System.Drawing.Point(145, 11);
            this.lblNumVenta1.Name = "lblNumVenta1";
            this.lblNumVenta1.Size = new System.Drawing.Size(56, 25);
            this.lblNumVenta1.TabIndex = 0;
            this.lblNumVenta1.Text = "0222";
            this.lblNumVenta1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNumVenta1.Click += new System.EventHandler(this.lblNumVenta1_Click);
            // 
            // lblVenta1
            // 
            this.lblVenta1.AutoSize = true;
            this.lblVenta1.BackColor = System.Drawing.Color.Transparent;
            this.lblVenta1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenta1.Location = new System.Drawing.Point(60, 11);
            this.lblVenta1.Name = "lblVenta1";
            this.lblVenta1.Size = new System.Drawing.Size(81, 25);
            this.lblVenta1.TabIndex = 1;
            this.lblVenta1.Text = "Venta #";
            this.lblVenta1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnVerFactura
            // 
            this.btnVerFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnVerFactura.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerFactura.Location = new System.Drawing.Point(-7, 129);
            this.btnVerFactura.Name = "btnVerFactura";
            this.btnVerFactura.Radius = 0;
            this.btnVerFactura.Size = new System.Drawing.Size(281, 37);
            this.btnVerFactura.TabIndex = 6;
            this.btnVerFactura.Text = "Ver Factura";
            this.btnVerFactura.Type = AntdUI.TTypeMini.Primary;
            this.btnVerFactura.Click += new System.EventHandler(this.btnVerFactura_Click);
            // 
            // lblDayVenta
            // 
            this.lblDayVenta.AutoSize = true;
            this.lblDayVenta.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayVenta.ForeColor = System.Drawing.Color.White;
            this.lblDayVenta.Location = new System.Drawing.Point(64, 36);
            this.lblDayVenta.Name = "lblDayVenta";
            this.lblDayVenta.Size = new System.Drawing.Size(18, 24);
            this.lblDayVenta.TabIndex = 7;
            this.lblDayVenta.Text = "-";
            this.lblDayVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDayVenta.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPaidMet
            // 
            this.lblPaidMet.AutoSize = true;
            this.lblPaidMet.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidMet.ForeColor = System.Drawing.Color.White;
            this.lblPaidMet.Location = new System.Drawing.Point(64, 65);
            this.lblPaidMet.Name = "lblPaidMet";
            this.lblPaidMet.Size = new System.Drawing.Size(18, 24);
            this.lblPaidMet.TabIndex = 8;
            this.lblPaidMet.Text = "-";
            this.lblPaidMet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.AutoSize = true;
            this.lblTotalVenta.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenta.ForeColor = System.Drawing.Color.White;
            this.lblTotalVenta.Location = new System.Drawing.Point(64, 99);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(18, 24);
            this.lblTotalVenta.TabIndex = 9;
            this.lblTotalVenta.Text = "-";
            this.lblTotalVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // icnMoney
            // 
            this.icnMoney.BackColor = System.Drawing.Color.Transparent;
            this.icnMoney.BackgroundImage = global::IlkaPoint.Properties.Resources.image_Photoroom__17_;
            this.icnMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icnMoney.Location = new System.Drawing.Point(33, 99);
            this.icnMoney.Name = "icnMoney";
            this.icnMoney.Size = new System.Drawing.Size(28, 25);
            this.icnMoney.TabIndex = 5;
            this.icnMoney.TabStop = false;
            // 
            // icnUser
            // 
            this.icnUser.BackColor = System.Drawing.Color.Transparent;
            this.icnUser.BackgroundImage = global::IlkaPoint.Properties.Resources.image_Photoroom__15_;
            this.icnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icnUser.Location = new System.Drawing.Point(33, 67);
            this.icnUser.Name = "icnUser";
            this.icnUser.Size = new System.Drawing.Size(28, 25);
            this.icnUser.TabIndex = 4;
            this.icnUser.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // icnCalendar
            // 
            this.icnCalendar.BackColor = System.Drawing.Color.Transparent;
            this.icnCalendar.BackgroundImage = global::IlkaPoint.Properties.Resources.image_Photoroom__12_;
            this.icnCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icnCalendar.Location = new System.Drawing.Point(33, 36);
            this.icnCalendar.Name = "icnCalendar";
            this.icnCalendar.Size = new System.Drawing.Size(28, 25);
            this.icnCalendar.TabIndex = 2;
            this.icnCalendar.TabStop = false;
            // 
            // Tarjeta_de_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotalVenta);
            this.Controls.Add(this.lblPaidMet);
            this.Controls.Add(this.lblDayVenta);
            this.Controls.Add(this.btnVerFactura);
            this.Controls.Add(this.icnMoney);
            this.Controls.Add(this.icnUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.icnCalendar);
            this.Controls.Add(this.lblVenta1);
            this.Controls.Add(this.lblNumVenta1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Tarjeta_de_Ventas";
            this.Size = new System.Drawing.Size(268, 160);
            this.Load += new System.EventHandler(this.Tarjeta_de_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icnMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnCalendar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumVenta1;
        private System.Windows.Forms.Label lblVenta1;
        private System.Windows.Forms.PictureBox icnCalendar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox icnUser;
        private System.Windows.Forms.PictureBox icnMoney;
        private System.Windows.Forms.Label lblDayVenta;
        private System.Windows.Forms.Label lblPaidMet;
        private System.Windows.Forms.Label lblTotalVenta;
        public AntdUI.Button btnVerFactura;
    }
}
