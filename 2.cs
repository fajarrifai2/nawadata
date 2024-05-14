using System;

class Program
{
    static int CariAngkaTerbesar(int[] angka)
    {
        int angkaTerbesar = angka[0];

        for (int i = 1; i < angka.Length; i++)
        {
            if (angka[i] > angkaTerbesar)
            {
                angkaTerbesar = angka[i];
            }
        }

        return angkaTerbesar;
    }

    static void Main(string[] args)
    {
        int[] angka = { 1, 5, 3, 7, 2 };

        int angkaTerbesar = CariAngkaTerbesar(angka);
        Console.WriteLine($"Angka terbesar dalam array adalah: {angkaTerbesar}");
    }
}
