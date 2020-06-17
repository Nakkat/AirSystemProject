using AirSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        UsuarioRepository usuarioRepository = new UsuarioRepository();

        private void RelogioDigital_Tick(object sender, EventArgs e)
        {
            this.Relogio.Text = DateTime.Now.ToString("HH:mm:ss:fff");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }


        public static int idioma = -1;
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = usuarioRepository.login(tbxUsuario.Text, tbxSenha.Text);
            if (tbxUsuario.Text.Trim().Length != 0 && tbxUsuario.ForeColor != Color.Black)// 
            {
                MessageBox.Show("o campo \"Usuario\" é obrigatório", "Campo não preenchido");
            }
            else if (tbxSenha.Text.Trim().Length != 0 && tbxSenha.ForeColor != Color.Black)
            {
                MessageBox.Show("o campo \"Senha\" é obrigatório", "Campo não preenchido");
            }
            else if (usuario != null)
            {
                if (usuario.tipoUsuario == true)
                {
                    new TelaPrincipalAdm().ShowDialog();
                }
                else
                {
                    new TelaPrincipalComum().ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Usuario ou Senha Incorretos", "Usuario não encontrado");
            }
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem Vindo", "Cadastra-se!");
            new NovoUsuario().ShowDialog();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer fechar?", "Confirmação",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer fechar?", "Confirmação",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //para fechar o form principal
                this.Close();
                //para sair da aplicação
                Application.Exit();
            }
        }

        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            idioma = cmbIdioma.SelectedIndex;
            if (idioma == 0)
            {
                Idioma.AjustaCultura(this, "en");
                tbxSenha.PasswordChar = '\0';
                tbxSenha.ForeColor = Color.Silver;
                tbxUsuario.ForeColor = Color.Silver;
            }
            else
            {
                Idioma.AjustaCultura(this, "pt");
                tbxSenha.PasswordChar = '\0';
                tbxSenha.ForeColor = Color.Silver;
                tbxUsuario.ForeColor = Color.Silver;
            }
        }

        private void tbxUsuario_Enter(object sender, EventArgs e)
        {
            Utils.Utils.EnterPlaceHolder(tbxUsuario, "Digite seu usuário...");
        }

        private void tbxUsuario_Leave(object sender, EventArgs e)
        {
            Utils.Utils.LeavePlaceHolder(tbxUsuario, "Digite seu usuário...");
        }

        private void tbxSenha_Enter(object sender, EventArgs e)
        {
            tbxSenha.PasswordChar = '*';
            Utils.Utils.EnterPlaceHolder(tbxSenha, "Digite sua senha...");
        }

        private void tbxSenha_Leave(object sender, EventArgs e)
        {
            Utils.Utils.LeavePlaceHolder(tbxSenha, "Digite sua senha...");
        }
    }
}

            
        
    

