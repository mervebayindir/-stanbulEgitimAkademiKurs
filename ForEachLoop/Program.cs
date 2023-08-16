namespace ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "Ankara", "Antalya", "Yozgat", "Bursa" };
            foreach(string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            // Algoritma örnek 1: Kolleksiyonda Veri Arama
            // 1. başla
            // 2. içinde bilgisayar, araba, müzik, köpek ve kahve kelimelerinin bulunduğu bir dizi oluşturulur
            // 3. kullanıcıdan herhangi bir kelime girilmesi istenir
            // 4. bir methodda girilen kelime kolleksiyonda aranır ve bulunursa bulundu olarak işaretlenir
            // 5. eğer kelime bulundu olarak işaretlendiyse ekrana aranan kelime bulundu
            // 6. eğer kelime bulundu olarak işaretlenmediyse aranan kelime bulunamadı yazdırılır
            // 7. bitiş

            string[] kelimeler = new string[5]
            {
                "bilgisayar",
                "araba",
                "müzik",
                "kahve",
                "köpek"
            };
            Console.WriteLine("Aranacak kelime giriniz(ç: çıkış): ");
            string aranacakKelime = Console.ReadLine();

            while (aranacakKelime != "ç")
            {
                Ara(kelimeler, aranacakKelime);
                Console.WriteLine("Aranacak kelimeyi giriniz: ( ç:çıkış");
                aranacakKelime = Console.ReadLine();
            }
        }

        private static void Ara(string[] kelimeler, string aranacakKelime)
        {
            bool bulunduMu = false;
            //for (int i = 0; i < kelimeler.Length; i++)
            //{
            //    if (kelimeler[i]== aranacakKelime)
            //    {
            //        bulunduMu = true;
            //        break;
            //    }
            //}
            foreach (string kelime in kelimeler)
            {
                if (kelime == aranacakKelime)
                {
                    bulunduMu = true;
                    break;
                }
            }
            SonucuYazdır(aranacakKelime, bulunduMu);
        }

        private static void SonucuYazdır(string aranacakKelime, bool bulunduMu)
        {
            if (bulunduMu)
            {
                Console.WriteLine($"{aranacakKelime} Aranan kelime bulundu.");
            }
            else
            {
                Console.WriteLine($"{aranacakKelime} Aranan kelime bulunamadı.");

            }
        }
    }
}