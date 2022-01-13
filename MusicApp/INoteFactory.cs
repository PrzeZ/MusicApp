using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal interface INoteFactory //abstract class for note factories
    {
        INote CreateNote(float pitch);
    }
}
