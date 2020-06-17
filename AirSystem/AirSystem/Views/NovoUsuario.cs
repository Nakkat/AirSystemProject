using System;
using AirSystem.Utils;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Text;

namespace AirSystem.Views
{
    public partial class NovoUsuario : Form
    {
        public NovoUsuario()
        {
            InitializeComponent();
        }


        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //O filtro - somente apresentar os arquivos de imagem
            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";
            //Chamar a janela - entrar somente se confirma a seleção do arquivo
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Carregar a imagem selecionada no picturebox
                fotoUsuarioPicBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            UsuarioRepository usuariosRepository = new UsuarioRepository();
            Regex senha = new Regex(
                @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$", RegexOptions.IgnorePatternWhitespace);
            if (nomeTextBox.Text.Trim().Length != 0 && nomeTextBox.ForeColor != Color.Black)
            {
                MessageBox.Show("o campo \"Nome\" é obrigatório", "Campo não preenchido");
            }
            else if (sobrenomeTextBox.Text.Trim().Length != 0 && sobrenomeTextBox.ForeColor != Color.Black)
            {
                MessageBox.Show("o campo \"Sobrenome\" é obrigatório", "Campo não preenchido");
            }
            else if (usuarioTextBox.Text.Trim().Length != 0 && usuarioTextBox.ForeColor != Color.Black)
            {
                MessageBox.Show("o campo \"Usuário\" é obrigatório", "Campo não preenchido");
            }
            else if (senhaTextBox.Text.Trim().Length != 0 && senhaTextBox.ForeColor != Color.Black)
            {
                MessageBox.Show("o campo \"Senha\" é obrigatório", "Campo não preenchido");
            }
            else if (confirmarSenhaTextBox.Text.Trim().Length != 0 && confirmarSenhaTextBox.ForeColor != Color.Black)
            {
                MessageBox.Show("o campo \"Confirmar senha\" é obrigatório", "Campo não preenchido");
            }
            else if (!senha.IsMatch(senhaTextBox.Text))
            {
                MessageBox.Show("O Campo \"Senha \" é inválido, A senha deve ter pelo menos 8 caracteres – pelo menos 1 letra maiúscula, 1 letra minúscula e um número.", "Senha inválida");
            }
            else if (confirmarSenhaTextBox.Text != senhaTextBox.Text)
            {
                MessageBox.Show("O Campo \"Senha \" e o Campo \"Confirmar Senha\" Devem ser iguais", "Erro");
            }
            else
            {
                Usuario usuario = new Usuario
                {
                    nome = nomeTextBox.Text,
                    endereco = enderecoTextBox.Text,
                    numero = numTextBox.Text,
                    dataNascimento = dateTimePicker.Value,
                    usuario = usuarioTextBox.Text,
                    sobrenome = sobrenomeTextBox.Text,
                    senha = senhaTextBox.Text,
                    tipoUsuario = checkBox.Checked
                };
                usuariosRepository.adicionar(usuario);
                MessageBox.Show("Usuário Cadastrado com Sucesso", "Sucesso", MessageBoxButtons.OK);
                new Login().ShowDialog();
                this.Close();
            };
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            fotoUsuarioPicBox.Image = null;
        }

        private void NovoUsuario_Load_1(object sender, EventArgs e)
        {
            if (Login.idioma == 0)
            {
                Idioma.AjustaCultura(this, "en");
            }
            else
            {
                Idioma.AjustaCultura(this, "pt");
            }
        }

        private void nomeTextBox_Enter(object sender, EventArgs e)
        {
            Utils.Utils.EnterPlaceHolder(nomeTextBox, "Digite seu nome...");
        }

        private void nomeTextBox_Leave_1(object sender, EventArgs e)
        {
            Utils.Utils.LeavePlaceHolder(nomeTextBox, "Digite seu nome...");
        }

        private void sobrenomeTextBox_Enter(object sender, EventArgs e)
        {
            Utils.Utils.EnterPlaceHolder(sobrenomeTextBox, "Digite seu sobrenome...");
        }

        private void sobrenomeTextBox_Leave_1(object sender, EventArgs e)
        {
            Utils.Utils.LeavePlaceHolder(sobrenomeTextBox, "Digite seu sobrenome...");
        }

        private void enderecoTextBox_Enter_1(object sender, EventArgs e)
        {
            Utils.Utils.EnterPlaceHolder(enderecoTextBox, "Digite seu endereço...");
        }

        private void enderecoTextBox_Leave_1(object sender, EventArgs e)
        {
            Utils.Utils.LeavePlaceHolder(enderecoTextBox, "Digite seu endereço...");
        }

        private void numTextBox_Enter_1(object sender, EventArgs e)
        {
            Utils.Utils.EnterPlaceHolder(numTextBox, "Nº");
        }

        private void numTextBox_Leave_1(object sender, EventArgs e)
        {
            Utils.Utils.LeavePlaceHolder(numTextBox, "Nº");
        }

        private void usuarioTextBox_Enter_1(object sender, EventArgs e)
        {
            Utils.Utils.EnterPlaceHolder(usuarioTextBox, "Digite seu usuário...");
        }

        private void usuarioTextBox_Leave_1(object sender, EventArgs e)
        {
            Utils.Utils.LeavePlaceHolder(usuarioTextBox, "Digite seu usuário...");
        }

        private void senhaTextBox_Enter_1(object sender, EventArgs e)
        {
            Utils.Utils.EnterPlaceHolder(senhaTextBox, "Digite sua senha...");
            senhaTextBox.PasswordChar = '*';
        }

        private void senhaTextBox_Leave_1(object sender, EventArgs e)
        {
            Utils.Utils.LeavePlaceHolder(senhaTextBox, "Digite sua senha...");
        }

        private void confirmarSenhaTextBox_Enter_1(object sender, EventArgs e)
        {
            Utils.Utils.EnterPlaceHolder(confirmarSenhaTextBox, "Confirme sua senha...");
            confirmarSenhaTextBox.PasswordChar = '*';
        }

        private void confirmarSenhaTextBox_Leave_1(object sender, EventArgs e)
        {
            Utils.Utils.LeavePlaceHolder(confirmarSenhaTextBox, "Confirme sua senha...");
        }


        //private void Inputs_Enter(object sender, EventArgs e)
        //{
        //    TextBox txt = sender as TextBox;
        //    if (txt != null)
        //    {
        //        txt.BackColor = Color.LightYellow;
        //        string value = txt.Text;
        //        if (value.Substring(0, 7) == "Digite ")
        //        {
        //            txt.Text = "";
        //        }
        //    }
        //}
        //private void Inputs_Leave(object sender, EventArgs e)
        //{
        //    TextBox txt = sender as TextBox;
        //    if (txt != null)
        //    {
        //        txt.BackColor = Color.White;
        //        if (txt.Text == "")
        //        {
        //            txt.Text = "Digite - " + txt.AccessibleName;
        //        }
        //    }
        //}
    }
}
        
    
   
