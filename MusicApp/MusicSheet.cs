using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class MusicSheet
    {
        private List<Note> notes = new List<Note>();

        public void AddNoteToSheet(Note note)
        {
            notes.Add(note);
        }

        private Note ConvertTextToNote(string text)
        {
            string[] parts = text.Split(new char[notes.Count]);
            foreach (var part in parts)
            {
                if (part == "c3")
                {
                    return (new Note("c3", 0, 0));
                }
                else return null;
            }
            return null;
        }
    }
}
