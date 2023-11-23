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
    public partial class Form3 : Form //ttps://drive.google.com/drive/folders/1IAz2YSxnT8KvcsYAYlOGdP3KFWTIZQNe?usp=sharing
    {
        //se não conseguir abrir o programa vai no Forms3.Cs, e apaga os caminhos da musica(.wav) ou abaixa  pasta
        // ttps://drive.google.com/drive/folders/1IAz2YSxnT8KvcsYAYlOGdP3KFWTIZQNe?usp=sharing
        SoundPlayer MusicaMarceline, MusicaAki, MusicaGojo, MusicaKurapika, MusicaDanHeng, MusicaChainsaw, MusicaNeon, MusicaJustAwake, MusicaSunflower, MusicaSerotonin, MusicaTaki1;
        SoundPlayer Whativedone, MeunovoMundo, Paradise, TheNights, TheLazySong, HappierThanEver, WaitAMinute, Riptide, LoversRock, Seusol, MakimaDenji, lampadasnegras, Tanjiro, Extravagante;
        SoundPlayer YouEI, Lovely, SelfLove, transparentsoul, SpaceSong;
        public Form3()
        {
            InitializeComponent();
            MusicaMarceline = new SoundPlayer(); // Crie uma instância do SoundPlayer
            MusicaMarceline.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\Mistery-Marceline.wav"; // Defina o caminho do arquivo de áudio
            MusicaAki = new SoundPlayer();
            MusicaAki.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\FrioAkiHayakawa(ChainsawMan)Enygma.wav";
            MusicaGojo = new SoundPlayer();
            MusicaGojo.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\RapdoSatoruGojo(JujutsuKaisen)MundoInfinitoEnygma88.wav";
            MusicaKurapika = new SoundPlayer();
            MusicaKurapika.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\RapdoKurapika(HunterxHunter)MinhasCorrentesEnygma91.wav";
            MusicaDanHeng = new SoundPlayer();
            MusicaDanHeng.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\EmbebidorLunae(HonkaiStarRail)PartindooMar.wav";
            MusicaChainsaw = new SoundPlayer();
            MusicaChainsaw.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\CHAINSAWMAN3Ending.wav";
            MusicaNeon = new SoundPlayer();
            MusicaNeon.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\Taka-LuadeNeon-Feat.Anny.wav";
            MusicaJustAwake = new SoundPlayer();
            MusicaJustAwake.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\JUSTAWAKEFearandLoathinginLasVegas.wav";
            MusicaSunflower = new SoundPlayer();
            MusicaSunflower.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\PostMaloneSwaeLee-Sunflower(Spider-ManIntotheSpider-Verse).wav";
            MusicaSerotonin = new SoundPlayer();
            MusicaSerotonin.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\girlinred-Serotonin.wav";
            MusicaTaki1 = new SoundPlayer();
            MusicaTaki1.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\LeahciM-SeunomeYourName.wav";
            Whativedone = new SoundPlayer();
            Whativedone.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\WhatI_veDoneLinkinPark.wav";
            MeunovoMundo = new SoundPlayer();
            MeunovoMundo.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\CharlieBrownJr.MeuNovoMundo.wav";
            Paradise = new SoundPlayer();
            Paradise.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\ColdplayParadise.wav";
            TheNights = new SoundPlayer();
            TheNights.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\AviciiTheNights.wav";
            TheLazySong = new SoundPlayer();
            TheLazySong.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\BrunoMarsTheLazySong.wav";
            HappierThanEver = new SoundPlayer();
            HappierThanEver.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\BillieEilishHappierThanEver.wav";
            WaitAMinute = new SoundPlayer();
            WaitAMinute.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\WaitaMinute!.wav";
            Riptide = new SoundPlayer();
            Riptide.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\Riptide.wav";
            LoversRock = new SoundPlayer();
            LoversRock.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\LoversRock.wav";
            Seusol = new SoundPlayer();
            Seusol.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\Seusol.wav";
            MakimaDenji = new SoundPlayer();
            MakimaDenji.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\Makima&Denji(ChainsawMan)PoderD.Y.A Ft. @OtaldoHiro.wav";
            lampadasnegras = new SoundPlayer();
            lampadasnegras.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\Taka -LâmpadasNegras-Omori.wav";
            Tanjiro = new SoundPlayer();
            Tanjiro.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\Tanjiro(Kimetsu no Yaiba)ALuzResplandeceHenrique Mendonça.wav";
            Extravagante = new SoundPlayer();
            Extravagante.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\RapdoTenge Uzui(Demon Slayer)EXTRAVAGANTE.wav";
            SpaceSong = new SoundPlayer();
            SpaceSong.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\Beach House - Space Song.wav";
            Lovely = new SoundPlayer();
            Lovely.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\Billie Eilish, Khalid - lovely (Official Music Video).wav";
            SelfLove = new SoundPlayer();
            SelfLove.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\Metro Boomin, Coi Leray - Self Love (Spider-Man： Across the Spider-Verse).wav";
            YouEI = new SoundPlayer();
            YouEI.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\One Direction - You & I.wav";
            transparentsoul = new SoundPlayer();
            transparentsoul.SoundLocation = @"C:\Users\CJ3016757\Downloads\MusicaXiao_Music\t r a n s p a r e n t s o u l.wav";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Close();
        }
        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }
        private void button26_Click(object sender, EventArgs e)
        {
            MusicaMarceline.Play();
        }
        private void buttonStopMarceline_Click(object sender, EventArgs e)
        {
            MusicaMarceline.Stop();
        }
        private void button31_Click(object sender, EventArgs e)
        {
            MusicaAki.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusicaAki.Stop();
        }
        private void button36_Click(object sender, EventArgs e)
        {
            MusicaGojo.Play();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MusicaGojo.Stop();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            MusicaNeon.Play();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MusicaNeon.Stop();
        }
        private void button46_Click(object sender, EventArgs e)
        {
            MusicaDanHeng.Play();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MusicaDanHeng.Stop();
        }
        private void button27_Click(object sender, EventArgs e)
        {
            MusicaKurapika.Play();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            MusicaKurapika.Stop();
        }
        private void button32_Click(object sender, EventArgs e)
        {
            MusicaChainsaw.Play();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            MusicaChainsaw.Stop();
        }
        private void button37_Click(object sender, EventArgs e)
        {
            MusicaJustAwake.Play();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            MusicaJustAwake.Stop();
        }
        private void button42_Click(object sender, EventArgs e)
        {
            MusicaSunflower.Play();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            MusicaSunflower.Stop();
        }
        private void button47_Click(object sender, EventArgs e)
        {
            MusicaTaki1.Play();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            MusicaTaki1.Stop();
        }
        private void button28_Click(object sender, EventArgs e)
        {
            HappierThanEver.Play();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            HappierThanEver.Stop();
        }
        private void button33_Click(object sender, EventArgs e)
        {
            MusicaSerotonin.Play();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            MusicaSerotonin.Stop();
        }
        private void button38_Click(object sender, EventArgs e)
        {
            WaitAMinute.Play();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            WaitAMinute.Stop();
        }
        private void button43_Click(object sender, EventArgs e)
        {
            Riptide.Play();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            Riptide.Stop();
        }
        private void button48_Click(object sender, EventArgs e)
        {
            LoversRock.Play();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            LoversRock.Stop();
        }
        private void button29_Click(object sender, EventArgs e)
        {
            MeunovoMundo.Play();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void button52_Click(object sender, EventArgs e)
        {
            transparentsoul.Play();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            transparentsoul.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            MeunovoMundo.Stop();
        }
        private void button34_Click(object sender, EventArgs e)
        {
            Whativedone.Play();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            Whativedone.Stop();
        }
        private void button39_Click(object sender, EventArgs e)
        {
            Paradise.Play();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            Paradise.Stop();
        }
        private void button44_Click(object sender, EventArgs e)
        {
            TheNights.Play();
        }
        private void button19_Click(object sender, EventArgs e)
        {
            TheNights.Stop();
        }
        private void button49_Click(object sender, EventArgs e)
        {
            TheLazySong.Play();
        }
        private void button20_Click(object sender, EventArgs e)
        {
            TheLazySong.Stop();
        }
        private void button30_Click(object sender, EventArgs e)
        {
            Seusol.Play();
        }
        private void button22_Click(object sender, EventArgs e)
        {
            Seusol.Stop();
        }
        private void button35_Click(object sender, EventArgs e)
        {
            MakimaDenji.Play();
        }
        private void button21_Click(object sender, EventArgs e)
        {
            MakimaDenji.Stop();
        }
        private void button40_Click(object sender, EventArgs e)
        {
            lampadasnegras.Play();
        }
        private void button23_Click(object sender, EventArgs e)
        {
            lampadasnegras.Stop();
        }
        private void button45_Click(object sender, EventArgs e)
        {
            Tanjiro.Play();
        }
        private void button24_Click(object sender, EventArgs e)
        {
            Tanjiro.Stop();
        }
        private void button50_Click(object sender, EventArgs e)
        {
            Extravagante.Play();
        }
        private void button25_Click(object sender, EventArgs e)
        {
            Extravagante.Stop();
        }
        private void button51_Click(object sender, EventArgs e)
        {
            SpaceSong.Play();
        }
        private void button60_Click(object sender, EventArgs e)
        {
            SpaceSong.Stop();
        }
        private void button53_Click(object sender, EventArgs e)
        {
            SelfLove.Play();
        }
        private void button58_Click(object sender, EventArgs e)
        {
            SelfLove.Stop();
        }
        private void button54_Click(object sender, EventArgs e)
        {
            Lovely.Play();
        }
        private void button57_Click(object sender, EventArgs e)
        {
            Lovely.Stop();
        }
        private void button56_Click(object sender, EventArgs e)
        {
            YouEI.Stop();
        }
        private void button55_Click(object sender, EventArgs e)
        {
            YouEI.Play();
        }
    }
}
