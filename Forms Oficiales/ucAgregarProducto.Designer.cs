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
            this.btnCerrarPanel = new FontAwesome.Sharp.IconButton();
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
            this.button1 = new AntdUI.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).BeginInit();
            this.SuspendLayout();
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
            this.btnCerrarPanel.Location = new System.Drawing.Point(378, 43);
            this.btnCerrarPanel.Name = "btnCerrarPanel";
            this.btnCerrarPanel.Size = new System.Drawing.Size(52, 52);
            this.btnCerrarPanel.TabIndex = 29;
            this.btnCerrarPanel.UseVisualStyleBackColor = false;
            this.btnCerrarPanel.Click += new System.EventHandler(this.btnCerrarPanel_Click_1);
            // 
            // pbProducto
            // 
            this.pbProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.pbProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProducto.Image = global::IlkaPoint.Properties.Resources.subir_imagen;
            this.pbProducto.Location = new System.Drawing.Point(137, 762);
            this.pbProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbProducto.Name = "pbProducto";
            this.pbProducto.Size = new System.Drawing.Size(210, 140);
            this.pbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProducto.TabIndex = 27;
            this.pbProducto.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(44, 718);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 37);
            this.label3.TabIndex = 26;
            this.label3.Text = "5. Agregar Imagen";
            // 
            // input1
            // 
            this.input1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(70, 628);
            this.input1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.input1.Name = "input1";
            this.input1.PlaceholderText = "Ejemplo: 1.75";
            this.input1.PrefixFore = System.Drawing.Color.Black;
            this.input1.PrefixFormat = AntdUI.FormatFlags.Left;
            this.input1.PrefixSvg = "";
            this.input1.Radius = 0;
            this.input1.Size = new System.Drawing.Size(360, 64);
            this.input1.SuffixFore = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.input1.SuffixFormat = AntdUI.FormatFlags.Left;
            this.input1.SuffixSvg = "";
            this.input1.SuffixWidth = 0;
            this.input1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(44, 577);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 37);
            this.label2.TabIndex = 24;
            this.label2.Text = "4. Precio unitario ($)";
            // 
            // inputNumberCantProducto
            // 
            this.inputNumberCantProducto.AlwaysShowControl = true;
            this.inputNumberCantProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNumberCantProducto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNumberCantProducto.Location = new System.Drawing.Point(68, 494);
            this.inputNumberCantProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputNumberCantProducto.Name = "inputNumberCantProducto";
            this.inputNumberCantProducto.Radius = 0;
            this.inputNumberCantProducto.Size = new System.Drawing.Size(360, 64);
            this.inputNumberCantProducto.TabIndex = 23;
            this.inputNumberCantProducto.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(44, 440);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 53);
            this.label1.TabIndex = 22;
            this.label1.Text = "3. Cantidad por unidad";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(68, 352);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(0);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PaddGap = 0F;
            this.txtNombreProducto.PlaceholderText = "Ejemplo: Queso Amarillo Kraft";
            this.txtNombreProducto.PrefixFore = System.Drawing.Color.Black;
            this.txtNombreProducto.PrefixFormat = AntdUI.FormatFlags.Left;
            this.txtNombreProducto.PrefixSvg = "";
            this.txtNombreProducto.Radius = 0;
            this.txtNombreProducto.Size = new System.Drawing.Size(360, 64);
            this.txtNombreProducto.SuffixFore = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.txtNombreProducto.SuffixFormat = AntdUI.FormatFlags.Left;
            this.txtNombreProducto.SuffixSvg = "";
            this.txtNombreProducto.SuffixWidth = 0;
            this.txtNombreProducto.TabIndex = 21;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblNombreProducto.Location = new System.Drawing.Point(43, 307);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(386, 43);
            this.lblNombreProducto.TabIndex = 20;
            this.lblNombreProducto.Text = "2. Nombre del Producto";
            // 
            // cmbCategorías
            // 
            this.cmbCategorías.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategorías.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategorías.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbCategorías.FormattingEnabled = true;
            this.cmbCategorías.Items.AddRange(new object[] {
            "Abarrotes",
            "Lácteos",
            "Bebidas",
            "Limpieza",
            "Papelería"});
            this.cmbCategorías.Location = new System.Drawing.Point(70, 238);
            this.cmbCategorías.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategorías.Name = "cmbCategorías";
            this.cmbCategorías.Size = new System.Drawing.Size(360, 35);
            this.cmbCategorías.TabIndex = 19;
            this.cmbCategorías.Text = "Seleccione la categoría";
            // 
            // lblCategoríaDeProducto
            // 
            this.lblCategoríaDeProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoríaDeProducto.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoríaDeProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblCategoríaDeProducto.Location = new System.Drawing.Point(44, 182);
            this.lblCategoríaDeProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCategoríaDeProducto.Name = "lblCategoríaDeProducto";
            this.lblCategoríaDeProducto.Size = new System.Drawing.Size(386, 43);
            this.lblCategoríaDeProducto.TabIndex = 18;
            this.lblCategoríaDeProducto.Text = "1. Categoría de Producto";
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.Font = new System.Drawing.Font("Microsoft YaHei", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblIndicaciones.Location = new System.Drawing.Point(44, 101);
            this.lblIndicaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(386, 62);
            this.lblIndicaciones.TabIndex = 17;
            this.lblIndicaciones.Text = "Para agregar un producto complete los siguientes campos:";
            // 
            // lblAgregarProducto
            // 
            this.lblAgregarProducto.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAgregarProducto.Location = new System.Drawing.Point(44, 39);
            this.lblAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAgregarProducto.Name = "lblAgregarProducto";
            this.lblAgregarProducto.Size = new System.Drawing.Size(320, 58);
            this.lblAgregarProducto.TabIndex = 16;
            this.lblAgregarProducto.Text = "Agregar Producto";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(44, 921);
            this.button1.Name = "button1";
            this.button1.Radius = 0;
            this.button1.Size = new System.Drawing.Size(386, 68);
            this.button1.TabIndex = 32;
            this.button1.Text = "Añadir Productos";
            this.button1.Type = AntdUI.TTypeMini.Primary;
            // 
            // ucAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCerrarPanel);
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
            this.Controls.Add(this.lblAgregarProducto);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucAgregarProducto";
            this.Size = new System.Drawing.Size(480, 1024);
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCerrarPanel;
        private System.Windows.Forms.PictureBox pbProducto;
        private AntdUI.Label label3;
        private AntdUI.Input input1;
        private AntdUI.Label label2;
        private AntdUI.InputNumber inputNumberCantProducto;
        private AntdUI.Label label1;
        private AntdUI.Input txtNombreProducto;
        private AntdUI.Label lblNombreProducto;
        private System.Windows.Forms.ComboBox cmbCategorías;
        private AntdUI.Label lblCategoríaDeProducto;
        private AntdUI.Label lblIndicaciones;
        private AntdUI.Label lblAgregarProducto;
        private AntdUI.Button button1;
    }
}
