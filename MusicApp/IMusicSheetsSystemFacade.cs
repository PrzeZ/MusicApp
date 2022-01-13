using System.Collections.Generic;
using System.Drawing;

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
