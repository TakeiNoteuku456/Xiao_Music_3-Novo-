using CefSharp.DevTools.DOM;
using InvestimentosMais;
using iTextSharp.text.pdf.codec.wmf;
using Microsoft.Win32;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
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
            //Cria uma instância da classe para gerenciar a conexão com o banco de dados.
            Connection conn = new Connection();
            //Cria uma instância da classe para executar comandos SQL no banco de dados.
            SqlCommand sqlCom = new SqlCommand();

            //Isso indica qual conexão será usada para executar o comando SQL.
            sqlCom.Connection = conn.ReturnConnection();
            //Define o texto do comando SQL a ser executado.
            //Neste caso, é uma consulta "SELECT"
            //Recupera todas as colunas da tabela "Table_2" onde os campos "nome, sobrenome e cpf"
            //correspondem aos parâmetros fornecidos.
            sqlCom.CommandText = "SELECT * FROM Table_2 WHERE" +
                " nome = @nome AND sobrenome = @sobrenome AND cpf = @cpf ";

            //Adiciona um parâmetro chamado "@.." ao comando SQL e define seu valor como a variável "usuario2".
            sqlCom.Parameters.AddWithValue("@nome", usuario2);
            sqlCom.Parameters.AddWithValue("@sobrenome", sobrenome);
            sqlCom.Parameters.AddWithValue("@cpf", cpf);

            try
            {
                //Executa o comando SQL e cria um "SqlDataReader" para ler os resultados.
                //O "SqlDataReader" é usado para percorrer as linhas retornadas pela consulta.
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Verifica se o SqlDataReader possui alguma linha retornada pela consulta.
                if (dr.HasRows)
                {
                    dr.Close(); //Fecha o "SqlDataReader" para liberar os recursos associados a ele.
                    return true; //indica que pelo menos uma linha foi encontrada na consulta.

                }
                dr.Close(); //Fecha o "SqlDataReader" para liberar os recursos associados a ele.
                return false; //não há linhas correspondentes.
            }
            catch (Exception err) //Captura exceções que podem ocorrer durante a execução do bloco "try".
            {
                throw new Exception(
                    "Erro na leitura de Dados \n" +
                    err.Message);//Lança uma nova exceção com uma mensagem personalizada.
            }
            finally//é usado para garantir que a conexão com o banco de dados seja sempre fechada.
            {
                conn.CloseConnection();
            }
        }

        //Declaração do método que retorna uma lista de objetos do tipo "Usuario2".
        //Este método é responsável por realizar uma consulta "SELECT" no banco de dados
        //e retornar os resultados como uma lista de objetos "Usuario2".
        public List<Usuario2> SelectUsuario2()
        {
            //Cria uma instância da classe para gerenciar a conexão com o banco de dados.
            Connection conn = new Connection();
            //Cria uma instância da classe para executar comandos SQL no banco de dados.
            SqlCommand sqlCom = new SqlCommand();

            //Isso indica qual conexão será usada para executar o comando SQL.
            sqlCom.Connection = conn.ReturnConnection();
            //Define o texto do comando SQL a ser executado.
            //Neste caso, é uma consulta "SELECT".
            sqlCom.CommandText = "SELECT * FROM Table_2";

            //Cria uma lista vazia para armazenar os objetos Usuario2 que serão recuperados do banco de dados.
            List <Usuario2> usuarios2 = new List<Usuario2>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();//Este objeto permite ler os resultados da consulta linha por linha.

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute..
                while (dr.Read())
                {
                    //Cria uma instância do objeto "Usuario2 para cada linha lida do banco de dados,
                    //utilizando os valores das colunas retornadas na consulta.
                    Usuario2 objeto = new Usuario2(
                    (int)dr["Id"],
                    (string)dr["Nome"],
                    (string)dr["Sobrenome"],
                    (string)dr["Cpf"]
                    );

                    usuarios2.Add(objeto);//Adiciona o objeto "Usuario2" criado à lista de usuários.
                }
                dr.Close();//Fecha o "SqlDataReader" após concluir a leitura dos resultados da consulta.
                return usuarios2;//retornar a lista
            }
            catch (Exception err)//Captura exceções que podem ocorrer durante a execução do bloco "try".
            {
                MessageBox.Show(err.Message);//Lança uma nova exceção com uma mensagem personalizada.
            }
            finally//é usado para garantir que a conexão com o banco de dados seja sempre fechada.
            {
                conn.CloseConnection();
            }
            return null;
        }
        
        
        //Esse método é responsável por inserir um novo usuário na tabela Table_2 do banco de dados
        public void InsertUsuario2//Isso define um método público chamado InsertUsuario2
            (Usuario2 usuario2)//que aceita um objeto do tipo "Usuario2" como parâmetro. 
        {
            //Cria uma instância da classe para gerenciar a conexão com o banco de dados.
            Connection connection = new Connection();
            //Cria uma instância da classe para executar comandos SQL no banco de dados.
            SqlCommand sqlCommand = new SqlCommand();

            //Isso indica qual conexão será usada para executar o comando SQL.
            sqlCommand.Connection = connection.ReturnConnection();

            //Define o texto da instrução SQL que será executada.
            sqlCommand.CommandText = 
            @"INSERT INTO Table_2 VALUES 
            (@nome, @sobrenome, @cpf)";

            //Adiciona um parâmetro chamado @... à instrução SQL e atribui a ele o valor da propriedade ... do objeto usuario2.
            sqlCommand.Parameters.AddWithValue("@nome", usuario2.Nome);
            sqlCommand.Parameters.AddWithValue("@sobrenome", usuario2.Sobrenome);
            sqlCommand.Parameters.AddWithValue("@cpf", usuario2.Cpf);
            sqlCommand.ExecuteNonQuery(); //Irá inserir um novo registro na tabela Table_2 com os valores fornecidos.
        }


        //Declaração de um método público chamado "DeleteUsuario2", que recebe um parâmetro "id" do tipo "int".
        public void DeleteUsuario2(int id)
        {
            //Cria uma instância da classe para gerenciar a conexão com o banco de dados.
            Connection connection = new Connection();
            //Cria uma instância da classe para executar comandos SQL no banco de dados.
            SqlCommand sqlCommand = new SqlCommand();

            //Isso indica qual conexão será usada para executar o comando SQL.
            sqlCommand.Connection = connection.ReturnConnection();

            //Define o comando SQL para deletar registros da tabela "Table_2" onde o "ID" é igual ao parâmetro fornecido
            sqlCommand.CommandText = @"DELETE FROM Table_2 WHERE id = @id";
            //Adiciona um parâmetro ao comando SQL para o valor do ID
            sqlCommand.Parameters.AddWithValue("@id", id);
            try
            {
                //Executa o comando SQL para excluir o registro
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                //Captura exceções e lança uma nova exceção com uma mensagem personalizada
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                //Garante que a conexão é fechada, independentemente de ocorrer uma exceção ou não
                connection.CloseConnection();
            }
        }
        public void UpdateUsuario2//Esta linha declara um método público chamado UpdateUsuario2
            (Usuario2 usuario2)//que aceita um objeto Usuario2 como parâmetro.
        {
            //Cria uma instância da classe para gerenciar a conexão com o banco de dados.
            Connection connection = new Connection();
            //Cria uma instância da classe para executar comandos SQL no banco de dados.
            SqlCommand sqlCommand = new SqlCommand();

            //Isso indica qual conexão será usada para executar o comando SQL.
            sqlCommand.Connection = connection.ReturnConnection();

            //Define o texto do comando SQL a ser executado.
            //Neste caso, é um comando UPDATE que atualiza os campos
            //na tabela "table_2" com base no valor da coluna id.
            sqlCommand.CommandText = @"UPDATE table_2 SET
            nome = @nome,
            sobrenome = @sobrenome,
            cpf = @cpf
            WHERE id = @id";

            //Adiciona um parâmetro chamado @... à instrução SQL e atribui a ele o valor da propriedade ... do objeto usuario2.
            sqlCommand.Parameters.AddWithValue("@nome", usuario2.Nome);
            sqlCommand.Parameters.AddWithValue("@sobrenome", usuario2.Sobrenome);
            sqlCommand.Parameters.AddWithValue("@cpf", usuario2.Cpf);
            sqlCommand.Parameters.AddWithValue("@id", usuario2.Id);
            sqlCommand.ExecuteNonQuery();//Irá inserir um novo registro na tabela Table_2 com os valores fornecidos.

        }//Este método é provavelmente destinado a realizar uma operação de atualização(UPDATE)
         //no banco de dados para um usuário específico.
    }
}
