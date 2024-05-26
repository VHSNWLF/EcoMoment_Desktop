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
            IsMdiContainer = true;

        }


        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            PaginaInicial2 fl = new PaginaInicial2(1);
            fl.Show();
        }

        private void excluirUsuárioADMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormExcluirAtualizarUsuarioAdm>().Count() == 0)
            {
            FormExcluirAtualizarUsuarioAdm fe = new FormExcluirAtualizarUsuarioAdm(2);
            fe.MdiParent = this;
            fe.Show();
            }
        }
           
        private void atualizarUsuarioADMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<FormExcluirAtualizarUsuarioAdm>().Count() == 0)
            {
            FormExcluirAtualizarUsuarioAdm fa = new FormExcluirAtualizarUsuarioAdm(1);
            fa.MdiParent = this;
            fa.Show();
            }
            
        }

        private void consultarDadosDeUsuáriosADMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsultaAdm>().Count() == 0)
            {
            FormConsultaAdm fc = new FormConsultaAdm();
            fc.MdiParent = this;
            fc.Show();
            }
            
        }

        private void excluirUsuárioWebToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormExcluirAtualizarUsuarioWeb>().Count() == 0)
            {
            FormExcluirAtualizarUsuarioWeb fe = new FormExcluirAtualizarUsuarioWeb(2);
            fe.MdiParent = this;
            fe.Show();
            }

        }

        private void atualizarUsuárioWebToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormExcluirAtualizarUsuarioWeb>().Count() == 0)
            {
            FormExcluirAtualizarUsuarioWeb fa = new FormExcluirAtualizarUsuarioWeb(1);
            fa.MdiParent = this;
            fa.Show();
            }

        }

        private void consultarDadosDeUsuáriosWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsultarUsuarioWeb>().Count() == 0)
            {
            FormConsultarUsuarioWeb fc = new FormConsultarUsuarioWeb();
            fc.MdiParent = this;
            fc.Show();
            }

        }
    }
}
