using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class HalfNoteFactory : NoteFactory
    {
        public override INote GetNote()
        {
            INote note = new HalfNote();
            return note;
        }
    }
}
