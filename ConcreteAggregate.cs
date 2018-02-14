namespace IteratorPattern
{
    // Uses the bluprint Aggregate to make any kind of iterator required. 
    public class ConcreteAggregate : Aggregate
    {
        // Iterator: Returns an iterator without any need for input.
        //
        // Call the default CreateIterator method.
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        // Iterator: Returns an iterator depending on the input.
        // IteratorType: The type of itterator that should be returned. 
        //  - SortedByAge: Will sort the dataset by age.
        //  - SortedByName: Will sort the dataset by name.
        //  - NotSorted: Will leave the dataset as is.
        //
        // Calls the declared CreateIterator method.
        public override Iterator CreateIterator(IteratorType iteratorType)
        {
            switch (iteratorType)
            {
                case IteratorType.SortedByAge: return SortedByAge();
                case IteratorType.SortedByName: return SortedByName();
                default: return new ConcreteIterator(this);
            }
        }

        // Iterator: An iterator sorted by name.
        //
        // Sorts the iterator by name and returns it.
        private Iterator SortedByName()
        {
            // This will allow the person to be compared by name and sorted in
            // acending order. Note there is no safty for if the list is empty.
            Sort(delegate (Person x, Person y)
            {
                return x.GetName().CompareTo(y.GetName());
            });

            return new ConcreteIterator(this);
        }

        // Iterator: An iterator sorted by age.
        //
        // Sorts the iterator by age and returns it.
        private Iterator SortedByAge()
        {
            // This will sort the person by age in acending order. Mind there is
            // no safety net for if the list is empty.
            Sort(delegate (Person x, Person y) 
            {
                return x.GetAge().CompareTo(y.GetAge());
            });

            return new ConcreteIterator(this);
        }
    }
}
