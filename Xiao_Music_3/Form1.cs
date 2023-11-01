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
        private int id;
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
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            List<Usuario> usuarios = usuarioDAO.SelectUsuario();
            try
            {
                foreach (Usuario usuario in usuarios)
                {

                    //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                    ListViewItem lv = new ListViewItem(usuario.Id.ToString());
                    lv.SubItems.Add(usuario.Nome);
                    lv.SubItems.Add(usuario.Senha);
                    listView1.Items.Add(lv);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
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
                Form2 Form2 = new Form2();
                Form2.Show();
                this.Hide();
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //Criar objeto da Classe Usuario
                Usuario usuario = new Usuario(
                    textnome.Text,
                    textsenha.Text);
                //chamando o metodo de exclusão
                UsuarioDAO nomeDoObj = new UsuarioDAO();
                nomeDoObj.InsertUsuario(usuario);

                MessageBox.Show("Cadastro com sucesso",
                "AVISO",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

                textnome.Clear();
                textsenha.Clear();
                UpdateListView();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
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
            //UsuarioDAO dAO = new UsuarioDAO();
            //dAO.
            //Insertuser(Id, textBox1.Text, textBox2.Text);
            //textBox1.Clear();
            //textBox2.Clear();
            //UpdateListView();

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
            sqlCommand.Parameters.AddWithValue("@id", id);//A
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
