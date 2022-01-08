using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    internal class BitmapGenerator : IBitmapGenerator
    {
        Bitmap background = null;
        Image key = Image.FromFile("D:/projekty/.net/MusicApp/MusicApp/images/key.png");

        public Bitmap CreateBitmap(List<INote> notes)
        {
            int xOffset = 100;
            int yOffset = 0;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(1000, 800);

            Bitmap bitmap = new Bitmap(1000, 800);
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.DrawImage(background, 0, 0, 1000, 800);

            for (int i = 0; i < notes.Count; i++)
            {
                var NoteEnumerator = (Enums.Notes)Enum.Parse(typeof(Enums.Notes), notes[i].Pitch); //may get replaced by a better solution
                graphics.DrawEllipse(Pens.Black, new RectangleF(xOffset, (float)NoteEnumerator + yOffset, 25f, 20f));
                if (i == 30 || i == 60 || i == 90)
                {
                    xOffset = 100;
                    yOffset += 200;
                }
                else
                {
                    xOffset += 30;
                }
            }
            return bitmap;
        }

        public Bitmap Initialize()
        {
            Bitmap bitmap = new Bitmap(1000, 800);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillRectangle(Brushes.White, 0, 0, 1000, 800);

            int offset = 0;
            for (int j = 0; j < 4; j++)
            {
                graphics.DrawImage(key, 0, 10 + offset, 100, 100); //To refactor
                for (int i = 0; i < 5; i++)
                {
                    graphics.FillRectangle(Brushes.Black, 0, 20 + (i * 20) + offset, 1000, 3);
                }
                offset += 200;
            }

            background = bitmap;
            return bitmap;
        }
    }
}
