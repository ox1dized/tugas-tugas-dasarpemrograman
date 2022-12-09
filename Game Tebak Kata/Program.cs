/*
Nama  : Muhammad Ikram Syafwan
NIM   : 2207112599
Kelas : Teknik Informatika - A
*/
using System;
using System.Collections.Generic;

namespace TebakKata
{
    public class SlowWriter
    {
        public static void Write(string text)
        {
            Random rnd = new Random();
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(rnd.Next(20, 40));
            }
        }
    }
    class Program
    {
        static int kesempatan = 5;
        static string kataRahasia = "indie";
        static List<string> hurufTebakan = new List<string>{};
        static void Main(string[] args)
        {
            Intro();
            MulaiMain();
            selesaiMain();
        }

        static void Intro()
        {
            SlowWriter.Write("Selamat datang dalam permainan Tebak Kata.\n");
            SlowWriter.Write("Pada Permainan ini, para player akan menebak kata rahasia.\n");
            SlowWriter.Write($"Setiap player memiliki {kesempatan} kesempatan.\n");
            SlowWriter.Write("Petunjuk untuk tebak kata adalah kata ini merupakan genre musik.\n");
            SlowWriter.Write($"Kata Rahasia ini terdiri dari {kataRahasia.Length} huruf.\n");
            SlowWriter.Write("Selamat bermain!\n");
            Console.ReadKey();
        }

        static string cekHuruf(string Kata, List<string> List)
        {
            string letakKata = "";
            for (int i = 0; i < Kata.Length; i++)
            {
                string sisaKata = Convert.ToString(Kata[i]);
                if(List.Contains(sisaKata))
                {
                    letakKata += sisaKata;
                }
                else
                {
                    letakKata += "_";
                }
            }
            return letakKata;
        }

        static bool cekJawaban(string Kata, List<string> List)
        {
            bool letakKata = false;
            for (int i = 0; i < Kata.Length; i++)
            {
                string sisaKata = Convert.ToString(Kata[i]);
                if (List.Contains(sisaKata))
                {
                    letakKata = true;
                }
                else
                {
                    return letakKata = false;
                }
            }
            return letakKata;
        }

        static void MulaiMain()
        {
            while(kesempatan > 0)
            {
                Console.Write("\nApa karakter tebakanmu? (a-z): ");
                string input = Console.ReadLine().ToLower();
                hurufTebakan.Add(input);

                if(cekJawaban(kataRahasia, hurufTebakan))
                {
                    Console.WriteLine("Selamat, Player berhasil menebak Kata Rahasia!");
                    Console.WriteLine($"Kata Rahasianya adalah: {kataRahasia}.");
                    break;
                }
                else if(kataRahasia.Contains(input))
                {
                    Console.WriteLine($"Huruf {input} ada di dalam Kata Rahasia.");
                    Console.WriteLine(cekHuruf(kataRahasia, hurufTebakan));
                    Console.WriteLine("Silahkan melanjutkan untuk menebak.");
                }
                else
                {
                    Console.WriteLine("Maaf, kata yang anda input tidak ada di dalam Kata Rahasia.");
                    kesempatan--;
                    Console.WriteLine($"Kesempatan player untuk menebak tersisa {kesempatan}.");
                }
            }
        }

        static void selesaiMain()
        {
            if(kesempatan == 0)
            {
                Console.WriteLine("Maaf kesempatan player telah habis.");
                Console.WriteLine($"Kata Rahasia yang dimaksud adalah {kataRahasia}.");
            }
            Console.WriteLine("Terimakasih sudah bermain!");
            Console.ReadKey();
        }
    }
}