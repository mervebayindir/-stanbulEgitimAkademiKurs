namespace MethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaslikYaz();
            Yazdir("Bugun günlerden Çarşamba");

            double piSayisi = GetPi();
            //Console.WriteLine("PI Sayısı: " + piSayisi);

            Console.WriteLine("PI Sayısı: " + GetPi());

            int radius = 2;
            double area = DaireAlanHesapla(radius);
            Console.WriteLine($"Dairenin alanı: {area}");

            string ad = "Merve";
            string soyad = "Bayındır";
            string kurum = "Apple";
            ad = "Leo";
            Console.WriteLine(ad, soyad, kurum);

            string sonuc = KurumaGorePersonelGetir("Merve", "Bayındır", "Microsoft");
            Console.WriteLine(sonuc);

            Console.WriteLine(KurumaGorePersonelGetir(ad, soyad, kurum));


            DepartmanaGoreCalisanGetir("Zümra", "Bayındır");
            DepartmanaGoreCalisanGetir("Zümra", "Bayındır", "Microsoft", "CEO");
        }

        static string KurumaGorePersonelGetir(string ad, string soyad, string kurum = "Microsoft")  //default değerler en sondan başlayarak yazılır.
        {
            return "Personel: " + ad + " " + soyad + ", Kurum: " + kurum;
        }

        static void BaslikYaz()
        {
            Console.WriteLine("Methodlar Demo");
        }
        static void Yazdir(string mesaj)
        {
            mesaj = "Mesaj: " + mesaj;
            Console.WriteLine(mesaj);
        }
        static double GetPi()
        {
            //double pi;
            //pi = 3.14;
            //return pi;

            return 3.14;
        }
        static double DaireAlanHesapla(int yariçap)
        {
            //double alan;
            //double pi = GetPi();
            //alan = pi * yariçap * yariçap;
            //return alan;
            //Console.WriteLine("Alan: " + alan);
            return GetPi() * yariçap * yariçap;
        }
        static void DepartmanaGoreCalisanGetir(string ad, string soyad, string kurum = "Migros", string departman = "Satış")
        {
            string sonuc =ad + " " + soyad + " (" + kurum + " - " + departman + ")";
            string sonuc2 = $"{ad} {soyad} ({kurum} - {departman})";
            Console.WriteLine(sonuc);
        }
    }
}