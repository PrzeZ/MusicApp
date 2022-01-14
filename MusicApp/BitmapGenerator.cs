using System.Drawing;
using System.Windows.Forms;

namespace MusicApp
{
    internal class BitmapGenerator : IBitmapGenerator
    {
        public Bitmap CreateBitmap(IMusicSheet musicSheet, Bitmap background)
        {
            const int xOffsetIncrement = 75;
            int xOffset = 100;
            int yOffset = 0;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(1000, 800);

            Bitmap bitmap = new Bitmap(1000, 800);
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.DrawImage(background, 0, 0, 1000, 800);

            for (int i = 0; i < musicSheet.Notes.Count; i++)
            {
                graphics.DrawEllipse(Pens.Black, new RectangleF(xOffset, (float)musicSheet.Notes[i].Pitch + yOffset, 25f, 20f));
                if (i == 12 || i == 24 || i == 36)
                {
                    xOffset = 100;
                    yOffset += 200;
                }
                else
                {
                    xOffset += xOffsetIncrement;
                }
            }
            return bitmap;
        }

        public Bitmap Initialize()
        {
            Bitmap bitmap = new Bitmap(1000, 800);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillRectangle(Brushes.White, 0, 0, 1000, 800);

            Image key = Properties.Resources.key;

            int offset = 0;
            for (int j = 0; j < 4; j++)
            {
                graphics.DrawImage(key, 0, 10 + offset, 100, 100);
                for (int i = 0; i < 5; i++)
                {
                    graphics.FillRectangle(Brushes.Black, 0, 20 + (i * 20) + offset, 1000, 3);
                }
                offset += 200;
            }           
            return bitmap;
        }
    }
}
