using CefSharp.DevTools.DOM;
using InvestimentosMais;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Xiao_Music_3
{
    internal class UsuarioDAO
    {
        public bool LoginUsuario(string usuario, string senha)
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Table_1 WHERE" +
                " nome = @nome";

            sqlCom.Parameters.AddWithValue("@nome", usuario);

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();
                
                if (dr.HasRows)
                {
                    dr.Read();
                    string hashedSenha = (string)dr["Senha"];
                    dr.Close();

                    // Verificar se a senha fornecida corresponde à senha armazenada no banco de dados
                    if (VerificarSenha(senha, hashedSenha))
                    {
                        return true;
                    }
                    return true;
         
                }
                dr.Close();
                return false;
            }
            catch (Exception err)
            {
                throw new Exception(
                    "Erro na leitura de Dados \n" +
                    err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }
        public List<Usuario> SelectUsuario()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Table_1";

            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute..
                while (dr.Read())
                {
                    Usuario objeto = new Usuario(
                    (int)dr["Id"],
                    (string)dr["Nome"],
                    (string)dr["Senha"]
                    );

                    usuarios.Add(objeto);
                }
                dr.Close();
                return usuarios;//retornar a lista
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return null;
        }

        public void InsertUsuario(Usuario usuario)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Table_1 (nome, senha) VALUES 
           (@nome, @senha)";

            sqlCommand.Parameters.AddWithValue("@nome", usuario.Nome);
            // Hash da senha antes de armazenar no banco de dados
            string hashedSenha = HashSenha(usuario.Senha);
            sqlCommand.Parameters.AddWithValue("@senha", hashedSenha);
            sqlCommand.ExecuteNonQuery();
        }
        public void DeleteUsuario(int id)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM Table_1 WHERE id = @id";
            sqlCommand.Parameters.AddWithValue("@id", id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }



        }
        public void UpdateUsuario(Usuario usuario)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE table_1 SET
            nome = @nome,
            senha = @senha
            WHERE id = @id";

            sqlCommand.Parameters.AddWithValue("@nome", usuario.Nome);
            sqlCommand.Parameters.AddWithValue("@senha", usuario.Senha);
            sqlCommand.Parameters.AddWithValue("@id", usuario.Id);
            sqlCommand.ExecuteNonQuery();

        }
        // Método para verificar se a senha fornecida corresponde à senha armazenada no banco de dados
        private bool VerificarSenha(string senha, string hashedSenha)
        {
            string hashedInputSenha = HashSenha(senha);
            return string.Equals(hashedSenha, hashedInputSenha);
        }

        // Método para gerar o hash SHA-256 de uma senha
        private string HashSenha(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
