namespace AirSystem.Views
{
    partial class TelaPrincipalAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalAdm));
            this.btnListarUsuarios = new System.Windows.Forms.Button();
            this.bntListarAvioes = new System.Windows.Forms.Button();
            this.btnGerenciarAviao = new System.Windows.Forms.Button();
            this.btnGerenciarCompanhia = new System.Windows.Forms.Button();
            this.btnGerenciarRelatorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarUsuarios
            // 
            resources.ApplyResources(this.btnListarUsuarios, "btnListarUsuarios");
            this.btnListarUsuarios.Name = "btnListarUsuarios";
            this.btnListarUsuarios.UseVisualStyleBackColor = true;
            this.btnListarUsuarios.Click += new System.EventHandler(this.btnListarUsuarios_Click);
            // 
            // bntListarAvioes
            // 
            resources.ApplyResources(this.bntListarAvioes, "bntListarAvioes");
            this.bntListarAvioes.Name = "bntListarAvioes";
            this.bntListarAvioes.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarAviao
            // 
            resources.ApplyResources(this.btnGerenciarAviao, "btnGerenciarAviao");
            this.btnGerenciarAviao.Name = "btnGerenciarAviao";
            this.btnGerenciarAviao.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarCompanhia
            // 
            resources.ApplyResources(this.btnGerenciarCompanhia, "btnGerenciarCompanhia");
            this.btnGerenciarCompanhia.Name = "btnGerenciarCompanhia";
            this.btnGerenciarCompanhia.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarRelatorios
            // 
            resources.ApplyResources(this.btnGerenciarRelatorios, "btnGerenciarRelatorios");
            this.btnGerenciarRelatorios.Name = "btnGerenciarRelatorios";
            this.btnGerenciarRelatorios.UseVisualStyleBackColor = true;
            // 
            // TelaPrincipalAdm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGerenciarRelatorios);
            this.Controls.Add(this.btnGerenciarCompanhia);
            this.Controls.Add(this.btnGerenciarAviao);
            this.Controls.Add(this.bntListarAvioes);
            this.Controls.Add(this.btnListarUsuarios);
            this.Name = "TelaPrincipalAdm";
            this.Load += new System.EventHandler(this.TelaPrincipalAdm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarUsuarios;
        private System.Windows.Forms.Button bntListarAvioes;
        private System.Windows.Forms.Button btnGerenciarAviao;
        private System.Windows.Forms.Button btnGerenciarCompanhia;
        private System.Windows.Forms.Button btnGerenciarRelatorios;
    }
}