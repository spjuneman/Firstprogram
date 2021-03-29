using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            //double c = Convert.ToDouble(Console.ReadLine());
            //double d = Convert.ToDouble(Console.ReadLine());

            Test<int> t1 = new Test<int>();
            t1.Addtest(a, b);
            Test<int>.Add(a, b);
            Test<int>.Sub(a, b);
            Test<int>.Mul(a, b);
            Test<int>.Div(a, b);
            Console.ReadLine();
        }

        public static bool Compare<T>(T a, T b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }   
}
