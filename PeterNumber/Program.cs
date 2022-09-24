using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long result = PNumber(11235888);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static long PNumber(int N)
        {
            long lastDigit = 9;
            long index = 0;
            for (long i = 1; i <= 1000000000000000000; i *= 10)
            {
                long digit = N / i % 10;
                if (digit == 0 && (N / i == 0)) break;
                if (digit > lastDigit)
                {
                    lastDigit = digit - 1;
                    index = i;
                }
                else
                {
                    lastDigit = digit;
                }
            }
            if (index == 0)
                return N;
            return N / index * index - 1;
        }
    }
}
