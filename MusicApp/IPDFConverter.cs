using System.Drawing;
using System.Threading.Tasks;

namespace MusicApp
{
    internal interface IPDFConverter
    {
        Task ConvertToPDFAsync(Bitmap bitmap, string path);
    }
}
