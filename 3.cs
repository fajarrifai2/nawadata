using System;

class Program
{
    static void UrutkanAngka(int[] angka)
    {
        int n = angka.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (angka[j] > angka[j + 1])
                {
                    int temp = angka[j];
                    angka[j] = angka[j + 1];
                    angka[j + 1] = temp;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        int[] angka = { 3, 1, 5, 2, 4 };

        UrutkanAngka(angka);
        Console.WriteLine("Array setelah diurutkan: " + string.Join(", ", angka));
    }
}
