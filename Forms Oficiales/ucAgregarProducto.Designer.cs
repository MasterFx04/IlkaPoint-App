namespace IlkaPoint
{
    partial class ucAgregarProducto
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
            this.panelFondoUC = new AntdUI.In.Panel();
            this.panelContenidoUC = new AntdUI.In.Panel();
            this.btnCerrarPanel = new FontAwesome.Sharp.IconButton();
            this.btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            this.pbProducto = new System.Windows.Forms.PictureBox();
            this.label3 = new AntdUI.Label();
            this.input1 = new AntdUI.Input();
            this.label2 = new AntdUI.Label();
            this.inputNumberCantProducto = new AntdUI.InputNumber();
            this.label1 = new AntdUI.Label();
            this.txtNombreProducto = new AntdUI.Input();
            this.lblNombreProducto = new AntdUI.Label();
            this.cmbCategorías = new System.Windows.Forms.ComboBox();
            this.lblCategoríaDeProducto = new AntdUI.Label();
            this.lblIndicaciones = new AntdUI.Label();
            this.lblAgregarProducto = new AntdUI.Label();
            this.panelContenido = new AntdUI.In.Panel();
            this.panelFondoUC.SuspendLayout();
            this.panelContenidoUC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).BeginInit();
            this.panelContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFondoUC
            // 
            this.panelFondoUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.panelFondoUC.Controls.Add(this.panelContenidoUC);
            this.panelFondoUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondoUC.Location = new System.Drawing.Point(0, 0);
            this.panelFondoUC.Name = "panelFondoUC";
            this.panelFondoUC.Size = new System.Drawing.Size(480, 1024);
            this.panelFondoUC.TabIndex = 0;
            this.panelFondoUC.Text = "panel1";
            // 
            // panelContenidoUC
            // 
            this.panelContenidoUC.Controls.Add(this.btnCerrarPanel);
            this.panelContenidoUC.Controls.Add(this.label3);
            this.panelContenidoUC.Controls.Add(this.input1);
            this.panelContenidoUC.Controls.Add(this.label2);
            this.panelContenidoUC.Controls.Add(this.inputNumberCantProducto);
            this.panelContenidoUC.Controls.Add(this.label1);
            this.panelContenidoUC.Controls.Add(this.txtNombreProducto);
            this.panelContenidoUC.Controls.Add(this.lblNombreProducto);
            this.panelContenidoUC.Controls.Add(this.cmbCategorías);
            this.panelContenidoUC.Controls.Add(this.lblCategoríaDeProducto);
            this.panelContenidoUC.Controls.Add(this.lblIndicaciones);
            this.panelContenidoUC.Controls.Add(this.lblAgregarProducto);
            this.panelContenidoUC.Controls.Add(this.panelContenido);
            this.panelContenidoUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenidoUC.Location = new System.Drawing.Point(0, 0);
            this.panelContenidoUC.Name = "panelContenidoUC";
            this.panelContenidoUC.Size = new System.Drawing.Size(480, 1024);
            this.panelContenidoUC.TabIndex = 0;
            this.panelContenidoUC.Text = "panel1";
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
            this.btnCerrarPanel.Location = new System.Drawing.Point(408, 16);
            this.btnCerrarPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrarPanel.Name = "btnCerrarPanel";
            this.btnCerrarPanel.Size = new System.Drawing.Size(58, 65);
            this.btnCerrarPanel.TabIndex = 15;
            this.btnCerrarPanel.UseVisualStyleBackColor = false;
            this.btnCerrarPanel.Click += new System.EventHandler(this.btnCerrarPanel_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarProducto.IconColor = System.Drawing.Color.White;
            this.btnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProducto.IconSize = 45;
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.Location = new System.Drawing.Point(35, 928);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(365, 55);
            this.btnAgregarProducto.TabIndex = 14;
            this.btnAgregarProducto.Text = "Añadir Producto";
            this.btnAgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // pbProducto
            // 
            this.pbProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.pbProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProducto.Image = global::IlkaPoint.Properties.Resources.subir_imagen;
            this.pbProducto.Location = new System.Drawing.Point(107, 776);
            this.pbProducto.Name = "pbProducto";
            this.pbProducto.Size = new System.Drawing.Size(224, 124);
            this.pbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProducto.TabIndex = 12;
            this.pbProducto.TabStop = false;
            this.pbProducto.Click += new System.EventHandler(this.pbProducto_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(31, 724);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(437, 46);
            this.label3.TabIndex = 11;
            this.label3.Text = "5. Agregar Imagen";
            // 
            // input1
            // 
            this.input1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(27, 641);
            this.input1.Margin = new System.Windows.Forms.Padding(4);
            this.input1.Name = "input1";
            this.input1.PlaceholderText = "Ejemplo: 1.75";
            this.input1.PrefixFore = System.Drawing.Color.Black;
            this.input1.PrefixFormat = AntdUI.FormatFlags.Left;
            this.input1.PrefixSvg = "";
            this.input1.Radius = 0;
            this.input1.Size = new System.Drawing.Size(428, 62);
            this.input1.SuffixFore = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.input1.SuffixFormat = AntdUI.FormatFlags.Left;
            this.input1.SuffixSvg = "";
            this.input1.SuffixWidth = 0;
            this.input1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(29, 588);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "4. Precio unitario ($)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // inputNumberCantProducto
            // 
            this.inputNumberCantProducto.AlwaysShowControl = true;
            this.inputNumberCantProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNumberCantProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNumberCantProducto.Location = new System.Drawing.Point(35, 499);
            this.inputNumberCantProducto.Name = "inputNumberCantProducto";
            this.inputNumberCantProducto.Size = new System.Drawing.Size(420, 83);
            this.inputNumberCantProducto.TabIndex = 8;
            this.inputNumberCantProducto.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(29, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 66);
            this.label1.TabIndex = 7;
            this.label1.Text = "3. Cantidad por unidad";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(29, 369);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PlaceholderText = "Ejemplo: Queso Amarillo Kraft";
            this.txtNombreProducto.PrefixFore = System.Drawing.Color.Black;
            this.txtNombreProducto.PrefixFormat = AntdUI.FormatFlags.Left;
            this.txtNombreProducto.PrefixSvg = "";
            this.txtNombreProducto.Radius = 0;
            this.txtNombreProducto.Size = new System.Drawing.Size(420, 60);
            this.txtNombreProducto.SuffixFore = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.txtNombreProducto.SuffixFormat = AntdUI.FormatFlags.Left;
            this.txtNombreProducto.SuffixSvg = "";
            this.txtNombreProducto.SuffixWidth = 0;
            this.txtNombreProducto.TabIndex = 6;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreProducto.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblNombreProducto.Location = new System.Drawing.Point(31, 317);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(420, 54);
            this.lblNombreProducto.TabIndex = 5;
            this.lblNombreProducto.Text = "2. Nombre del Producto";
            // 
            // cmbCategorías
            // 
            this.cmbCategorías.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategorías.Font = new System.Drawing.Font("Trebuchet MS", 12.5F);
            this.cmbCategorías.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbCategorías.FormattingEnabled = true;
            this.cmbCategorías.Items.AddRange(new object[] {
            "Abarrotes",
            "Lácteos",
            "Bebidas",
            "Limpieza",
            "Papelería"});
            this.cmbCategorías.Location = new System.Drawing.Point(31, 256);
            this.cmbCategorías.Name = "cmbCategorías";
            this.cmbCategorías.Size = new System.Drawing.Size(413, 40);
            this.cmbCategorías.TabIndex = 4;
            this.cmbCategorías.Text = "Seleccione la categoría";
            // 
            // lblCategoríaDeProducto
            // 
            this.lblCategoríaDeProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoríaDeProducto.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoríaDeProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblCategoríaDeProducto.Location = new System.Drawing.Point(31, 196);
            this.lblCategoríaDeProducto.Name = "lblCategoríaDeProducto";
            this.lblCategoríaDeProducto.Size = new System.Drawing.Size(420, 54);
            this.lblCategoríaDeProducto.TabIndex = 3;
            this.lblCategoríaDeProducto.Text = "1. Categoría de Producto";
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblIndicaciones.Location = new System.Drawing.Point(31, 98);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(452, 77);
            this.lblIndicaciones.TabIndex = 1;
            this.lblIndicaciones.Text = "Para agregar un producto complete los siguientes campos:";
            // 
            // lblAgregarProducto
            // 
            this.lblAgregarProducto.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAgregarProducto.Location = new System.Drawing.Point(3, 0);
            this.lblAgregarProducto.Name = "lblAgregarProducto";
            this.lblAgregarProducto.Size = new System.Drawing.Size(410, 92);
            this.lblAgregarProducto.TabIndex = 0;
            this.lblAgregarProducto.Text = "Agregar Producto";
            this.lblAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.btnAgregarProducto);
            this.panelContenido.Controls.Add(this.pbProducto);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(480, 1024);
            this.panelContenido.TabIndex = 16;
            this.panelContenido.Text = "panel1";
            // 
            // ucAgregarProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelFondoUC);
            this.Name = "ucAgregarProducto";
            this.Size = new System.Drawing.Size(480, 1024);
            this.panelFondoUC.ResumeLayout(false);
            this.panelContenidoUC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).EndInit();
            this.panelContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.Panel panelFondoUC;
        private AntdUI.In.Panel panelContenidoUC;
        private AntdUI.Label lblAgregarProducto;
        private AntdUI.Label lblIndicaciones;
        private AntdUI.Label lblCategoríaDeProducto;
        private System.Windows.Forms.ComboBox cmbCategorías;
        private AntdUI.Label lblNombreProducto;
        private AntdUI.Input txtNombreProducto;
        private AntdUI.Label label2;
        private AntdUI.InputNumber inputNumberCantProducto;
        private AntdUI.Label label1;
        private AntdUI.Label label3;
        private AntdUI.Input input1;
        private System.Windows.Forms.PictureBox pbProducto;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private FontAwesome.Sharp.IconButton btnCerrarPanel;
        private AntdUI.In.Panel panelContenido;
    }
}
