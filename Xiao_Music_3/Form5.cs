using CefSharp.WinForms;
using CefSharp;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
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
    public partial class Youtube : Form
    {
        public Youtube()
        {
            InitializeComponent();
            InitializeChromium();
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);


            ChromiumWebBrowser chromeBrowser = new ChromiumWebBrowser("https://www.youtube.com/"); //ttps://www.youtube.com/ //ttps://open.spotify.com/intl-pt //ttps://www.friv.com/new.html

            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }
        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
        
    }
}
