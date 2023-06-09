﻿using CadastrandoProjetos.BLL;
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

namespace CadastrandoProjetos.APPv1
{
    public partial class ListarProjetos : Form
    {
        public ListarProjetos()
        {
            InitializeComponent();
        }

        private void ListarProjetos_Activated(object sender, EventArgs e)
        {

        }

        private void ListarProjetos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaDeInicio telaDeInicio = new TelaDeInicio();
            telaDeInicio.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Projeto> projetos = ProjectRepository.GetAll();
            dataGridView1.DataSource = projetos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
