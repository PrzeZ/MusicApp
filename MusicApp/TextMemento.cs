namespace MusicApp
{
    internal class TextMemento : IMemento
    {
        private string state;

        public TextMemento(string state)
        {
            this.state = state;
        }

        // The Originator uses this method when restoring its state.
        public string GetState()
        {
            return state;
        }
    }
}
