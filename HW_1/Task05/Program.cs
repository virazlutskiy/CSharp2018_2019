using System;


namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            double x, y, z;
            do
            {
                Console.Write("Катет 1:");
                input = Console.ReadLine();
                while (!double.TryParse(input, out x) || x <= 0)
                {
                    Console.WriteLine("Вы ввели неверное значение для первого катета. Попробуйте снова.");
                    Console.Write("Катет 1:");
                    input = Console.ReadLine();
                }
                Console.Write("Катет 2:");
                input = Console.ReadLine();
                while (!double.TryParse(input, out y) || y <= 0)
                {
                    Console.WriteLine("Вы ввели неверное значение для второго катета. Попробуйте снова.");
                    Console.Write("Катет 2:");
                    input = Console.ReadLine();
                }
                z = Math.Sqrt(x * x + y * y);
                if ((x + y < z) || (x + z < y) || (y + z < x))
                {
                    Console.WriteLine("Такой треугольник не существует, попробуйте снова.");
                }
            }
            while ((x + y < z) || (x + z < y) || (y + z < x));
            Console.WriteLine("Гипотенуза=" + z);
            Console.ReadKey();
        }
    }
}
