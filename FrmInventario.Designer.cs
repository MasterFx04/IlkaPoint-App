namespace IlkaPoint
{
    partial class FrmInventario
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
            this.panelFondo = new AntdUI.In.Panel();
            this.panelContenido = new AntdUI.Panel();
            this.panelCentralTabla = new AntdUI.Panel();
            this.panelSuperiorBusqueda = new AntdUI.In.Panel();
            this.btnAñadirProducto = new AntdUI.Button();
            this.lblTitulo = new AntdUI.Label();
            this.inputBuscador = new AntdUI.Input();
            this.tableInventario = new AntdUI.Table();
            this.panelInferiorBotones = new AntdUI.In.Panel();
            this.panelMenu = new AntdUI.Panel();
            this.panelFondo.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.panelCentralTabla.SuspendLayout();
            this.panelSuperiorBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.panelFondo.Controls.Add(this.panelContenido);
            this.panelFondo.Controls.Add(this.panelMenu);
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Padding = new System.Windows.Forms.Padding(15);
            this.panelFondo.Size = new System.Drawing.Size(1418, 968);
            this.panelFondo.TabIndex = 0;
            this.panelFondo.Text = "panel1";
            // 
            // panelContenido
            // 
            this.panelContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenido.Back = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.panelContenido.Controls.Add(this.panelCentralTabla);
            this.panelContenido.Controls.Add(this.panelInferiorBotones);
            this.panelContenido.Location = new System.Drawing.Point(320, 15);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1083, 938);
            this.panelContenido.TabIndex = 1;
            this.panelContenido.Text = "panel2";
            // 
            // panelCentralTabla
            // 
            this.panelCentralTabla.Back = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.panelCentralTabla.Controls.Add(this.panelSuperiorBusqueda);
            this.panelCentralTabla.Controls.Add(this.tableInventario);
            this.panelCentralTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentralTabla.Location = new System.Drawing.Point(0, 0);
            this.panelCentralTabla.Name = "panelCentralTabla";
            this.panelCentralTabla.Size = new System.Drawing.Size(1083, 851);
            this.panelCentralTabla.TabIndex = 2;
            this.panelCentralTabla.Text = "panel2";
            // 
            // panelSuperiorBusqueda
            // 
            this.panelSuperiorBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.panelSuperiorBusqueda.Controls.Add(this.btnAñadirProducto);
            this.panelSuperiorBusqueda.Controls.Add(this.lblTitulo);
            this.panelSuperiorBusqueda.Controls.Add(this.inputBuscador);
            this.panelSuperiorBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperiorBusqueda.Location = new System.Drawing.Point(0, 0);
            this.panelSuperiorBusqueda.Name = "panelSuperiorBusqueda";
            this.panelSuperiorBusqueda.Size = new System.Drawing.Size(1083, 200);
            this.panelSuperiorBusqueda.TabIndex = 0;
            this.panelSuperiorBusqueda.Text = "panel2";
            // 
            // btnAñadirProducto
            // 
            this.btnAñadirProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAñadirProducto.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnAñadirProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnAñadirProducto.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirProducto.Location = new System.Drawing.Point(723, 12);
            this.btnAñadirProducto.Name = "btnAñadirProducto";
            this.btnAñadirProducto.Size = new System.Drawing.Size(341, 74);
            this.btnAñadirProducto.TabIndex = 3;
            this.btnAñadirProducto.Text = "Añadir Producto";
            this.btnAñadirProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirProducto.Type = AntdUI.TTypeMini.Primary;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitulo.Location = new System.Drawing.Point(51, 113);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(383, 47);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Inventario y Stock";
            // 
            // inputBuscador
            // 
            this.inputBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBuscador.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBuscador.Location = new System.Drawing.Point(670, 102);
            this.inputBuscador.Name = "inputBuscador";
            this.inputBuscador.PlaceholderText = "Buscar Producto";
            this.inputBuscador.Size = new System.Drawing.Size(383, 78);
            this.inputBuscador.Suffix = global::IlkaPoint.Properties.Resources.search_engine_optimization;
            this.inputBuscador.TabIndex = 0;
            this.inputBuscador.Text = "Buscar nombre del Producto";
            this.inputBuscador.TextChanged += new System.EventHandler(this.inputBuscador_TextChanged);
            // 
            // tableInventario
            // 
            this.tableInventario.Gap = 12;
            this.tableInventario.Location = new System.Drawing.Point(0, 232);
            this.tableInventario.Name = "tableInventario";
            this.tableInventario.Size = new System.Drawing.Size(1083, 619);
            this.tableInventario.TabIndex = 0;
            this.tableInventario.Text = "table1";
            // 
            // panelInferiorBotones
            // 
            this.panelInferiorBotones.BackColor = System.Drawing.Color.Gray;
            this.panelInferiorBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferiorBotones.Location = new System.Drawing.Point(0, 851);
            this.panelInferiorBotones.Name = "panelInferiorBotones";
            this.panelInferiorBotones.Size = new System.Drawing.Size(1083, 87);
            this.panelInferiorBotones.TabIndex = 1;
            this.panelInferiorBotones.Text = "panel2";
            // 
            // panelMenu
            // 
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(15, 15);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(20);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(256, 938);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Text = "panel1";
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.panelFondo);
            this.Name = "FrmInventario";
            this.Text = "FrmInventario";
            this.panelFondo.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.panelCentralTabla.ResumeLayout(false);
            this.panelSuperiorBusqueda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.Panel panelFondo;
        private AntdUI.Panel panelMenu;
        private AntdUI.Panel panelContenido;
        private AntdUI.Panel panelCentralTabla;
        private AntdUI.In.Panel panelInferiorBotones;
        private AntdUI.Table tableInventario;
        private AntdUI.In.Panel panelSuperiorBusqueda;
        private AntdUI.Button btnAñadirProducto;
        private AntdUI.Label lblTitulo;
        private AntdUI.Input inputBuscador;
    }
}