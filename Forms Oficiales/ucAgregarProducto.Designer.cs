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
            this.lblAgregarProducto = new AntdUI.Label();
            this.btnCerrarPanel = new FontAwesome.Sharp.IconButton();
            this.lblIndicaciones = new AntdUI.Label();
            this.lblCategoríaDeProducto = new AntdUI.Label();
            this.cmbCategorías = new System.Windows.Forms.ComboBox();
            this.lblNombreProducto = new AntdUI.Label();
            this.txtNombreProducto = new AntdUI.Input();
            this.label1 = new AntdUI.Label();
            this.inputNumberCantProducto = new AntdUI.InputNumber();
            this.label2 = new AntdUI.Label();
            this.input1 = new AntdUI.Input();
            this.label3 = new AntdUI.Label();
            this.pbProducto = new System.Windows.Forms.PictureBox();
            this.btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgregarProducto
            // 
            this.lblAgregarProducto.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAgregarProducto.Location = new System.Drawing.Point(35, 20);
            this.lblAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAgregarProducto.Name = "lblAgregarProducto";
            this.lblAgregarProducto.Size = new System.Drawing.Size(339, 58);
            this.lblAgregarProducto.TabIndex = 1;
            this.lblAgregarProducto.Text = "Agregar Producto";
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
            this.btnCerrarPanel.Location = new System.Drawing.Point(394, 26);
            this.btnCerrarPanel.Name = "btnCerrarPanel";
            this.btnCerrarPanel.Size = new System.Drawing.Size(52, 52);
            this.btnCerrarPanel.TabIndex = 17;
            this.btnCerrarPanel.UseVisualStyleBackColor = false;
            this.btnCerrarPanel.Click += new System.EventHandler(this.btnCerrarPanel_Click);
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblIndicaciones.Location = new System.Drawing.Point(30, 110);
            this.lblIndicaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(402, 62);
            this.lblIndicaciones.TabIndex = 18;
            this.lblIndicaciones.Text = "Para editar un producto complete los siguientes campos:";
            // 
            // lblCategoríaDeProducto
            // 
            this.lblCategoríaDeProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoríaDeProducto.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoríaDeProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblCategoríaDeProducto.Location = new System.Drawing.Point(34, 201);
            this.lblCategoríaDeProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCategoríaDeProducto.Name = "lblCategoríaDeProducto";
            this.lblCategoríaDeProducto.Size = new System.Drawing.Size(426, 43);
            this.lblCategoríaDeProducto.TabIndex = 19;
            this.lblCategoríaDeProducto.Text = "1. Categoría de Producto";
            // 
            // cmbCategorías
            // 
            this.cmbCategorías.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategorías.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategorías.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbCategorías.FormattingEnabled = true;
            this.cmbCategorías.ItemHeight = 36;
            this.cmbCategorías.Items.AddRange(new object[] {
            "Abarrotes",
            "Lácteos",
            "Bebidas",
            "Limpieza",
            "Papelería"});
            this.cmbCategorías.Location = new System.Drawing.Point(30, 266);
            this.cmbCategorías.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategorías.Name = "cmbCategorías";
            this.cmbCategorías.Size = new System.Drawing.Size(416, 44);
            this.cmbCategorías.TabIndex = 20;
            this.cmbCategorías.Text = "Seleccione la categoría";
            this.cmbCategorías.Click += new System.EventHandler(this.cmbCategorías_SelectedIndexChanged);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreProducto.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblNombreProducto.Location = new System.Drawing.Point(30, 325);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(426, 43);
            this.lblNombreProducto.TabIndex = 21;
            this.lblNombreProducto.Text = "2. Nombre del Producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(30, 383);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PlaceholderText = "Ejemplo: Queso Amarillo Kraft";
            this.txtNombreProducto.PrefixFore = System.Drawing.Color.Black;
            this.txtNombreProducto.PrefixFormat = AntdUI.FormatFlags.Left;
            this.txtNombreProducto.PrefixSvg = "";
            this.txtNombreProducto.Radius = 0;
            this.txtNombreProducto.Size = new System.Drawing.Size(416, 67);
            this.txtNombreProducto.SuffixFore = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.txtNombreProducto.SuffixFormat = AntdUI.FormatFlags.Left;
            this.txtNombreProducto.SuffixSvg = "";
            this.txtNombreProducto.SuffixWidth = 0;
            this.txtNombreProducto.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(34, 466);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 43);
            this.label1.TabIndex = 23;
            this.label1.Text = "3. Cantidad por unidad";
            // 
            // inputNumberCantProducto
            // 
            this.inputNumberCantProducto.AlwaysShowControl = true;
            this.inputNumberCantProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNumberCantProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNumberCantProducto.Location = new System.Drawing.Point(30, 525);
            this.inputNumberCantProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputNumberCantProducto.Name = "inputNumberCantProducto";
            this.inputNumberCantProducto.Size = new System.Drawing.Size(416, 67);
            this.inputNumberCantProducto.TabIndex = 24;
            this.inputNumberCantProducto.Text = "0";
            this.inputNumberCantProducto.Click += new System.EventHandler(this.input1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(34, 609);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 43);
            this.label2.TabIndex = 25;
            this.label2.Text = "4. Precio unitario ($)";
            // 
            // input1
            // 
            this.input1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(30, 664);
            this.input1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.input1.Name = "input1";
            this.input1.PlaceholderText = "Ejemplo: 1.75";
            this.input1.PrefixFore = System.Drawing.Color.Black;
            this.input1.PrefixFormat = AntdUI.FormatFlags.Left;
            this.input1.PrefixSvg = "";
            this.input1.Radius = 0;
            this.input1.Size = new System.Drawing.Size(416, 67);
            this.input1.SuffixFore = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.input1.SuffixFormat = AntdUI.FormatFlags.Left;
            this.input1.SuffixSvg = "";
            this.input1.SuffixWidth = 0;
            this.input1.TabIndex = 26;
            this.input1.Click += new System.EventHandler(this.input1_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(34, 736);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 43);
            this.label3.TabIndex = 27;
            this.label3.Text = "5. Agregar Imagen";
            // 
            // pbProducto
            // 
            this.pbProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.pbProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProducto.Image = global::IlkaPoint.Properties.Resources.subir_imagen;
            this.pbProducto.Location = new System.Drawing.Point(131, 800);
            this.pbProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbProducto.Name = "pbProducto";
            this.pbProducto.Size = new System.Drawing.Size(208, 100);
            this.pbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProducto.TabIndex = 28;
            this.pbProducto.TabStop = false;
            this.pbProducto.Click += new System.EventHandler(this.pbProducto_Click);
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
            this.btnAgregarProducto.Location = new System.Drawing.Point(35, 927);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(416, 67);
            this.btnAgregarProducto.TabIndex = 29;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // ucAgregarProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.pbProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputNumberCantProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.cmbCategorías);
            this.Controls.Add(this.lblCategoríaDeProducto);
            this.Controls.Add(this.lblIndicaciones);
            this.Controls.Add(this.btnCerrarPanel);
            this.Controls.Add(this.lblAgregarProducto);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucAgregarProducto";
            this.Size = new System.Drawing.Size(480, 1025);
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Label lblAgregarProducto;
        private FontAwesome.Sharp.IconButton btnCerrarPanel;
        private AntdUI.Label lblIndicaciones;
        private AntdUI.Label lblCategoríaDeProducto;
        private System.Windows.Forms.ComboBox cmbCategorías;
        private AntdUI.Label lblNombreProducto;
        private AntdUI.Input txtNombreProducto;
        private AntdUI.Label label1;
        private AntdUI.InputNumber inputNumberCantProducto;
        private AntdUI.Label label2;
        private AntdUI.Input input1;
        private AntdUI.Label label3;
        private System.Windows.Forms.PictureBox pbProducto;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
    }
}
