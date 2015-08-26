using System;
using System.Text;

namespace Euler2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint i = 1;
            uint j = 2;
            long s = 2;
            while (j < 4000000)
            {
                uint t = i + j;
                i = j;
                j = t;
                if (t % 2 == 0)
                    s += t;
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
