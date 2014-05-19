using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace EulerTimer
{
   /// <summary>
   /// This is just a timer that hooks to any running console process so I don't have to implement a timer to everything.
   /// </summary>
   public class Timer
   {
      private readonly Stopwatch stopWatch;

      public Timer()
      {
         stopWatch = Stopwatch.StartNew();
         AppDomain.CurrentDomain.ProcessExit += OnProcessExit;
      }

      private void OnProcessExit(object sender, EventArgs e) 
      {
         Console.WriteLine("[TIMER] Timer stopped, elapsed time: {0} ms", stopWatch.ElapsedMilliseconds);
         System.Threading.Thread.Sleep(5000); // Delay process exit by this time
      }
   }
}
