using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714230051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angka1;
            int angka2;
            double penjumlahan = 0, pengurangan = 0, perkalian = 0;
            double pembagian = 0;

            Console.Write("Masukkan Angka Pertama : ");
            angka1 = double.Parse(Console.ReadLine());
            Console.Write("Masukkan Angka Kedua : ");
            angka2 = int.Parse(Console.ReadLine());

           
            penjumlahan = angka1 + angka2;
            Console.WriteLine("{0} + {1} = {2}", angka1, angka2, penjumlahan);

            
            pengurangan = angka1 - angka2;
            Console.WriteLine("{0} - {1} = {2}", angka1, angka2, pengurangan);

           
            perkalian = angka1 * angka2;
            Console.WriteLine("{0} * {1} = {2}", angka1, angka2, perkalian);

            
            pembagian = (double)angka1 / angka2;
            Console.WriteLine("{0} / {1} = {2}", angka1, angka2, pembagian);
        }
    }
}
