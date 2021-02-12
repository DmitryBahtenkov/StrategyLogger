using System;

namespace StrategyLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator(new ConsoleLogger());
            Console.WriteLine("Введите первое число: ");
            var first = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите первое число: ");
            var second = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите действие: ");
            var action = Console.ReadLine();
            switch (action)
            {
                case "/":
                    calculator.CalculateDivide(first, second);
                    break;
            }
        }
    }
}