namespace MyprojecsApp
{
    class Calculator<T>
    {
        public delegate T DelCalculator(T arg_1, T arg_2);
        public DelCalculator OpPlus = Plus;
        public DelCalculator OpMinus = Minus;
        public DelCalculator OpMultiply = Multiply;
        public DelCalculator OpDivide = Divide;
        private static T Plus(T arg_1, T arg_2)         //Вызов методов происходит только по средством делегата. по этому private
        {
            System.Console.Write($"{arg_1} + {arg_2} = ");
            return (dynamic)arg_1 + (dynamic)arg_2;
        }
        private static T Minus(T arg_1, T arg_2)
        {
            System.Console.Write($"{arg_1} - {arg_2} = ");
            return (dynamic)arg_1 - (dynamic)arg_2;
        }
        private static T Multiply(T arg_1, T arg_2)
        {
            System.Console.Write($"{arg_1} * {arg_2} = ");
            return (dynamic)arg_1 * (dynamic)arg_2;
        }
        private static T Divide(T arg_1, T arg_2)
        {
            if ((dynamic)arg_2 == 0)
            {
                System.Console.Write($"Ошибка: Деление на нол!!!\t{arg_1} / ");
                return (dynamic)arg_2;
            }
            else
            {
                System.Console.Write($"{arg_1} / {arg_2} = ");
                return (dynamic)arg_1 / (dynamic)arg_2;
            }
        }
    }
}