using CadastrandoProjetos.BLL;
using CadastrandoProjetos.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Projeto projeto = new Projeto();
            projeto.Nome = textBox1.Text;
            projeto.Status = comboBox1.SelectedItem.ToString();
            projeto.Resumo = richTextBox1.Text;
            projeto.Gerente = textBox2.Text;
            projeto.DataInicio = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToShortDateString());
            projeto.DataFinal = DateTime.Parse(monthCalendar2.SelectionRange.Start.ToShortDateString());
            ProjectRepository.Add(projeto);
            MessageBox.Show("Projeto Adicionado");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
