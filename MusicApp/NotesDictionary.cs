using System.Collections.Generic;

namespace MusicApp
{
    public class NotesDictionary //SINGLETON
    {
        private NotesDictionary() { }

        private static NotesDictionary instance;

        public Dictionary<string, int> dictionary { get; set; } 

        private static readonly object locker = new object();

        public static NotesDictionary GetInstance()
        {
            // lock once the instance is ready.
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new NotesDictionary();
                        instance.dictionary = new Dictionary<string, int>()
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
            }
            return instance;
        }
    }

}
