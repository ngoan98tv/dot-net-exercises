using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication08012020
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("First number:");
            string st = Console.ReadLine();
            x = int.Parse(st);

            Console.Write("Second number:");
            y = int.Parse(Console.ReadLine());

            float tong = x + y;
            Console.WriteLine("Tong {0} va {1} la {2}", x, y, tong);

            Console.WriteLine("Tich {0} va {1} la {2}", x, y, x * y);
            float thuong = (float)x / y;
            Console.WriteLine("Thuong {0} va {1} la {2:0.000}", x, y, thuong);

            Console.ReadLine();

        }
    }
}
