using System;

namespace UTSDasPro
{
    class Program
    {
        static string namaMahasiswa;
        static string nimMahasiswa;
        static string konsentrasiMahasiswa;
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan Nama Mahasiswa: ");
            namaMahasiswa = Console.ReadLine();
            Console.WriteLine("Masukkan NIM Mahasiswa: ");
            nimMahasiswa = Console.ReadLine();
            Console.WriteLine("Masukkan Konsentrasi Mahasiswa: ");
            konsentrasiMahasiswa = Console.ReadLine();

            NametagPrint();
            Console.ReadKey();
        }
        static void NametagPrint()
        {
            Console.WriteLine("Berikut adalah nametag anda: \n");
            Console.WriteLine("|*********************************|");
            Console.WriteLine("{0,-8} {1,26}", "|Nama:", namaMahasiswa+"|");
            Console.WriteLine("{0,-17} {1,17}", "|", nimMahasiswa+"|");
            Console.WriteLine("|---------------------------------|");
            Console.WriteLine("{0,-1} {1,33}", "|", konsentrasiMahasiswa+"|");
            Console.WriteLine("|*********************************|");
        }
    }
}