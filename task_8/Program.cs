namespace task_8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\tВведіть дані ТВ");
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
        
        TV myTV = new TV(v, s, m, sn, d,
            (h.Key == ConsoleKey.Y), (t.Key == ConsoleKey.Y), p);

        Console.WriteLine("\n\n");
        Console.WriteLine("Інформація про ТВ:");
        Console.WriteLine(myTV.getFullName());
        Console.WriteLine(myTV.getDescription());
        Console.WriteLine($"Ціна за дюйм: {myTV.getPricePerInch()}");
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

