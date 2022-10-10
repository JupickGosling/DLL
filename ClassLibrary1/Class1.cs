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
    public class Dif
    {
        int x;
        int y;

        public Dif(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void PrintDif()
        {
            double r = x / y;
            Console.WriteLine($"Задача №2: {x}/{y}\nРешение: {r}");
        }
    }
}

