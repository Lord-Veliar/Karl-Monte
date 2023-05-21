using System;
namespace MyApp
{
    internal class Program
    {
        static void karl1()
        {
            int n;
            int k;
            double s, x, y;
            Random rand = new Random();
            k = 0;
            n = 10000000;
            for (int i = 1; i < n; i++)
            {
                x = rand.NextDouble();
                y = rand.NextDouble();

                if (((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= 1)
                {
                    k = k + 1;
                }

            }
            s = 4.0 * k / n;
            Console.Write("Результат pi = ");
            Console.WriteLine(s);
            Console.WriteLine("Точно pi = 3,14");
        }
        static void karl2()
        {
            double a = 8.5, b = 5, x, y, s;
            int n = 100000;
            int k = 0;

            Random rand = new Random();
            for (int i = 1; i < n; i++)
            {
                x = rand.NextDouble() * a;
                y = rand.NextDouble() * b;

                if ((x / 3 < y) && (y < x * (10 - x) / 5))
                {
                    k = k + 1;
                }

            }
            s = a * b * k / n;
            Console.WriteLine(s);
        }
        static void karl3()
        {
            double a = 8.5, b = 5, x, y, s;
            int n = 100000;
            int k = 0;

            Random rand = new Random();
            for (int i = 1; i < n; i++)
            {
                x = rand.NextDouble() * a;
                y = rand.NextDouble() * b;

                if ((x / 2 < y) && ((y < (x * (8 - x)) / 2)))
                {
                    k = k + 1;
                }

            }
            s = a * b * k / n;
            Console.WriteLine(s);
        }
        static void karl4()
        {
            double a = 8.5, b = 5, x, y, s;
            int n = 100000;
            int k = 0;

            Random rand = new Random();
            for (int i = 1; i < n; i++)
            {
                x = rand.NextDouble() * a;
                y = rand.NextDouble() * b;

                if ((6 >y) && ((y > ((x - 6) * (x - 6)) / 6)))
                {
                    k = k + 1;
                }

            }
            s = a * b * k / n;
            Console.WriteLine(s);
        }
        static void karl5()
        {
            double a = 8.5, b = 5, x, y, s;
            int n = 100000;
            int k = 0;

            Random rand = new Random();
            for (int i = 1; i < n; i++)
            {
                x = rand.NextDouble() * a;
                y = rand.NextDouble() * b;

                if ((x / 5 < y) && ((y < (x * (12 - x)) / 9)))
                {
                    k = k + 1;
                }

            }
            s = a * b * k / n;
            Console.WriteLine(s);
        }
        static void karl6()
        {
            double a = 8.5, b = 5, x, y, s;
            int n = 100000;
            int k = 0;

            Random rand = new Random();
            for (int i = 1; i < n; i++)
            {
                x = rand.NextDouble() * a;
                y = rand.NextDouble() * b;

                if (((8 - x) / 8 < y) && ((y < (x * (8 - x)) / 4)))
                {
                    k = k + 1;
                }

            }
            s = a * b * k / n;
            Console.WriteLine(s);
        }
        static void karl7()
        {
            double a = 8.5, b = 5, x, y, s;
            int n = 100000;
            int k = 0;

            Random rand = new Random();
            for (int i = 1; i < n; i++)
            {
                x = rand.NextDouble() * a;
                y = rand.NextDouble() * b;

                if ((((x - 2) * (x - 2)) / 2 > y) && ((y > Math.Sin(x))))
                {
                    k = k + 1;
                }

            }
            s = a * b * k / n;
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            karl1();
            karl2();
            karl3();
            karl4();
            karl5();
            karl6();
            karl7();
        }
    }
}