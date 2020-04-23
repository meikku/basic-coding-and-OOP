namespace Exercise
{
    using System;
    using System.Collections.Generic;
    public class Book : IComparable<Book>
    {

        public string name { get; set; }
        public int age { get; set; }

        public Book(string name, int age)
        {
            this.name = name;
            this.age = age;// Fill in the blanks
        }


        public override string ToString()
        {

            // Don't touch this
            return this.name + " (recommended for " + this.age + " year-olds or older)";
        }


        public int CompareTo(Book other)
        {

            // Do some magic here
            /*if (other == null)
            {
                return 1;
            }
            if (this.age == other.age)
            {
                return 0;
            }
            else if (this.age > other.age)
            {
                return 1;
            }
            else
            {
                return 0;
            }*/
            if (this.age == other.age)
            {
              return this.name.CompareTo(other.name);
              

            }
            return (this.age.CompareTo(other.age));
           

        }

    }
}