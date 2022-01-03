using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class Note
    {
        private string name;
        private int posX;
        private int posY;

        public Note(string name, int posX, int posY)
        {
            this.name = name;
            this.PosX = posX;  
            this.PosY = posY;
        }

        public int PosX { get => posX; set => posX = value; }
        public int PosY { get => posY; set => posY = value; }
    }
}
