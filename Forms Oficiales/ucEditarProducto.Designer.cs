namespace IlkaPoint
{
    partial class ucEditarProducto
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
            this.btnGuardarCambios = new FontAwesome.Sharp.IconButton();
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
            this.panelFondoUC.SuspendLayout();
            this.panelContenidoUC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondoUC
            // 
            this.panelFondoUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.panelFondoUC.Controls.Add(this.panelContenidoUC);
            this.panelFondoUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondoUC.Location = new System.Drawing.Point(0, 0);
            this.panelFondoUC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFondoUC.Name = "panelFondoUC";
            this.panelFondoUC.Size = new System.Drawing.Size(427, 819);
            this.panelFondoUC.TabIndex = 0;
            this.panelFondoUC.Text = "panel1";
            // 
            // panelContenidoUC
            // 
            this.panelContenidoUC.Controls.Add(this.btnCerrarPanel);
            this.panelContenidoUC.Controls.Add(this.btnGuardarCambios);
            this.panelContenidoUC.Controls.Add(this.pbProducto);
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
            this.panelContenidoUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenidoUC.Location = new System.Drawing.Point(0, 0);
            this.panelContenidoUC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContenidoUC.Name = "panelContenidoUC";
            this.panelContenidoUC.Size = new System.Drawing.Size(427, 819);
            this.panelContenidoUC.TabIndex = 1;
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
            this.btnCerrarPanel.Location = new System.Drawing.Point(348, 16);
            this.btnCerrarPanel.Name = "btnCerrarPanel";
            this.btnCerrarPanel.Size = new System.Drawing.Size(52, 52);
            this.btnCerrarPanel.TabIndex = 16;
            this.btnCerrarPanel.UseVisualStyleBackColor = false;
            this.btnCerrarPanel.Click += new System.EventHandler(this.btnCerrarPanel_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarCambios.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnGuardarCambios.IconColor = System.Drawing.Color.White;
            this.btnGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCambios.IconSize = 45;
            this.btnGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCambios.Location = new System.Drawing.Point(49, 932);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(372, 55);
            this.btnGuardarCambios.TabIndex = 14;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            // 
            // pbProducto
            // 
            this.pbProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.pbProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProducto.Image = global::IlkaPoint.Properties.Resources.subir_imagen;
            this.pbProducto.Location = new System.Drawing.Point(94, 618);
            this.pbProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbProducto.Name = "pbProducto";
            this.pbProducto.Size = new System.Drawing.Size(208, 100);
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
            this.label3.Location = new System.Drawing.Point(28, 577);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "5. Agregar Imagen";
            // 
            // input1
            // 
            this.input1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(26, 513);
            this.input1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.input1.Name = "input1";
            this.input1.PlaceholderText = "Ejemplo: 1.75";
            this.input1.PrefixFore = System.Drawing.Color.Black;
            this.input1.PrefixFormat = AntdUI.FormatFlags.Left;
            this.input1.PrefixSvg = "";
            this.input1.Radius = 0;
            this.input1.Size = new System.Drawing.Size(380, 50);
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
            this.label2.Location = new System.Drawing.Point(26, 470);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "4. Precio unitario ($)";
            // 
            // inputNumberCantProducto
            // 
            this.inputNumberCantProducto.AlwaysShowControl = true;
            this.inputNumberCantProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNumberCantProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNumberCantProducto.Location = new System.Drawing.Point(26, 399);
            this.inputNumberCantProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputNumberCantProducto.Name = "inputNumberCantProducto";
            this.inputNumberCantProducto.Size = new System.Drawing.Size(373, 66);
            this.inputNumberCantProducto.TabIndex = 8;
            this.inputNumberCantProducto.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(28, 342);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 53);
            this.label1.TabIndex = 7;
            this.label1.Text = "3. Cantidad por unidad";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(26, 295);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PlaceholderText = "Ejemplo: Queso Amarillo Kraft";
            this.txtNombreProducto.PrefixFore = System.Drawing.Color.Black;
            this.txtNombreProducto.PrefixFormat = AntdUI.FormatFlags.Left;
            this.txtNombreProducto.PrefixSvg = "";
            this.txtNombreProducto.Radius = 0;
            this.txtNombreProducto.Size = new System.Drawing.Size(373, 48);
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
            this.lblNombreProducto.Location = new System.Drawing.Point(26, 246);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(373, 43);
            this.lblNombreProducto.TabIndex = 5;
            this.lblNombreProducto.Text = "2. Nombre del Producto";
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
            this.cmbCategorías.Location = new System.Drawing.Point(28, 205);
            this.cmbCategorías.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategorías.Name = "cmbCategorías";
            this.cmbCategorías.Size = new System.Drawing.Size(413, 44);
            this.cmbCategorías.TabIndex = 4;
            this.cmbCategorías.Text = "Seleccione la categoría";
            // 
            // lblCategoríaDeProducto
            // 
            this.lblCategoríaDeProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoríaDeProducto.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoríaDeProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblCategoríaDeProducto.Location = new System.Drawing.Point(28, 157);
            this.lblCategoríaDeProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCategoríaDeProducto.Name = "lblCategoríaDeProducto";
            this.lblCategoríaDeProducto.Size = new System.Drawing.Size(373, 43);
            this.lblCategoríaDeProducto.TabIndex = 3;
            this.lblCategoríaDeProducto.Text = "1. Categoría de Producto";
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblIndicaciones.Location = new System.Drawing.Point(17, 78);
            this.lblIndicaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(402, 62);
            this.lblIndicaciones.TabIndex = 1;
            this.lblIndicaciones.Text = "Para editar un producto complete los siguientes campos:";
            // 
            // lblAgregarProducto
            // 
            this.lblAgregarProducto.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAgregarProducto.Location = new System.Drawing.Point(28, 16);
            this.lblAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAgregarProducto.Name = "lblAgregarProducto";
            this.lblAgregarProducto.Size = new System.Drawing.Size(320, 58);
            this.lblAgregarProducto.TabIndex = 0;
            this.lblAgregarProducto.Text = "Editar Producto";
            this.lblAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucEditarProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelFondoUC);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucEditarProducto";
            this.Size = new System.Drawing.Size(427, 819);
            this.panelFondoUC.ResumeLayout(false);
            this.panelContenidoUC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.Panel panelFondoUC;
        private AntdUI.In.Panel panelContenidoUC;
        private FontAwesome.Sharp.IconButton btnGuardarCambios;
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
        private FontAwesome.Sharp.IconButton btnCerrarPanel;
    }
}
