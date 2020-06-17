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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Relogio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
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
            resources.ApplyResources(this.Relogio, "Relogio");
            this.Relogio.Name = "Relogio";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // tbxUsuario
            // 
            resources.ApplyResources(this.tbxUsuario, "tbxUsuario");
            this.tbxUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.tbxUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Enter += new System.EventHandler(this.tbxUsuario_Enter);
            this.tbxUsuario.Leave += new System.EventHandler(this.tbxUsuario_Leave);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tbxSenha
            // 
            resources.ApplyResources(this.tbxSenha, "tbxSenha");
            this.tbxSenha.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Enter += new System.EventHandler(this.tbxSenha_Enter);
            this.tbxSenha.Leave += new System.EventHandler(this.tbxSenha_Leave);
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Items.AddRange(new object[] {
            resources.GetString("cmbIdioma.Items"),
            resources.GetString("cmbIdioma.Items1")});
            resources.ApplyResources(this.cmbIdioma, "cmbIdioma");
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.SelectedIndexChanged += new System.EventHandler(this.cmbIdioma_SelectedIndexChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // btnEntrar
            // 
            resources.ApplyResources(this.btnEntrar, "btnEntrar");
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSair
            // 
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnNovoUsuario
            // 
            resources.ApplyResources(this.btnNovoUsuario, "btnNovoUsuario");
            this.btnNovoUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // RelogioDigital
            // 
            this.RelogioDigital.Enabled = true;
            this.RelogioDigital.Tick += new System.EventHandler(this.RelogioDigital_Tick);
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.Image = global::AirSystem.Properties.Resources.logotipo_airsystem;
            resources.ApplyResources(this.loginPictureBox, "loginPictureBox");
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.TabStop = false;
            // 
            // userPictureBox
            // 
            this.userPictureBox.Image = global::AirSystem.Properties.Resources.download;
            resources.ApplyResources(this.userPictureBox, "userPictureBox");
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.TabStop = false;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNovoUsuario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loginPictureBox);
            this.Controls.Add(this.Relogio);
            this.Controls.Add(this.userPictureBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
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
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.Timer RelogioDigital;
        private System.Windows.Forms.PictureBox userPictureBox;
    }
}

