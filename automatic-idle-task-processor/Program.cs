using System;
using System.Diagnostics;
using System.Threading;


namespace automatic_idle_task_processor
{
    class Program
    {
        static void RunRundll()
        {
            Process.Start(".\\rundll32.bat");
        }

        static void Main(string[] args)
        {
            while(true)
            {
                RunRundll();
                Thread.Sleep(TimeSpan.FromMinutes(0.5));
            }
        }
    }
}
