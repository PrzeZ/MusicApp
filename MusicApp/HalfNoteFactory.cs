namespace MusicApp
{
    internal class HalfNoteFactory : INoteFactory //FABRYKA
    {
        public INote CreateNote(float pitch)
        {
            INote note = new HalfNote(pitch);
            return note;
        }
    }
}
