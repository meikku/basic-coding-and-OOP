namespace Exercise
{
    using System;
    public class Student : IComparable<Student>
    {

        public string name { get; }

        public Student(string name)
        {
            this.name = name;
        }


        public override string ToString()
        {
            return name;
        }

        //BEGIN SOLUTION
        public int CompareTo(Student another)
        {
            // -1 if this is earlier
            // 0 if this is equal
            // 1 if this is later
            int result = this.name.CompareTo(another.name);
            return result;

            // or return this.name.CompareTo(another.name);
        }
        //END SOLUTION
    }
}