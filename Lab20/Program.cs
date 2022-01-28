using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        delegate double MyDelegate(double R);
        static void Main(string[] args)
        {
            MyDelegate myDelegate1 =  Length;
            Console.WriteLine(myDelegate1(10) );
            MyDelegate myDelegate2 = Square;
            Console.WriteLine(myDelegate2(10));
            MyDelegate myDelegate3 = Volume;
            Console.WriteLine(myDelegate3(10));
            Console.ReadKey();
        }

        static double Length(double R) => 2 * Math.PI * R;
        static double Square(double R) => Math.PI * Math.Pow(R, 2);
        static double Volume(double R) => 4 / 3 * Math.PI * Math.Pow(R, 3);
    }
}
