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


            graphics.FillRectangle(Brushes.White, 0, 0, 700, 500);

            for (int i = 0; i < 5; i++)
            {
                graphics.FillRectangle(Brushes.Black, 0, 20 + (i * 20), 700, 5);
            }

            return bitmap;
            //pictureBox1.Image = bitmap;
        }
    }
}
