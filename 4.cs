using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static char CariHurufTerbanyak(string kata)
    {
        kata = kata.ToLower();

        Dictionary<char, int> frekuensiHuruf = new Dictionary<char, int>();

        foreach (char huruf in kata)
        {
            if (frekuensiHuruf.ContainsKey(huruf))
            {
                frekuensiHuruf[huruf]++;
            }
            else
            {
                frekuensiHuruf[huruf] = 1;
            }
        }

        char hurufTerbanyak = frekuensiHuruf.OrderByDescending(x => x.Value).First().Key;

        return hurufTerbanyak;
    }

    static void Main(string[] args)
    {
        Console.Write("Masukkan sebuah kata: ");
        string kata = Console.ReadLine();

        char hurufTerbanyak = CariHurufTerbanyak(kata);
        Console.WriteLine($"Huruf yang paling sering muncul dalam kata '{kata}' adalah: '{hurufTerbanyak}'");
    }
}
