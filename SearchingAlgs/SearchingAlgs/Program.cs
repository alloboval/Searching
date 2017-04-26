using SearchingAlgs.Algs;
using System;

namespace SearchingAlgs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 123, 543, 654, 34, 645, 75, 234, 98, 23, 1, 5658, 980, 56, 231, 6, 35, 8, 923, 68, 34 };
            LineSearch.Search(a, 5658);
            Console.WriteLine(LineSearch.positionX);
            Console.ReadKey();
        }
    }
}
