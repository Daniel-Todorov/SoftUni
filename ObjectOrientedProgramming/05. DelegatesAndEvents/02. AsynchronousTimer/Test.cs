//Create a class AsyncTimer that executes a given method each t seconds.
//•	The constructor should accept 3 arguments: 
//Action (a method to be called on every t milliseconds), ticks (the number of times the method should be called) 
//and t (time interval between each tick in milliseconds).
//•	The main program's execution should NOT be paused at any time (use some kind of background execution).

namespace _02.AsynchronousTimer
{
    using System;
    using System.Threading;

    public class AsynchronousTimerClass
    {
        public static void Main(string[] args)
        {
            AsyncTimer timer = new AsyncTimer(RespondMethod, 1000, 50);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Some other action while timer is running...");
                Thread.Sleep(500);
            }

            Console.ReadLine();
        }

        public static void RespondMethod()
        {
            Console.WriteLine(DateTime.Now.TimeOfDay);
        }
    }
}
