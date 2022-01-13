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
            try
            {
                PdfDocument pdf = new PdfDocument();
                bitmap.Save("tmp.bmp");

                PdfPage page = pdf.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                XImage image = XImage.FromFile("tmp.bmp");
                gfx.DrawImage(image, 0, 0, (int)bitmap.Width, (int)bitmap.Height);

                pdf.Save(("test.pdf"));
                pdf.Close();

                var p = new System.Diagnostics.Process();
                p.StartInfo = new System.Diagnostics.ProcessStartInfo("test.pdf")
                {
                    UseShellExecute = true
                };
                p.Start();

                MessageBox.Show("Save success", "Saved to pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e)
            {
                MessageBox.Show("Saving to pdf failed \n" +
                    e.StackTrace, "An exception occured", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            await Task.Delay(1000);
        }


    }
}
