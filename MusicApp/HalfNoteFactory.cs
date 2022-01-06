using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class HalfNoteFactory : NoteFactory
    {
        public override INote CreateNote(string pitch)
        {
            INote note = new HalfNote(pitch);
            return note;
        }
    }
}
