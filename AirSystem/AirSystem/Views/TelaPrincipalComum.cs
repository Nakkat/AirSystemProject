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
    public partial class TelaPrincipalComum : Form
    {
        public TelaPrincipalComum()
        {
            InitializeComponent();
        }

        private void TelaPrincipalComum_Load(object sender, EventArgs e)
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

        private void TelaPrincipalComum_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer fechar?", "Confirmação",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
