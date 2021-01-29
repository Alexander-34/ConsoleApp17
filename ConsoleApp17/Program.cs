using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        interface IRunnable
        {
            int A { get; set; }
            int this[int i] { get; set; }
        }
        class Runnable : IRunnable
        {
            public int this [int i] { get; set; }
        }
        static void Main(string[] args)
        {
            ReadKey();
        }
    }
}
