using System;

namespace MyprojecsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator<double> Operation = new Calculator<double>();
            while (true)
            {
                Console.Write("Аргумент_1: "); double arg_1= double.Parse(Console.ReadLine());
                Console.Write("Аргумент_2: "); double arg_2 = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Выберите действия(+ , - , * , / , e); e-выход");
                switch (Console.ReadLine())
                {
                    case "+":
                        {
                            Console.WriteLine(Operation.OpPlus(arg_1, arg_2));
                        }
                        break;
                    case "-":
                        {
                            Console.WriteLine(Operation.OpMinus(arg_1, arg_2));
                        }
                        break;
                    case "*":
                        {
                            Console.WriteLine(Operation.OpMultiply(arg_1, arg_2));
                        }
                        break;
                    case "/":
                        {
                            Console.WriteLine(Operation.OpDivide(arg_1, arg_2));
                        }
                        break;
                    case "e":
                        {
                            return;
                        }
                }
            }
        }
    }
}
