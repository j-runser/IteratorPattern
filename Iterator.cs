namespace IteratorPattern
{
    // All of this is just a ,blueprint, for the iterator, IE the reason it is
    // abstract.
    public abstract class Iterator
    {
        // Every time there is an iterator created there will be space for the
        // aggregate.
        protected Aggregate aggregate;

        // For commenting see the ConcreteIterator class.
        public abstract void First();
        public abstract void Next();
        public abstract bool IsDone();
        public abstract Person CurrentItem();

    }
}