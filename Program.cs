using System;
using System.IO;
using System.Linq;

namespace laba6
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = File.ReadAllLines("input.txt").Select(int.Parse);

            
            var sortedNumbers = numbers.OrderBy(x => x);

            
            File.WriteAllLines("output.txt", sortedNumbers.Select(x => x.ToString()));
        }
    }
}
