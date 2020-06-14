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
            this.btnGerenciarRelatorios = new System.Windows.Forms.Button();
            this.btnListarAvioes = new System.Windows.Forms.Button();
            this.btnGerenciarAviao = new System.Windows.Forms.Button();
            this.btnGerenciarCompanhia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerenciarRelatorios
            // 
            this.btnGerenciarRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGerenciarRelatorios.Location = new System.Drawing.Point(423, 259);
            this.btnGerenciarRelatorios.Name = "btnGerenciarRelatorios";
            this.btnGerenciarRelatorios.Size = new System.Drawing.Size(172, 142);
            this.btnGerenciarRelatorios.TabIndex = 9;
            this.btnGerenciarRelatorios.Text = "Gerenciar relatórios";
            this.btnGerenciarRelatorios.UseVisualStyleBackColor = true;
            // 
            // btnListarAvioes
            // 
            this.btnListarAvioes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnListarAvioes.Location = new System.Drawing.Point(189, 68);
            this.btnListarAvioes.Name = "btnListarAvioes";
            this.btnListarAvioes.Size = new System.Drawing.Size(172, 142);
            this.btnListarAvioes.TabIndex = 6;
            this.btnListarAvioes.Text = "Listar aviões";
            this.btnListarAvioes.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarAviao
            // 
            this.btnGerenciarAviao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGerenciarAviao.Location = new System.Drawing.Point(423, 68);
            this.btnGerenciarAviao.Name = "btnGerenciarAviao";
            this.btnGerenciarAviao.Size = new System.Drawing.Size(172, 142);
            this.btnGerenciarAviao.TabIndex = 7;
            this.btnGerenciarAviao.Text = "Gerenciar avião";
            this.btnGerenciarAviao.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarCompanhia
            // 
            this.btnGerenciarCompanhia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGerenciarCompanhia.Location = new System.Drawing.Point(189, 259);
            this.btnGerenciarCompanhia.Name = "btnGerenciarCompanhia";
            this.btnGerenciarCompanhia.Size = new System.Drawing.Size(172, 142);
            this.btnGerenciarCompanhia.TabIndex = 8;
            this.btnGerenciarCompanhia.Text = "Gerenciar companhia";
            this.btnGerenciarCompanhia.UseVisualStyleBackColor = true;
            // 
            // TelaPrincipalComum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGerenciarRelatorios);
            this.Controls.Add(this.btnGerenciarCompanhia);
            this.Controls.Add(this.btnGerenciarAviao);
            this.Controls.Add(this.btnListarAvioes);
            this.Name = "TelaPrincipalComum";
            this.Text = "TelaPrincipalComum";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerenciarRelatorios;
        private System.Windows.Forms.Button btnListarAvioes;
        private System.Windows.Forms.Button btnGerenciarAviao;
        private System.Windows.Forms.Button btnGerenciarCompanhia;
    }
}