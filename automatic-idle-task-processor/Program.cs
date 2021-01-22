using System;
using System.Diagnostics;
using System.Threading; // Para controle de tempo

using System.Runtime.InteropServices; // Para ocultar o console

namespace automatic_idle_task_processor
{
    class Program
    {
        static void RunRundll()
        {
            Process.Start(".\\hide.vbs");
        }

        static void Main(string[] args)
        {
            // Aparato para ocultar o console
            [DllImport("kernel32.dll")]
            static extern IntPtr GetConsoleWindow();
            [DllImport("user32.dll")]
            static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
            var handle = GetConsoleWindow();

            // Esconder
            const int SW_HIDE = 0;
            ShowWindow(handle, SW_HIDE);

            // Mostrar
            // const int SW_SHOW = 5;
            // ShowWindow(handle, SW_SHOW);


            while(true)
            {
                RunRundll();
                Thread.Sleep(TimeSpan.FromMinutes(0.5)); // default = 0.5
                Console.WriteLine("i");

                
            }
        }
    }
}
