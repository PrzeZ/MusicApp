using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class MusicSheet : IMusicSheet
    {
        private List<INote> notes = new List<INote>();

        public List<INote> Notes => notes;
 
        public bool CheckIfFull()
        {
            if (notes.Count == 48) { return true; }
            return false;
        }

        public void AddNote(INote note)
        {
            notes.Add(note);
        }

        public void ClearNotes()
        {
            notes.Clear();
        }
    }
}
