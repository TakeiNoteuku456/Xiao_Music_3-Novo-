using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Globalization;

namespace Xiao_Music_3
{
    public partial class FormCadastrar2 : Form
    {
        private int id;
        public FormCadastrar2()
        {
            InitializeComponent();
            UpdateListView();
            textBox3.TextChanged += textBox3_TextChanged;
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();
            UsuarioDAO2 usuarioDAO2 = new UsuarioDAO2();
            List<Usuario2> usuarios2 = usuarioDAO2.SelectUsuario2();
            try
            {
                foreach (Usuario2 usuario2 in usuarios2)
                {

                    //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                    ListViewItem lv = new ListViewItem(usuario2.Id.ToString());
                    lv.SubItems.Add(usuario2.Nome);
                    lv.SubItems.Add(usuario2.Sobrenome);
                    lv.SubItems.Add(usuario2.Cpf);
                    listView1.Items.Add(lv);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
        private void FormCadastrar2_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            id = int.Parse(listView1.Items[index].SubItems[0].Text);
            textBox1.Text = listView1.Items[index].SubItems[1].Text;
            textBox2.Text = listView1.Items[index].SubItems[2].Text;
            textBox3.Text = listView1.Items[index].SubItems[3].Text;

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                // Remove qualquer formatação existente
                string cpfSemFormato = textBox3.Text.Replace(".", "").Replace("-", "");

                // Verifica se o CPF tem 11 dígitos
                if (cpfSemFormato.Length == 11)
                {
                    // Formata o CPF com pontos e traço
                    string cpfFormatado = Convert.ToUInt64(cpfSemFormato).ToString(@"000\.000\.000\-00");

                    // Atualiza o texto do TextBox
                    textBox3.Text = cpfFormatado;

                    // Move o cursor para o final do texto
                    textBox3.SelectionStart = textBox3.Text.Length;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {        
            try
            {
                //Criar objeto da Classe Usuario
                Usuario2 usuario2 = new Usuario2(
                    textBox1.Text,
                    textBox2.Text,
                    textBox3.Text
                    );
                //chamando o metodo de exclusão
                UsuarioDAO2 nomeDoObj = new UsuarioDAO2();
                nomeDoObj.InsertUsuario2(usuario2);

                MessageBox.Show("Cadastro com sucesso",
                "AVISO",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                UpdateListView();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String nome = textBox1.Text;
            String sobrenome = textBox2.Text;
            String cpf = textBox3.Text;
            //Criar objeto da classe UsuarioDAO
            UsuarioDAO2 user2 = new UsuarioDAO2();
            //chamar o metodo que verifica o login
            //o usuário e senha existem na tabela
            if (user2.LoginUsuario2(nome, sobrenome, cpf))
            {
                Form3 tela = new Form3();
                tela.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Verifique os dados inseridos!",
                    "errou..errou...",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string USER_LR = textBox1.Text, SOBRENOME = textBox2.Text, CPF = textBox3.Text;

            try
            {
                Usuario2 usuario2 = new Usuario2(
                        id,
                        textBox1.Text,
                        textBox2.Text,
                        textBox3.Text);
                //chamando o metodo de exclusão
                UsuarioDAO2 nomeDoObj = new UsuarioDAO2();
                nomeDoObj.UpdateUsuario2(usuario2);
                MessageBox.Show(
                 "Login alterado com sucesso !",
                 "AVISO",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                 );
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                UpdateListView();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string USER_LR = textBox1.Text, SOBRENOME = textBox2.Text, CPF = textBox3.Text;
           
            try
            {
                Usuario2 usuario2 = new Usuario2(
                        textBox1.Text,
                        textBox2.Text,
                        textBox3.Text);
                //chamando o metodo de exclusão
                UsuarioDAO2 nomeDoObj = new UsuarioDAO2();
                nomeDoObj.DeleteUsuario2(id);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            UpdateListView();
        }
    }
}
