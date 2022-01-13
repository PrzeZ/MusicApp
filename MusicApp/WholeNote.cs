using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class WholeNote : INote
    {
        private float pitch;

        public WholeNote(float pitch)
        {
            this.pitch = pitch;
        }

        public float Pitch => pitch;
    }
}
