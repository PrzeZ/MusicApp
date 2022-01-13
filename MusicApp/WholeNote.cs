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
