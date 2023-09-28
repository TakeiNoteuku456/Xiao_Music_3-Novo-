using InvestimentosMais;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Xiao_Music_3
{
    public partial class Form1 : Form
    {
        //se não conseguir abrir o programa vai no Forms3.Cs, e apaga os caminhos da musica(.wav)
        //Meu programa não está completo ainda preciso arrumar o forms4 e colocar mais musicas, mas o resto está funcionando
        //se não conseguir abrir o programa vai no Forms3.Cs, e apaga os caminhos da musica(.wav)
        //Meu programa não está completo ainda preciso arrumar o forms4 e colocar mais musicas, mas o resto está funcionando
        //se não conseguir abrir o programa vai no Forms3.Cs, e apaga os caminhos da musica(.wav)
        //Meu programa não está completo ainda preciso arrumar o forms4 e colocar mais musicas, mas o resto está funcionando
        private int id;
        Thread fdp;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            UpdateListView();
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Table_1";

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
                    listView1.Items.Add(lv);
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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Xiao Comendo Neve                    " +
                "⣿⣿⣿⣿⣿⣿⡿⡛⠟⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿ " +
                "⣿⣿⣿⣿⣿⠿⠨⡀⠄⠄⡘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿ " +
                "⣿⣿⣿⠿⢁⠼⠊⣱⡃⠄⠈⠹⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿ " +
                "⣿⡿⠛⡧⠁⡴⣦⣔⣶⣄⢠⠄⠄⠹⣿⣿⣿⣿⣿⣿⣿⣤⠭⠏⠙⢿⣿⣿ " +
                "⡧⠠⠠⢠⣾⣾⣟⠝⠉⠉⠻⡒⡂⠄⠙⠻⣿⣿⣿⣿⣿⡪⠘⠄⠉⡄⢹⣿ " +
                "⠃⠁⢐⣷⠉⠿⠐⠑⠠⠠⠄⣈⣿⣄⣱⣠⢻⣿⣿⣿⣿⣯⠷⠈⠉⢀⣾⣿ " +
                "⣴⠤⣬⣭⣴⠂⠇⡔⠚⠍⠄⠄⠁⠘⢿⣷⢈⣿⣿⣿⣿⡧⠂⣠⠄⠸⡜⡿ " +
                "⣇⠄⡙⣿⣷⣭⣷⠃⣠⠄⠄⡄⠄⠄⠄⢻⣿⣿⣿⣿⣿⣧⣁⣿⡄⠼⡿⣦ " +
                "⣷⣥⣴⣿⣿⣿⣿⠷⠲⠄⢠⠄⡆⠄⠄⠄⡨⢿⣿⣿⣿⣿⣿⣎⠐⠄⠈⣙ " +
                "⣿⣿⣿⣿⣿⢟⠕⠁⠈⢠⢃⢸⣿⣿⣶⡘⠑⠄⠸⣿⣿⣿⣿⣿⣦⡀⡉⢿ " +
                "⣿⣿⣿⡿⠋⠄⠄⢀⠄⠐⢩⣿⣿⣿⣿⣦⡀⠄⠄⠉⠿⣿⣿⣿⣿⣿⣷⣨ ",
                "Amém",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String name = textnome.Text;
            String senha = textsenha.Text;
            if (name == "" && senha == "")
            {
                this.Close();
                fdp = new Thread(novoForm);
                fdp.SetApartmentState(ApartmentState.STA);
                fdp.Start();
            }
            else
            {

                String message = "Nome: " + name +
                                "\nSenha: " + senha;
                MessageBox.Show(message, "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                    );
            }
        }
        private void novoForm()
        {
            Application.Run(new Form2());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Table_1 VALUES(@nome,@senha)";

            sqlCommand.Parameters.AddWithValue("@nome", textnome.Text);
            sqlCommand.Parameters.AddWithValue("@senha", textsenha.Text);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Cadastro com sucesso",
                "AVISO",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            textnome.Clear();
            textsenha.Clear();
            UpdateListView();
        }
        private void ListView1_LR_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            id = int.Parse(listView1.Items[index].SubItems[0].Text);
            textnome.Text = listView1.Items[index].SubItems[1].Text;
            textsenha.Text = listView1.Items[index].SubItems[2].Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string USER_LR = textnome.Text, SENHA = textsenha.Text;


            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE table_1 SET
            nome = @nome,
            senha = @senha
            WHERE id = @id";

            sqlCommand.Parameters.AddWithValue("@nome", textnome.Text);
            sqlCommand.Parameters.AddWithValue("@senha", textsenha.Text);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show(
             "Login alterado com sucesso !",
             "AVISO",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information
             );

            textnome.Clear();
            textsenha.Clear();

            UpdateListView();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //Código para excluir
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
            textnome.Clear();
            textsenha.Clear();

            UpdateListView();
        }
    }
}
