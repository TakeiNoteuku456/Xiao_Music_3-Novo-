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
    public partial class Form4 : Form
    {
        Thread fdp;
        public Form4()
        {
            InitializeComponent();
        }

        private void TextAdicionar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Adicionar = TextAdicionar.Text;
            SoundPlayer Musica = new SoundPlayer();
            Musica.SoundLocation = Adicionar;
            Musica.Play();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            fdp = new Thread(novoForm);
            fdp.SetApartmentState(ApartmentState.STA);
            fdp.Start();
        }
        private void novoForm()
        {
            Application.Run(new Form2());
        }
    }
}
