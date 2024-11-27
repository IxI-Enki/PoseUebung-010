namespace WorldClockWithInterfaces.ClassLib;

public abstract class Subject
{
  private readonly List<IObserver> _observers = [ ];

  public void AddObserver(IObserver observer)
  {
    lock (this)
      if (!_observers!.Contains(observer))
        _observers.Add(observer);
  }

  public void RemoveObserver(IObserver observer)
  {
    lock (this)
      _observers!.Remove(observer);
  }

  protected void NotifyAll(EventArgs e)
  {
    lock (this)
      foreach (var observer in _observers!)
        Task.Run(() => observer.Update(this , e));
  }
}
