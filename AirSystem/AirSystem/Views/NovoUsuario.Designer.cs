namespace AirSystem.Views
{
    partial class NovoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoUsuario));
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label lblSenhaValida;
            System.Windows.Forms.Label lblSenhaValida2;
            System.Windows.Forms.Label label6;
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.sobrenomeTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.confirmarSenhaTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.fotoUsuarioPicBox = new System.Windows.Forms.PictureBox();
            nomeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblSenhaValida = new System.Windows.Forms.Label();
            lblSenhaValida2 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUsuarioPicBox)).BeginInit();
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
            // lblSenhaValida
            // 
            resources.ApplyResources(lblSenhaValida, "lblSenhaValida");
            lblSenhaValida.ForeColor = System.Drawing.Color.Black;
            lblSenhaValida.Name = "lblSenhaValida";
            // 
            // lblSenhaValida2
            // 
            resources.ApplyResources(lblSenhaValida2, "lblSenhaValida2");
            lblSenhaValida2.ForeColor = System.Drawing.Color.Black;
            lblSenhaValida2.Name = "lblSenhaValida2";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Name = "label6";
            // 
            // nomeTextBox
            // 
            resources.ApplyResources(this.nomeTextBox, "nomeTextBox");
            this.nomeTextBox.ForeColor = System.Drawing.Color.Silver;
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Enter += new System.EventHandler(this.nomeTextBox_Enter);
            this.nomeTextBox.Leave += new System.EventHandler(this.nomeTextBox_Leave_1);
            // 
            // sobrenomeTextBox
            // 
            resources.ApplyResources(this.sobrenomeTextBox, "sobrenomeTextBox");
            this.sobrenomeTextBox.ForeColor = System.Drawing.Color.Silver;
            this.sobrenomeTextBox.Name = "sobrenomeTextBox";
            this.sobrenomeTextBox.Enter += new System.EventHandler(this.sobrenomeTextBox_Enter);
            this.sobrenomeTextBox.Leave += new System.EventHandler(this.sobrenomeTextBox_Leave_1);
            // 
            // enderecoTextBox
            // 
            resources.ApplyResources(this.enderecoTextBox, "enderecoTextBox");
            this.enderecoTextBox.ForeColor = System.Drawing.Color.Silver;
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Enter += new System.EventHandler(this.enderecoTextBox_Enter_1);
            this.enderecoTextBox.Leave += new System.EventHandler(this.enderecoTextBox_Leave_1);
            // 
            // numTextBox
            // 
            resources.ApplyResources(this.numTextBox, "numTextBox");
            this.numTextBox.ForeColor = System.Drawing.Color.Silver;
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Enter += new System.EventHandler(this.numTextBox_Enter_1);
            this.numTextBox.Leave += new System.EventHandler(this.numTextBox_Leave_1);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dateTimePicker, "dateTimePicker");
            this.dateTimePicker.Name = "dateTimePicker";
            // 
            // confirmarSenhaTextBox
            // 
            resources.ApplyResources(this.confirmarSenhaTextBox, "confirmarSenhaTextBox");
            this.confirmarSenhaTextBox.ForeColor = System.Drawing.Color.Silver;
            this.confirmarSenhaTextBox.Name = "confirmarSenhaTextBox";
            this.confirmarSenhaTextBox.Enter += new System.EventHandler(this.confirmarSenhaTextBox_Enter_1);
            this.confirmarSenhaTextBox.Leave += new System.EventHandler(this.confirmarSenhaTextBox_Leave_1);
            // 
            // senhaTextBox
            // 
            resources.ApplyResources(this.senhaTextBox, "senhaTextBox");
            this.senhaTextBox.ForeColor = System.Drawing.Color.Silver;
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Enter += new System.EventHandler(this.senhaTextBox_Enter_1);
            this.senhaTextBox.Leave += new System.EventHandler(this.senhaTextBox_Leave_1);
            // 
            // usuarioTextBox
            // 
            resources.ApplyResources(this.usuarioTextBox, "usuarioTextBox");
            this.usuarioTextBox.ForeColor = System.Drawing.Color.Silver;
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Enter += new System.EventHandler(this.usuarioTextBox_Enter_1);
            this.usuarioTextBox.Leave += new System.EventHandler(this.usuarioTextBox_Leave_1);
            // 
            // btnSelecionar
            // 
            resources.ApplyResources(this.btnSelecionar, "btnSelecionar");
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnDeletar
            // 
            resources.ApplyResources(this.btnDeletar, "btnDeletar");
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // checkBox
            // 
            resources.ApplyResources(this.checkBox, "checkBox");
            this.checkBox.Name = "checkBox";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            resources.ApplyResources(this.btnCadastrar, "btnCadastrar");
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // fotoUsuarioPicBox
            // 
            resources.ApplyResources(this.fotoUsuarioPicBox, "fotoUsuarioPicBox");
            this.fotoUsuarioPicBox.Name = "fotoUsuarioPicBox";
            this.fotoUsuarioPicBox.TabStop = false;
            // 
            // NovoUsuario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(label6);
            this.Controls.Add(this.fotoUsuarioPicBox);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.confirmarSenhaTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.sobrenomeTextBox);
            this.Controls.Add(lblSenhaValida2);
            this.Controls.Add(lblSenhaValida);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(nomeLabel);
            this.Name = "NovoUsuario";
            this.Load += new System.EventHandler(this.NovoUsuario_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.fotoUsuarioPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox sobrenomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox confirmarSenhaTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.PictureBox fotoUsuarioPicBox;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.CheckBox checkBox;
    }
}