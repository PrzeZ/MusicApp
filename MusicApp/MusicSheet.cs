using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class MusicSheet
    {
        private List<Note> notes = new List<Note>();
        private string inputText;

        public void SetText(string text)
        {
            inputText = text;
        }
    }
}
