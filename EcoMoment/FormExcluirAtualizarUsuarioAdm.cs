using EcoMoment.Properties;
using MySql.Data.MySqlClient;
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
    public partial class FormExcluirAtualizarUsuarioAdm : Form
    {
        int op = 0;
        public FormExcluirAtualizarUsuarioAdm(int n1)
        {
            InitializeComponent();

            comboBoxExcluirAdm.Focus();

            UsuarioAdm uadm = new UsuarioAdm();
            //Abriu conexao
            MySqlDataReader reader = uadm.consultarTodosUsuariosAdm();
            while (reader.Read())
            {
                comboBoxExcluirAdm.Items.Add(reader["idUsuarioAdm"]);
            }
            DAO_Conexao.con.Close();//Fechou conexao
            //a
            if (n1 == 1)
            {
                this.Text = "Atualizar usuário ADM";
                btnExcluirAdm.Text = "Atualizar";
                this.Text = "Atualizar Usuário ADM";
                pictureBox1.Image = Resources.Atualizar_Adm;
                op = 1;
            }
            else
            {
                btnExcluirAdm.Text = "Excluir";
                txtSenhaExcluirAdm.Visible = false;
                op = 2;
            }
        }

        private void btnExcluirAdm_Click(object sender, EventArgs e)
        {
            if (comboBoxExcluirAdm.Text != "" && txtEmailExcluirAdm.Text != "" && txtNomeExcluirAdm.Text != "" && txtSenhaExcluirAdm.Text != "")
            {
                if (op == 2)
                {
                    try
                    {
                        UsuarioAdm uadm = new UsuarioAdm();
                        if (uadm.excluirUsuarioAdm(int.Parse(comboBoxExcluirAdm.SelectedItem.ToString())))
                        {
                            MessageBox.Show("Usuário excluído com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao excluir Usuário Adm. Tente novamente.");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro de execução.");
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (op == 1)
                {
                    MessageBox.Show("Erro de execução.");

                    try
                    {
                        UsuarioAdm uadm = new UsuarioAdm();
                        if (uadm.atualizarUsuarioAdm(int.Parse(comboBoxExcluirAdm.SelectedItem.ToString()), txtNomeExcluirAdm.Text, txtEmailExcluirAdm.Text, txtSenhaExcluirAdm.Text))
                        {
                            MessageBox.Show("Usuário atualizado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao atualizar Usuário Adm. Tente novamente.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Erro de execução.");
                    }
                }
            }
            else
            {
                try
                {
                    UsuarioAdm uadm = new UsuarioAdm();
                    if (uadm.atualizarUsuarioAdm(int.Parse(comboBoxExcluirAdm.SelectedItem.ToString()), txtNomeExcluirAdm.Text, txtEmailExcluirAdm.Text, txtSenhaExcluirAdm.Text))
                    {
                        MessageBox.Show("Usuário atualizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar Usuário Adm. Tente novamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de execução.");
                }
                MessageBox.Show("Nenhum campo pode estar vazio. Preencha todos e tente novamente.");
            }
        }

        private void comboBoxExcluirAdm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (op == 2)
            {
                txtEmailExcluirAdm.Enabled = false;
                txtNomeExcluirAdm.Enabled = false;
                txtSenhaExcluirAdm.Enabled = false;
            }
            try
            {
                UsuarioAdm uadm = new UsuarioAdm();
                //Abriu conexao
                MySqlDataReader r = uadm.consultarUsuarioAdmId(int.Parse(comboBoxExcluirAdm.SelectedItem.ToString()));
                while (r.Read())
                {
                    txtNomeExcluirAdm.Text = r["NomeAdm"].ToString();
                    txtEmailExcluirAdm.Text = r["EmailAdm"].ToString();
                    txtSenhaExcluirAdm.Text = r["SenhaAdm"].ToString();
                }
                DAO_Conexao.con.Close();//Fechou conexao
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao localizar o Usuário");
            }
        }

        private void txtNomeExcluirAdm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailExcluirAdm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenhaExcluirAdm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
