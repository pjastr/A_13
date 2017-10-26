using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_13
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 99; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
