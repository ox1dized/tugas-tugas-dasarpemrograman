using System;

namespace UTSDasPro
{
    class Program
    {
        static int skorMenang = 0;
        static int skorKalah = 0;
        static int skorSeri = 0;
        static char userInput = ' ';
        static int computerInput;
        static void Main(string[] args)
        {
            Console.WriteLine("Selamat datang pada permainan Suit!");
            Console.ReadKey();
            Console.Clear();
            IntiGame();
        }
        static void IntiGame()
        {
            Random rnd = new Random();
            while (userInput != 'e')
            {
                Console.WriteLine("Pilihlah salah satu dari option berikut:");
                Console.WriteLine("(b) Batu");
                Console.WriteLine("(g) Gunting");
                Console.WriteLine("(k) Kertas");
                Console.WriteLine("(e) Keluar");
                Console.Write("Masukkan pilihan anda: ");
                userInput = Convert.ToChar(Console.ReadLine());

                if (userInput == 'e')
                {
                    Console.WriteLine("Selamat Tinggal...");
                    Console.ReadKey();
                    break;
                }
                computerInput = rnd.Next(1, 4);
                if (userInput == 'b')
                {
                    if (computerInput == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Hasil suit adalah seri!");
                        skorSeri++;
                    }
                    else if (computerInput == 2)
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Selamat kamu menang!");
                        skorMenang++;
                    }
                    else if (computerInput == 3)
                    {
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Maaf kamu kalah!");
                        skorKalah++;
                    }
                }
                else if (userInput == 'g')
                {
                    if (computerInput == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Maaf kamu kalah!");
                        skorKalah++;
                    }
                    else if (computerInput == 2)
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Hasil suit adalah seri!");
                        skorSeri++;
                    }
                    else if (computerInput == 3)
                    {
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Selamat kamu menang!");
                        skorMenang++;
                    }
                }
                else if (userInput == 'k')
                {
                    if (computerInput == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Selamat kamu menang!");
                        skorMenang++;
                    }
                    else if (computerInput == 2)
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Maaf kamu kalah!");
                        skorKalah++;
                    }
                    else if (computerInput == 3)
                    {
                        Console.WriteLine ("Komputer memilih kertas");
                        Console.WriteLine("Hasil suit adalah seri!");
                        skorSeri++;
                    }
                }
                Console.WriteLine("Skor kamu : {0} - {1} - {2}", "Menang: " + skorMenang, "Seri: " + skorSeri, "Kalah: " + skorKalah);
                Console.WriteLine("Tekan Enter untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}