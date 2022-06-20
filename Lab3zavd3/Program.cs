using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3zavd3
{

    class Program
    {

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { -5, -4, -2, 3, -1 };

            int minNumber = numbers.Select(num => num > 0).FirstOrDefault();

            //var result = minNumber == int.MaxValue ? 0 : minNumber;
            Console.WriteLine("Min Positive Number = " + minNumber);

        }
    }
}