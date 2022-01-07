using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    internal class PDFConverter
    {
        internal async Task ConvertToPDF(Bitmap bitmap)
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
