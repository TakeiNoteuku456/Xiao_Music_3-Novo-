using CefSharp.DevTools.Database;
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
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Net.Mail;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Xiao_Music_3
{
    public partial class Form1 : Form
    {
        private readonly string DataBase = "Xiao_Music";
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
                "Xiao Comendo Neve            " +
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
            try
            {
                UsuarioDAO user = new UsuarioDAO();

                // Criptografar a senha antes de verificar o login
                string hashedSenha = Usuario.CriptografarSenha(senha);

                if (user.LoginUsuario(name, hashedSenha))
                {
                    Form0 Form0 = new Form0();
                    Form0.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nome de usuário ou senha incorretos!",
                        "Erro de Login",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar objeto da Classe Usuario
                Usuario usuario = new Usuario(
                    textnome.Text,
                    textsenha.Text
                );

                // Chamando o método de inserção
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string USER_LR = textnome.Text, SENHA = textsenha.Text;
            try
            {
                Usuario usuario = new Usuario(
                        id,
                        textnome.Text,
                        textsenha.Text);
                //chamando o metodo de exclusão
                UsuarioDAO nomeDoObj = new UsuarioDAO();
                nomeDoObj.UpdateUsuario(usuario);
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
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string USER_LR = textnome.Text, SENHA = textsenha.Text;

            try
            {
                //cria um objeto da classe e o instancia com os valores provenientes
                //dos campos de texto
                Usuario usuario = new Usuario(
                            textnome.Text,
                            textsenha.Text);
                    //chamando o metodo de exclusão
                    UsuarioDAO nomeDoObj = new UsuarioDAO();
                    nomeDoObj.DeleteUsuario(id);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            textnome.Clear();
            textsenha.Clear();

            UpdateListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form0 Form0 = new Form0();
            Form0.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            // Cria uma instância do SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Define as propriedades do SaveFileDialog
            saveFileDialog.Filter = "Arquivos PDF (*.pdf)|*.pdf|Todos os arquivos (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            // Exibe o diálogo e verifica se o usuário pressionou OK
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                /// Obtém o caminho escolhido pelo usuário
                string filePath = saveFileDialog.FileName;

                // Conexão com o banco de dados SQL Server
                string stringConnection = @"Data Source="
                         + Environment.MachineName +
                         @"\SQLEXPRESS;Initial Catalog=" +
                         DataBase + ";Integrated Security=true";
                SqlConnection connection = new SqlConnection(stringConnection);
                connection.Open();

                // Consulta SQL para recuperar as informações
                string query = "SELECT nome, senha FROM Table_1";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Cria um novo documento PDF
                Document document = new Document();

                try
                { // Cria um PdfWriter usando o caminho escolhido pelo usuário
                    PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                    // Abre o documento antes de adicionar elementos
                    document.Open();

                    // Cria uma nova tabela e adiciona as informações recuperadas
                    PdfPTable table = new PdfPTable(2);
                    table.AddCell("nome");
                    table.AddCell("senha");

                    while (reader.Read())
                    {
                        table.AddCell(reader["nome"].ToString());
                        table.AddCell(reader["senha"].ToString());
                    }

                    // Adiciona a tabela ao documento
                    document.Add(table);

                    MessageBox.Show("Relatório gerado com sucesso", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    // Fecha o documento e a conexão com o banco de dados
                    document.Close();
                    connection.Close();
                }
            }
        }
    }
}
