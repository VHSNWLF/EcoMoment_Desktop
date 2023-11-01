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
    public partial class FormConsultaTodosAdm : Form
    {
        public FormConsultaTodosAdm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioAdm uAdm = new UsuarioAdm();
            try
            {
                dataGridView1.Rows.Clear();
                MySqlDataReader reader = uAdm.consultarTodosUsuariosAdm();
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
