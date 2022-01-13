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
        Bitmap background = null;

        public Bitmap Background { get => background; set => background = value; }

        public MusicSheetsSystemFacade(IBitmapGenerator bitmapFactory)
        {
            bitmapGenerator = bitmapFactory;
        }

        public void InitializeMusicSheets()
        {
            AddMusicSheet();
            Background = bitmapGenerator.Initialize();
        }

        public Bitmap UpdateMusicSheet(string text)
        {
            var notes = ConvertTextToNote(text);
            IMusicSheet sheet = musicSheets[selectedMusicSheetIndex];
            return bitmapGenerator.CreateBitmap(sheet, Background);
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
            if (musicSheets[selectedMusicSheetIndex].CheckIfFull())
            {
                AddMusicSheet();
            }
            if (selectedMusicSheetIndex == musicSheets.Count - 1) { return; }

            selectedMusicSheetIndex++;
            //UpdateMusicSheet();
        }

        public void SelectPreviousMusicSheet()
        {
            if (selectedMusicSheetIndex == 0) { return; }
            selectedMusicSheetIndex--;
            //UpdateMusicSheet();
        }

        public List<INote> ConvertTextToNote(string text)
        {       
            string[] separators = new string[] { " ", "\n" };
            NoteFactory wholeNoteFactory = new WholeNoteFactory(); //notes in specified sheet

            List<INote> notes = new List<INote>();
            string[] parts = text.Split(separators, StringSplitOptions.None);
            int sheetIndex = 0;

            musicSheets[sheetIndex].ClearNotes(); //SLOW!
            for (int i = (sheetIndex * 48); i < parts.Length; i++)
            {
                string lastPart = null;

                var value = 0;
                if (!NotesDictionary.dictionary.TryGetValue(parts[i], out value))
                {
                    // value not found
                    continue;
                }

                if (lastPart == " " && parts[i] == " ")
                {
                    continue;
                }
                else
                {
                    string notePart = parts[i];
                    musicSheets[sheetIndex].AddNote(wholeNoteFactory.CreateNote(value));
                }
                lastPart = parts[i];
            }
            return notes;
        }

    }
}
