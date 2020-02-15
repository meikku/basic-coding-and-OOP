namespace exercise_105
{
  public class Statistics
  {
    public int count { get; set; }
    public int sum { get; set; }

    public Statistics()
    {
      this.count = 0;
      this.sum = 0;
      // initialize the variables here
    }

    public void AddNumber(int number)
    {
      // write code here
      this.count = this.count + 1;
      this.sum = this.sum + number;
    }
  }
}