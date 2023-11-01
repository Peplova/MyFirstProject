using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject

{
    public static class BankSystem
    {
        public static void ReadFromConsolAndToReturnPomotion()
        {
            NameClientReadFromConsol ();
            int a = AgeClientReadFromConsol ();
            int b = ChisloZakazovReadFromConsol ();
            int c = SummaDenegReadFromConsol ();
            if ((a > 60 && c>1000000) || (b >= 3 && c > 400000))
            { 
                Console.WriteLine("Предоставляется скидка");
            }
            else
            {
                Console.WriteLine("Скидка не предоствляется");
            }
        }

            public static void NameClientReadFromConsol()
        {
            Console.WriteLine("Имя клиента");
            Console.ReadLine();
        }
        public static int AgeClientReadFromConsol ()
        {
            Console.WriteLine("Возраст");
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
        public static int ChisloZakazovReadFromConsol ()
        {
            Console.WriteLine("Количество банковских продуктов");
            int b = Convert.ToInt32(Console.ReadLine());
            return b;
        }
       public static int SummaDenegReadFromConsol()
        {
            Console.WriteLine("Сумма потраченных средств");
            int c = Convert.ToInt32(Console.ReadLine());
            return c;
        }

       public static void CalculateRazmerVkladaAtEndSrokaToReturnConsol ()
        {
            Console.WriteLine("Введите сумму вклада");
            double s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите продолжительность в годах");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите % начисляемый за год");
            int p = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= y; i++)
            {
                s += s / 100 * p;
            }
            Console.WriteLine(s);
        }
        public static void CalculateBanknoteAtmToReturnConsole ()
        {
        int summ = Convert.ToInt32(Console.ReadLine());
        int novayaSumm = 0;
        int b1000 = 0;
        int b500 = 0;
        int b100 = 0;
if (summ<100)
{
    Console.WriteLine("Выдача невозможна");
}
else
{
    novayaSumm = summ;
    while (novayaSumm >= 1000)
    {
        if (novayaSumm/1000 >= 1)
        {
            b1000++;
            novayaSumm = novayaSumm - 1000;
        }
    }
    novayaSumm = summ;
novayaSumm = novayaSumm - b1000 * 1000;
while (novayaSumm >= 500)
{
    if (novayaSumm / 500 >= 1)
    {
        b500++;
        novayaSumm = novayaSumm - 500;
    }
}

novayaSumm = summ;
novayaSumm = novayaSumm - b1000 * 1000 - b500 * 500;
while (novayaSumm >= 100)
{
    if (novayaSumm / 100 >= 1)
    {
        b100++;
        novayaSumm = novayaSumm - 100;
    }
}
    
}
Console.WriteLine($" Вывод купюр по 1000: {b1000}");
Console.WriteLine($" Вывод купюр по 500: {b500}");
Console.WriteLine($" Вывод купюр по 100: {b100}");

    }
}

}
