using System.Drawing;
using System.Threading.Tasks;

namespace MusicApp
{
    class OpenFileDecorator //DEKORATOR
    {
        protected PDFConverter converter;

        public OpenFileDecorator(PDFConverter converter)
        {
            this.converter = converter;
        }

        public async Task SaveAndOpen(Bitmap bitmap, string path)
        {
            await converter.ConvertToPDFAsync(bitmap, path);

            var p = new System.Diagnostics.Process();
            p.StartInfo = new System.Diagnostics.ProcessStartInfo(path)
            {
                UseShellExecute = true
            };
            p.Start();

            await Task.Delay(1000);
        }
    }
}
