using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);

            myTimer.Elapsed += MyTimerOnElapsed;
            myTimer.Elapsed += MyTimerOnElapsed1;

            myTimer.Start();

            Console.WriteLine("Press enter to remove the red event.");
            Console.ReadLine();

            myTimer.Elapsed -= MyTimerOnElapsed;

            Console.ReadLine();
        }

        private static void MyTimerOnElapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Elapsed1: {0:HH:mm:ss.fff}", e.SignalTime);
        }


        private static void MyTimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}",e.SignalTime);
        }
    }
}
