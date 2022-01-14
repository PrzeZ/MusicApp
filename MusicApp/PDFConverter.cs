using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    internal class PDFConverter
    {
        internal async Task ConvertToPDFAsync(Bitmap bitmap)
        {
            FileOpener fileOpener = new FileOpener();

            try
            {            
                PdfDocument pdf = new PdfDocument();
                bitmap.Save("tmp.bmp");

                PdfPage page = pdf.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                XImage image = XImage.FromFile("tmp.bmp");
                gfx.DrawImage(image, 0, 0, bitmap.Width, bitmap.Height);

                pdf.Save(("test.pdf"));
                pdf.Close();

                

                MessageBox.Show("Save success", "Saved to pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e)
            {
                MessageBox.Show("Saving to pdf failed \n" +
                    e.StackTrace, "An exception occured", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            await fileOpener.OpenFileAsync("test.pdf");
            await Task.Delay(1000);
        }


    }
}
