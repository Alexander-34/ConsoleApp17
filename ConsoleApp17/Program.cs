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
        interface A
        {
            void Print();
        }
        interface B
        {
            void Print();
        }
        interface C
        {
            void Print();
        }
        class Runnable : A, B, C
        {
            public void Print()
            {
                WriteLine("Runnable");
            }
            void A.Print()
            {
                WriteLine("Runnable A");
            }
            void B.Print()
            {
                WriteLine("Runnable B");
            }
            void C.Print()
            {
                WriteLine("Runnable C");
            }
        }
        static void Main(string[] args)
        {
            A r = new Runnable();
            r.Print();          
            
            ReadKey();
        }
    }
}
