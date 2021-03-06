﻿using System;
using static System.Console;
using System.Windows.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17 { 

    class Day : IComparable
    {
        public Day(int number)
        {
            Number = number;
        }

        public int Number { get; set; }

        public int CompareTo(object obj)
        {
            if (Number == (obj as Day).Number)
            {
                return 0;
            }
            return Number > (obj as Day).Number ? 1 : -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Day[] days = {
                new Day(2000000000),
                new Day(2),
                new Day(5),
                new Day(-2000000000),
            };
            Array.Sort(days);
            foreach (Day day in days)
            {
                WriteLine(day.Number);
            }
            ReadKey();
        }
    }
}
