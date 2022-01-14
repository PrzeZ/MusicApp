using System.Drawing;

namespace MusicApp
{
    internal class SaveCommand : ICommand //POLECENIE
    {
        private Bitmap bitmap;

        private OpenFileDecorator openFileDecorator;

        public SaveCommand(PDFConverter converter, Bitmap bitmap)
        {
            this.bitmap = bitmap;
            openFileDecorator = new OpenFileDecorator(converter);
        }

        public async void Execute()
        {
            await openFileDecorator.SaveAndOpen(bitmap, "musicSheets.pdf");
        }
    }
}
