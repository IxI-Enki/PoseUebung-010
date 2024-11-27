using System;

/// <summary>
///  Beobachter
/// </summary>
public interface IObserver
{
  void Update(object sender , EventArgs e);
}