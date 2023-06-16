using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int x, n;
        decimal wynik;
        Console.WriteLine("Podaj wartość x");
        x = inputValue();
        Console.WriteLine("Podaj wartość n");
        n = inputValue();
        wynik = szereg(x, n);
        Console.WriteLine("Liczba eulera podniesiona do potęgi " +x+ " wynosi " +wynik);
    }
    static decimal szereg(int x, int n)
    {
        decimal wynik = 0;
        for (int i = 0; i <= n; i++)
        {
            wynik = wynik + (decimal)(Math.Pow(x, i) / sil(i));
        }
        return wynik;
    }
    static int sil(int z)
    {
        if (z == 0)
        {
            z = 1;
        }
        else
        {
            for (int i = z; i > 1; i--)
            {
                z = z * (i - 1);
            }
        }
        return z;
    }
    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

}