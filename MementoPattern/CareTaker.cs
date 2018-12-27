using System.Collections.Generic;

namespace MementoPattern
{
    public class CareTaker
    {
        List<Memento> savedArticles = new List<Memento>();

        public void AddMemento(Memento m)
        {
            savedArticles.Add(m);
        }

        public Memento GetMemento(int index)
        {
            return savedArticles[index];
        }
    }
}
