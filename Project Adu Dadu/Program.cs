using System;

namespace AduDadu
{
    class Program
    {
        static int angkaDaduComp;
        static int angkaDaduPlayer;
        static int Ronde = 0;
        static int compPoint = 0; 
        static int playerPoint = 0;
        static void Main(string[] args)
        {
            Console.Title = "AduDadu";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Intro();
            Inti();
            Outro();
        }
        static int RandomNumberGen()
        {
            Random rng = new Random();
            int rnum = rng.Next(1,7);
            return rnum;
        }
        static void Intro()
        {
            Console.WriteLine("ADU DADU\n");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Selamat datang dalam permainan Adu Dadu!");
            Console.WriteLine("Pada permainan Adu Dadu ini player akan berlawanan dengan komputer");
            Console.WriteLine("Permainan ini terdiri dari 10 Ronde");
            Console.WriteLine("Setiap ronde para player dan komputer akan melempar satu buah dadu");
            Console.WriteLine("Player/Komputer dengan point terbanyak setelah 10 ronde akan memenangkan permainan");
            Console.WriteLine("----------------------------------------------------------------------------------\n");
        }
        static void Inti()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nTekan key apa saja untuk memulai permainan...\n");
                Console.ReadKey();

                Ronde++;
                angkaDaduComp = RandomNumberGen();
                angkaDaduPlayer = RandomNumberGen();
                Console.WriteLine("Ronde " + Ronde);
                Console.WriteLine("Komputer melempar dadu dan mendapatkan angka " + angkaDaduComp + ".");
                Console.ReadKey();
                Console.Write("...");
                System.Threading.Thread.Sleep(1000);
                Console.Write("\b\b\b\b");
                Console.WriteLine("Player melempar dadu dan mendapatkan angka " + angkaDaduPlayer + ".");

                if(angkaDaduPlayer > angkaDaduComp)
                {
                    playerPoint++;
                    Console.WriteLine("\nPlayer memenangkan ronde " + Ronde + "!\n");
                } 
                else if(angkaDaduPlayer < angkaDaduComp) 
                {
                    compPoint++;
                    Console.WriteLine("\nKomputer memenangkan ronde " + Ronde + "!\n");
                }
                else
                {
                    Console.WriteLine("\nRonde " + Ronde + " berakhir seri!\n");
                }
                Console.WriteLine("Point Player saat ini: " + playerPoint + " || Point Komputer saat ini: " + compPoint);
                Console.WriteLine("------------------------------------------------------");
                Console.ReadKey();
            }
            if (playerPoint > compPoint)
            {
                Console.WriteLine("\n-----------------------------------------------");
                Console.WriteLine("Selamat, player memenangkan permainan Adu Dadu!");
                Console.WriteLine("-----------------------------------------------\n");

            } 
            else if (playerPoint < compPoint)
            {
                Console.WriteLine("\n----------------------------------------");
                Console.WriteLine("Komputer memenangkan permainan Adu Dadu!");
                Console.WriteLine("----------------------------------------\n");

            }
            else
            {
                Console.WriteLine("\n---------------------------------");
                Console.WriteLine("Permainan Adu Dadu berakhir seri!");
                Console.WriteLine("---------------------------------\n");
            }
            Console.ReadKey();
        }
        static void Outro()
        {
            Console.WriteLine("\nTerimakasih telah memainkan permainan ini!");
            Console.WriteLine("Dibuat oleh.");
            Console.WriteLine("Nama  : Muhammad Ikram Syafwan");
            Console.WriteLine("Prodi : Teknik Informatika");
            Console.WriteLine("NIM   : 2207112599");
            Console.ReadKey();
        }
    }        
}