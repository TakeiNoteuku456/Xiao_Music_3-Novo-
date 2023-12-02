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
    public partial class FormLP : Form
    {
        public FormLP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 Form7 = new Form7();
            Form7.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCadastrar2 Form8 = new FormCadastrar2();
            Form8.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }
    }
}
