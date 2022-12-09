using System;

namespace UTSDasPro
{
    class Program
    {
        static void Main(string[] args)
        {
            int tebakanAngkaPlayer = 0;
            Random rnd = new Random();
            int angkaRandom = rnd.Next(1, 101);
            while (tebakanAngkaPlayer != angkaRandom)
            {
                Console.WriteLine("Tebak angka antara 1-100: ");
                tebakanAngkaPlayer = Convert.ToInt32(Console.ReadLine());
                if (tebakanAngkaPlayer < angkaRandom)
                {
                    Console.WriteLine("Salah. Angka terlalu rendah");
                } 
                else if (tebakanAngkaPlayer > angkaRandom)
                {
                    Console.WriteLine("Salah. Angka terlalu tinggi");
                }
                else
                {
                    Console.WriteLine("Selamat! Anda berhasil menebak angka!");
                    Console.ReadKey();
                }
            }
        }
    }
}