using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class HalfNote : INote
    {
        private string pitch;

        public HalfNote(string pitch)
        {
            this.pitch = pitch;
        }

        public string Pitch => pitch;
    }
}
