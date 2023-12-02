using CefSharp.DevTools.DOM;
using InvestimentosMais;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Xiao_Music_3
{
    internal class UsuarioDAO2
    {
        public bool LoginUsuario2(string usuario2, string sobrenome, string cpf)
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Table_2 WHERE" +
                " nome = @nome AND sobrenome = @sobrenome AND cpf = @cpf ";

            sqlCom.Parameters.AddWithValue("@nome", usuario2);
            sqlCom.Parameters.AddWithValue("@sobrenome", sobrenome);
            sqlCom.Parameters.AddWithValue("@cpf", cpf);

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Close();
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
        public List<Usuario2> SelectUsuario2()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Table_2";

            List<Usuario2> usuarios2 = new List<Usuario2>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute..
                while (dr.Read())
                {
                    Usuario2 objeto = new Usuario2(
                    (int)dr["Id"],
                    (string)dr["Nome"],
                    (string)dr["Sobrenome"],
                    (string)dr["Cpf"]
                    );

                    usuarios2.Add(objeto);
                }
                dr.Close();
                return usuarios2;//retornar a lista
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

        public void InsertUsuario2(Usuario2 usuario2)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Table_2 VALUES 
            (@nome, @sobrenome, @cpf)"
            ;

            sqlCommand.Parameters.AddWithValue("@nome", usuario2.Nome);
            sqlCommand.Parameters.AddWithValue("@sobrenome", usuario2.Sobrenome);
            sqlCommand.Parameters.AddWithValue("@cpf", usuario2.Cpf);
            sqlCommand.ExecuteNonQuery();
        }
        public void DeleteUsuario2(int id)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM Table_2 WHERE id = @id";
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
        public void UpdateUsuario2(Usuario2 usuario2)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE table_2 SET
            nome = @nome,
            sobrenome = @sobrenome,
            cpf = @cpf
            WHERE id = @id";

            sqlCommand.Parameters.AddWithValue("@nome", usuario2.Nome);
            sqlCommand.Parameters.AddWithValue("@sobrenome", usuario2.Sobrenome);
            sqlCommand.Parameters.AddWithValue("@cpf", usuario2.Cpf);
            sqlCommand.Parameters.AddWithValue("@id", usuario2.Id);
            sqlCommand.ExecuteNonQuery();

        }
    }
}
