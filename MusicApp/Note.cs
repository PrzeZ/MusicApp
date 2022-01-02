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
            this.posX = posX;  
            this.posY = posY;
        }
    }
}
