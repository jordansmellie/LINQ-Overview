using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Overview
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void NumQuery()
        {
            var numbers = new int[] { 1, 4, 9, 16, 25, 36 };
            var evenNumbers = from p in numbers
                              where (p % 2) == 0
                              select p;
        }
    }
}
