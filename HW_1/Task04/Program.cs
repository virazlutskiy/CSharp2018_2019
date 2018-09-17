using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            double U, R;
            Console.Write("Введите U:");
            input = Console.ReadLine(); ;

            while (!double.TryParse(input, out U))
            {
                Console.WriteLine("Вы ввели неверное значение для U. Попробуйте снова.");
                Console.Write("Введите U:");
                input = Console.ReadLine();
            }
            Console.Write("Введите R:");
            input = Console.ReadLine(); ;
            while (!double.TryParse(input, out R) || R == 0)
            {
                Console.WriteLine("R не может быть равное 0 или вы ввели неверное значение для R. Попробуйте снова.");
                Console.Write("Введите R:");
                input = Console.ReadLine();
            }
            Console.WriteLine("P=" + (U * U / R));
            Console.ReadKey();
        }
    }
}
