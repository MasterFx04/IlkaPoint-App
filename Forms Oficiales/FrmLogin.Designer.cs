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
            this.panelFondo = new AntdUI.In.Panel();
            this.panelCentro = new AntdUI.In.Panel();
            this.lblBienvenido = new AntdUI.Label();
            this.panelLogin = new AntdUI.Panel();
            this.avatarCandado = new AntdUI.Avatar();
            this.btnEntar = new AntdUI.Button();
            this.txtContraseña = new AntdUI.Input();
            this.lblContraseña = new AntdUI.Label();
            this.lblIniciarSesión = new AntdUI.Label();
            this.avatarLogo = new AntdUI.Avatar();
            this.avatar1 = new AntdUI.Avatar();
            this.panelFondo.SuspendLayout();
            this.panelCentro.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(69)))));
            this.panelFondo.Controls.Add(this.panelCentro);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(1418, 968);
            this.panelFondo.TabIndex = 0;
            this.panelFondo.Text = "panelFondo";
            this.panelFondo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFondo_Paint);
            // 
            // panelCentro
            // 
            this.panelCentro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCentro.Controls.Add(this.avatar1);
            this.panelCentro.Controls.Add(this.lblBienvenido);
            this.panelCentro.Controls.Add(this.panelLogin);
            this.panelCentro.Controls.Add(this.avatarLogo);
            this.panelCentro.Location = new System.Drawing.Point(112, 65);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(1198, 837);
            this.panelCentro.TabIndex = 3;
            this.panelCentro.Text = "panel1";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBienvenido.Location = new System.Drawing.Point(645, 83);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(512, 128);
            this.lblBienvenido.TabIndex = 2;
            this.lblBienvenido.Text = "¡Bienvenido!";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBienvenido.Click += new System.EventHandler(this.lblBienvenido_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.Back = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.Controls.Add(this.avatarCandado);
            this.panelLogin.Controls.Add(this.btnEntar);
            this.panelLogin.Controls.Add(this.txtContraseña);
            this.panelLogin.Controls.Add(this.lblContraseña);
            this.panelLogin.Controls.Add(this.lblIniciarSesión);
            this.panelLogin.Location = new System.Drawing.Point(705, 254);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Radius = 20;
            this.panelLogin.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panelLogin.Size = new System.Drawing.Size(411, 385);
            this.panelLogin.TabIndex = 0;
            this.panelLogin.Text = "panelLogin";
            // 
            // avatarCandado
            // 
            this.avatarCandado.Location = new System.Drawing.Point(0, 0);
            this.avatarCandado.Name = "avatarCandado";
            this.avatarCandado.Size = new System.Drawing.Size(0, 0);
            this.avatarCandado.TabIndex = 1;
            // 
            // btnEntar
            // 
            this.btnEntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(86)))), ((int)(((byte)(205)))));
            this.btnEntar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntar.Location = new System.Drawing.Point(88, 268);
            this.btnEntar.Name = "btnEntar";
            this.btnEntar.Size = new System.Drawing.Size(244, 74);
            this.btnEntar.TabIndex = 3;
            this.btnEntar.Text = "Entrar";
            this.btnEntar.Type = AntdUI.TTypeMini.Primary;
            this.btnEntar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(145)))));
            this.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtContraseña.Location = new System.Drawing.Point(20, 166);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PlaceholderText = "********";
            this.txtContraseña.Size = new System.Drawing.Size(378, 70);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Text = "input1";
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // lblContraseña
            // 
            this.lblContraseña.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblContraseña.Location = new System.Drawing.Point(64, 118);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(163, 35);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.Click += new System.EventHandler(this.lblContraseña_Click);
            // 
            // lblIniciarSesión
            // 
            this.lblIniciarSesión.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesión.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblIniciarSesión.Location = new System.Drawing.Point(88, 36);
            this.lblIniciarSesión.Name = "lblIniciarSesión";
            this.lblIniciarSesión.Size = new System.Drawing.Size(234, 35);
            this.lblIniciarSesión.TabIndex = 0;
            this.lblIniciarSesión.Text = "Iniciar Sesión";
            this.lblIniciarSesión.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIniciarSesión.Click += new System.EventHandler(this.lblIniciarSesión_Click);
            // 
            // avatarLogo
            // 
            this.avatarLogo.Location = new System.Drawing.Point(0, 0);
            this.avatarLogo.Name = "avatarLogo";
            this.avatarLogo.Size = new System.Drawing.Size(0, 0);
            this.avatarLogo.TabIndex = 3;
            // 
            // avatar1
            // 
            this.avatar1.BackColor = System.Drawing.Color.White;
            this.avatar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatar1.BorderColor = System.Drawing.Color.Transparent;
            this.avatar1.Image = global::IlkaPoint.Properties.Resources._2;
            this.avatar1.Location = new System.Drawing.Point(138, 254);
            this.avatar1.Name = "avatar1";
            this.avatar1.Round = true;
            this.avatar1.Size = new System.Drawing.Size(377, 374);
            this.avatar1.TabIndex = 10;
            this.avatar1.Text = "";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.panelFondo);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panelFondo.ResumeLayout(false);
            this.panelCentro.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.Panel panelFondo;
        private AntdUI.Panel panelLogin;
        private AntdUI.Label lblIniciarSesión;
        private AntdUI.Input txtContraseña;
        private AntdUI.Label lblContraseña;
        private AntdUI.Button btnEntar;
        private AntdUI.Avatar avatarLogo;
        private AntdUI.Label lblBienvenido;
        private AntdUI.In.Panel panelCentro;
        private AntdUI.Avatar avatarCandado;
        private AntdUI.Avatar avatar1;
    }
}