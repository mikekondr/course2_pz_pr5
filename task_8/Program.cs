using task_8_lib;

namespace task_8;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Яку кількість ТВ необхідно ввести? ");
        int im = 0; int.TryParse(Console.ReadLine(), out im);
        if (im == 0) System.Environment.Exit(0);
        TV[] TVs = new TV[im];

        for (int i = 0; i < im; i++)
        {
            Console.WriteLine($"\n\n\tВведіть дані ТВ №{i+1}");
            Console.Write("Виробник: "); string? v = Console.ReadLine();
            Console.Write("Модельний ряд: "); string? s = Console.ReadLine();
            Console.Write("Модель: "); string? m = Console.ReadLine();
            Console.Write("Серійний номер: "); string? sn = Console.ReadLine();
            decimal d = getDecimal("Діагональ екрану: ");
            decimal p = getDecimal("Ціна телевізора: ");

            Console.Write("Чи має ТВ приймач Т2? (y - так, n - ні): ");
            ConsoleKeyInfo t = Console.ReadKey();
            Console.WriteLine();
            Console.Write("Чи має ТВ вхід HDMI? (y - так, n - ні): ");
            ConsoleKeyInfo h = Console.ReadKey();

            TVs[i] = new TV(v, s, m, sn, d,
                (h.Key == ConsoleKey.Y), (t.Key == ConsoleKey.Y), p);
        }

        Console.WriteLine("\n\n");
        Console.WriteLine("Інформація про ТВ:\n");
        foreach (TV tv in TVs)
        {
            Console.WriteLine(tv.fullInfo + '\n');
        }
    }

    private static decimal getDecimal(string s)
    {
        decimal d = 0;
        while (d == 0)
        {
            Console.Write(s);
            string? str = Console.ReadLine();
            decimal.TryParse(str, out d);
            if (d == 0 || d < 0)
            {
                Console.WriteLine("ПОМИЛКА! Значення може бути тільки " +
                    "раціональним числом більше нуля у вигляді десяткового дробу!");
            }
        }
        return d;
    }
}

