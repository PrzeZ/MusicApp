﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class MusicSheetsSystemFacade : IMusicSheetsSystemFacade
    {
        private IBitmapFactory bitmapFactory = null;
        private List<IMusicSheet> musicSheets = new List<IMusicSheet>();

        public MusicSheetsSystemFacade(IBitmapFactory bitmapFactory)
        {
            this.bitmapFactory = bitmapFactory;
        }

        public Bitmap InitializeMusicSheet()
        {
            if (musicSheets.Count == 0)
            {
                AddMusicSheet();
            }
            return bitmapFactory.CreateBitmap(musicSheets[0].Notes); //TODO
        }

        public Bitmap UpdateMusicSheet(string text)
        {
            var notes = musicSheets[0].ConvertTextToNote(text);
            return bitmapFactory.CreateBitmap(notes);
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
