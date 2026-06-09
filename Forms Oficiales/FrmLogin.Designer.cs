namespace IlkaPoint
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panelFondo = new AntdUI.In.Panel();
            this.panelLogin = new AntdUI.Panel();
            this.avatarCandado = new AntdUI.Avatar();
            this.btnEntar = new AntdUI.Button();
            this.txtContraseña = new AntdUI.Input();
            this.lblContraseña = new AntdUI.Label();
            this.lblIniciarSesión = new AntdUI.Label();
            this.panelCentro = new AntdUI.In.Panel();
            this.avatarLogo = new AntdUI.Avatar();
            this.lblmessag = new System.Windows.Forms.Label();
            this.lblBienvenido = new AntdUI.Label();
            this.pcpassw = new System.Windows.Forms.PictureBox();
            this.pcuser = new System.Windows.Forms.PictureBox();
            this.avatar1 = new AntdUI.Avatar();
            this.panelFondo.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcpassw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcuser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(69)))));
            this.panelFondo.Controls.Add(this.panelLogin);
            this.panelFondo.Controls.Add(this.panelCentro);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(1422, 977);
            this.panelFondo.TabIndex = 0;
            this.panelFondo.Text = "panelFondo";
            this.panelFondo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFondo_Paint);
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogin.Back = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.Controls.Add(this.pcpassw);
            this.panelLogin.Controls.Add(this.pcuser);
            this.panelLogin.Controls.Add(this.avatarCandado);
            this.panelLogin.Controls.Add(this.btnEntar);
            this.panelLogin.Controls.Add(this.txtContraseña);
            this.panelLogin.Controls.Add(this.lblContraseña);
            this.panelLogin.Controls.Add(this.lblIniciarSesión);
            this.panelLogin.Location = new System.Drawing.Point(866, 0);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Radius = 0;
            this.panelLogin.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panelLogin.Size = new System.Drawing.Size(556, 1024);
            this.panelLogin.TabIndex = 11;
            this.panelLogin.Text = "panelLogin";
            // 
            // avatarCandado
            // 
            this.avatarCandado.Location = new System.Drawing.Point(0, 0);
            this.avatarCandado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avatarCandado.Name = "avatarCandado";
            this.avatarCandado.Size = new System.Drawing.Size(0, 0);
            this.avatarCandado.TabIndex = 1;
            // 
            // btnEntar
            // 
            this.btnEntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.btnEntar.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntar.Location = new System.Drawing.Point(108, 573);
            this.btnEntar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntar.Name = "btnEntar";
            this.btnEntar.Radius = 5;
            this.btnEntar.Size = new System.Drawing.Size(348, 61);
            this.btnEntar.TabIndex = 3;
            this.btnEntar.Text = "Entrar";
            this.btnEntar.Type = AntdUI.TTypeMini.Primary;
            this.btnEntar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(145)))));
            this.txtContraseña.BorderWidth = 0.5F;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtContraseña.Location = new System.Drawing.Point(108, 490);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PlaceholderText = "********";
            this.txtContraseña.Radius = 5;
            this.txtContraseña.Size = new System.Drawing.Size(348, 61);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Text = "input1";
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.Click += new System.EventHandler(this.txtContraseña_TextClick);
            // 
            // lblContraseña
            // 
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblContraseña.Location = new System.Drawing.Point(170, 447);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(190, 28);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblIniciarSesión
            // 
            this.lblIniciarSesión.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesión.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblIniciarSesión.Location = new System.Drawing.Point(170, 275);
            this.lblIniciarSesión.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblIniciarSesión.Name = "lblIniciarSesión";
            this.lblIniciarSesión.Size = new System.Drawing.Size(228, 58);
            this.lblIniciarSesión.TabIndex = 0;
            this.lblIniciarSesión.Text = "Iniciar Sesión";
            this.lblIniciarSesión.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCentro
            // 
            this.panelCentro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCentro.Controls.Add(this.lblmessag);
            this.panelCentro.Controls.Add(this.avatarLogo);
            this.panelCentro.Controls.Add(this.lblBienvenido);
            this.panelCentro.Controls.Add(this.avatar1);
            this.panelCentro.Location = new System.Drawing.Point(-7, 0);
            this.panelCentro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(867, 984);
            this.panelCentro.TabIndex = 3;
            this.panelCentro.Text = "panel1";
            // 
            // avatarLogo
            // 
            this.avatarLogo.Location = new System.Drawing.Point(0, 0);
            this.avatarLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avatarLogo.Name = "avatarLogo";
            this.avatarLogo.Size = new System.Drawing.Size(0, 0);
            this.avatarLogo.TabIndex = 3;
            // 
            // lblmessag
            // 
            this.lblmessag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblmessag.AutoSize = true;
            this.lblmessag.BackColor = System.Drawing.Color.Transparent;
            this.lblmessag.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessag.ForeColor = System.Drawing.Color.White;
            this.lblmessag.Location = new System.Drawing.Point(264, 741);
            this.lblmessag.Name = "lblmessag";
            this.lblmessag.Size = new System.Drawing.Size(408, 39);
            this.lblmessag.TabIndex = 17;
            this.lblmessag.Text = "Inicia sesión para continuar";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft YaHei", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBienvenido.Location = new System.Drawing.Point(148, 632);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(564, 97);
            this.lblBienvenido.TabIndex = 15;
            this.lblBienvenido.Text = "¡Bienvenido!";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcpassw
            // 
            this.pcpassw.BackgroundImage = global::IlkaPoint.Properties.Resources.password_148;
            this.pcpassw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcpassw.Location = new System.Drawing.Point(115, 441);
            this.pcpassw.Name = "pcpassw";
            this.pcpassw.Size = new System.Drawing.Size(37, 37);
            this.pcpassw.TabIndex = 5;
            this.pcpassw.TabStop = false;
            // 
            // pcuser
            // 
            this.pcuser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcuser.Image = ((System.Drawing.Image)(resources.GetObject("pcuser.Image")));
            this.pcuser.Location = new System.Drawing.Point(201, 100);
            this.pcuser.Name = "pcuser";
            this.pcuser.Size = new System.Drawing.Size(170, 170);
            this.pcuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcuser.TabIndex = 4;
            this.pcuser.TabStop = false;
            // 
            // avatar1
            // 
            this.avatar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.avatar1.BackColor = System.Drawing.Color.White;
            this.avatar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatar1.BorderColor = System.Drawing.Color.Transparent;
            this.avatar1.Image = global::IlkaPoint.Properties.Resources._2;
            this.avatar1.Location = new System.Drawing.Point(235, 187);
            this.avatar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avatar1.Name = "avatar1";
            this.avatar1.Round = true;
            this.avatar1.Size = new System.Drawing.Size(400, 400);
            this.avatar1.TabIndex = 16;
            this.avatar1.Text = "";
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.panelFondo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panelFondo.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelCentro.ResumeLayout(false);
            this.panelCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcpassw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcuser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.Panel panelFondo;
        private AntdUI.Avatar avatarLogo;
        private AntdUI.In.Panel panelCentro;
        private AntdUI.Panel panelLogin;
        private AntdUI.Avatar avatarCandado;
        private AntdUI.Button btnEntar;
        private AntdUI.Input txtContraseña;
        private AntdUI.Label lblContraseña;
        private AntdUI.Label lblIniciarSesión;
        private System.Windows.Forms.PictureBox pcpassw;
        private System.Windows.Forms.PictureBox pcuser;
        private System.Windows.Forms.Label lblmessag;
        private AntdUI.Label lblBienvenido;
        private AntdUI.Avatar avatar1;
    }
}