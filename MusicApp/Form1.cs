using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class Form1 : Form
    {
        private MusicSheet musicSheet = null;

        public Form1()
        {
            InitializeComponent();
            musicSheet = new MusicSheet();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = BitmapFactory.CreateBitmap();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = BitmapFactory.CreateBitmap();
        }



        //void DrawImage(XGraphics gfx, int number)
        //{

        //    XImage image = XImage.FromFile(/*jpegSamplePath*/);

        //    // Left position in point
        //    double x = (250 - image.PixelWidth * 72 / image.HorizontalResolution) / 2;
        //    gfx.DrawImage(image, x, 0);
        //}
    }
}
