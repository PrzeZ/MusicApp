using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class HalfNoteFactory : INoteFactory //FABRYKA
    {
        public INote CreateNote(float pitch)
        {
            INote note = new HalfNote(pitch);
            return note;
        }
    }
}
