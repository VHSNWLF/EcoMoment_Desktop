﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoMoment
{
    public partial class FormPaginaInicial : Form
    {
        public FormPaginaInicial()
        {
            Thread thread = new Thread(new ThreadStart(splashScreen));
            thread.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            thread.Abort();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl202247", "cl202247", "ENVI2224*"))
                Console.WriteLine("\nConectado\n");
            else
                Console.WriteLine("Erro de Conexão");
        }

        private void splashScreen()
        {
            Application.Run(new SplashScreen());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void excluirUsuárioADMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormExcluirAtualizarUsuarioAdm fe = new FormExcluirAtualizarUsuarioAdm(2);
            fe.Show();
        }

        private void atualizarUsuarioADMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirAtualizarUsuarioAdm fa = new FormExcluirAtualizarUsuarioAdm(1);
            fa.Show();
        }

        private void consultarDadosDeUsuáriosADMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConsultaAdm fc = new FormConsultaAdm();
            fc.Show();
        }

        private void excluirUsuárioWebToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormExcluirAtualizarUsuarioWeb fe = new FormExcluirAtualizarUsuarioWeb(2);
            fe.Show();
        }

        private void atualizarUsuárioWebToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormExcluirAtualizarUsuarioWeb fa = new FormExcluirAtualizarUsuarioWeb(1);
            fa.Show();
        }

        private void consultarDadosDeUsuáriosWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarUsuarioWeb fc = new FormConsultarUsuarioWeb();
            fc.Show();
        }
    }
}
