using System;
using System.Windows.Forms;

namespace IteratorPattern
{
    public partial class Form1 : Form
    {

        private ConcreteAggregate aggregate;
        private Iterator iterator;
        
        public Form1()
        {
            InitializeComponent();
            
            // Create an aggregate to be turned in to an iterator.
            aggregate = new ConcreteAggregate();

            // Adding elements to the aggregate, this would normally not be
            // done this way. For the sake of the demo it will work. I made
            // the Person object just to learn about objects in C#, specifically
            // the ToString() method.
            aggregate.Add(new Person("Joe", 24));
            aggregate.Add(new Person("Alicia", 24));
            aggregate.Add(new Person("Roger", 58));
            aggregate.Add(new Person("Beth", 51));
            aggregate.Add(new Person("Emily", 22));
            aggregate.Add(new Person("Dave", 103));

            // Turn the aggregate into the iterator.
            iterator = aggregate.CreateIterator();

            FillListBox();
            SetLblTxt();
            
        }

        // Accidentally added this.
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            iterator.Next();

            // I would not normally do something so useless but I felt the need to show
            // of the IsDone() method.
            if(iterator.IsDone())
            {
                lbl_age.Text = "";
                lbl_name.Text = "There are no people left.";
            }
            else
            {
                SetLblTxt();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iterator.First();
            SetLblTxt();
        }

        private void SetLblTxt()
        {
            lbl_age.Text = iterator.CurrentItem().GetAge() + "";
            lbl_name.Text = iterator.CurrentItem().GetName();
        }

        private void FillListBox()
        {
            list_people.Items.Clear();
            // This is done as shown in the video and in class.
            for (iterator.First(); !iterator.IsDone(); iterator.Next())
            {
                list_people.Items.Add(iterator.CurrentItem().ToString());
            }
            // Set it to first becasue I may be OCD, this is not requried.
            iterator.First();
        }

        private void btn_ageSort_Click(object sender, EventArgs e)
        {
            // Replaces the exsisting iterator with on that is sorted by age.
            iterator = aggregate.CreateIterator(Aggregate.IteratorType.SortedByAge);
            FillListBox();
        }

        private void btn_nameSort_Click(object sender, EventArgs e)
        {
            // Replaces the exsisting iterator with one that is sorted by name.
            iterator = aggregate.CreateIterator(Aggregate.IteratorType.SortedByName);
            FillListBox();
        }
    }
}
