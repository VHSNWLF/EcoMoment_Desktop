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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
            txtNomeCadastrar.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtEmailCadastrar.Text != "" && txtNomeCadastrar.Text != "" && txtSenha2Cadastrar.Text != "" && txtSenhaCadastrar.Text != "")
            {
                if (txtSenhaCadastrar.Text.Equals(txtSenha2Cadastrar.Text))
                {
                    try
                    {
                        UsuarioAdm uAdm = new UsuarioAdm(txtNomeCadastrar.Text, txtEmailCadastrar.Text, txtSenha2Cadastrar.Text);
                        if (uAdm.cadastrarUsuarioAdm())
                        {
                            MessageBox.Show("Sucesso ao cadastrar usuário Adm. Este formulário fechará automáticamente em 3 segundos.");
                            System.Threading.Thread.Sleep(3000);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Erro de excução ao cadastrar usuário Adm. Revise seus dados e tente novamente.");
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro de excução ao cadastrar usuário Adm");
                    }
                }
                else
                {
                    MessageBox.Show("Ambas as senhas devem ser iguais.");
                }

            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio. Preencha todos e tente novamente.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            this.Close();
        }
    }
}
