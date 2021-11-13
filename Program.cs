using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interchanging_two_no
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7, b = 3, temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Values after swapping are:");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
        }
    }
}
