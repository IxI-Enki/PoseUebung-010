using WorldClockWithInterfaces.ClassLib;

namespace WorldClockWithEvents.ClassLib;

public class WorlClockWithEvents : ObserveableWithEvent
{
  #region FIELDS
  private static readonly WorlClockWithEvents _instance;
  #endregion
  #region CONSTRUCTOR
  private WorlClockWithEvents() { }
  static WorlClockWithEvents()
  {
    _instance = new WorlClockWithEvents();
    Start();
  }
  #endregion

  #region PROPERTIES
  public static WorlClockWithEvents Instance { get => _instance; }
  #endregion

  #region METHODS
  private static void Start()
  {
    Thread thread = new(Run)
    {
      IsBackground = true
    };
    thread.Start();
  }
  private static void Run()
  {
    while (true)
    {
      Thread.Sleep(1000);
      Instance.NotifyAll(new DateTimeArgs());
    }
  }
}
#endregion
