﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class WholeNoteFactory : INoteFactory //FABRYKA
    {
        public INote CreateNote(float pitch)
        {
            INote note = new WholeNote(pitch);
            return note;
        }
    }
}
