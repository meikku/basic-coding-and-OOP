namespace Exercise
{
  using System;
  public class TemperatureSensor : Sensor
  {
    private bool isOn;
    public bool IsOn()
    {
      return isOn;
    }


    public void SetOn()
    {
      isOn = true;
    }


    public void SetOff()
    {
      isOn = false;
    }


    public int Read()
    {
      if (isOn == false)
      {
        throw new InvalidOperationException();
      }
      Random random = new Random();
      int temperature = random.Next(-30, 31);
      return temperature;
    }
  }
}