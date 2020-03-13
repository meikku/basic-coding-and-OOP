namespace extra_16
{
    public class Person
    {
        private string name;
        private int age;
        private int height;
        private int weight;

        public Person(string name) : this(name, 0, 0, 0)
        {
         
        }
        public Person(string name, int age) : this(name, age, 0, 0)
        {

        }
        public Person(string name, int age, int height, int weight)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }
        public int GrowOlder(int howMuch)
        {
            this.age = this.age + howMuch;
            return this.age;
        }
        public override string ToString()
        {
            return this.name + ", age " + this.age + ", height " + this.height + "cm, weight " + this.weight + "kg";
            
        }
    }
}
