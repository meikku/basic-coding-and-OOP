namespace Exercise
{
  using System.Text.RegularExpressions;
  public class Checker
  {
    public bool DayOfWeek(string str)
    {
      Regex regex = new Regex ("^(mon|tue|wed|thu|fri|sat|sun)$");
    
        return regex.IsMatch(str);
    
    }

    public bool AllVowels(string str)
    {
      Regex regex = new Regex("^[a|e|i|o|u]*$");

     
        return regex.IsMatch(str);
     
    }

    public bool TimeOfDay(string str)
    {
      Regex regex = new Regex("^([0-1][0-9]|[2][0-3]):([0-5][0-9]):([0-5][0-9])$");
      
        return regex.IsMatch(str);
      
    }
  }
}