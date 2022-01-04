using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class WholeNoteFactory : NoteFactory
    {
        public override INote GetNote()
        {
            INote note = new WholeNote();
            return note;
        }
    }
}
