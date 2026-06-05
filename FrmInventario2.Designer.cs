namespace IlkaPoint
{
    partial class FrmInventario2
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
            this.panelFondo = new AntdUI.Panel();
            this.tlpContenidos = new System.Windows.Forms.TableLayoutPanel();
            this.panelTablaInventario = new AntdUI.Panel();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.Categoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelEncabezado = new AntdUI.Panel();
            this.btnBuscarProducto = new AntdUI.Button();
            this.txtBuscarProducto = new AntdUI.Input();
            this.lblTitulo = new AntdUI.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblNombreApp = new AntdUI.Label();
            this.panelMenuInv = new AntdUI.Panel();
            this.btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.avatarLogo = new AntdUI.Avatar();
            this.btnCerrarsesion = new FontAwesome.Sharp.IconButton();
            this.btnAyuda = new FontAwesome.Sharp.IconButton();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.btnInventario = new FontAwesome.Sharp.IconButton();
            this.panel1 = new AntdUI.Panel();
            this.panelFondo.SuspendLayout();
            this.tlpContenidos.SuspendLayout();
            this.panelTablaInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.panelEncabezado.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.Back = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.panelFondo.Controls.Add(this.tlpContenidos);
            this.panelFondo.Controls.Add(this.panelMenu);
            this.panelFondo.Controls.Add(this.panelMenuInv);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(1418, 968);
            this.panelFondo.TabIndex = 0;
            this.panelFondo.Text = "panel1";
            // 
            // tlpContenidos
            // 
            this.tlpContenidos.ColumnCount = 1;
            this.tlpContenidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenidos.Controls.Add(this.panelEncabezado, 0, 0);
            this.tlpContenidos.Controls.Add(this.panelTablaInventario, 0, 1);
            this.tlpContenidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenidos.Location = new System.Drawing.Point(376, 0);
            this.tlpContenidos.Name = "tlpContenidos";
            this.tlpContenidos.RowCount = 3;
            this.tlpContenidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpContenidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpContenidos.Size = new System.Drawing.Size(1042, 968);
            this.tlpContenidos.TabIndex = 2;
            // 
            // panelTablaInventario
            // 
            this.panelTablaInventario.Back = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.panelTablaInventario.Controls.Add(this.dgvInventario);
            this.panelTablaInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTablaInventario.Location = new System.Drawing.Point(3, 303);
            this.panelTablaInventario.Name = "panelTablaInventario";
            this.panelTablaInventario.Padding = new System.Windows.Forms.Padding(20);
            this.panelTablaInventario.Size = new System.Drawing.Size(1036, 642);
            this.panelTablaInventario.TabIndex = 1;
            this.panelTablaInventario.Text = "panel1";
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoría,
            this.Producto,
            this.Stock,
            this.Estado,
            this.colEditar,
            this.colEliminar});
            this.dgvInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventario.Location = new System.Drawing.Point(20, 20);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowHeadersWidth = 62;
            this.dgvInventario.RowTemplate.Height = 28;
            this.dgvInventario.Size = new System.Drawing.Size(996, 602);
            this.dgvInventario.TabIndex = 1;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellContentClick);
            this.dgvInventario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvInventario_CellFormatting);
            // 
            // Categoría
            // 
            this.Categoría.HeaderText = "Categoría";
            this.Categoría.MinimumWidth = 8;
            this.Categoría.Name = "Categoría";
            this.Categoría.Width = 150;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 8;
            this.Producto.Name = "Producto";
            this.Producto.Width = 150;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 8;
            this.Stock.Name = "Stock";
            this.Stock.Width = 150;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 8;
            this.Estado.Name = "Estado";
            this.Estado.Width = 150;
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "Editar";
            this.colEditar.MinimumWidth = 8;
            this.colEditar.Name = "colEditar";
            this.colEditar.Text = "✏️";
            this.colEditar.UseColumnTextForButtonValue = true;
            this.colEditar.Width = 150;
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.MinimumWidth = 8;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Text = "🗑️";
            this.colEliminar.UseColumnTextForButtonValue = true;
            this.colEliminar.Width = 150;
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.Back = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.panelEncabezado.Controls.Add(this.panel1);
            this.panelEncabezado.Controls.Add(this.lblTitulo);
            this.panelEncabezado.Controls.Add(this.btnAgregarProducto);
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Location = new System.Drawing.Point(3, 3);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(1036, 294);
            this.panelEncabezado.TabIndex = 0;
            this.panelEncabezado.Text = "panel1";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.IconSvg = "SearchOutlined";
            this.btnBuscarProducto.Location = new System.Drawing.Point(260, 0);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Radius = 0;
            this.btnBuscarProducto.Size = new System.Drawing.Size(88, 67);
            this.btnBuscarProducto.TabIndex = 6;
            this.btnBuscarProducto.Type = AntdUI.TTypeMini.Primary;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(0, 0);
            this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.PlaceholderText = "Buscar nombre de producto...";
            this.txtBuscarProducto.PrefixFore = System.Drawing.Color.Black;
            this.txtBuscarProducto.PrefixFormat = AntdUI.FormatFlags.Left;
            this.txtBuscarProducto.PrefixSvg = "";
            this.txtBuscarProducto.Radius = 0;
            this.txtBuscarProducto.Size = new System.Drawing.Size(273, 67);
            this.txtBuscarProducto.SuffixFore = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.txtBuscarProducto.SuffixFormat = AntdUI.FormatFlags.Left;
            this.txtBuscarProducto.SuffixSvg = "";
            this.txtBuscarProducto.SuffixWidth = 0;
            this.txtBuscarProducto.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.lblTitulo.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitulo.Location = new System.Drawing.Point(47, 115);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(305, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Inventario y Stock";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.avatarLogo);
            this.panelMenu.Controls.Add(this.btnCerrarsesion);
            this.panelMenu.Controls.Add(this.btnAyuda);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.btnInventario);
            this.panelMenu.Controls.Add(this.lblNombreApp);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(376, 968);
            this.panelMenu.TabIndex = 3;
            // 
            // lblNombreApp
            // 
            this.lblNombreApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombreApp.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNombreApp.Location = new System.Drawing.Point(70, 31);
            this.lblNombreApp.Margin = new System.Windows.Forms.Padding(4);
            this.lblNombreApp.Name = "lblNombreApp";
            this.lblNombreApp.Size = new System.Drawing.Size(239, 75);
            this.lblNombreApp.TabIndex = 2;
            this.lblNombreApp.Text = "Ilca Point";
            this.lblNombreApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenuInv
            // 
            this.panelMenuInv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenuInv.Back = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.panelMenuInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelMenuInv.Location = new System.Drawing.Point(27, 28);
            this.panelMenuInv.Name = "panelMenuInv";
            this.panelMenuInv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelMenuInv.Size = new System.Drawing.Size(376, 928);
            this.panelMenuInv.TabIndex = 1;
            this.panelMenuInv.Text = "panelMenuDP";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProducto.AutoSize = true;
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarProducto.IconColor = System.Drawing.Color.White;
            this.btnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProducto.IconSize = 45;
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.Location = new System.Drawing.Point(653, 28);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(355, 56);
            this.btnAgregarProducto.TabIndex = 4;
            this.btnAgregarProducto.Text = "Añadir Producto";
            this.btnAgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInicio.IconColor = System.Drawing.Color.White;
            this.btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicio.IconSize = 40;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(32, 387);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(344, 66);
            this.btnInicio.TabIndex = 4;
            this.btnInicio.Text = " Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // avatarLogo
            // 
            this.avatarLogo.BackColor = System.Drawing.Color.White;
            this.avatarLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatarLogo.BorderColor = System.Drawing.Color.Transparent;
            this.avatarLogo.Image = global::IlkaPoint.Properties.Resources._2;
            this.avatarLogo.Location = new System.Drawing.Point(70, 115);
            this.avatarLogo.Name = "avatarLogo";
            this.avatarLogo.Round = true;
            this.avatarLogo.Size = new System.Drawing.Size(234, 234);
            this.avatarLogo.TabIndex = 9;
            this.avatarLogo.Text = "";
            // 
            // btnCerrarsesion
            // 
            this.btnCerrarsesion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarsesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarsesion.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarsesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarsesion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCerrarsesion.IconColor = System.Drawing.Color.White;
            this.btnCerrarsesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarsesion.IconSize = 40;
            this.btnCerrarsesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarsesion.Location = new System.Drawing.Point(32, 870);
            this.btnCerrarsesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarsesion.Name = "btnCerrarsesion";
            this.btnCerrarsesion.Size = new System.Drawing.Size(344, 66);
            this.btnCerrarsesion.TabIndex = 8;
            this.btnCerrarsesion.Text = " Cerrar sesión";
            this.btnCerrarsesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarsesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarsesion.UseVisualStyleBackColor = true;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAyuda.IconColor = System.Drawing.Color.White;
            this.btnAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAyuda.IconSize = 40;
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(32, 796);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(4);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(344, 66);
            this.btnAyuda.TabIndex = 7;
            this.btnAyuda.Text = " Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            this.btnVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVentas.IconColor = System.Drawing.Color.White;
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.IconSize = 40;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(32, 558);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(344, 66);
            this.btnVentas.TabIndex = 6;
            this.btnVentas.Text = " Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            this.btnInventario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInventario.IconColor = System.Drawing.Color.White;
            this.btnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInventario.IconSize = 40;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(32, 472);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(344, 66);
            this.btnInventario.TabIndex = 5;
            this.btnInventario.Text = " Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Back = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.btnBuscarProducto);
            this.panel1.Controls.Add(this.txtBuscarProducto);
            this.panel1.Location = new System.Drawing.Point(638, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 86);
            this.panel1.TabIndex = 5;
            this.panel1.Text = "panel1";
            // 
            // FrmInventario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.panelFondo);
            this.MinimumSize = new System.Drawing.Size(1400, 800);
            this.Name = "FrmInventario2";
            this.Text = "FrmInventario2";
            this.panelFondo.ResumeLayout(false);
            this.tlpContenidos.ResumeLayout(false);
            this.panelTablaInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panelFondo;
        private AntdUI.Panel panelMenuInv;
        private System.Windows.Forms.Panel panelMenu;
        private AntdUI.Avatar avatarLogo;
        private FontAwesome.Sharp.IconButton btnCerrarsesion;
        private FontAwesome.Sharp.IconButton btnAyuda;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnInventario;
        private FontAwesome.Sharp.IconButton btnInicio;
        private AntdUI.Label lblNombreApp;
        private System.Windows.Forms.TableLayoutPanel tlpContenidos;
        private AntdUI.Panel panelEncabezado;
        private AntdUI.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private AntdUI.Input txtBuscarProducto;
        private AntdUI.Button btnBuscarProducto;
        private AntdUI.Panel panelTablaInventario;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoría;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
        private AntdUI.Panel panel1;
    }
}