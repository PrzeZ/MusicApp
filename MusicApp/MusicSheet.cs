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

        public void SetText(string text)
        {
            notes = ConvertTextToNotes(text);
        }

        private List<Note> ConvertTextToNotes(string text)
        {
            List<Note> notes = new List<Note>();
            string[] parts = text.Split(new char[notes.Count]);
            foreach (var part in parts)
            {
                if (part == "c3")
                { 
                    notes.Add(new Note("c3"));
                }
            }
            
            return notes;
        }
    }
}
