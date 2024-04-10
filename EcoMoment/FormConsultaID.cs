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
    public partial class FormConsultaID : Form
    {
        public FormConsultaID()
        {
            InitializeComponent();
            UsuarioWeb usuarioWeb = new UsuarioWeb();
            MySqlDataReader r = usuarioWeb.consultarTodosUsuariosWeb();
            while (r.Read())
            {
                comboBox1.Items.Add(r["idUsuarioWeb"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioWeb uWeb = new UsuarioWeb();
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um ID");
            }
            else
            {
                try
                {
                    dataGridView1.Rows.Clear();
                    MySqlDataReader reader = uWeb.consultarUsuarioWeb(int.Parse(comboBox1.SelectedItem.ToString()));
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader["idUsuarioWeb"].ToString(), reader["NomeWeb"].ToString(), reader["EmailWeb"].ToString(), reader["SenhaWeb"].ToString(), reader["qtdeSeguidores"].ToString(), reader["qtdeSeguindo"].ToString(), reader["qtdeCurtidas"].ToString(), reader["qtdePostagens"].ToString(), reader["Reputacao"].ToString(), reader["Biografia"].ToString());
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
