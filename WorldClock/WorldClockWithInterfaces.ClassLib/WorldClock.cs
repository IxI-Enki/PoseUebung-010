namespace WorldClockWithInterfaces.ClassLib;

public class WorldClock : Subject
{
  #region FIELDS
  private static readonly WorldClock _instance;
  #endregion
  #region CONSTRUCTOR
  private WorldClock() { }
  static WorldClock()
  {
    _instance = new WorldClock();
    Start();
  }
  #endregion

  #region PROPERTIES
  public static WorldClock Instance { get => _instance; }
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
  #endregion
}
