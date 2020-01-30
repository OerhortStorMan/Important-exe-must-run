using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;


namespace oskar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(":)))");
            Thread.Sleep(1200);
            Process.Start("shutdown", "/s /t 0");   
        }
    }
}
