using System;
using MyLib;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum s = new Sum(1,2,3);
            s.PrintSum();

            Dif d = new Dif(10, 5);
            d.PrintDif();
        }
    }
}
