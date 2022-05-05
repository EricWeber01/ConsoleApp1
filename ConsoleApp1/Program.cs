using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Message(string m, int c, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine(m);
            }
            Console.ResetColor();
        }
        //--------------------------------------------------------------------
        static int Sum(int x, int y) => x + y;
        static int Min(int x, int y) => x - y;
        static int Mult(int x, int y) => x * y;
        static int Div(int x, int y)
        {
            if (y != 0)
                return x / y;
            else
                throw new DivideByZeroException();
        }
        //--------------------------------------------------------------------
        static bool IsOdd(int num)
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }
        static bool IsSimple(int num)
        {
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;

                }
            }
            return true;
        }
        static bool IsFibonacci(int x)
        {
            double X1 = 5 * Math.Pow(x, 2) + 4;
            double X2 = 5 * Math.Pow(x, 2) - 4;
            long X1_sqrt = (long)Math.Sqrt(X1);
            long X2_sqrt = (long)Math.Sqrt(X2);
            if ((X1_sqrt * X1_sqrt == X1) || (X2_sqrt * X2_sqrt == X2))
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Action<string, int, ConsoleColor> messageShow;
            messageShow = Message;
            messageShow("Green Message", 3, ConsoleColor.Green);
            Console.WriteLine("");
            messageShow("Red Message", 2, ConsoleColor.Red);
            Func<int, int, int>[] Calc = new Func<int, int, int>[4] { Sum, Min, Mult, Div };
            foreach (var item in Calc)
            {
                Console.WriteLine($"10 {item.Method.Name} 5 = {item(10, 5)}");
            }
            Predicate<int>[] checkNum = new Predicate<int>[] { IsOdd, IsSimple, IsFibonacci };
            Console.WriteLine($"(IsOdd)checkNum[0](2) - {checkNum[0](3)}");
            Console.WriteLine($"(IsSimple)checkNum[1](11) - {checkNum[1](11)}");
            Console.WriteLine($"(IsFibonacci)checkNum[2](8) - {checkNum[2](8)}");
            DateInterface d = new DateInterface(6, 4, 2020);
            d.Show();
            d.CheckDate();
        }
    }
}
