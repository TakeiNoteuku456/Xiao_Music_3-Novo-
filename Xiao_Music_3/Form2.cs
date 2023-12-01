using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Xiao_Music_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCadastrar2 Form8 = new FormCadastrar2();
            Form8.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin FormLogin = new FormLogin();
            FormLogin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Youtube Form5 = new Youtube();
            Form5.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 Form7 = new Form7();
            Form7.Show();
            this.Hide();
        }
    }
}

