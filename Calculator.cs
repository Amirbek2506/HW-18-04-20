namespace MyprojecsApp
{
     class Calculator<T>
    {
        private static T Plus(T arg_1, T arg_2)
        {
            return (dynamic)arg_1 + (dynamic)arg_2;
        }
        private static T Minus(T arg_1, T arg_2)
        {
            return (dynamic)arg_1 - (dynamic)arg_2;
        }
        private static T Multiply(T arg_1, T arg_2)
        {
            return (dynamic)arg_1 * (dynamic)arg_2;
        }
        private static T Divide(T arg_1, T arg_2)
        {
            if ((dynamic)arg_2 == 0)
            {
                System.Console.Write($"Ошибка: Деление на нол!!!\t{arg_1} / ");
                return (dynamic)arg_2;
            }
            else return (dynamic)arg_1 / (dynamic)arg_2;
        }
    }
}