namespace Exercise
{
    public class TripleTacoBox : ITacoBox
    {
        private int tacos { get; set; }
        public TripleTacoBox()
        {
            this.tacos = 3;
        }

        public int TacosRemaining()
        {
            return this.tacos;
        }

        public void Eat()
        {
            if (this.tacos - 1 >= 0)
            {
                this.tacos -= 1;
            }


        }
    }
}