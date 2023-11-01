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
    public partial class FormConsultaidAdm : Form
    {
        public FormConsultaidAdm()
        {
            InitializeComponent();
            UsuarioAdm uAdm = new UsuarioAdm();
            MySqlDataReader r = uAdm.consultarTodosUsuariosAdm();
            while (r.Read())
            {
                comboBox1.Items.Add(r["idUsuarioAdm"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioAdm uAdm = new UsuarioAdm();
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um ID");
            }
            else
            {
                try
                {
                    dataGridView1.Rows.Clear();
                    MySqlDataReader reader = uAdm.consultarUsuarioAdmId(int.Parse(comboBox1.SelectedItem.ToString()));
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader["idUsuarioAdm"].ToString(), reader["NomeAdm"].ToString(), reader["EmailAdm"].ToString(), reader["SenhaAdm"].ToString());
                    }
                    DAO_Conexao.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar usuário");
                }
            }
        }
    }
}
