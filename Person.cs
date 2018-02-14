namespace IteratorPattern
{
    // As to represent a person, very scaleable.
    public class Person
    {
        string name;
        int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        // I wanted to use the ToString() method in C#, I have only ever used
        // it in Java.
        public override string ToString()
        {
            return name + ", " + age;
        }
    }
}
