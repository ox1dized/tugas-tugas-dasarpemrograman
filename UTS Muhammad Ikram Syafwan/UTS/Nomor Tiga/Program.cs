using System;

namespace UTSDasPro
{
    class Program
    {
        static int dendaTelat = 0;
        static int hariTelat = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan jumlah hari peminjaman buku perpustakaan: ");
            hariTelat = Convert.ToInt32(Console.ReadLine());
            Algoritma();
            Console.ReadKey();
        }
        static void Algoritma()
        {
            if (hariTelat > 30)
            {
                dendaTelat = (hariTelat - 30) * 30000 + 50000 + 400000;
                Console.WriteLine("Denda Telat: " + dendaTelat);
                Console.WriteLine("Keanggotaan perpustakaan dibatalkan.");
            }
            else if (hariTelat > 10)
            {
                dendaTelat = (hariTelat - 10) * 20000 + 50000;
                Console.WriteLine("Denda Telat: " + dendaTelat);
            }
            else if (hariTelat > 5)
            {
                dendaTelat = hariTelat * 10000;
                Console.WriteLine("Denda Telat: " + dendaTelat);
            }
            else
            {
                Console.WriteLine("Tidak ada denda.");
            }
        }
    }
}