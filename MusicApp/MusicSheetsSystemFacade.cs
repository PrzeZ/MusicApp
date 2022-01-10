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
        private IMusicSheet selectedMusicSheet;

        public MusicSheetsSystemFacade(IBitmapGenerator bitmapFactory)
        {
            this.bitmapGenerator = bitmapFactory;
        }

        public Bitmap InitializeMusicSheet()
        {

            AddMusicSheet();
            selectedMusicSheet = musicSheets[0];
            return bitmapGenerator.Initialize();
        }

        public Bitmap UpdateMusicSheet(string text)
        {
            var notes = selectedMusicSheet.ConvertTextToNote(text);
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
    }
}
