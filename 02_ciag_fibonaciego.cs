using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Podaj ilość wyrazów do wyświetlenia");
        n = inputValue();
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} wyraz ciągu fibonnaciego wynosi {Fibo(i)}");
            }
        }
        else
        {
            Console.WriteLine("Podana wartość nie jest liczbą naturalną dodatnią");
        }
    }

    private static int Fibo(int n)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }
        else
        {
            return Fibo(n - 1) + Fibo(n - 2);
        }

    }
    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

}