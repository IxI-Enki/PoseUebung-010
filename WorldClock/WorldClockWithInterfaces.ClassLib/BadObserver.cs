namespace WorldClockWithInterfaces.ClassLib;

public class BadObserver(int offset , string destination , string rgbColor)
  : ConsoleClock(offset , destination , rgbColor)
{
  public new void Update(object sender , EventArgs e)
  {
    Thread.Sleep(5000);
  }
}
