namespace Calisma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ogrenciAdi;
            double vize2, vize1, final, ortalama;
            const double vize1carpan = 0.2;
            const double vize2carpan = 0.2;
            const double finalCarpan = 0.6;

            Console.Write("Lütfen adınızı giriniz: ");
            ogrenciAdi = Console.ReadLine();

            Console.WriteLine("Vize 1: ");
            vize1 = double.Parse(Console.ReadLine());
            if (vize1 < 0 || vize1 > 100)
            {
                Console.WriteLine("Vize 0 ila 100 arasında olmalıdır");
                Console.WriteLine("Vize 1: ");
                vize1 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Vize 2: ");
            vize2 = Convert.ToDouble(Console.ReadLine());
            if (vize2 < 0 || vize2 > 100)
            {
                Console.WriteLine("Vize 0 ila 100 arasında olmalıdır");
                Console.WriteLine("Vize 2: ");
                vize2 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Final: ");
            final = Convert.ToDouble(Console.ReadLine());
            if (final < 0 || final > 100)
            {
                Console.WriteLine("Final 0 ila 100 arasında olmalıdır");
                Console.WriteLine("Final: ");
                final = double.Parse(Console.ReadLine());
            }

            ortalama = vize1 * vize1carpan + vize2 * vize2carpan + final * finalCarpan;

            if (ortalama >= 60)
                Console.WriteLine($"Öğrenci: {ogrenciAdi}, Geçti (Not: {ortalama})");
            else
                Console.WriteLine("Öğrenci: " + ogrenciAdi + ", Kaldı (Not: " + ortalama + ")");
        }
    }
}