using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoMoment
{
    internal class DAO_Conexao
    {
        public static MySqlConnection con;
        public static Boolean getConexao(String local, String banco, String user, String senha)
        {
            Boolean retorno = false;
            try
            {
                con = new MySqlConnection("server=" + local + "; User ID=" + user + ";" + "database=" + banco + "; password=" + senha + "; SslMode = none");
                retorno = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return retorno;
        }

        public static Boolean CadLogin(String usuario, String senha, int tipo)
        {
            bool cad = false;
            try
            {
                con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Login (usuario, senha, tipo) " + "values ('" + usuario + "','" + senha + "'," + tipo + ")", con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return cad;
        }

        public static int VeriLogin(String email, String senha)
        {
            int retorno = 0; //quando não encontra nada
            try
            {
                con.Open();
                MySqlCommand login = new MySqlCommand("select * from EcoMomentBD_UsuarioAdm where EmailAdm = '" + email + "' and SenhaAdm = '" + senha + "'", con);
                MySqlDataReader resultado = login.ExecuteReader();
                if (resultado.Read())
                {
                    retorno = 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return retorno;
        }
    }
}
