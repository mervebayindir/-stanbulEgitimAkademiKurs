using System.Globalization;

namespace Math_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Algoritma Örnek 1:
            /*
            1. başla
            2. kullanıcıya yarıçap sorulur ve alınır, çıkış için 0'a basması istenir
            3. kullanıcıya alan (a) veya çevre (ç) hesabı mı yapılacağı sorulur ve alınır 
            4. kullanıcıya Pİ'nin gerçek değeri mi (evet için e) 3.14 değeri mi (hayır için h) kullanılacağı sorulur ve alınır
            5. bir methoda alınan yarıçap, alan (a) veya çevre (ç) hesabı ve Pİ sayısının 3.14 mü gerçek değeri mi kullanılacağı parametreler olarak gönderilir
            6. Pİ'nin gerçek veya 3.14 değerine göre eğer alan (a) hesaplanacaksa dairenin alanı, çevre (ç) hesaplanacaksa dairenin çevresi hesaplanır ve dönülür
            7. dönen sonuç ekrana yazdırılır
            8. 2. adımdan devam edilir, eğer 0 girilirse 9. adıma gidilir
            9. bitiş
            */
            //const double pi=
            double yaricap;
            bool piGercekmi;
            string hesapTipi, piGiris;
            Console.Write("Yarıçap (0:çıkış): ");
            yaricap = Convert.ToDouble(Console.ReadLine(), new CultureInfo("tr-TR"));
            while (yaricap != 0)
            {

                Console.Write("Alan mı (a), çevre mi(ç) :");
                hesapTipi = Console.ReadLine();
                Console.WriteLine("PI 3,14 mü (e : evet, h : hayır):  ");
                piGiris = Console.ReadLine();

                //if (piGiris == "e")
                //{
                //    piGercekmi = false;
                //}

                piGercekmi = Console.ReadLine() == "e" ? false : true;
                //piGercekmi = Console.ReadLine() != "e"; 

                Console.WriteLine((hesapTipi == "a" ? "Alan: " : "Çevre: ") + Hesapla2(yaricap, hesapTipi, piGercekmi));

                Console.Write("Yarıçap (0: çıkış): ");
                yaricap = Convert.ToDouble(Console.ReadLine(), new CultureInfo("tr-TR"));
            }

        }
        static double Hesapla(double yaricap, string tipi, bool piGercekMi = true)
        {
            double sonuc = 0f;
            if (tipi == "a")
            {
                if (piGercekMi)
                {
                    sonuc = Math.PI * Math.Pow(yaricap, 2);
                }
                else
                {
                    sonuc = 3.14 * Math.Pow(yaricap, 2);
                }
            }
            else
            {
                if (piGercekMi)
                {
                    sonuc = 2 * Math.PI * yaricap;
                }
                else
                {
                    sonuc = 2 * 3.14 * yaricap;
                }
            }
            return sonuc;
        }
        static double Hesapla2(double yaricap, string tipi, bool piGercekMi = true)
        {
            double sonuc;
            double pi;
            pi = 3.14;
            //if (piGercekMi)
            //{
            //    pi = Math.PI;
            //}
            pi = piGercekMi ? Math.PI : 3.14;

            //if (tipi != "a")
            //{
            //    sonuc = pi * 2 * yaricap;  // çevre
            //}
            //else
            //{
            //    sonuc = pi * Math.Pow(yaricap, 2); // alan
            //}
            sonuc = tipi != "a" ? pi * 2 * yaricap : pi* Math.Pow(yaricap, 2);
            return sonuc;
        }
    }
}