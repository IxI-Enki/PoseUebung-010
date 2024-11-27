namespace WorldClockWithInterfaces.ClassLib;

public class DateTimeArgs : EventArgs
{
  private DateTime _dateTime = DateTime.Now;

  public DateTime Time
  {
    get => _dateTime;
  }
}
