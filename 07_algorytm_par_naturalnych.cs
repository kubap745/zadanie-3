using System;
using System.Security.Cryptography.X509Certificates;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Podaj liczbę naturalną");
        n = inputValue();
        Console.WriteLine("Pary liczb naturalnych tworzące " +n+ " to:");
        wypis(n);

    }

    private static int wypis(int z)
    {
        int x = z;
        for (int i = 1; (z - i) != 0; i++)
        {
            x = z - i;
            Console.WriteLine(i +". "+ x +" i "+ i);
        }
        return 1;
    }
    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

}