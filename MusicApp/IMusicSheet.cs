using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal interface IMusicSheet
    {
        List<INote> Notes { get; }
        List<INote> ConvertTextToNote(string text);
    }
}
