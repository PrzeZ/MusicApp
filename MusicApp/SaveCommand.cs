using System.Drawing;

namespace MusicApp
{
    internal class SaveCommand : ICommand //POLECENIE
    {
        private PDFConverter converter;

        private Bitmap bitmap;

        public SaveCommand(PDFConverter converter, Bitmap bitmap)
        {
            this.converter = converter;
            this.bitmap = bitmap;
        }

        public async void Execute()
        {
            await converter.ConvertToPDFAsync(bitmap);
        }
    }
}
