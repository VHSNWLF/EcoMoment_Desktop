using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoMoment
{
    internal class UsuarioAdm
    {
        private string nome;
        private string email;
        private string senha;

        public UsuarioAdm() { }

        public UsuarioAdm(string nome, string email, string senha)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        public bool cadastrarUsuarioAdm()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into EcoMomentBD_UsuarioAdm (NomeAdm, EmailAdm, SenhaAdm) values ('" + nome + "', '" + email + "', '" + senha + "')", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }

        public MySqlDataReader consultarUsuarioAdmId(int id)
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select * from EcoMomentBD_UsuarioAdm where idUsuarioAdm = " + id, DAO_Conexao.con);
                resultado = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("-----------ERRO--------------");
            }
            return resultado;
        }

        public MySqlDataReader consultarTodosUsuariosAdm()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select * from EcoMomentBD_UsuarioAdm", DAO_Conexao.con);
                resultado = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("-----------ERRO--------------");
            }
            return resultado;
        }

        public bool excluirUsuarioAdm(int id)
        {
            bool result = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("delete from EcoMomentBD_UsuarioAdm where idUsuarioAdm = " + id, DAO_Conexao.con);
                sql.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return result;
        }

        public bool atualizarUsuarioAdm(int id, string nome, string email, string senha)
        {
            bool result = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("update EcoMomentBD_UsuarioAdm set NomeAdm = '" + nome + "', EmailAdm =  '" + email + "', SenhaAdm = '" + senha + "' where idUsuarioAdm = " + id + "", DAO_Conexao.con);
                sql.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return result;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
