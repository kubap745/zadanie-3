using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, i, wynik;

        Console.WriteLine("Podaj podstawe potegi");
        a = inputValue();
        Console.WriteLine("Podaj wykładnik potęgi");
        b = inputValue();
        wynik = 1;
        for (i = 1; i <= b; i++)
        {
            wynik = wynik * a;
        }
        Console.WriteLine("Wynik podniesienia " + a + " do potęgi " + b + " wynosi " + wynik);
    }

    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
