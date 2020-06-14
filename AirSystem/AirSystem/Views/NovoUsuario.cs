using System;
using AirSystem.Models;
using AirSystem.Repositories;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AirSystem.Views
{
    public partial class NovoUsuario : Form
    {
        public NovoUsuario()
        {
            InitializeComponent();
        }

        public NovoUsuario(Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
        }

        private void NovoUsuario_Load(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                nomeTextBox.Text = usuario.nome;
                sobrenomeTextBox = usuario.sobrenome;
                enderecoTextBox.Text = usuario.endereco;
                numTextBox.Text = usuario.numero;
                usuarioTextBox.Text = usuario.usuario;
                senhaTextBox = usuario.senha;
                confirmarSenhaTextBox = usuario.confirmarSenha;
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Utils.temCamposVazio(this))
            //8. Armazena os dados do novo usuário nas propriedades da classe e carrega na lista (para alimentar o datagrid)
            //instanciar a classe UsuarioRepository onde estão criados os métodos de acesso aos dados

            {
                UsuarioRepository repository = new UsuarioRepository();
                if (this.usuario == null)
                {
                    //Atribui nas propriedades da classe usuários os valores dos campos do formulário
                    Usuario usuario = new Usuario
                    {
                        nome = nomeTextBox.Text,
                        sobrenome = sobrenomeTextBox.Text,
                        endereco = enderecoTextBox.Text,
                        numero = numTextBox.Text,
                        usuario = usuarioTextBox.Text,
                        senha = senhaTextBox.Text,
                        confirmarSenha = confirmarSenhaTextBox.Text
                };
                    //chama o método adicionar - passando a classe usuario
                    repository.adicionar(usuario);

                    //Todos os campos foram preenchidos - Salva os campos no BD
                    MessageBox.Show("Dados Salvos.",
                                    "Aviso", MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);

                }
                else
                {
                    //alimenta as propriedades da classe com o conteúdo dos campos do formulário

                    this.usuario.nome = nomeTextBox.Text;
                    this.usuario.sobrenome = sobrenomeTextBox.Text;
                    this.usuario.endereco = enderecoTextBox.Text;
                    this.usuario.numero = numTextBox.Text;
                    this.usuario.usuario = usuarioTextBox.Text;
                    this.usuario.senha = "1234";
                    this.usuario.confirmarSenha = "1234";
                }
                this.Close();

            }
            else
            {   //Texto , Título, Botões, Ícone
                MessageBox.Show("Todos os campos são obrigatórios.",
                                "Aviso", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }

           
        }
        bool isValidSenha;
        private void senhaTextBox_TextChanged(object sender, EventArgs e)
        {
            //cria um padrão regex
            string pattern = "[a-z]{3,}[.][a-z]{3,}[@][a-z]{3,}[.][a-z]{2,3}";
            //seta uma propriedade com a verificação do regex
            isValidSenha = Regex.IsMatch(senhaTextBox.Text, pattern);
            //Altera a visualização da label
            lblSenhaValida.Visible = false;

        }
    }
}

