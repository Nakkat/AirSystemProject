namespace AirSystem
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Relogio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.idiomaComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.RelogioDigital = new System.Windows.Forms.Timer(this.components);
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Relogio
            // 
            this.Relogio.AutoSize = true;
            this.Relogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Relogio.Location = new System.Drawing.Point(665, 9);
            this.Relogio.Name = "Relogio";
            this.Relogio.Size = new System.Drawing.Size(90, 25);
            this.Relogio.TabIndex = 2;
            this.Relogio.Text = "08:33:22";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(552, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Usuário";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.tbxUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbxUsuario.Location = new System.Drawing.Point(556, 194);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(150, 20);
            this.tbxUsuario.TabIndex = 11;
            this.tbxUsuario.Text = "Digite seu nome...";
            this.tbxUsuario.Enter += new System.EventHandler(this.tbxUsuario_Enter);
            this.tbxUsuario.Leave += new System.EventHandler(this.tbxUsuario_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(552, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Senha";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxSenha
            // 
            this.tbxSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxSenha.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbxSenha.Location = new System.Drawing.Point(556, 259);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(150, 20);
            this.tbxSenha.TabIndex = 13;
            this.tbxSenha.Text = "Digite sua senha...";
            this.tbxSenha.Enter += new System.EventHandler(this.tbxSenha_Enter);
            this.tbxSenha.Leave += new System.EventHandler(this.tbxSenha_Leave);
            // 
            // idiomaComboBox
            // 
            this.idiomaComboBox.FormattingEnabled = true;
            this.idiomaComboBox.Items.AddRange(new object[] {
            "Português - PT-BR",
            "Inglês - EN-US"});
            this.idiomaComboBox.Location = new System.Drawing.Point(556, 325);
            this.idiomaComboBox.Name = "idiomaComboBox";
            this.idiomaComboBox.Size = new System.Drawing.Size(121, 21);
            this.idiomaComboBox.TabIndex = 14;
            this.idiomaComboBox.Text = "Português - PTBR";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(552, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Idioma";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(556, 390);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(49, 23);
            this.btnEntrar.TabIndex = 17;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(611, 390);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(48, 23);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNovoUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnNovoUsuario.Location = new System.Drawing.Point(677, 390);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(90, 23);
            this.btnNovoUsuario.TabIndex = 19;
            this.btnNovoUsuario.Text = "Novo Usuário";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            // 
            // RelogioDigital
            // 
            this.RelogioDigital.Enabled = true;
            this.RelogioDigital.Tick += new System.EventHandler(this.RelogioDigital_Tick);
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.Image = global::AirSystem.Properties.Resources.logotipo_airsystem;
            this.loginPictureBox.Location = new System.Drawing.Point(409, 37);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(358, 128);
            this.loginPictureBox.TabIndex = 4;
            this.loginPictureBox.TabStop = false;
            // 
            // userPictureBox
            // 
            this.userPictureBox.Image = global::AirSystem.Properties.Resources.download;
            this.userPictureBox.Location = new System.Drawing.Point(121, 124);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(226, 222);
            this.userPictureBox.TabIndex = 0;
            this.userPictureBox.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovoUsuario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idiomaComboBox);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loginPictureBox);
            this.Controls.Add(this.Relogio);
            this.Controls.Add(this.userPictureBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Login";
            this.Text = "Login - AirSystem";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Relogio;
        private System.Windows.Forms.PictureBox loginPictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.ComboBox idiomaComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.Timer RelogioDigital;
        private System.Windows.Forms.PictureBox userPictureBox;
    }
}

