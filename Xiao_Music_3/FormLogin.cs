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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario = textBox1.Text;
            String senha = textBox2.Text;
            //Criar objeto da classe UsuarioDAO
            UsuarioDAO user = new UsuarioDAO();
            //chamar o metodo que verifica o login
            //o usuário e senha existem na tabela
            if (user.LoginUsuario(usuario,senha)) {
                Form2 tela = new Form2();
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
            Form0 tela0 = new Form0();
            tela0.Show();
            this.Hide();
        }
    }
}
