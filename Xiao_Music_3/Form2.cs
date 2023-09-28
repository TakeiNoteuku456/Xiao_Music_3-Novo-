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
        Thread fdp;
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            fdp = new Thread(novoForm1);
            fdp.SetApartmentState(ApartmentState.STA);
            fdp.Start();
        }
        private void novoForm1()
        {
            Application.Run(new Form3());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            fdp = new Thread(novoForm1);
            fdp.SetApartmentState(ApartmentState.STA);
            fdp.Start();
        }
        private void novoForm2()
        {
            Application.Run(new Form4());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            fdp = new Thread(novoForm);
            fdp.SetApartmentState(ApartmentState.STA);
            fdp.Start();
        }
        private void novoForm()
        {
            Application.Run(new Form1());
        }
    }
}

