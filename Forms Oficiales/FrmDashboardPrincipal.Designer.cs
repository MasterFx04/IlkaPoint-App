namespace IlkaPoint
{
    partial class FrmDashboardPrincipal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelFondoDP = new AntdUI.Panel();
            this.panelMenuDP = new AntdUI.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.avatarLogo = new AntdUI.Avatar();
            this.btnCerrarsesion = new FontAwesome.Sharp.IconButton();
            this.btnAyuda = new FontAwesome.Sharp.IconButton();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.btnInventario = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.lblNombreApp = new AntdUI.Label();
            this.panelContenidoDP = new AntdUI.In.Panel();
            this.panelInventarioRapido = new AntdUI.Panel();
            this.dgvInventarioRapido = new System.Windows.Forms.DataGridView();
            this.labelInventarioRapido = new AntdUI.Label();
            this.tableLayoutPanelGraficosMedios = new System.Windows.Forms.TableLayoutPanel();
            this.chartCategorias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTendencia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanelTarjetas = new System.Windows.Forms.TableLayoutPanel();
            this.panelBajoStock = new AntdUI.Panel();
            this.label4 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.panelTotalArticulos = new AntdUI.Panel();
            this.lblTotalDeArticulos = new AntdUI.Label();
            this.lblNumTotalArt = new AntdUI.Label();
            this.panelArticulosAgotados = new AntdUI.Panel();
            this.lblArticulosAgotados = new AntdUI.Label();
            this.lblNumArtAgotados = new AntdUI.Label();
            this.panelFondoDP.SuspendLayout();
            this.panelMenuDP.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelContenidoDP.SuspendLayout();
            this.panelInventarioRapido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioRapido)).BeginInit();
            this.tableLayoutPanelGraficosMedios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTendencia)).BeginInit();
            this.tableLayoutPanelTarjetas.SuspendLayout();
            this.panelBajoStock.SuspendLayout();
            this.panelTotalArticulos.SuspendLayout();
            this.panelArticulosAgotados.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFondoDP
            // 
            this.panelFondoDP.Back = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.panelFondoDP.Controls.Add(this.panelMenuDP);
            this.panelFondoDP.Controls.Add(this.panelContenidoDP);
            this.panelFondoDP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondoDP.Location = new System.Drawing.Point(0, 0);
            this.panelFondoDP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFondoDP.Name = "panelFondoDP";
            this.panelFondoDP.Radius = 0;
            this.panelFondoDP.Size = new System.Drawing.Size(1418, 968);
            this.panelFondoDP.TabIndex = 0;
            this.panelFondoDP.Text = "panelFondoDP";
            this.panelFondoDP.Click += new System.EventHandler(this.panelFondoDP_Click);
            // 
            // panelMenuDP
            // 
            this.panelMenuDP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenuDP.Back = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.panelMenuDP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelMenuDP.Controls.Add(this.panelMenu);
            this.panelMenuDP.Location = new System.Drawing.Point(43, 35);
            this.panelMenuDP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenuDP.Name = "panelMenuDP";
            this.panelMenuDP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelMenuDP.Size = new System.Drawing.Size(376, 928);
            this.panelMenuDP.TabIndex = 0;
            this.panelMenuDP.Text = "panelMenuDP";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.avatarLogo);
            this.panelMenu.Controls.Add(this.btnCerrarsesion);
            this.panelMenu.Controls.Add(this.btnAyuda);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.btnInventario);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.lblNombreApp);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(376, 928);
            this.panelMenu.TabIndex = 3;
            // 
            // avatarLogo
            // 
            this.avatarLogo.BackColor = System.Drawing.Color.White;
            this.avatarLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatarLogo.BorderColor = System.Drawing.Color.Transparent;
            this.avatarLogo.Image = global::IlkaPoint.Properties.Resources._2;
            this.avatarLogo.Location = new System.Drawing.Point(70, 115);
            this.avatarLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnCerrarsesion.AutoSize = true;
            this.btnCerrarsesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarsesion.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarsesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarsesion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCerrarsesion.IconColor = System.Drawing.Color.White;
            this.btnCerrarsesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarsesion.IconSize = 40;
            this.btnCerrarsesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarsesion.Location = new System.Drawing.Point(32, 824);
            this.btnCerrarsesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarsesion.Name = "btnCerrarsesion";
            this.btnCerrarsesion.Size = new System.Drawing.Size(344, 100);
            this.btnCerrarsesion.TabIndex = 8;
            this.btnCerrarsesion.Text = " Cerrar sesión";
            this.btnCerrarsesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarsesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarsesion.UseVisualStyleBackColor = true;
            this.btnCerrarsesion.Click += new System.EventHandler(this.btnCerrarsesion_Click);
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
            this.btnAyuda.Location = new System.Drawing.Point(32, 756);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(4);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(344, 66);
            this.btnAyuda.TabIndex = 7;
            this.btnAyuda.Text = " Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click_1);
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
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click_1);
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
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
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
            this.btnInicio.Location = new System.Drawing.Point(32, 388);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(344, 66);
            this.btnInicio.TabIndex = 4;
            this.btnInicio.Text = " Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // lblNombreApp
            // 
            this.lblNombreApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombreApp.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNombreApp.Location = new System.Drawing.Point(70, 31);
            this.lblNombreApp.Margin = new System.Windows.Forms.Padding(4);
            this.lblNombreApp.Name = "lblNombreApp";
            this.lblNombreApp.Size = new System.Drawing.Size(238, 75);
            this.lblNombreApp.TabIndex = 2;
            this.lblNombreApp.Text = "Ilca Point";
            this.lblNombreApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContenidoDP
            // 
            this.panelContenidoDP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenidoDP.BackColor = System.Drawing.Color.Transparent;
            this.panelContenidoDP.Controls.Add(this.panelInventarioRapido);
            this.panelContenidoDP.Controls.Add(this.tableLayoutPanelGraficosMedios);
            this.panelContenidoDP.Controls.Add(this.tableLayoutPanelTarjetas);
            this.panelContenidoDP.Location = new System.Drawing.Point(426, 35);
            this.panelContenidoDP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContenidoDP.Name = "panelContenidoDP";
            this.panelContenidoDP.Size = new System.Drawing.Size(989, 930);
            this.panelContenidoDP.TabIndex = 1;
            this.panelContenidoDP.Text = "panelContenidoDP";
            // 
            // panelInventarioRapido
            // 
            this.panelInventarioRapido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInventarioRapido.Controls.Add(this.dgvInventarioRapido);
            this.panelInventarioRapido.Controls.Add(this.labelInventarioRapido);
            this.panelInventarioRapido.Location = new System.Drawing.Point(0, 648);
            this.panelInventarioRapido.Margin = new System.Windows.Forms.Padding(3, 20, 3, 2);
            this.panelInventarioRapido.Name = "panelInventarioRapido";
            this.panelInventarioRapido.Size = new System.Drawing.Size(989, 282);
            this.panelInventarioRapido.TabIndex = 9;
            this.panelInventarioRapido.Text = "panel1";
            // 
            // dgvInventarioRapido
            // 
            this.dgvInventarioRapido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventarioRapido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventarioRapido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarioRapido.Location = new System.Drawing.Point(0, 40);
            this.dgvInventarioRapido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInventarioRapido.Name = "dgvInventarioRapido";
            this.dgvInventarioRapido.RowHeadersWidth = 62;
            this.dgvInventarioRapido.RowTemplate.Height = 28;
            this.dgvInventarioRapido.Size = new System.Drawing.Size(989, 242);
            this.dgvInventarioRapido.TabIndex = 1;
            // 
            // labelInventarioRapido
            // 
            this.labelInventarioRapido.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventarioRapido.Location = new System.Drawing.Point(14, 5);
            this.labelInventarioRapido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelInventarioRapido.Name = "labelInventarioRapido";
            this.labelInventarioRapido.Size = new System.Drawing.Size(249, 28);
            this.labelInventarioRapido.TabIndex = 0;
            this.labelInventarioRapido.Text = "Inventario Rápido";
            // 
            // tableLayoutPanelGraficosMedios
            // 
            this.tableLayoutPanelGraficosMedios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelGraficosMedios.AutoSize = true;
            this.tableLayoutPanelGraficosMedios.ColumnCount = 2;
            this.tableLayoutPanelGraficosMedios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGraficosMedios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGraficosMedios.Controls.Add(this.chartCategorias, 1, 0);
            this.tableLayoutPanelGraficosMedios.Controls.Add(this.chartTendencia, 0, 0);
            this.tableLayoutPanelGraficosMedios.Location = new System.Drawing.Point(7, 225);
            this.tableLayoutPanelGraficosMedios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 30);
            this.tableLayoutPanelGraficosMedios.Name = "tableLayoutPanelGraficosMedios";
            this.tableLayoutPanelGraficosMedios.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.tableLayoutPanelGraficosMedios.RowCount = 1;
            this.tableLayoutPanelGraficosMedios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGraficosMedios.Size = new System.Drawing.Size(982, 344);
            this.tableLayoutPanelGraficosMedios.TabIndex = 8;
            // 
            // chartCategorias
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCategorias.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCategorias.Legends.Add(legend1);
            this.chartCategorias.Location = new System.Drawing.Point(501, 17);
            this.chartCategorias.Margin = new System.Windows.Forms.Padding(10, 2, 3, 2);
            this.chartCategorias.Name = "chartCategorias";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCategorias.Series.Add(series1);
            this.chartCategorias.Size = new System.Drawing.Size(453, 300);
            this.chartCategorias.TabIndex = 1;
            this.chartCategorias.Text = "chart2";
            // 
            // chartTendencia
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTendencia.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTendencia.Legends.Add(legend2);
            this.chartTendencia.Location = new System.Drawing.Point(10, 17);
            this.chartTendencia.Margin = new System.Windows.Forms.Padding(10, 2, 3, 2);
            this.chartTendencia.Name = "chartTendencia";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTendencia.Series.Add(series2);
            this.chartTendencia.Size = new System.Drawing.Size(453, 300);
            this.chartTendencia.TabIndex = 0;
            this.chartTendencia.Text = "chart1";
            this.chartTendencia.Click += new System.EventHandler(this.chartTendencia_Click);
            // 
            // tableLayoutPanelTarjetas
            // 
            this.tableLayoutPanelTarjetas.AutoSize = true;
            this.tableLayoutPanelTarjetas.ColumnCount = 3;
            this.tableLayoutPanelTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.53378F));
            this.tableLayoutPanelTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.10931F));
            this.tableLayoutPanelTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.35691F));
            this.tableLayoutPanelTarjetas.Controls.Add(this.panelBajoStock, 2, 0);
            this.tableLayoutPanelTarjetas.Controls.Add(this.panelTotalArticulos, 0, 0);
            this.tableLayoutPanelTarjetas.Controls.Add(this.panelArticulosAgotados, 1, 0);
            this.tableLayoutPanelTarjetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTarjetas.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTarjetas.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelTarjetas.Name = "tableLayoutPanelTarjetas";
            this.tableLayoutPanelTarjetas.RowCount = 1;
            this.tableLayoutPanelTarjetas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanelTarjetas.Size = new System.Drawing.Size(989, 180);
            this.tableLayoutPanelTarjetas.TabIndex = 7;
            // 
            // panelBajoStock
            // 
            this.panelBajoStock.Back = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.panelBajoStock.Controls.Add(this.label4);
            this.panelBajoStock.Controls.Add(this.label3);
            this.panelBajoStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBajoStock.Location = new System.Drawing.Point(668, 10);
            this.panelBajoStock.Margin = new System.Windows.Forms.Padding(10);
            this.panelBajoStock.Name = "panelBajoStock";
            this.panelBajoStock.Radius = 10;
            this.panelBajoStock.Size = new System.Drawing.Size(311, 160);
            this.panelBajoStock.TabIndex = 9;
            this.panelBajoStock.Text = "panel2";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(82, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 51);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bajo Stock";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(62, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 60);
            this.label3.TabIndex = 1;
            this.label3.Text = "2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelTotalArticulos
            // 
            this.panelTotalArticulos.Back = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(112)))), ((int)(((byte)(210)))));
            this.panelTotalArticulos.Controls.Add(this.lblTotalDeArticulos);
            this.panelTotalArticulos.Controls.Add(this.lblNumTotalArt);
            this.panelTotalArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTotalArticulos.Location = new System.Drawing.Point(10, 10);
            this.panelTotalArticulos.Margin = new System.Windows.Forms.Padding(10);
            this.panelTotalArticulos.Name = "panelTotalArticulos";
            this.panelTotalArticulos.Radius = 10;
            this.panelTotalArticulos.Size = new System.Drawing.Size(311, 160);
            this.panelTotalArticulos.TabIndex = 7;
            this.panelTotalArticulos.Text = "panel1";
            // 
            // lblTotalDeArticulos
            // 
            this.lblTotalDeArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDeArticulos.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTotalDeArticulos.Location = new System.Drawing.Point(34, 21);
            this.lblTotalDeArticulos.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalDeArticulos.Name = "lblTotalDeArticulos";
            this.lblTotalDeArticulos.Size = new System.Drawing.Size(239, 50);
            this.lblTotalDeArticulos.TabIndex = 0;
            this.lblTotalDeArticulos.Text = "Total de Artículos";
            this.lblTotalDeArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalDeArticulos.Click += new System.EventHandler(this.lblTotalDeArticulos_Click);
            // 
            // lblNumTotalArt
            // 
            this.lblNumTotalArt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumTotalArt.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTotalArt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNumTotalArt.Location = new System.Drawing.Point(92, 83);
            this.lblNumTotalArt.Margin = new System.Windows.Forms.Padding(0);
            this.lblNumTotalArt.Name = "lblNumTotalArt";
            this.lblNumTotalArt.Size = new System.Drawing.Size(104, 47);
            this.lblNumTotalArt.TabIndex = 1;
            this.lblNumTotalArt.Text = "1990";
            this.lblNumTotalArt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumTotalArt.Click += new System.EventHandler(this.lblNumTotalArt_Click_1);
            // 
            // panelArticulosAgotados
            // 
            this.panelArticulosAgotados.Back = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelArticulosAgotados.Controls.Add(this.lblArticulosAgotados);
            this.panelArticulosAgotados.Controls.Add(this.lblNumArtAgotados);
            this.panelArticulosAgotados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelArticulosAgotados.Location = new System.Drawing.Point(341, 10);
            this.panelArticulosAgotados.Margin = new System.Windows.Forms.Padding(10);
            this.panelArticulosAgotados.Name = "panelArticulosAgotados";
            this.panelArticulosAgotados.Radius = 10;
            this.panelArticulosAgotados.Size = new System.Drawing.Size(307, 160);
            this.panelArticulosAgotados.TabIndex = 8;
            this.panelArticulosAgotados.Text = "panel1";
            // 
            // lblArticulosAgotados
            // 
            this.lblArticulosAgotados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArticulosAgotados.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulosAgotados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblArticulosAgotados.Location = new System.Drawing.Point(22, 19);
            this.lblArticulosAgotados.Margin = new System.Windows.Forms.Padding(0);
            this.lblArticulosAgotados.Name = "lblArticulosAgotados";
            this.lblArticulosAgotados.Size = new System.Drawing.Size(258, 52);
            this.lblArticulosAgotados.TabIndex = 0;
            this.lblArticulosAgotados.Text = "Productos Agotados ";
            this.lblArticulosAgotados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumArtAgotados
            // 
            this.lblNumArtAgotados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumArtAgotados.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumArtAgotados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNumArtAgotados.Location = new System.Drawing.Point(85, 70);
            this.lblNumArtAgotados.Margin = new System.Windows.Forms.Padding(0);
            this.lblNumArtAgotados.Name = "lblNumArtAgotados";
            this.lblNumArtAgotados.Size = new System.Drawing.Size(141, 60);
            this.lblNumArtAgotados.TabIndex = 1;
            this.lblNumArtAgotados.Text = "2";
            this.lblNumArtAgotados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumArtAgotados.Click += new System.EventHandler(this.lblNumArtAgotados_Click);
            // 
            // FrmDashboardPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.panelFondoDP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(850, 797);
            this.Name = "FrmDashboardPrincipal";
            this.Text = "Dashboard Principal";
            this.Load += new System.EventHandler(this.FrmDashboardPrincipal_Load);
            this.panelFondoDP.ResumeLayout(false);
            this.panelMenuDP.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelContenidoDP.ResumeLayout(false);
            this.panelContenidoDP.PerformLayout();
            this.panelInventarioRapido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioRapido)).EndInit();
            this.tableLayoutPanelGraficosMedios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTendencia)).EndInit();
            this.tableLayoutPanelTarjetas.ResumeLayout(false);
            this.panelBajoStock.ResumeLayout(false);
            this.panelTotalArticulos.ResumeLayout(false);
            this.panelArticulosAgotados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panelFondoDP;
        private AntdUI.Panel panelMenuDP;
        private AntdUI.In.Panel panelContenidoDP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTarjetas;
        private AntdUI.Panel panelBajoStock;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private AntdUI.Panel panelTotalArticulos;
        private AntdUI.Label lblNumTotalArt;
        private AntdUI.Label lblTotalDeArticulos;
        private AntdUI.Panel panelArticulosAgotados;
        private AntdUI.Label lblNumArtAgotados;
        private AntdUI.Label lblArticulosAgotados;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGraficosMedios;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTendencia;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategorias;
        private AntdUI.Panel panelInventarioRapido;
        private AntdUI.Label labelInventarioRapido;
        private System.Windows.Forms.DataGridView dgvInventarioRapido;
        private System.Windows.Forms.Panel panelMenu;
        private AntdUI.Avatar avatarLogo;
        private FontAwesome.Sharp.IconButton btnCerrarsesion;
        private FontAwesome.Sharp.IconButton btnAyuda;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnInventario;
        private FontAwesome.Sharp.IconButton btnInicio;
        private AntdUI.Label lblNombreApp;
    }
}