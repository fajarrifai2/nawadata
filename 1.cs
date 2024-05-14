using System;
using System.Linq;

class Program
{
    static int HitungJumlahKata(string kalimat)
    {
        string[] kata = kalimat.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return kata.Length;
    }

    static void Main(string[] args)
    {
        Console.Write("Masukkan sebuah kalimat: ");
        string kalimat = Console.ReadLine();

        int jumlahKata = HitungJumlahKata(kalimat);
        Console.WriteLine($"Jumlah kata dalam kalimat tersebut adalah: {jumlahKata}");
    }
}
