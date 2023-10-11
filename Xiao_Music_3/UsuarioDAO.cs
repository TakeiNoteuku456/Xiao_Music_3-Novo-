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
    internal class UsuarioDAO
    {
        public List<Usuario> SelectUsuario()
        {
            //Usuario objeto = new Usuario(
            //(int)dr["Id"],
            //(string)dr["nome"],
            //(string)dr["senha"]
            //); 
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Table_1";
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["id"];
                    string name = (string)dr["Nome"];
                    string Senha = (string)dr["Senha"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(name);
                    lv.SubItems.Add(Senha);
                }
                dr.Close();
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
            sqlCommand.CommandText = @"INSERT INTO Table_1 VALUES(@nome,@senha)";

            sqlCommand.Parameters.AddWithValue("@nome", usuario.Nome);
            sqlCommand.Parameters.AddWithValue("@senha", usuario.Senha);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Cadastro com sucesso",
                "AVISO",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
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
    }
}
