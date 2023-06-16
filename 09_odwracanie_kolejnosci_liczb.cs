using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("Podaj liczbę do odwrócenia");
        a = inputValue();
        b = odwrocenie(a);
        Console.WriteLine("Liczba " +a+ " po odwróceniu to "+b);
    }
    private static int odwrocenie(int a)
    {
        int b;
        for (b = 0; a != 0; a = a / 10)
        {
            b = b * 10 + a % 10;
        }
        return b;
    }
    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

}