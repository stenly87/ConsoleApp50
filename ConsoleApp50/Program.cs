using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // тема 6. задание 1
            /*double x1,x2,x3,y1,y2,y3;
            Console.WriteLine("Введите 3 угла х и у");
            double.TryParse(Console.ReadLine(), out x1);
            double.TryParse(Console.ReadLine(), out y1);
            double.TryParse(Console.ReadLine(), out x2);
            double.TryParse(Console.ReadLine(), out y2);
            double.TryParse(Console.ReadLine(), out x3);
            double.TryParse(Console.ReadLine(), out y3);

            double a = МойКрутойМетод(x1, y1, x2, y2);
            double b = МойКрутойМетод(x2, y2, x3, y3);
            double c = МойКрутойМетод(x1, y1, x3, y3);

            double p = P(a, b, c);
            double s = S(a, b, c, p);

            Console.WriteLine($"Площадь: " + s);*/
            Console.WriteLine("рекурсия началась");
            int number = 2;
            Print(number, "");
            Console.WriteLine("рекурсия закончилась");

            Console.WriteLine("то же самое, но без рекурсии, через стек");
            // LIFO - последний вошел, первый вышел
            Stack<(int number, string text)> stack = new Stack<(int, string)>();

            stack.Push((number, ""));
            while (stack.Count > 0)
            {
                var last = stack.Pop();
                if (last.number == 0)
                {
                    Console.WriteLine(last.text);
                }
                else
                {
                    stack.Push((last.number - 1, last.text + "1"));
                    stack.Push((last.number - 1, last.text + "0"));
                }
            }

            test();
            // метод, созданный внутри метода
            // test можно вызвать только в методе Main
            // можно использовать, чтобы не засорять класс 
            // мелкими методами, призванными упростить код
            void test()
            {
                number = 10;
                Console.WriteLine("Main - test");
            }


            // тема 6 задание 10

            long sum = 0;
            for (int i = 1; i < 10; i++)
            {
                sum += Factorial(i);
            }
            Console.WriteLine(sum);

            // то же самое рекурсией:
            sum = 0;
            for (int i = 1; i < 10; i++)
            {
                sum += Factorial2(i);
            }
            Console.WriteLine(sum);
        }

        // рекурсивное вычисление факториала
        static long Factorial2(long number)
        {
            if (number == 1)
                return 1;

            return number * Factorial2(number - 1);
        }

        static long Factorial(int f)
        {
            long result = 1;
            for (int i = 1; i <= f; i++)
                result *= i;
            return result;
        }

        static void Print(int number, string text)
        {
            if (number == 0)
            {
                Console.WriteLine(text);
                return;
            }
            else
            {
                Print(number - 1, text + "0");
                Print(number - 1, text + "1");
            }
        }




        static double МойКрутойМетод(double x1, double y1,
            double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) +
                Math.Pow(y2 - y1, 2));
        }
        // необязательно выносить, т.к. формула используется 1 раз
        static double P(double a, double b, double c)
        {
            return (a + b + c) / 2;
        }
        // необязательно выносить, т.к. формула используется 1 раз
        static double S(double a, double b, double c, double p)
        {
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
