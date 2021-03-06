using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class MusicSheetsSystemFacade : IMusicSheetsSystemFacade //FASADA
    {
        private IBitmapGenerator bitmapGenerator = null;
        private List<IMusicSheet> musicSheets = new List<IMusicSheet>();

        private int selectedMusicSheetIndex = 0;

        private Bitmap background = null;

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
            INoteFactory wholeNoteFactory = new WholeNoteFactory();

            List<INote> notes = new List<INote>();
            string[] parts = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int sheetIndex = 0;

            var notesDictionary = NotesDictionary.GetInstance();
            musicSheets[sheetIndex].ClearNotes();

            Parallel.For(sheetIndex * 48, parts.Length, (i) =>
            {
                var value = 0;
                if (!notesDictionary.dictionary.TryGetValue(parts[i], out value))
                {
                    // value not found
                }
                else
                {
                    string notePart = parts[i];
                    musicSheets[sheetIndex].AddNote(wholeNoteFactory.CreateNote(value));
                }
            });

            return notes;
        }

    }
}
