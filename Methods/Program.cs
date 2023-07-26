namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adSoyad;   //camel Case
            Console.WriteLine("Hello, World!");

            DisplayHello();  //invoke
            string  sonuc = MerhabaGetir();
            Console.WriteLine(sonuc + "!");

            IkiSayiTopla(3, 5);

            int no1 = -10;
            int no2 = 20;
            IkiSayiTopla(no1, no2);

            //double result = IkiSayiCarp(1.23f, -5.5);
            //Console.WriteLine(result);
            Console.WriteLine(IkiSayiCarp(1.23f,-5.5));

        }

        static void DisplayHello()  // Pascal case, implementasyon
        {
            Console.WriteLine("Hello!");
        }

        static string MerhabaGetir()
        {
            string sonuc;
            sonuc = "Merhaba";
            return sonuc;
        }
        static void IkiSayiTopla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + toplam);
        }

        static double IkiSayiCarp(float f1, double m2)
        {
            return f1 * m2;

        }
    }
}