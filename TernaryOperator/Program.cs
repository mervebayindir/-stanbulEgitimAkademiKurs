namespace TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TernaryKullanim1();

            string ad = null;
            if (ad is null) //(ad == null)
            {
                Console.WriteLine("Ad boştur");
            }
            else
            {
                Console.WriteLine(ad);
            }

            string isimSonuc;
            string isim = "merve";
            if (isim is null)
            {
                isimSonuc = "Ad boştur";
            }
            else
            {
                isimSonuc = isim;
            }
            Console.WriteLine(isimSonuc);

            isimSonuc = ad == null ? "Ad boştur" : ad;
            Console.WriteLine(isimSonuc);

            isimSonuc = ad ?? "Ad boştur";
            Console.WriteLine(isimSonuc);

            //TernarKullanim2();

            Console.Write("Sayı: ");
            string input = Console.ReadLine(); // ?? "" Boş olma ihtimaline karşı
            if (input == "")
            {
                Console.WriteLine("sayı girilmelidir");
            }
            else
            {
                int number = Convert.ToInt32(input);
                if (TekMi(number))
                {
                    Console.WriteLine("Tek");
                }
                else
                {
                    Console.WriteLine("Çift");
                }
            }

        }

        private static bool TekMi(int no)
        {
            //if (no % 2 == 0)
            //    return false;
            //return true;
            return no % 2 == 0 ? false : true;
        }


        private static void TernarKullanim2()
        {
            Console.Write("Sayı: ");
            string input = Console.ReadLine(); // ?? "" Boş olma ihtimaline karşı
            if (input == "")
            {
                Console.WriteLine("sayı girilmelidir");
            }
            else
            {
                int number = Convert.ToInt32(input);
            }

        }

        private static void TernaryKullanim1()
        {
            Console.Write("Sayı: ");
            short sayi = Convert.ToInt16(Console.ReadLine());
            string sonuc = sayi > 0 ? "pozitif" : sayi < 0 ? "negatif" : "nötr";
            Console.WriteLine(sonuc);
        }
    }
}