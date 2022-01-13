using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal interface IMusicSheet
    {
        List<INote> Notes { get; }
        bool CheckIfFull();
        void AddNote(INote note);
        void ClearNotes();
    }
}
