namespace MusicApp
{
    internal class TextMemento : IMemento //PAMIĄTKA
    {
        private string state;

        public TextMemento(string state)
        {
            this.state = state;
        }

        public string GetState()
        {
            return state;
        }
    }
}
