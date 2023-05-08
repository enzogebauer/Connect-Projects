using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastrandoProjetos.APPv1
{
    public partial class CadastrarProjeto : Form
    {
        public CadastrarProjeto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarProjeto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void s(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaDeInicio telaDeInicio = new TelaDeInicio();
            telaDeInicio.Show();
            Visible = false;
        }
    }
}
