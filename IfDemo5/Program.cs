namespace IfDemo5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BaslikYaz();

            double boy = Giris("Boy (m) giriniz:");
            double kilo = Giris("Kilo (kg) giriniz: ");
            double endeks= EndeksHesapla(boy, kilo);
            Console.WriteLine($"Endeks: {endeks} ");
            HesapSonucunuYazdır(endeks);
        }

        static void HesapSonucunuYazdır(double endeks)
        {
            Console.Write("Vücut Kütle Endeksiniz: ");
            if (endeks<18)
            {
                Console.Write("Zayıf");
            }
            else if(endeks>=18 && endeks<25)
            {
                Console.Write("Normal");
            }
            else if(endeks>=25 && endeks<30)
            {
                Console.Write("Kilolu");
            }
            else if (endeks>=30 && endeks<35)
            {
                Console.Write("Obez");
            }
            else
            {
                Console.Write("Ultra obez");
            }
        }

        static double EndeksHesapla(double boy, double kilo)
        {
            double sonuc = (boy * boy) / kilo;
            return sonuc;
        }

        static double Giris(string mesaj)
        {
            Console.Write(mesaj);
            double giris = Convert.ToDouble(Console.ReadLine());
            return giris;
        }

        static void BaslikYaz()
        {
            Console.WriteLine("*** Vücut Kitle Endeksi Hesaplama  ***");
        }
    }
}