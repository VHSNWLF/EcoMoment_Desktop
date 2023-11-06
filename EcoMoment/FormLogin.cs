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
    public partial class FormLogin : Form
    {
        int op = 0;

        public FormLogin()
        {
            InitializeComponent();

            txtEmailEntrar.Focus();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl202247", "cl202247", "ENVI2224*"))
                Console.WriteLine("\nConectado\n");
            else
                Console.WriteLine("Erro de Conexão");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
                FormCadastro fc = new FormCadastro();
                fc.Show();
                this.Close();
                txtEmailEntrar.Text = "";
                txtSenhaEntrar.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmailEntrar.Text != "" && txtSenhaEntrar.Text != "")
            {
                if (DAO_Conexao.VeriLogin(txtEmailEntrar.Text, txtSenhaEntrar.Text) == 1)
                {
                    MessageBox.Show("Login realizado com sucesso!");
                    op= 1;
                    this.Close();
                    FormPaginaInicial p = new FormPaginaInicial();
                    p.Show();

                }
                else
                {
                    MessageBox.Show("Usuário não encontrado. Tente novamente com um email e/ou senha diferente ou cadastre-se agora mesmo no link abaixo!");
                }
            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio. Preencha todos e tente novamente.");
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (op == 0)
            {
                PaginaInicial2 p = new PaginaInicial2(1);
                p.Show();
            }
            
        }
    }
}
