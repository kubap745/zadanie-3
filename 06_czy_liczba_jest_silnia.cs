using System;
using System.Security.Cryptography.X509Certificates;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int n, k;
        Console.WriteLine("Podaj liczbę naturalną");
        n = inputValue();
        k = test(n);
        if (k == 0)
        {
            Console.WriteLine("Liczba " +n+ " nie jest silnią żadnej liczby");
        }
        else
        {
            Console.WriteLine("Liczba " + n + " jest silnią liczby" +k);
        }
    }

    static int test(int z)
    {
        int x = 1;
        if (z == 0)
        {
            x = 0;
        }
        else
        {
            for (int i = 1; i != 0; i++)
            {
                Console.WriteLine("elo");
                if (z % i == 0)
                {
                    Console.WriteLine(z / i);
                    z = z / i;
                    x = i;
                }
                else
                {
                    if (z == 1)
                    {
                        i = -1;
                    }
                    else
                    {
                        i = -1;
                        x = 0;
                    }
                }
            }
        }
        return x;
    }
    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

}