using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MusicApp
{
    internal class Caretaker
    {
        private List<IMemento> mementos = new List<IMemento>();

        private TextBox originator = null;

        public Caretaker(TextBox originator)
        {
            this.originator = originator;
        }

        public void Backup()
        {
            Console.WriteLine("\nCaretaker: Saving Originator's state...");
            mementos.Add(new TextMemento(originator.Text));
        }

        public void Undo()
        {
            if (mementos.Count == 0)
            {
                return;
            }

            var memento = mementos.Last();
            mementos.Remove(memento);

            try
            {
                originator.Text = memento.GetState();
            }
            catch (Exception)
            {
                Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (var memento in mementos)
            {
                Console.WriteLine(memento.GetState());
            }
        }
    }
}
