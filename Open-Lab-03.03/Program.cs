using NUnitLite;
using System;

namespace Open_Lab_03._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Comparator comp = new Comparator();
            Console.WriteLine(comp.CompareCharactersCount("AB", "CD"));
        }
    }
}
