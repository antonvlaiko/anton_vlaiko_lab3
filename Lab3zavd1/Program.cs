using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3zavd1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, -10, 2, 18 };
            var indexOfMin = numbers.IndexOf(numbers.Max());
            var indexOfMax = numbers.IndexOf(numbers.Min());

            var c = numbers[indexOfMax];
            numbers[indexOfMax] = numbers[indexOfMin];
            numbers[indexOfMin] = c;

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
