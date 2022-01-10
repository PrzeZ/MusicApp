using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class MusicSheetsSystemFacade : IMusicSheetsSystemFacade
    {
        private IBitmapGenerator bitmapGenerator = null;
        private List<IMusicSheet> musicSheets = new List<IMusicSheet>();
        private int selectedMusicSheetIndex = 0;

        public MusicSheetsSystemFacade(IBitmapGenerator bitmapFactory)
        {
            this.bitmapGenerator = bitmapFactory;
        }

        public Bitmap InitializeMusicSheet()
        {
            AddMusicSheet();
            return bitmapGenerator.Initialize();
        }

        public Bitmap UpdateMusicSheet(string text)
        {
            var notes = musicSheets[selectedMusicSheetIndex].ConvertTextToNote(text);
            return bitmapGenerator.CreateBitmap(notes);
        }

        public void AddMusicSheet()
        {
            musicSheets.Add(new MusicSheet());           
        }

        public void RemoveMusicSheet()
        {
            if (musicSheets.Count < 1) { return; }
            musicSheets.Remove(musicSheets[musicSheets.Count - 1]);
        }

        public void SelectNextMusicSheet()
        {
            if (selectedMusicSheetIndex == musicSheets.Count - 1) { return; }
            selectedMusicSheetIndex++;
        }

        public void SelectPreviousMusicSheet()
        {
            if (selectedMusicSheetIndex == 0) { return; }
            selectedMusicSheetIndex--;
        }
    }
}
