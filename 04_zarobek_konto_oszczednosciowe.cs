using System;

public class MyProgram
{
    static void Main()
    {
        decimal kwota_poczotkowa, oprocentowanie, kwota_zarobiona;
        int lm;
        Console.WriteLine("Podaj kwotę początkową");
        kwota_poczotkowa = inputValue();
        Console.WriteLine("Podaj oprocentowanie w skali roku");
        oprocentowanie = inputValue();
        Console.WriteLine("Podaj liczbę miesięcy oszczędzania");
        lm = int.Parse(Console.ReadLine());

        kwota_zarobiona = Math.Round(Zarobek(kwota_poczotkowa, oprocentowanie, lm),2);

        Console.WriteLine("Kwota zarobiona (z uwzględnieniem podatku Belki) wynosi "+ kwota_zarobiona);
    }

    static decimal Zarobek(decimal kwota_poczotkowa, decimal oprocentowanie_miesieczne, int lm)
    {
        decimal oprocentowanie_miesieczne = oprocentowanie / 12 / 100;
        decimal kwota_zarobiona = kwota_poczotkowa * (decimal)Math.Pow(1 + (double)oprocentowanie_miesieczne, lm);

        kwota_zarobiona = kwota_zarobiona - (decimal)(0.19 * (double)(kwota_zarobiona - kwota_poczotkowa));

        return kwota_zarobiona;
    }

    private static decimal inputValue()
    {
        decimal result;
        while (!decimal.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
