using System;

namespace IteratorPattern
{
    public class Iterator : IIterator
    {

        private Aggregate _aggregate;
        int index;

        public Iterator(Aggregate aggregate)
        {
            _aggregate = aggregate;
            index = -1;
        }

        public object Current
        {
            get
            {
                if (index < _aggregate.Count)
                {
                    return _aggregate[index];
                }

                throw new InvalidOperationException();
            }
        }

        public bool Next()
        {
            index++;
            return index < _aggregate.Count;
        }
    }

}
