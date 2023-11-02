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
    public partial class FormExcluirAtualizarUsuarioWeb : Form
    {
        int op = 0;
        public FormExcluirAtualizarUsuarioWeb(int p)
        {
            InitializeComponent();

            comboBoxExcluirWeb.Focus();

            UsuarioWeb uWeb = new UsuarioWeb();
            //Abriu conexao
            MySqlDataReader reader = uWeb.consultarTodosUsuariosWeb();
            while (reader.Read())
            {
                comboBoxExcluirWeb.Items.Add(reader["idUsuarioWeb"]);
            }
            DAO_Conexao.con.Close();//Fechou conexao

            if (p == 1)
            {
                this.Text = "Atualizar usuário Web";
                btnExcluirWeb.Text = "Atualizar";
                this.Text = "Atualizar Usuário Web";
                pictureBox1.Image = Resources.Atualizar_Web1;
                op = 1;
            }
            else
            {
                btnExcluirWeb.Text = "Excluir";
                txtSenhaExcluirWeb.Visible = false;
                op = 2;
            }
        }

        private void btnExcluirWeb_Click(object sender, EventArgs e)
        {
            if (comboBoxExcluirWeb.Text != "" && txtEmailExcluirWeb.Text != "" && txtNomeExcluirWeb.Text != "" && txtSenhaExcluirWeb.Text != "")
            {
                if (op == 2)
                {
                    try
                    {
                        UsuarioWeb uWeb = new UsuarioWeb();
                        if (uWeb.excluirUsuarioWeb(int.Parse(comboBoxExcluirWeb.SelectedItem.ToString())))
                        {
                            MessageBox.Show("Usuário excluído com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao excluir Usuário Web. Tente novamente.");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro de execução.");
                    }
                }
                else if (op == 1)
                {
                    try
                    {
                        UsuarioWeb uWeb = new UsuarioWeb();
                        if (uWeb.atualizarUsuarioWeb(int.Parse(comboBoxExcluirWeb.SelectedItem.ToString()), txtNomeExcluirWeb.Text, txtEmailExcluirWeb.Text, txtSenhaExcluirWeb.Text))
                        {
                            MessageBox.Show("Usuário atualizado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao atualizar Usuário Web. Tente novamente.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro de execução.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio. Preencha todos e tente novamente.");
            }
        }

        private void comboBoxExcluirWeb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (op == 2)
            {
                txtEmailExcluirWeb.Enabled = false;
                txtNomeExcluirWeb.Enabled = false;
                txtSenhaExcluirWeb.Enabled = false;
            }
            try
            {
                UsuarioWeb uWeb = new UsuarioWeb();
                //Abriu conexao
                MySqlDataReader r = uWeb.consultarUsuarioWeb(int.Parse(comboBoxExcluirWeb.SelectedItem.ToString()));
                while (r.Read())
                {
                    txtNomeExcluirWeb.Text = r["NomeWeb"].ToString();
                    txtEmailExcluirWeb.Text = r["EmailWeb"].ToString();
                    txtSenhaExcluirWeb.Text = r["SenhaWeb"].ToString();
                }
                DAO_Conexao.con.Close();//Fechou conexao
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao localizar o Usuário");
            }
        }
    }
}
