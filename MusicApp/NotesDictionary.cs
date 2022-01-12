using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public static class NotesDictionary
    {
        public static Dictionary<string, int> dictionary = new Dictionary<string, int>()
        {
            { "c", 110 },
            { "d", 100 },
            { "e", 90 },
            { "f", 80 },
            { "g", 70 },
            { "a", 60 },
            { "h", 50 },
        };
    }
}
