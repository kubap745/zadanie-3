using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("Podaj liczbę naturalną (co najmniej 3 cyfrową) ");
        a = inputValue();
        Console.WriteLine("Liczba "+ a +" składa się z cyfr:");
        b = odwrocenie(a);
    }
    private static int odwrocenie(int a)
    {
        int b, c = a, d = 0;
        for (b = 0; c != 0; c = c / 10)
        {
            b++;
        }
        while (b != 0)
        {
            d = (int)(a / (int)Math.Pow(10, b - 1));
            a = a - (d * (int)Math.Pow(10, b - 1));
            b--;
            Console.WriteLine(d);
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