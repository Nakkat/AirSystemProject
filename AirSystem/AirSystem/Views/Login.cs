﻿using AirSystem.Views;
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

        private void RelogioDigital_Tick(object sender, EventArgs e)
        {
            this.Relogio.Text = DateTime.Now.ToString("HH:mm:ss:fff");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }

        private void tbxUsuario_Enter(object sender, EventArgs e)
        {
            if (tbxUsuario.Text == "Digite seu nome...")
            {
                tbxUsuario.Text = "";
                tbxUsuario.ForeColor = Color.Black;
            }
        }

        private void tbxUsuario_Leave(object sender, EventArgs e)
        {
            if (tbxUsuario.Text == "")
            {
                tbxUsuario.Text = "Digite seu nome...";
                tbxUsuario.ForeColor = Color.Silver;
            }
        }

        private void tbxSenha_Enter(object sender, EventArgs e)
        {
            if (tbxSenha.Text == "Digite sua senha...")
            {
                tbxSenha.Text = "";
            }
        }

        private void tbxSenha_Leave(object sender, EventArgs e)
        {
            if (tbxSenha.Text == "")
            {
                tbxSenha.Text = "Digite sua senha...";
            }
        }

        public static int idioma;
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            idioma = cmbIdioma.SelectedIndex;
            if (tbxUsuario.Text.Trim().Length == 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Digite o usuário.", "Erro");
            }
            else if (tbxSenha.Text.Trim().Length == 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Digite a senha.", "Erro");
            }
            //else if (NovoUsuario.checkBox.Checked = false)
            //{
            //    MessageBox.Show("Bem Vindo", "Entrada");
            //    new TelaPrincipalAdm().ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Bem Vindo", "Entrada");
            //    new TelaPrincipalComum().ShowDialog();
            //}
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem Vindo", "Cadastra-se!");
            new NovoUsuario().ShowDialog();
        }
    }
}

            
        
    

