using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class MusicSheet
    {
        private List<INote> notes = new List<INote>();

        internal List<INote> Notes { get => notes; set => notes = value; }

        public List<INote> ConvertTextToNote(string text)
        {
            WholeNoteFactory wholeNoteFactory = new WholeNoteFactory();

            List<INote> notes = new List<INote>();
            string[] parts = text.Split(' ');

            for (int i = 0; i < parts.Length; i++)
            {
                string lastPart = null;

                if (lastPart == " " && parts[i] == " ")
                {
                    continue;
                }
                else if (parts[i] == "c")
                {
                    notes.Add(wholeNoteFactory.CreateNote("C"));
                }
                else if (parts[i] == "d")
                {
                    notes.Add(wholeNoteFactory.CreateNote("D"));
                }
                else if (parts[i] == "e")
                {
                    notes.Add(wholeNoteFactory.CreateNote("E"));
                }
                else if (parts[i] == "f")
                {
                    notes.Add(wholeNoteFactory.CreateNote("F"));
                }
                else if (parts[i] == "g")
                {
                    notes.Add(wholeNoteFactory.CreateNote("G"));
                }
                else if (parts[i] == "a")
                {
                    notes.Add(wholeNoteFactory.CreateNote("A"));
                }
                else if (parts[i] == "h")
                {
                    notes.Add(wholeNoteFactory.CreateNote("H"));
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
