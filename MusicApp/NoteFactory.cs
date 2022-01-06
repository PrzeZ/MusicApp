using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal abstract class NoteFactory
    {
        public abstract INote CreateNote(string pitch);
    }
}
