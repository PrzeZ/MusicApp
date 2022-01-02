using PdfSharp.Drawing;
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

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            musicSheet.SetText(textBox1.Text);
=======
            musicSheet.SetNotes(textBox1.Text);
            CreateBitmapAtRuntime();
        }

        public void CreateBitmapAtRuntime()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox1.Size = new Size(700, 500);
            this.Controls.Add(pictureBox);

            Bitmap bitmap = new Bitmap(700, 500);
            Graphics graphics = Graphics.FromImage(bitmap);

            int red = 0;
            int white = 11;

            graphics.FillRectangle(Brushes.Red, 0, red, 700, 500);
            pictureBox1.Image = bitmap;
        }

        void DrawImage(XGraphics gfx, int number)
        {

            XImage image = XImage.FromFile(/*jpegSamplePath*/);

            // Left position in point
            double x = (250 - image.PixelWidth * 72 / image.HorizontalResolution) / 2;
            gfx.DrawImage(image, x, 0);
>>>>>>> Stashed changes
        }
    }
}
