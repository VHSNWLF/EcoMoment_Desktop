using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoMoment
{
    public partial class FormPaginaInicial : Form
    {
        public FormPaginaInicial()
        {
            InitializeComponent();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl202247", "cl202247", "ENVI2224*"))
                Console.WriteLine("\nConectado\n");
            else
                Console.WriteLine("Erro de Conexão");
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Show();
        }

        private void excluirUsuárioADMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirAtualizarUsuarioAdm fe = new FormExcluirAtualizarUsuarioAdm(2);
            fe.Show();
        }

        private void atualizarDadosADMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirAtualizarUsuarioAdm fa = new FormExcluirAtualizarUsuarioAdm(1);
            fa.Show();
        }

        private void consultarDadosDeUsuáriosADMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaAdm fc = new FormConsultaAdm();
            fc.Show();

        }

        private void excluirUsuárioWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirAtualizarUsuarioWeb fe = new FormExcluirAtualizarUsuarioWeb(2);
            fe.Show();
        }

        private void atualizarUsuárioWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirAtualizarUsuarioWeb fa = new FormExcluirAtualizarUsuarioWeb(1);
            fa.Show();
        }

        private void consultarDadosDeUisuáriosWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarUsuarioWeb fc = new FormConsultarUsuarioWeb();
            fc.Show();
        }
    }
}
