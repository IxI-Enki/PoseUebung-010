using WorldClockWithInterfaces.ClassLib;

namespace WorldClockWithInterfaces.ConApp;

internal class Program
{
  static void Main()
  {
    Console.WriteLine(" WORLDCLOCK ");


    ConsoleClock c1 = new(0 , "Vienna" , "0;200;100");
    ConsoleClock c2 = new(0 , "London" , "0;100;100");
    ConsoleClock c3 = new(0 , "Tokio" , "120;100;0");

    BadObserver b = new(0 , "Tokio" , "120;100;0");

    WorldClock.Instance.AddObserver(c1);
    WorldClock.Instance.AddObserver(c2);
    WorldClock.Instance.AddObserver(c3);

    // ADD A "BAD OBSERVER" FOR TESTING:
    //     WorldClock.Instance.AddObserver(b);

    Console.ReadLine();
  }
}
