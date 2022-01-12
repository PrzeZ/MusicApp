using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class HalfNote : INote
    {
        private float pitch;

        public HalfNote(float pitch)
        {
            this.pitch = pitch;
        }

        public float Pitch => pitch;
    }
}
