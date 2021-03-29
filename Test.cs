using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_2021
{
    public class Test <T>
    {
        public void Addtest(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }

        public static void Add(T a, T b)
        {
            // Datatype that have to be created on the go(at run time)
            dynamic d1 = a;
            dynamic d2 = b;

            Console.WriteLine(d1 + d2);
        }
        public static void Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;

            Console.WriteLine(d1 - d2);
        }
        public static void Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;

            Console.WriteLine(d1 * d2);
        }
        public static void Div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;

            Console.WriteLine(d1 / d2);
        }
    }
}
