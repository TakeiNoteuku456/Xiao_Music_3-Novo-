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
        private SoundPlayer player;
        private bool isPlaying = false;

        public Form4()
        {
            InitializeComponent();;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Áudio (*.wav)|*.wav";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (player != null)
                {
                    player.Stop();
                    player.Dispose();
                }
                player = new SoundPlayer(openFileDialog.FileName);
            }
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (player != null)
            {
                player.Play();
            }
        }

        private void buttonStopMarceline_Click(object sender, EventArgs e)
        {

            if (player != null)
            {
                player.Stop();
                isPlaying = false;
                radioButton1.Checked = false;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (!isPlaying)
                {
                    player.Play();
                    isPlaying = true;
                }
                else
                {
                    player.Stop();
                    isPlaying = false;
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

           
        }
    }

}
