using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    internal class BitmapFactory : IBitmapFactory
    {
        public Bitmap CreateBitmap(List<INote> notes)
        {
            const int offset = 30;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(700, 500);

            Bitmap bitmap = new Bitmap(700, 500);
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.FillRectangle(Brushes.White, 0, 0, 700, 500);

            for (int i = 0; i < 5; i++)
            {
                graphics.FillRectangle(Brushes.Black, 0, 20 + (i * 20), 700, 3);
            }

            for (int i = 0; i < notes.Count; i++)
            {
                var NoteEnumerator = (Enums.Notes)Enum.Parse(typeof(Enums.Notes), notes[i].Pitch); //may get replaced by a better solution
                graphics.DrawEllipse(Pens.Black, new RectangleF(i * offset, (float)NoteEnumerator, 25f, 20f));
            }

            return bitmap;
        }
    }
}
