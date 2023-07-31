namespace TernaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RandomOlmadanYazim();

            Random();

        }

        private static void RandomOlmadanYazim()
        {
            //string sonuc;
            int para = 1; // 1:tura, 0:yazı
            Console.Write("Yazı (y) mı tura(t) mı: ");
            string kullaniciGirisi = Console.ReadLine();
            //int giris = Console.ReadLine() == "y" ? 0 : 1
            int giris = kullaniciGirisi == "y" ? 0 : kullaniciGirisi == "t" ? 1 : -1; // x, a, ali:-1
            if (giris == -1)
            {
                Console.WriteLine("Lütfen y veya t giriniz.");
            }
            else
            {
                //sonuc = giris == para ? "Tebrikler bildiniz" : "Bilemediniz"; 1 seçenek
                Console.WriteLine(giris == para ? "Tebrikler bildiniz" : "Bilemediniz"); // 2. seçenektedeki gibi de yazılabilir
            }
        }

        private static void Random()
        {
            Random rastgele = new Random();
            int para = rastgele.Next(0,2); // burada 0 ve 1 degerlerini kullanır 2'yi o yüzden yazdık // 1:tura, 0:yazı
            Console.Write("Yazı (y) mı tura(t) mı: ");
            string kullaniciGirisi = Console.ReadLine();
            //int giris = Console.ReadLine() == "y" ? 0 : 1
            int giris = kullaniciGirisi == "y" ? 0 : kullaniciGirisi == "t" ? 1 : -1; // x, a, ali:-1
            if (giris == -1)
            {
                Console.WriteLine("Lütfen y veya t giriniz.");
            }
            else
            {
                //sonuc = giris == para ? "Tebrikler bildiniz" : "Bilemediniz"; 1 seçenek
                Console.WriteLine(giris == para ? "Tebrikler bildiniz" : "Bilemediniz"); // 2. seçenektedeki gibi de yazılabilir
            }
        }
    }
}