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
            this.Hide();
            fc.ShowDialog();
            this.Close();
            txtEmailEntrar.Text = "";
            txtSenhaEntrar.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmailEntrar.Text != "" && txtSenhaEntrar.Text != "")
            {
                if(txtEmailEntrar.Text == "ADM" && txtSenhaEntrar.Text == "adm")
                {
                    DialogResult result = MessageBox.Show("Bem vindo, ADM","ADM", MessageBoxButtons.OK);
                    if(result == DialogResult.OK)
                    {
                        DialogResult = DialogResult.Yes;
                        FormPaginaInicial fp = new FormPaginaInicial(2);
                        this.Hide();
                        fp.ShowDialog();
                        this.Close();
                    }
                    
                }
                else if (DAO_Conexao.VeriLogin(txtEmailEntrar.Text, txtSenhaEntrar.Text) == 1)
                {
                    MessageBox.Show("Login realizado com sucesso!", "Moderador");
                    DialogResult = DialogResult.OK;
                    FormPaginaInicial fp = new FormPaginaInicial(1);
                    this.Hide();
                    fp.ShowDialog();
                    this.Close();
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
    }
}
