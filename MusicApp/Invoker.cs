namespace MusicApp
{
    internal class Invoker
    {
        private ICommand onStart;

        private ICommand onFinish;

        public void SetOnStart(ICommand command)
        {
            onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            onFinish = command;
        }

        public void DoCommands()
        {
            if (onStart is ICommand)
            {
                onStart.Execute();
            }

            if (onFinish is ICommand)
            {
                onFinish.Execute();
            }
        }
    }
}
