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

            const int offset = 30;
            int totalOffset = 0;

            for (int i = 0; i < parts.Length; i++)
            {
                string lastPart = null;


                if (lastPart == " " && parts[i] == " ")
                {
                    continue;
                }
                else if (parts[i] == "c")
                {
                    notes.Add(new Note("d", totalOffset, 110));
                    totalOffset += offset;
                }
                else if (parts[i] == "d")
                {
                    notes.Add(new Note("d", totalOffset, 100));
                    totalOffset += offset;
                }
                else if (parts[i] == "e")
                {
                    notes.Add(new Note("e", totalOffset, 90));
                    totalOffset += offset;
                }
                else if (parts[i] == "f")
                {
                    notes.Add(new Note("f", totalOffset, 80));
                    totalOffset += offset;
                }
                else if (parts[i] == "g")
                {
                    notes.Add(new Note("g", totalOffset, 70));
                    totalOffset += offset;
                }
                else if (parts[i] == "a")
                {
                    notes.Add(new Note("a", totalOffset * 30, 60));
                    totalOffset += offset;
                }
                else if (parts[i] == "h")
                {
                    notes.Add(new Note("h", i * 30, 50));
                    totalOffset += offset;
                }
                else
                {
                    continue;
                }
                lastPart = parts[i];
            }
            return notes;
        }
    }
}
