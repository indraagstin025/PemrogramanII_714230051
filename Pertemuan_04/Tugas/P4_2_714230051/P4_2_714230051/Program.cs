using System;

namespace LifePathCalculator
{
    public abstract class Numerology
    {
        private int hari;
        private int bulan;
        private int tahun;

        public int Hari
        {
            get { return hari; }
            set { hari = value; }
        }

        public int Bulan
        {
            get { return bulan; }
            set { bulan = value; }
        }

        public int Tahun
        {
            get { return tahun; }
            set { tahun = value; }
        }

        protected Numerology(int hari, int bulan, int tahun)
        {
            Hari = hari;
            Bulan = bulan;
            Tahun = tahun;
        }

        public abstract int CalculateLifePathNumber();
    }

    public class LifePathCalculator : Numerology
    {
        public LifePathCalculator(int hari, int bulan, int tahun) : base(hari, bulan, tahun)
        {
        }

        public override int CalculateLifePathNumber()
        {
            int hariSum = SumToSingleDigit(Hari);
            int bulanSum = SumToSingleDigit(Bulan);
            int tahunSum = SumToSingleDigit(Tahun);

            int totalSum = hariSum + bulanSum + tahunSum;
            return SumToSingleDigit(totalSum);
        }

        private int SumToSingleDigit(int number)
        {
            while (number > 9 && number != 11 && number != 22 && number != 33)
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                number = sum;
            }
            return number;
        }

        public string GetLifePathDescription(int lifePathNumber)
        {
            if (lifePathNumber == 1)
                return "Inovasi dan Kepemimpinan: Kamu adalah orang yang mandiri dan cenderung menjadi pemimpin.";
            else if (lifePathNumber == 2)
                return "Kerjasama dan Keseimbangan: Kamu punya kemampuan luar biasa dalam menjaga hubungan dan diplomasi.";
            else if (lifePathNumber == 3)
                return "Ekspresi dan Sensitivitas: Kamu adalah jiwa seni yang penuh kreativitas dan ekspresi.";
            else if (lifePathNumber == 4)
                return "Kerja Keras dan Disiplin: Kamu sangat terorganisir, praktis, dan penuh dedikasi.";
            else if (lifePathNumber == 5)
                return "Kebebasan dan Petualangan: Kamu adalah jiwa petualang yang selalu mencari kebebasan dan pengalaman baru.";
            else if (lifePathNumber == 6)
                return "Kasih Sayang dan Tanggung Jawab: Kamu adalah orang yang penuh kasih dan selalu merawat orang yang kamu sayangi.";
            else if (lifePathNumber == 7)
                return "Analisis dan Intuisi: Kamu punya kemampuan analisis yang tajam dan intuisi yang kuat.";
            else if (lifePathNumber == 8)
                return "Kekuatan dan Kesuksesan: Kamu ditakdirkan untuk sukses besar, baik secara material maupun spiritual.";
            else if (lifePathNumber == 9)
                return "Kemanusiaan dan Altruisme: Kamu memiliki empati yang besar dan selalu ingin memberikan kontribusi positif bagi banyak orang.";
            else if (lifePathNumber == 11)
                return "Penerangan dan Spiritualitas: Kamu adalah inspirasi bagi banyak orang dengan wawasan yang mendalam.";
            else if (lifePathNumber == 22)
                return "Master Builder: Kamu memiliki potensi besar untuk menciptakan perubahan besar di dunia.";
            else if (lifePathNumber == 33)
                return "Guru yang Penuh Kasih: Kamu memiliki pengaruh yang besar dalam menyebarkan kebaikan dan cinta kasih.";
            else
                return "Deskripsi tidak tersedia.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool ulangi = true;

            while (ulangi)
            {
                Console.Clear();
                Console.WriteLine("==== Kalkulator Life Path Number ====");
                Console.WriteLine("Masukkan tanggal lahir Anda (format: dd mm yyyy):");

                string[] input = Console.ReadLine().Split(' ');

                if (input.Length == 3 &&
                    int.TryParse(input[0], out int hari) &&
                    int.TryParse(input[1], out int bulan) &&
                    int.TryParse(input[2], out int tahun))
                {
                    LifePathCalculator calculator = new LifePathCalculator(hari, bulan, tahun);
                    int lifePathNumber = calculator.CalculateLifePathNumber();
                    string description = calculator.GetLifePathDescription(lifePathNumber);

                    Console.WriteLine($"\nLife Path Number Anda adalah: {lifePathNumber}");
                    Console.WriteLine(description);

                    Console.WriteLine("\nApakah Anda ingin menghitung lagi?");
                    Console.WriteLine("Ketik 'yes' untuk menghitung lagi atau 'no' untuk keluar.");
                    string pilihan = Console.ReadLine().Trim().ToLower();

                    if (pilihan == "no")
                    {
                        ulangi = false;
                        Console.WriteLine("Terima kasih telah menggunakan Kalkulator Life Path Number!");
                    }
                }
                else
                {
                    Console.WriteLine("Input tidak valid. Pastikan format yang Anda masukkan adalah 'dd mm yyyy'.");
                    Console.WriteLine("Tekan Enter untuk mencoba lagi.");
                    Console.ReadLine();
                }
            }
        }
    }
}
