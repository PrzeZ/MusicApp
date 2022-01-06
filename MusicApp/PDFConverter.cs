using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    internal class PDFConverter
    {
        internal async Task DrawImage(XGraphics gfx, int number)
        {
            try
            {
                PdfDocument pdf = new PdfDocument();
                pdf.Pages.Add(new PdfPage());
                XGraphics xgr = XGraphics.FromPdfPage(pdf.Pages[0]);
                XImage image = XImage.FromFile(null /*jpegSamplePath*/);

                // Left position in point
                double x = (250 - image.PixelWidth * 72 / image.HorizontalResolution) / 2;
                gfx.DrawImage(image, x, 0);
                pdf.Save(("~/Images/test.pdf"));
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
