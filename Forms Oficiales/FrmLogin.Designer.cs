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
            this.avatarLogo = new AntdUI.Avatar();
            this.pnlLoginContainer = new AntdUI.In.Panel();
            this.avatar2 = new AntdUI.Avatar();
            this.lblBienvenido = new AntdUI.Label();
            this.lbliniciotext = new System.Windows.Forms.Label();
            this.panelLogin = new AntdUI.Panel();
            this.lblIniciarSesión = new AntdUI.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcuser = new System.Windows.Forms.PictureBox();
            this.avatarCandado = new AntdUI.Avatar();
            this.btnEntar = new AntdUI.Button();
            this.txtContraseña = new AntdUI.Input();
            this.lblContraseña = new AntdUI.Label();
            this.panelFondo.SuspendLayout();
            this.pnlLoginContainer.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcuser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(69)))));
            this.panelFondo.Controls.Add(this.panelLogin);
            this.panelFondo.Controls.Add(this.pnlLoginContainer);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(1422, 977);
            this.panelFondo.TabIndex = 0;
            this.panelFondo.Text = "panelFondo";
            this.panelFondo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFondo_Paint);
            this.panelFondo.Resize += new System.EventHandler(this.panelFondo_Resize);
            // 
            // avatarLogo
            // 
            this.avatarLogo.Location = new System.Drawing.Point(0, 0);
            this.avatarLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avatarLogo.Name = "avatarLogo";
            this.avatarLogo.Size = new System.Drawing.Size(0, 0);
            this.avatarLogo.TabIndex = 3;
            // 
            // pnlLoginContainer
            // 
            this.pnlLoginContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLoginContainer.Controls.Add(this.lbliniciotext);
            this.pnlLoginContainer.Controls.Add(this.lblBienvenido);
            this.pnlLoginContainer.Controls.Add(this.avatar2);
            this.pnlLoginContainer.Controls.Add(this.avatarLogo);
            this.pnlLoginContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLoginContainer.Name = "pnlLoginContainer";
            this.pnlLoginContainer.Size = new System.Drawing.Size(783, 977);
            this.pnlLoginContainer.TabIndex = 3;
            this.pnlLoginContainer.Text = "panel1";
            // 
            // avatar2
            // 
            this.avatar2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.avatar2.BackColor = System.Drawing.Color.White;
            this.avatar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.avatar2.BorderColor = System.Drawing.Color.Transparent;
            this.avatar2.Image = global::IlkaPoint.Properties.Resources._2;
            this.avatar2.Location = new System.Drawing.Point(189, 152);
            this.avatar2.Name = "avatar2";
            this.avatar2.Round = true;
            this.avatar2.Size = new System.Drawing.Size(380, 380);
            this.avatar2.TabIndex = 18;
            this.avatar2.Text = "";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBienvenido.Location = new System.Drawing.Point(97, 566);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(581, 119);
            this.lblBienvenido.TabIndex = 17;
            this.lblBienvenido.Text = "¡Bienvenido!";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbliniciotext
            // 
            this.lbliniciotext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbliniciotext.AutoSize = true;
            this.lbliniciotext.BackColor = System.Drawing.Color.Transparent;
            this.lbliniciotext.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliniciotext.ForeColor = System.Drawing.Color.White;
            this.lbliniciotext.Location = new System.Drawing.Point(198, 696);
            this.lbliniciotext.Name = "lbliniciotext";
            this.lbliniciotext.Size = new System.Drawing.Size(467, 45);
            this.lbliniciotext.TabIndex = 19;
            this.lbliniciotext.Text = "Inicia sesión para continuar";
            this.lbliniciotext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogin.Back = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.Controls.Add(this.lblIniciarSesión);
            this.panelLogin.Controls.Add(this.pictureBox2);
            this.panelLogin.Controls.Add(this.pcuser);
            this.panelLogin.Controls.Add(this.avatarCandado);
            this.panelLogin.Controls.Add(this.btnEntar);
            this.panelLogin.Controls.Add(this.txtContraseña);
            this.panelLogin.Controls.Add(this.lblContraseña);
            this.panelLogin.Location = new System.Drawing.Point(782, 0);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Radius = 0;
            this.panelLogin.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panelLogin.Size = new System.Drawing.Size(640, 977);
            this.panelLogin.TabIndex = 16;
            this.panelLogin.Text = "panelLogin";
            // 
            // lblIniciarSesión
            // 
            this.lblIniciarSesión.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIniciarSesión.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesión.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblIniciarSesión.Location = new System.Drawing.Point(189, 355);
            this.lblIniciarSesión.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblIniciarSesión.Name = "lblIniciarSesión";
            this.lblIniciarSesión.Size = new System.Drawing.Size(268, 40);
            this.lblIniciarSesión.TabIndex = 0;
            this.lblIniciarSesión.Text = "Iniciar Sesión";
            this.lblIniciarSesión.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = global::IlkaPoint.Properties.Resources.passwordimg;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(178, 502);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pcuser
            // 
            this.pcuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcuser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcuser.BackgroundImage")));
            this.pcuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcuser.Location = new System.Drawing.Point(254, 169);
            this.pcuser.Name = "pcuser";
            this.pcuser.Size = new System.Drawing.Size(145, 145);
            this.pcuser.TabIndex = 4;
            this.pcuser.TabStop = false;
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
            this.btnEntar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(96)))));
            this.btnEntar.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntar.Location = new System.Drawing.Point(169, 626);
            this.btnEntar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntar.Name = "btnEntar";
            this.btnEntar.Size = new System.Drawing.Size(308, 59);
            this.btnEntar.TabIndex = 3;
            this.btnEntar.Text = "Entrar";
            this.btnEntar.Type = AntdUI.TTypeMini.Primary;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(145)))));
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtContraseña.Location = new System.Drawing.Point(169, 534);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PlaceholderText = "********";
            this.txtContraseña.Size = new System.Drawing.Size(308, 56);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Text = "input1";
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblContraseña.Location = new System.Drawing.Point(218, 502);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(145, 28);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña";
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
            this.pnlLoginContainer.ResumeLayout(false);
            this.pnlLoginContainer.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcuser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.Panel panelFondo;
        private AntdUI.Panel panelLogin;
        private AntdUI.Label lblIniciarSesión;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pcuser;
        private AntdUI.Avatar avatarCandado;
        private AntdUI.Button btnEntar;
        private AntdUI.Input txtContraseña;
        private AntdUI.Label lblContraseña;
        private AntdUI.In.Panel pnlLoginContainer;
        private System.Windows.Forms.Label lbliniciotext;
        private AntdUI.Label lblBienvenido;
        private AntdUI.Avatar avatar2;
        private AntdUI.Avatar avatarLogo;
    }
}