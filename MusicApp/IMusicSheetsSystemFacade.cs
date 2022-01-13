using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal interface IMusicSheetsSystemFacade
    {
        List<INote> ConvertTextToNote(string text);
        void InitializeMusicSheets();
        void AddMusicSheet();
        Bitmap UpdateMusicSheet(string text);
        void SelectNextMusicSheet();
        void SelectPreviousMusicSheet();
        Bitmap Background { get; }
    }
}
