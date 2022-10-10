using System;

namespace MyLib
{
    public class Sum
    {
        int x;
        int y;
        int z;

        public Sum(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void PrintSum()
        {
            double r = x + y + z;
            Console.WriteLine($"Задача №1: {x}+{y}+{z}\nРешение: {r}");
        }
    }
}
