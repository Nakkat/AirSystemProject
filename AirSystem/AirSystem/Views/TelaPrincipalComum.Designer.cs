namespace AirSystem.Views
{
    partial class TelaPrincipalComum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalComum));
            this.btnGerenciarRelatorios = new System.Windows.Forms.Button();
            this.btnListarAvioes = new System.Windows.Forms.Button();
            this.btnGerenciarAviao = new System.Windows.Forms.Button();
            this.btnGerenciarCompanhia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerenciarRelatorios
            // 
            resources.ApplyResources(this.btnGerenciarRelatorios, "btnGerenciarRelatorios");
            this.btnGerenciarRelatorios.Name = "btnGerenciarRelatorios";
            this.btnGerenciarRelatorios.UseVisualStyleBackColor = true;
            // 
            // btnListarAvioes
            // 
            resources.ApplyResources(this.btnListarAvioes, "btnListarAvioes");
            this.btnListarAvioes.Name = "btnListarAvioes";
            this.btnListarAvioes.UseVisualStyleBackColor = true;
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
            // TelaPrincipalComum
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGerenciarRelatorios);
            this.Controls.Add(this.btnGerenciarCompanhia);
            this.Controls.Add(this.btnGerenciarAviao);
            this.Controls.Add(this.btnListarAvioes);
            this.Name = "TelaPrincipalComum";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaPrincipalComum_FormClosing);
            this.Load += new System.EventHandler(this.TelaPrincipalComum_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerenciarRelatorios;
        private System.Windows.Forms.Button btnListarAvioes;
        private System.Windows.Forms.Button btnGerenciarAviao;
        private System.Windows.Forms.Button btnGerenciarCompanhia;
    }
}