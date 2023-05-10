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
    public partial class Editar_projeto : Form
    {
        public Editar_projeto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Projeto p2 = new Projeto();
            p2 = ProjectRepository.GetByNome(textBox3.Text);
            p2.Nome = textBox1.Text;
            p2.Gerente = textBox2.Text;
            p2.Status = comboBox1.SelectedItem.ToString();
            p2.Resumo = richTextBox1.Text;
            p2.DataFinal = DateTime.Parse(monthCalendar2.SelectionRange.Start.ToShortTimeString());
            ProjectRepository.Update(p2);
            MessageBox.Show("Projeto Atualizado !");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaDeInicio telaDeInicio = new TelaDeInicio();
            telaDeInicio.Show();
            Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Projeto p1 = new Projeto();
            p1 = ProjectRepository.GetByNome(textBox3.Text);
            textBox1.Text = p1.Nome;
            textBox2.Text = p1.Gerente;
            comboBox1.Text = p1.Status;
            richTextBox1.Text = p1.Resumo;
            monthCalendar1.Text = p1.DataInicio.ToString("yyyy-MM-dd");
            monthCalendar2.Text = p1.DataFinal?.ToString("yyyy-MM-dd");
            button2.Visible = true;
            button3.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
