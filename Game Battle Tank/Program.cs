/*
Nama  : Muhammad Ikram Syafwan
NIM   : 2207112599
Kelas : TI-A
*/
using System;

namespace BattleTank
{
    public class SlowWriter
    {
        public static void Write(string text)
        {
            Random rnd = new Random();
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(rnd.Next(20, 60));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int panjangArea = 5;
            char rumput = '~';
            char tank = 't';
            char hit = 'X';
            char miss = 'O';
            int jumlahTank = 3;
            Intro();
            Console.ReadKey();

            char[,] playArea = buatRuang(panjangArea, rumput, tank, jumlahTank);

            print(playArea, rumput, tank);

            int jumlahTankTersembunyi = jumlahTank;
            while (jumlahTankTersembunyi > 0)
            {
                int[] tebakanKoordinat = getKoordinatTebakan(panjangArea);
                char updateTampilanArea = verifikasiTebakan(tebakanKoordinat, playArea, tank, rumput, hit, miss);
                if (updateTampilanArea == hit)
                {
                    jumlahTankTersembunyi--;
                }
                playArea = updateArea(playArea, tebakanKoordinat, updateTampilanArea);
                print(playArea, rumput, tank);
            }
            Console.WriteLine("\nGame Over!");
            Console.ReadKey();
            Outro();
        }
        static void Intro()
        {
            Console.WriteLine("Selamat datang dalam permainan Battle Tank!");
            Console.WriteLine("Pada permainan ini para player akan diminta untuk menebak letak tank.");
            Console.WriteLine("Jumlah tank yang akan ditebak adalah 3 tank.");
            Console.WriteLine("Selamat bermain!");
            Console.WriteLine("=====================================================================\n");
        }
        static void Outro()
        {
            Console.WriteLine("Terimakasih sudah bermain permainan Battle Tank!");
            Console.WriteLine("Sampai jumpa pada project berikutnya!");
            Console.ReadKey();
        }
        private static char[,] buatRuang(int panjangArea, char rumput, char tank, int jumlahTank)
        {
            char[,] ruangan = new char[panjangArea, panjangArea];

            for (int baris = 0; baris < panjangArea; baris++)
            {
                for (int kolom = 0; kolom < panjangArea; kolom++)
                {
                    ruangan[baris, kolom] = rumput;
                }
            }
            return letakkanTank(ruangan, jumlahTank, rumput, tank);
        }
        private static char[,] letakkanTank(char[,] ruangan, int jumlahTank, char rumput, char tank)
        {
            int letakTank = 0;
            int panjangArea = 5;

            while (letakTank < jumlahTank)
            {
                int[] lokasiTank = koordinatTank(panjangArea);
                char posisi = ruangan[lokasiTank[0], lokasiTank[1]];

                if (posisi==rumput)
                {
                    ruangan[lokasiTank[0], lokasiTank[1]] = tank;
                    letakTank++;
                }
            }
            return ruangan;
        }
        private static int[] koordinatTank(int panjangArea)
        {
            Random rnd = new Random();
            int[] koordinat = new int[2];
            for (int i = 0; i < koordinat.Length; i++)
            {
                koordinat[i] = rnd.Next(panjangArea); 
            }
            return koordinat;
        }
        private static void print(char[,] playArea, char rumput, char tank)
        {
            SlowWriter.Write("  ");
            for (int i = 0; i < 5; i++)
            {
                SlowWriter.Write(i + 1 + " ");
            }
            Console.WriteLine();
            for (int baris = 0; baris < 5; baris++)
            {
                SlowWriter.Write(baris + 1 + " ");
                for (int kolom = 0; kolom < 5; kolom++)
                {
                    char posisi = playArea[baris, kolom];
                    if (posisi == tank)
                    {
                        SlowWriter.Write(rumput + " ");
                    } 
                    else
                    {
                        Console.Write(posisi + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        static int[] getKoordinatTebakan(int panjangArea)
        {
            int baris;
            int kolom;

            do
            {
                Console.Write("\nPilih Baris: ");
                baris = Convert.ToInt32(Console.ReadLine());
            } while (baris < 0 || baris > panjangArea + 1);

            do
            {
                Console.Write("Pilih Kolom: ");
                kolom = Convert.ToInt32(Console.ReadLine());
            } while (kolom < 0 || kolom > panjangArea + 1);
            return new[]{baris - 1, kolom - 1};
        }
        static char verifikasiTebakan(int[] tebakan, char[,] playArea, char tank, char rumput, char hit, char miss)
        {
            string pesan;
            int baris = tebakan[0];
            int kolom = tebakan[1];
            char target = playArea[baris, kolom];

            if (target == tank)
            {
                pesan = "Hit!";
                target = hit;
            } 
            else if (target == rumput)
            {
                pesan = "Miss!";
                target = miss;
            }
            else
            {
                pesan = "Clear!";
            }
            Console.WriteLine("====");
            Console.WriteLine(pesan);
            Console.WriteLine("====\n");
            return target;
        }
        static char[,] updateArea(char[,] area, int[] tebakanKoordinat, char updateTampilanArea)
        {
            int baris = tebakanKoordinat[0];
            int kolom = tebakanKoordinat[1];
            area[baris, kolom] = updateTampilanArea;
            return area;   
        }
    }
}