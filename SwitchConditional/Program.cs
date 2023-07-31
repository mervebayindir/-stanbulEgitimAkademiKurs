namespace SwitchConditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1.başla             DÜZENLE
            2.1.sayı al
            3.2. sayı al
            4.işlem al
            5.hesaplama methodu üzerinden işelmi yap ve dön
            6.methoddan dönen sonuç ile birlikte 1. sayı, işlem ve 2. sayıyı yazdır.
            7.bitiş
             */
            double sonuc;
            Console.Write("1.sayı: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2.sayı: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İslem: (+:toplam, -:Çıkarma, x:çarpma, /:bölme");
            string islem = Console.ReadLine();
            if (islem == string.Empty)  // ""
            {
                Console.WriteLine("İşlem boş girilemez!");
            }
            else
            {
                double islemSonucu = Hesapla(sayi1, sayi2, islem);
                Console.WriteLine($"{sayi1} {islem} = {islemSonucu}");
            }


        }

        static double Hesapla(double sayi1, double sayi2, string islem)
        {
            double sonuc = 0;
            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "x":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem!");
                    break;
            }
            return sonuc;
        }
    }
}