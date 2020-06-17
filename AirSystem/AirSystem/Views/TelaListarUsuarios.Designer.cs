namespace AirSystem.Views
{
    partial class TelaListarUsuarios
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
            System.Windows.Forms.Label nomeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaListarUsuarios));
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label lblNome;
            System.Windows.Forms.Label label9;
            this.dgvListaUsuario = new System.Windows.Forms.DataGridView();
            this.filtroTextbox = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.bntEditar = new System.Windows.Forms.Button();
            this.bntNovoUsuario = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.sobrenomeTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.nascTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.confirmarSenhaTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            nomeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            lblNome = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            resources.ApplyResources(nomeLabel, "nomeLabel");
            nomeLabel.ForeColor = System.Drawing.Color.Black;
            nomeLabel.Name = "nomeLabel";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Name = "label7";
            // 
            // lblNome
            // 
            resources.ApplyResources(lblNome, "lblNome");
            lblNome.ForeColor = System.Drawing.Color.Black;
            lblNome.Name = "lblNome";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Name = "label9";
            // 
            // dgvListaUsuario
            // 
            resources.ApplyResources(this.dgvListaUsuario, "dgvListaUsuario");
            this.dgvListaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuario.Name = "dgvListaUsuario";
            this.dgvListaUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaUsuario_CellClick);
            // 
            // filtroTextbox
            // 
            resources.ApplyResources(this.filtroTextbox, "filtroTextbox");
            this.filtroTextbox.ForeColor = System.Drawing.Color.Black;
            this.filtroTextbox.Name = "filtroTextbox";
            this.filtroTextbox.TextChanged += new System.EventHandler(this.filtroTextbox_TextChanged_1);
            // 
            // btnDeletar
            // 
            resources.ApplyResources(this.btnDeletar, "btnDeletar");
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnVoltar
            // 
            resources.ApplyResources(this.btnVoltar, "btnVoltar");
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // bntEditar
            // 
            resources.ApplyResources(this.bntEditar, "bntEditar");
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.UseVisualStyleBackColor = true;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // bntNovoUsuario
            // 
            resources.ApplyResources(this.bntNovoUsuario, "bntNovoUsuario");
            this.bntNovoUsuario.Name = "bntNovoUsuario";
            this.bntNovoUsuario.UseVisualStyleBackColor = true;
            this.bntNovoUsuario.Click += new System.EventHandler(this.bntNovoUsuario_Click);
            // 
            // nomeTextBox
            // 
            resources.ApplyResources(this.nomeTextBox, "nomeTextBox");
            this.nomeTextBox.ForeColor = System.Drawing.Color.Black;
            this.nomeTextBox.Name = "nomeTextBox";
            // 
            // sobrenomeTextBox
            // 
            resources.ApplyResources(this.sobrenomeTextBox, "sobrenomeTextBox");
            this.sobrenomeTextBox.ForeColor = System.Drawing.Color.Black;
            this.sobrenomeTextBox.Name = "sobrenomeTextBox";
            // 
            // enderecoTextBox
            // 
            resources.ApplyResources(this.enderecoTextBox, "enderecoTextBox");
            this.enderecoTextBox.ForeColor = System.Drawing.Color.Black;
            this.enderecoTextBox.Name = "enderecoTextBox";
            // 
            // numTextBox
            // 
            resources.ApplyResources(this.numTextBox, "numTextBox");
            this.numTextBox.ForeColor = System.Drawing.Color.Black;
            this.numTextBox.Name = "numTextBox";
            // 
            // nascTextBox
            // 
            resources.ApplyResources(this.nascTextBox, "nascTextBox");
            this.nascTextBox.ForeColor = System.Drawing.Color.Black;
            this.nascTextBox.Name = "nascTextBox";
            // 
            // UsuarioTextBox
            // 
            resources.ApplyResources(this.UsuarioTextBox, "UsuarioTextBox");
            this.UsuarioTextBox.ForeColor = System.Drawing.Color.Black;
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            // 
            // senhaTextBox
            // 
            resources.ApplyResources(this.senhaTextBox, "senhaTextBox");
            this.senhaTextBox.ForeColor = System.Drawing.Color.Black;
            this.senhaTextBox.Name = "senhaTextBox";
            // 
            // confirmarSenhaTextBox
            // 
            resources.ApplyResources(this.confirmarSenhaTextBox, "confirmarSenhaTextBox");
            this.confirmarSenhaTextBox.ForeColor = System.Drawing.Color.Black;
            this.confirmarSenhaTextBox.Name = "confirmarSenhaTextBox";
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnDeletarFt_Click);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblContador
            // 
            resources.ApplyResources(this.lblContador, "lblContador");
            this.lblContador.Name = "lblContador";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // TelaListarUsuarios
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.confirmarSenhaTextBox);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.nascTextBox);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.sobrenomeTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(label9);
            this.Controls.Add(lblNome);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.bntNovoUsuario);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.filtroTextbox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.dgvListaUsuario);
            this.Name = "TelaListarUsuarios";
            this.Load += new System.EventHandler(this.TelaListarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaUsuario;
        private System.Windows.Forms.TextBox filtroTextbox;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button bntEditar;
        private System.Windows.Forms.Button bntNovoUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox sobrenomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.TextBox nascTextBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox confirmarSenhaTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblContador;
    }
}