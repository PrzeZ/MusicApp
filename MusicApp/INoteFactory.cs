namespace MusicApp
{
    internal interface INoteFactory //FABRYKA ABSTRAKCYJNA
    {
        INote CreateNote(float pitch);
    }
}
