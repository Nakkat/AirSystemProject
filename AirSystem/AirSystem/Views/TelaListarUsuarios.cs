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

        private void TelaListarUsuario_Load(object sender, EventArgs e)
        {
            //carregaLista();
        }

        private void dgvListaUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //captura a linha que foi selecionada
            DataGridViewRow linha = dgvListaUsuario.Rows[e.RowIndex];
            //guarda nas variáveis os conteúdos das células
            string nome = linha.Cells[1].Value.ToString();
            string sobrenome = linha.Cells[2].Value.ToString();
            //esse campo precisa ser convertido pois é numérico
            int ID = Convert.ToInt32(linha.Cells[0].Value.ToString());
            //Joga nas propriedades do objeto usuario
            Usuario usuario = new Usuario
            {
                ID = ID,
                nome = nome,
                sobrenome = sobrenome,
            };

            //Chama o formulário de cadastro passando a classe usuario

            new NovoUsuario().ShowDialog();
            //chama o método para carregar o datagrid
            carregaLista();
        }

        private void carregaLista()
        {
            UsuarioRepository repository = new UsuarioRepository();
            dgvListaUsuario.DataSource = null;
            dgvListaUsuario.DataSource = repository.buscarTodos();
            alterarContador();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new TelaPrincipalAdm().ShowDialog();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja excluir este usuário?", "Atenção"
                    , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                //DataGridViewRow linha = dgvListaUsuario.Rows[e.RowIndex];

                //int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());

                //repository.deletar(codigo);

                carregaLista();
            }
        }

            private void filtroTextbox_TextChanged(object sender, EventArgs e)
            {
                dgvListaUsuario.DataSource = null;

            // filtra as lista recebida do repositório, verificando se o nome, 
            // email, usuario, contém o que está no campo filtro.
            //dgvListaUsuario.DataSource = repository.buscarTodos().FindAll(x =>
            //    x.nome.ToUpper().Contains(filtroTextbox.Text.ToUpper()) ||
            //        x.sobrenome.ToUpper().Contains(filtroTextbox.Text.ToUpper()) ||
            //        x.usuario.ToUpper().Contains(filtroTextbox.Text.ToUpper())
            //    );

                alterarContador();

            }
        private void alterarContador()
        {
            //2 itens de 10
            //lblContador.Text = $"{dgvListaUsuario.RowCount} itens de {repository.buscarTodos().Count}";
        }
    }
    }


