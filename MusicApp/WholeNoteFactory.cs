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
