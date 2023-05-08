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
    public partial class TelaDeInicio : Form
    {
        public TelaDeInicio()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TelaDeInicio_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            ListarProjetos l1 = new ListarProjetos();
            l1.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CadastrarProjeto telaDeCadastrar = new CadastrarProjeto();
            telaDeCadastrar.Show();
            Visible = false;
        }
    }
}
