using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c = 1, d = 0, losowa = 0;
        Random generator = new Random();
        Console.WriteLine("Podaj początek przedziału");
        a = inputValue();
        Console.WriteLine("Podaj koniec przedziału");
        b = inputValue();
        while (c != 0)
        {
            losowa = generator.Next(a, b);
            Console.WriteLine("Czy liczba o której myślisz to " +losowa+" ?");
            d = inputValue();
            if (d < 0)
            {
                b = losowa - 1;
            }
            else if (d > 0)
            {
                a = losowa + 1;
            }
            else if (d == 0)
            {
                c = 0;
            }
        }
        Console.WriteLine("Czyli liczba, o której myślałeś to " +losowa);
    }

    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

}