using System;
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
            
            InitializeComponent();

        }


        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            PaginaInicial2 fl = new PaginaInicial2(1);
            fl.Show();
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
