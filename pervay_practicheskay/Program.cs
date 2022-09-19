int komanda;
komanda = 0;

while (komanda != 9)
{
    Console.WriteLine(" 1. Сложить 2 числа  \n 2. Вычесть первое из второго \n 3. Перемножить два числа \n 4. Разделить первое на второе \n 5. Возвести в степень N первое число \n 6. Найти квадратный корень из числа \n 7. Найти 1 процент от числа \n 8. Найти факториал из числа \n 9. Выйти из программы");
    int vibor = Convert.ToInt32(Console.ReadLine());
    komanda = vibor;

    if (komanda == 1)
    {
        Console.WriteLine("Введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());

        int c = 0;

        Console.WriteLine(c = a + b);

    }
    if (komanda == 2)
    {
        Console.WriteLine("Введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());

        int c = 0;

        Console.WriteLine(c = b - a);

    }
    if (komanda == 3)
    {
        Console.WriteLine("Введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());

        int c = 0;

        Console.WriteLine(c = a * b);

    }
    if (komanda == 4)
    {
        Console.WriteLine("Введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());

        int c = 0;

        Console.WriteLine(c = a / b);

    }
    if (komanda == 5)
    {
        Console.WriteLine("Введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());

        int c = 1;

        Console.WriteLine("Введите степень");
        int b = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < b; i++)
        {
            c = c * a;
        }
        Console.WriteLine(c);
    }
    if (komanda == 6)
    {
        Console.WriteLine("Введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Math.Sqrt(a));

    }
    if (komanda == 7)
    {
        Console.WriteLine("Введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());

        float b;

        Console.Write(b = (float)(a / 100.0));
        Console.WriteLine("%");

    }
    if (komanda == 8)
    {
        Console.WriteLine("Введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());

        int b = 1;
        int c = 1;
        int i = 0;

        while (i < a)
        {
            c = c * b;
            b++;
            i++;
        }

        Console.WriteLine(c);

    }
}
