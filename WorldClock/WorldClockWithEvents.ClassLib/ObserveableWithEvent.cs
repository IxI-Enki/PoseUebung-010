namespace WorldClockWithEvents.ClassLib
{
  public abstract class ObserveableWithEvent
  {
    #region FIELDS
    public event EventHandler<EventArgs> Observers;
    #endregion

    protected void NotifyAll(EventArgs e)
    {
      Observers?.Invoke(this , e);
    }

    #region PROPERTIES
    public event EventHandler<EventArgs> Observeable
    {

      add
      {
        lock (this)
        {
          Observers += value;
        }
      }
      remove
      {
        lock (this)
        {
          Observers -= value;
        }
      }
    }
    #endregion
  }
}
