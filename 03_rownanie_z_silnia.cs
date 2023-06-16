using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int n, k;
        Console.WriteLine("Podaj pierwszą liczbę naturlaną większą od 5");
        n = inputValue();
        Console.WriteLine("Podaj drugą liczbę naturlaną większą od 5");
        k = inputValue();
        if (n > 5 && k > 5)
        {
            double m = (sil(n) - sil(k)) / sil(k);
            Console.WriteLine("Wartość m wynosi "+ m);
        }
        else
        {
            Console.WriteLine("Jedna z podanych wartości nie jest liczbą większą od 5");
        }
    }

    private static int sil(int z)
    {
        for (int i = z; i > 1; i--)
        {
            z = z * (i - 1);
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