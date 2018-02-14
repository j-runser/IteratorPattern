namespace IteratorPattern
{
    // The 'building' based off of the Iterator classes 'blueprint'.
    class ConcreteIterator : Iterator
    {
        
        int currentIndex;

        // Notice it requres an exsisting aggregate to create the iterator, if
        // there is no aggregate than there will be no iterator.
        public ConcreteIterator(Aggregate aggregate)
        {
            // The aggregate is derived from the Iterator (abstract) class.
            this.aggregate = aggregate;

            // It will always start at 0.
            currentIndex = 0;
        }

        // Person: Person object to be returned by the iterator.
        //
        // Returns the current item of the iterator.
        public override Person CurrentItem()
        {
            // Notice the check makes it so that it does not matter what the
            // currentIndex is, the software will not have an error if it gets
            // out of control.
            if(IsDone())
            {
                return aggregate[aggregate.Count - 1];
            }
            
            return aggregate[currentIndex];
        }

        // Takes it to the first index of the iterator.
        public override void First()
        {
            currentIndex = 0;
        }

        // bool: true if it the final element or later, false otherwise.
        //
        // Checks to see if it is the end of the iterator (at or beyond the last item).
        public override bool IsDone()
        {
            // It does not matter how many times current index is incremented
            // because unless this statement is true it will be higher than the
            // count of the elements.
            return currentIndex >= aggregate.Count;
        }

        // Moves to the next item in the iterator.
        public override void Next()
        {
            // This will keep increasing the index even if there are no more
            // items to iterate though, it is not necessary to check because
            // of how CurrentItem() and IsDone() work.
            currentIndex++;
        }
    }
}
