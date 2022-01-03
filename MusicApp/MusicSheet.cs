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
            for (int i = 0; i < notes.Count; i++)
            {
                if (parts[i] == "d")
                {
                    notes.Add(new Note("d", i * 20, 100));
                }
                else if (parts[i] == "e")
                {
                    notes.Add(new Note("e", i * 20, 90));
                }
                else if (parts[i] == "f")
                {
                    notes.Add(new Note("f", i * 20, 80));
                }
            }
            return notes;
        }
    }
}
