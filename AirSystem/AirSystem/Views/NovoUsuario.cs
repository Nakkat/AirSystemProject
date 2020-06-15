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

        public NovoUsuario(Usuario usuario)
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

        private void NovoUsuario_Load(object sender, EventArgs e)
        {
            if (Login.idioma == 0)
            {
                MessageBox.Show("INGLÊS");
            }
            else
            {
                MessageBox.Show("PORTUGUÊS");
            }
        }

        private bool isPasswordRight(string password)
        {
            if (password.Length >= 8)
            {
                // Tem pelo menos uma letra minúscula
                string pattern = "[a-z]{1,}";
                if (Regex.IsMatch(password, pattern))
                {
                    // Tem ao menos uma letra maiúscula
                    pattern = "[A-Z]{1,}";
                }
                if (Regex.IsMatch(password, pattern))
                {
                    // Tem ao menos um número
                    pattern = "[0-9]{1,}";
                    if (Regex.IsMatch(password, pattern))
                    {
                        return true;
                    }
                }

            }
            return false;
        }

        private void Inputs_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.BackColor = Color.LightYellow;
                if (txt.Text=="")
                {
                    txt.Text = "Digite seu " + txt.AccessibleName;
                }
            }
        }
        private void Inputs_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.BackColor = Color.White;
                string value = txt.Text;
                if (value.Substring(0,10) == "Digite seu")
                {
                    txt.Text = "";
                }
            }
        }
    }
}
        
    
   
