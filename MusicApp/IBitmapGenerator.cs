using System.Drawing;

namespace MusicApp
{
    internal interface IBitmapGenerator
    {
        Bitmap CreateBitmap(IMusicSheet musicSheet, Bitmap background);
        Bitmap Initialize();
    }
}
