using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_714230051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.Write(" Menentukan Index Prestasi Mahasiswa \n");
                Console.Write(" \n Masukkan Nama Mahasiswa : ");

                String nama = Console.ReadLine();

                Console.WriteLine("Masukkan Nilai : ");

                int nilai = Convert.ToInt16(Console.ReadLine());
                String[] grade = {"A", "B", "C", "D"};

                if (nilai >= 85)
                {
                    Console.WriteLine("Index dari nilai {0} adalah {1}", nama, grade[0]);
                }
                else if (nilai >= 70 && nilai < 85)
                {
                    Console.WriteLine("Index dari nilai {0} adalah {1}", nama, grade[1]);
                }
                else if (nilai >= 60 && nilai < 70)
                {
                    Console.WriteLine("Index dari nilai {0} adalah {1}", nama, grade[2]);
                }
                else
                {
                    Console.WriteLine("Index dari nilai {0} adalah {1}", nama, grade[3]);
                }

                Console.Write("\n Masukkan Index Yang Ditampilkan : ");
                char indeks = Convert.ToChar(Console.ReadLine());
                Console.Write("Index Prestasi {0} adalah ", nama);

                prestasi(indeks);

                Console.Write("\n Ingin Mengulang Kembali (Y/N) ?");
            }

            while (Console.ReadLine() == "Y");
        }

        private static void prestasi(char indeks)
        {
            switch (indeks)
            {
                case 'A':
                    Console.WriteLine("Sangat Baik");
                    break;
                case 'B':
                    Console.WriteLine("Baik");
                    break;
                case 'C':
                    Console.WriteLine("Cukup");
                    break;
                case 'D':
                    Console.WriteLine("Buruk");
                    break;
                default:
                    Console.WriteLine("Indeks Prestasi Tidak Ada");
                    break;
            }
        }
    }
}
