using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3sem_lab1
{
    class Program
    {
        private static double readfromconsole(string var_name)
        {
            double temp;

            Console.WriteLine(" Введите {0}:", var_name);
            while (!double.TryParse(Console.ReadLine(), out temp))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Введено неправильно. Повторите ввод!");
                Console.ResetColor();
            }
            return temp;
        }

        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                
                Console.WriteLine("Дума Эмилия ИУ5-32Б\n");
                Console.WriteLine("ax^2+bx+c=0");
                double a=0, b=0, c=0;
                double D = 0, x=0, x1=0, x2=0;
                a = readfromconsole("a");
                b = readfromconsole("b");
                c = readfromconsole("c");
                Console.WriteLine("Вы ввели уравнение: {0}x^2+{1}x+{2}=0", a, b, c);

                if (a == 0 && b == 0 && c == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Деление на ноль.");
                    Console.ResetColor();
                    Console.ReadLine();
                    return 0;
                }
                
                D = b * b - 4 * a * c;
                
                if (D > 0) 
                {
                    x1 = (-b+Math.Sqrt(D))/(2*a);
                    x2 = (-b-Math.Sqrt(D))/(2*a);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nДва корня:\nx1 = {0}\nx2 = {1}", x1, x2);
                    Console.ResetColor();
                }
                else if (D == 0) 
                {
                    x = (-b) / (2 * a);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nОдин корень:\nx1 = {0}\b", x);
                    Console.ResetColor();
                }
                else if (D < 0) 
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Корней нет.");
                    Console.ResetColor();
                }
                Console.ReadLine();
            }
            return 0;
        }
    }
}