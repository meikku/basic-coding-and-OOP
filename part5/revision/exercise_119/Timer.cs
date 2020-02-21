namespace exercise_119
{
    public class Timer
    {
        private ClockHand hundreths { get; set; }
        private ClockHand seconds { get; set; }

        public Timer()
        {
            this.hundreths = new ClockHand(100);
            this.seconds = new ClockHand(60);
        }

        public void Advance()
        {
            this.hundreths.value = this.hundreths.value + 1;
            if (this.hundreths.value == 100)
            {
                this.hundreths.value = 0;
                this.seconds.value = this.seconds.value + 1;
            }
            if (this.seconds.value == 60)
            {
                this.seconds.value = 0;
            }

        }
        public override string ToString()
        {
            if (this.seconds.value < 10 && this.hundreths.value < 10)
                return "0" + this.seconds.value + ":0" + this.hundreths.value;
            else if (this.seconds.value < 10)
                return "0" + this.seconds.value + ":" + this.hundreths.value;
            else if (this.hundreths.value < 10)
                return this.seconds.value + ":0" + this.hundreths.value;
            else
                return this.seconds.value + ":" + this.hundreths.value;
        }
    }
}
