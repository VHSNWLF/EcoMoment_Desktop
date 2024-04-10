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
    public partial class FormConsultaTodos : Form
    {
        public FormConsultaTodos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioWeb uWeb = new UsuarioWeb();
            try
            {
                dataGridView1.Rows.Clear();
                MySqlDataReader reader = uWeb.consultarTodosUsuariosWeb();
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
