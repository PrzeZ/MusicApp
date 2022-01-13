using System.Collections.Generic;

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
