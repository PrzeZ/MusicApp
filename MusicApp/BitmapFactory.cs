using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    internal static class BitmapFactory
    {
        public static Bitmap CreateBitmap()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(700, 500);

            Bitmap bitmap = new Bitmap(700, 500);
            Graphics graphics = Graphics.FromImage(bitmap);

            int red = 0;
            int white = 11;

            graphics.FillRectangle(Brushes.Red, 0, red, 700, 500);
            return bitmap;
            //pictureBox1.Image = bitmap;
        }
    }
}
