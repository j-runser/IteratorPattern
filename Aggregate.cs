using System.Collections.Generic;

namespace IteratorPattern
{
    // The 'blueprint' for the ConcreteAggregate class.
    public abstract class Aggregate : List<Person>
    {

        // I saw this in the demo and wanted to try it out. I have never used
        // it before.
        public enum IteratorType { SortedByName, SortedByAge, NotSorted };

        // For comments see the concreteAggregate class.
        public abstract Iterator CreateIterator();
        public abstract Iterator CreateIterator(IteratorType iteratorType);
    }
}
