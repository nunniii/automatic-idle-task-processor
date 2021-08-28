using System;
using System.Diagnostics;
using System.Threading; // Para controle de tempo
using System.Runtime.InteropServices; // Para ocultar o console

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automatic_idle_task_processor
{
    static class Program
    {

        static void RunRundll()
        {
            Process.Start(".\\hide.vbs");
        }

        static void ITP()
        {
            while (true)
            {
                RunRundll();
                Thread.Sleep(TimeSpan.FromMinutes(0.5)); // default = 0.5
                Console.WriteLine("i");
            }
        }


        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Aparato para ocultar o console
            [DllImport("kernel32.dll")]
            static extern IntPtr GetConsoleWindow();
            [DllImport("user32.dll")]
            static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
            var handle = GetConsoleWindow();

            // Esconder
            // const int SW_HIDE = 0;
            // ShowWindow(handle, SW_HIDE);

            // Mostrar
            const int SW_SHOW = 5;
            ShowWindow(handle, SW_SHOW);


            Thread core = new Thread(new ThreadStart(ITP));
            core.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
