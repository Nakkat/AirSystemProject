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
            this.btnListarUsuarios = new System.Windows.Forms.Button();
            this.bntListarAvioes = new System.Windows.Forms.Button();
            this.btnGerenciarAviao = new System.Windows.Forms.Button();
            this.btnGerenciarCompanhia = new System.Windows.Forms.Button();
            this.btnGerenciarRelatorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarUsuarios
            // 
            this.btnListarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnListarUsuarios.Location = new System.Drawing.Point(87, 83);
            this.btnListarUsuarios.Name = "btnListarUsuarios";
            this.btnListarUsuarios.Size = new System.Drawing.Size(172, 142);
            this.btnListarUsuarios.TabIndex = 0;
            this.btnListarUsuarios.Text = "Listar usuários";
            this.btnListarUsuarios.UseVisualStyleBackColor = true;
            this.btnListarUsuarios.Click += new System.EventHandler(this.btnListarUsuarios_Click);
            // 
            // bntListarAvioes
            // 
            this.bntListarAvioes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bntListarAvioes.Location = new System.Drawing.Point(321, 83);
            this.bntListarAvioes.Name = "bntListarAvioes";
            this.bntListarAvioes.Size = new System.Drawing.Size(172, 142);
            this.bntListarAvioes.TabIndex = 1;
            this.bntListarAvioes.Text = "Listar aviões";
            this.bntListarAvioes.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarAviao
            // 
            this.btnGerenciarAviao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGerenciarAviao.Location = new System.Drawing.Point(558, 83);
            this.btnGerenciarAviao.Name = "btnGerenciarAviao";
            this.btnGerenciarAviao.Size = new System.Drawing.Size(172, 142);
            this.btnGerenciarAviao.TabIndex = 2;
            this.btnGerenciarAviao.Text = "Gerenciar avião";
            this.btnGerenciarAviao.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarCompanhia
            // 
            this.btnGerenciarCompanhia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGerenciarCompanhia.Location = new System.Drawing.Point(87, 259);
            this.btnGerenciarCompanhia.Name = "btnGerenciarCompanhia";
            this.btnGerenciarCompanhia.Size = new System.Drawing.Size(172, 142);
            this.btnGerenciarCompanhia.TabIndex = 3;
            this.btnGerenciarCompanhia.Text = "Gerenciar companhia";
            this.btnGerenciarCompanhia.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarRelatorios
            // 
            this.btnGerenciarRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGerenciarRelatorios.Location = new System.Drawing.Point(321, 259);
            this.btnGerenciarRelatorios.Name = "btnGerenciarRelatorios";
            this.btnGerenciarRelatorios.Size = new System.Drawing.Size(172, 142);
            this.btnGerenciarRelatorios.TabIndex = 4;
            this.btnGerenciarRelatorios.Text = "Gerenciar relatórios";
            this.btnGerenciarRelatorios.UseVisualStyleBackColor = true;
            // 
            // TelaPrincipalAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGerenciarRelatorios);
            this.Controls.Add(this.btnGerenciarCompanhia);
            this.Controls.Add(this.btnGerenciarAviao);
            this.Controls.Add(this.bntListarAvioes);
            this.Controls.Add(this.btnListarUsuarios);
            this.Name = "TelaPrincipalAdm";
            this.Text = "Tela Principal - AirSytem";
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