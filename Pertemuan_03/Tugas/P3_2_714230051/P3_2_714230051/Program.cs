using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714230051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ulang = true;

            while (ulang)
            {
                Console.WriteLine("=== Menu Persegi Panjang ===");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.WriteLine("Pilih Menu (1-3) : ");

                int pilihan = int.Parse(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                        hitungLuas();
                        break;
                    case 2:
                        hitungKeliling();
                        break;
                    case 3:
                        ulang = false;
                        Console.WriteLine("Program Selesai");
                        break;
                    default:
                        Console.WriteLine("Menu Tidak Tersedia");
                        Console.WriteLine("Silahkan Anda Pilih Menu Yang Valid");
                        break;
                }

                if (ulang)
                {
                    Console.Write("Ingin Mengulang Kembali (Y/N) : ");
                    if (Console.ReadLine().ToUpper() != "Y")
                    {
                        ulang = false;
                        Console.WriteLine("Terima Kasih");
                    }
                }
            }
            
            Console.ReadKey();
        }

        static void hitungLuas()
        {
            Console.Write("Masukkan Panjang : ");
            double panjang = double.Parse(Console.ReadLine());
            Console.Write("Masukkan Lebar : ");
            double lebar = double.Parse(Console.ReadLine());

            double luas = panjang * lebar;

            Console.WriteLine("Luas Persegi Panjang adalah " + luas);
        }

        static void hitungKeliling()
        {
            Console.Write("Masukkan Panjang : ");
            double panjang = double.Parse(Console.ReadLine());
            Console.Write("Masukkan lebar : ");
            double lebar = double.Parse(Console.ReadLine());

            double keliling = 2 * (panjang + lebar);

            Console.WriteLine("Keliling Persegi Panjang adalah " + keliling);
        }
    }
}
