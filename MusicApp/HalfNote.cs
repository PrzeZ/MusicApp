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