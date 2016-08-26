using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using AxAXVLC;
//using System.IO;


namespace fix3_vlc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  System.Uri uri = new System.Uri("F:/videos/Gone Baby Gone (2007)/Gone.Baby.Gone.2007.720p.BrRip.x264.BOKUTOX.YIFY.mp4");
            System.Uri uri = new System.Uri("rtsp://admin:12345@192.168.1.100:554/Streaming/Channels/101?transportmode=unicast");
            axVLCPlugin21.playlist.add(uri.AbsoluteUri, null, null);
            Console.Out.WriteLine("sampe sini yaa");
            //axVLCPlugin21.playlist.play();
            
            
/*
            OpenFileDialog op1 = new OpenFileDialog();
            op1.Filter = "( *.mp4 | *.mp4";
            
                        if (op1.ShowDialog()==DialogResult.OK)
                        { 
                            System.Uri uri = new System.Uri(op1.FileName);
                            axVLCPlugin21.playlist.add(uri.ToString(), op1.SafeFileName, null);
                        }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.togglePause();
        }
    }
}
