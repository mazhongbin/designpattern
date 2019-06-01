using System.Collections.Generic;

namespace DP19Observer
{
    public abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }
    }
}
