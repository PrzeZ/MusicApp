using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class WholeNote : INote
    {
        private int posX;
        private int posY;

        public WholeNote()
        {
        }

        public WholeNote(string name, int posX, int posY)
        {
            this.PosX = posX;
            this.PosY = posY;
        }

        public int PosX { get => posX; set => posX = value; }
        public int PosY { get => posY; set => posY = value; }
    }
}
