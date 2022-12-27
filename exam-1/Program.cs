using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите желаемое значение N");
            var N = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат:");

            var res = prc(N - 1);

            foreach (var i in res)
            {
                switch (i)
                {
                    case 1:
                        Console.Write("a");
                        break;
                    case 2:
                        Console.Write("b");
                        break;
                    case 3:
                        Console.Write("c");
                        break;
                    case 4:
                        Console.Write("d");
                        break;
                    case 5:
                        Console.Write("e");
                        break;
                    case 6:
                        Console.Write("f");
                        break;
                    case 7:
                        Console.Write("g");
                        break;
                    case 8:
                        Console.Write("h");
                        break;
                    case 9:
                        Console.Write("i");
                        break;
                    case 10:
                        Console.Write("j");
                        break;
                    case 11:
                        Console.Write("k");
                        break;
                    case 12:
                        Console.Write("l");
                        break;
                }
            }
            Console.ReadKey();
        }
        public static int factorial(int num1)
        {
            var ex = 1;
            if (num1 != 0)
                for (var i = 1; i < num1 + 1; i++)
                    ex *= i;
            else return 1;
            return ex;
        }

        public static int[] prc(int num2)
        {
            var X1 = num2;
            var ex = new int[13];
            var free = new bool[13]
                {true, true, true, true, true, true,true, true,true,true,true,true, true,};
            for (var i = 1; i < 13; i++)
            {
                var fact = factorial(12 - i);
                var num_prc = X1 % fact;
                X1 = X1 % fact;
                var ct = 0;
                for (var j = 1; j < 13; j++)
                {
                    if (free[j])
                    {
                        ct += 1;
                        if (ct - 1 == num_prc)
                        {
                            free[j] = false;
                            ex[i] = j;
                        }
                    }
                }

            }
            return ex;
        }
    }
}
