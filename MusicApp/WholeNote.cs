using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class WholeNote : INote
    {
        private string pitch;

        public WholeNote(string pitch)
        {
            this.pitch = pitch;
        }

        public string Pitch => pitch;
    }
}
