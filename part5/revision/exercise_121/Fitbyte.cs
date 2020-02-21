namespace exercise_121
{
    class Fitbyte
    {
        int age;
        int restingHeartRate;

        public Fitbyte(int age, int restingHeartRate)
        {
            this.age = age;
            this.restingHeartRate = restingHeartRate;
        }

        public double TargetHeartRate(double percentageOfMaximum)
        {
            double maximumHeartRate =  206.3 - (0.711 * this.age);
           

            return (maximumHeartRate - restingHeartRate) *(percentageOfMaximum) + this.restingHeartRate;
        }
    }

}