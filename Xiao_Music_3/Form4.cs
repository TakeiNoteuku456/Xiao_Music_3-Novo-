﻿using System;
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
        public Form4()
        {
            InitializeComponent();
        }

        private void TextAdicionar_TextChanged(object sender, EventArgs e)
        {

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
            this.Close();
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
            }
        }
    }
}
