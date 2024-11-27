using WorldClockWithEvents.ClassLib;

namespace WorldClockWithEvents.ConApp;

internal class Program
{
  static void Main()
  {
    Console.WriteLine(" WORLDCLOCK ");

    WorlClockWithEvents.Instance.Observers += (s , e) => Console.WriteLine("Test - Ausgabe");

    Console.ReadLine();
  }
}
