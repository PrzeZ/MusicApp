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

        internal List<Note> Notes { get => notes; set => notes = value; }

        public List<Note> ConvertTextToNote(string text)
        {
            List<Note> notes = new List<Note>();
            string[] parts = text.Split(' ');
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i] == "c")
                {
                    notes.Add(new Note("d", i * 30, 110));
                }
                if (parts[i] == "d")
                {
                    notes.Add(new Note("d", i * 30, 100));
                }
                else if (parts[i] == "e")
                {
                    notes.Add(new Note("e", i * 30, 90));
                }
                else if (parts[i] == "f")
                {
                    notes.Add(new Note("f", i * 30, 80));
                }
                else if (parts[i] == "g")
                {
                    notes.Add(new Note("g", i * 30, 70));
                }
                else if (parts[i] == "a")
                {
                    notes.Add(new Note("a", i * 30, 60));
                }
                else if (parts[i] == "h")
                {
                    notes.Add(new Note("h", i * 30, 50));
                }
            }
            return notes;
        }
    }
}
