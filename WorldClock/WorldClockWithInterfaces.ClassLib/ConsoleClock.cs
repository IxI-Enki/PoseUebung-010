namespace WorldClockWithInterfaces.ClassLib;

public class ConsoleClock(int offset , string destination , string rgbColor) : IObserver
{
  private int _offset = offset;
  private string _location = destination;
  private string _rgbColor = rgbColor;

  public string TextColor => $"\u001b[38;2;{_rgbColor}m";
  public string RGBColor => _rgbColor;

  public void Update(object sender , EventArgs e)
  {
    if (e is DateTimeArgs args)
    {
      Console.Write($"{TextColor}{_location}: {args.Time.AddHours(_offset)} \u001b[0m\n");
    }
  }
}
