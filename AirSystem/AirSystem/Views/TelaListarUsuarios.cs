//using AirSystem.Models;
//using AirSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Views
{
    public partial class TelaListarUsuarios : Form
    {
        public TelaListarUsuarios()
        {
            InitializeComponent();
        }

        UsuarioRepository repository = new UsuarioRepository();
        private static Usuario u = new Usuario();

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            new TelaPrincipalAdm().ShowDialog();
        }

     
        private void carregaLista()
        {
            UsuarioRepository repository = new UsuarioRepository();
            dgvListaUsuario.DataSource = null;
            dgvListaUsuario.DataSource = repository.buscarTodos();
            alterarContador();
        }

        private void alterarContador()
        {
            //2 itens de 10
            lblContador.Text = $"{dgvListaUsuario.RowCount} itens de {repository.buscarTodos().Count}";
        }

        private void filtroTextbox_TextChanged_1(object sender, EventArgs e)
        {
            {
                dgvListaUsuario.DataSource = null;
                // filtra as lista recebida do repositório, verificando se o nome, 
                // email, usuario, contém o que está no campo filtro.
                dgvListaUsuario.DataSource = repository.buscarTodos().FindAll(x =>
                    x.nome.ToUpper().Contains(filtroTextbox.Text.ToUpper()) ||
                       x.sobrenome.ToUpper().Contains(filtroTextbox.Text.ToUpper()) ||
                       x.usuario.ToUpper().Contains(filtroTextbox.Text.ToUpper())
                    );
                alterarContador();
            }
        }

        private void TelaListarUsuarios_Load(object sender, EventArgs e)
        {
            if (Login.idioma == 0)
            {
                Idioma.AjustaCultura(this, "en");

            }
            else
            {
                Idioma.AjustaCultura(this, "pt");

            }
            carregaLista();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //O filtro - somente apresentar os arquivos de imagem
            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";
            //Chamar a janela - entrar somente se confirma a seleção do arquivo
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Carregar a imagem selecionada no picturebox
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnDeletarFt_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void bntNovoUsuario_Click(object sender, EventArgs e)
        {
            new NovoUsuario().ShowDialog();
        }

      

        private void bntEditar_Click(object sender, EventArgs e)
        {
            Usuario NovosDados = new Usuario
            {
                nome = nomeTextBox.Text,
                endereco = enderecoTextBox.Text,
                dataNascimento = Convert.ToDateTime(nascTextBox.Text),
                numero = numTextBox.Text,
                senha = senhaTextBox.Text,
                sobrenome = sobrenomeTextBox.Text,
                usuario = UsuarioTextBox.Text,
                ID = u.ID,
                tipoUsuario = u.tipoUsuario

            };
            repository.editar(NovosDados);
            MessageBox.Show("Dados editados com sucesso", "Sucesso");
            carregaLista();
        }

        private void dgvListaUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //captura a linha que foi selecionada
            DataGridViewRow linha = dgvListaUsuario.Rows[e.RowIndex];
            //esse campo precisa ser convertido pois é numérico
            int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());
            //Joga nas propriedades do objeto usuario
            u = repository.BuscarPorId(codigo);
            nomeTextBox.Text = u.nome;
            enderecoTextBox.Text = u.endereco;
            nascTextBox.Text = Convert.ToString(u.dataNascimento);
            numTextBox.Text = u.numero;
            senhaTextBox.Text = u.senha;
            sobrenomeTextBox.Text = u.sobrenome;
            UsuarioTextBox.Text = u.usuario;
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja excluir este usuário?", "Atenção"
                    , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                repository.Deletar(u.ID);
                carregaLista();
            }
        }
    }
}


