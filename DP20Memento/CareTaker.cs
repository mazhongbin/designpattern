using System.Collections.Generic;

namespace DP20Memento
{
    public class CareTaker
    {
        private Dictionary<int, Memento> mementos = new Dictionary<int, Memento>();

        public void SaveMemento(int id,Memento memento)
        {
            mementos.Add(id, memento);
        }

        public Memento LoadMemento(int id)
        {
            return mementos[id];
        }
    }
}
