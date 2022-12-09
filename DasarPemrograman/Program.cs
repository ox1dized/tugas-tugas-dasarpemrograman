using System;

namespace DasPro
{
    class Program
    {
      //Main Method
        static void Main(string[] args)
        {
            int kesempatan = 3;
            Intro();
            while (kesempatan > 0)
            {
                PlayGame();
                kesempatan = kesempatan - 1;
            }
            Console.ReadKey();
        }
        static void Intro() 
        {
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server....");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
        }
        static void PlayGame()
        {
            Random rng = new Random();
            int codeA = rng.Next(1, 10);
            int codeB = rng.Next(1, 10);
            int codeC = rng.Next(1, 10);
            const int jumlahKode = 3;
            int tebakanA;
            int tebakanB;
            int tebakanC;

            int hasilTambah = codeA + codeB + codeC;
            int hasilKali = codeA * codeB * codeC;

            Console.WriteLine("Password terdiri dari " + jumlahKode + " angka");
            Console.WriteLine("Jika ditambahkan hasilnya " + hasilTambah);
            Console.WriteLine("Jika dikalikan maka hasilnya " + hasilKali);

            Console.Write("Masukkan Kode Pertama: ");
            tebakanA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Kode Kedua: ");
            tebakanB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Kode Ketiga: ");
            tebakanC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tebakan Anda: " + tebakanA + tebakanB + tebakanC + " ? (y/n)");

            string confirm = Console.ReadLine();
            if(confirm == "y") 
            {
                if(tebakanA == codeA && tebakanB == codeB && tebakanC == codeC) {
                    Console.WriteLine("Tebakan Anda benar!");
                } else {
                    Console.WriteLine("Tebakan Anda salah!");
                    Console.WriteLine("Tebakan yang benar adalah " + codeA + codeB + codeC);
                }
            } else 
            {
                PlayGame();
            }

            Console.ReadKey();
        }
    }
}