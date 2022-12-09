using System;

namespace DasPro
{
    class Program
    {
      //Main Method
      static void Main(string[] args)
        {
            //Mengganti warna tulisan cmd
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            //Deklarasi variabel
            const int codeA = 1;
            const int codeB = 2;
            const int codeC = 3;
            const int jumlahKode = 3;
            int tebakanA;
            int tebakanB;
            int tebakanC;

            int hasilTambah = codeA + codeB + codeC;
            int hasilKali = codeA * codeB * codeC;

            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("Password terdiri dari " + jumlahKode + " angka");
            Console.WriteLine("Jika ditambahkan hasilnya " + hasilTambah);
            Console.WriteLine("Jika dikalikan maka hasilnya " + hasilKali);

            Console.Write("Masukkan Kode Pertama: ");
            tebakanA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Kode Kedua: ");
            tebakanB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Kode Ketiga: ");
            tebakanC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tebakan Anda: " + tebakanA + tebakanB + tebakanC);

            if(tebakanA == codeA && tebakanB == codeB && tebakanC == codeC) {
                Console.WriteLine("Tebakan Anda benar!");
            } else {
                Console.WriteLine("Tebakan Anda salah!");
            }

            Console.ReadKey();
        }
    }
}
