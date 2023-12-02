using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xiao_Music_3
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nome = maskedTextBox1.Text;
            String sobrenome = textBox2.Text;
            String cpf = textBox3.Text;
            //Criar objeto da classe UsuarioDAO
            UsuarioDAO2 user2 = new UsuarioDAO2();
            //chamar o metodo que verifica o login
            //o usuário e senha existem na tabela
            if (user2.LoginUsuario2(nome, sobrenome, cpf))
            {
                Form3 Form3 = new Form3();
                Form3.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            FormLP FormLP = new FormLP();
            FormLP.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
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
    }
}
