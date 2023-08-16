using System.Globalization;

namespace DateTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DateTime stilleri
            DateTime simdi = DateTime.Now;
            Console.WriteLine(simdi);

            simdi = DateTime.Today; // bir yerde sadece tarihe ulaşmak gerekınce kullanılır saat kısmı sıfır olarak gelır saat yok yanı
            Console.WriteLine(simdi);

            simdi = DateTime.Now.Date; // tarih kullanımı today gıbı aynıdır
            Console.WriteLine(simdi);

            DateTime tarih1 = new DateTime(2022, 08, 21);
            Console.WriteLine(tarih1); // 21.08.2022  00:00:00

            DateTime tarih2 = new DateTime(2022, 11, 21, 18, 23, 04);
            Console.WriteLine(tarih2.ToString("MM/dd/yyyy HH:mm:ss", new CultureInfo("en-Us")));
            Console.WriteLine(tarih2.ToString("MM/dd/yyyy", new CultureInfo("en-Us")));

            DateTime tarih3 = new DateTime(2022, 11, 21, 18, 35, 54, 548);
            string tarih3Yazi = tarih3.Year + "-" + tarih3.Month + "-" + tarih3.Day + " " + tarih3.Hour + ":" + tarih3.Minute + tarih3.Second + "." + tarih3.Millisecond;
            Console.WriteLine(tarih3Yazi);

            Console.WriteLine(tarih3.ToShortDateString());  // 21.11.2022
            Console.WriteLine(tarih3.ToLongDateString());   // 21 Kasım 2022 Pazartesi
            Console.WriteLine(tarih3.ToShortTimeString());  // 18:35
            Console.WriteLine(tarih3.ToLongTimeString());   // 18:35:41


            // Türkçe format  => gün.ay.yıl  Tr
            // İngilizce format => ay.gün.yıl  En
            // yıl-ay-gun => SQL
            DateTime tarih4 = DateTime.Parse("23.11.2022", new CultureInfo("tr-TR"));
            tarih4 = DateTime.Parse("11/21/2022", new CultureInfo("en-US")); //2022-11-21
            Console.WriteLine(tarih4.ToString(new CultureInfo("en-US"))); //11/21/2022 00:00:00 Tr -> 21.11.2022 00:00:00

            //  2022-11-21 00:00:00
            Console.WriteLine(tarih4.ToString("yyyy-MM-dd"));  //2022-11-21

            double sayi = 1.2;
            sayi = double.Parse("1,2", new CultureInfo("tr-TR"));
            Console.WriteLine(sayi.ToString(new CultureInfo("tr-TR")));

            DateTime now = DateTime.Now;
            Console.WriteLine("Bugün: " + now);
            Console.WriteLine("Yarın: " + now.AddDays(1.5).ToShortDateString() + " " + now.AddDays(1).ToLongDateString()); // 15.08.2023  bugun 14.08.2023
            Console.WriteLine("1 Hafta öncesi: " + now.AddDays(-7).ToShortDateString()); // 7.08.2023
            Console.WriteLine("6 Ay öncesi: " + now.AddMonths(6).ToShortDateString()); // 14.02.2023
            Console.WriteLine("1 yıl öncesi: " + now.AddYears(-10).ToShortDateString()); // 14.08.2023
            Console.WriteLine("12 saat öncesi: " + now.AddHours(-12).ToString(new CultureInfo("tr-TR"))); // 15.08.2023 00:07:00
            Console.WriteLine("Yarım saat öncesi: " + now.AddMinutes(-30).ToString(new CultureInfo("en-US"))); // 8/14/2023 11:38:00
            Console.WriteLine("Yarım saat öncesi: " + now.AddHours(-0.5).ToString(new CultureInfo("en-US"))); // 8/14/2023 11:38:00 
            #endregion


            #region Date Time karşılaştırma
            DateTime date1 = DateTime.Parse("06.09.2015 01:02:03", new CultureInfo("tr-TR"));
            DateTime date2 = DateTime.Parse("20.04.2010 23:02:58", new CultureInfo("tr-TR"));
            DateTime date3 = DateTime.Parse("2022-04-12", new CultureInfo("tr-TR"));
            Console.WriteLine(date3);
            date3 = DateTime.Parse("2020-05-29", new CultureInfo("en-US"));
            Console.WriteLine(date3.ToString(new CultureInfo("en-US")));


            if (date1 > date1)  // if(date1.CompareTo(date2 > 0)
            {
                Console.WriteLine($"{date1} büyüktür {date2}");
            }
            else if (date1 < date2)  // if(date1.CompareTo(date2 < 0)
            {
                Console.WriteLine($"{date1} küçüktür {date2}");
            }
            else   // if(date1.CompareTo(date2 == 0)
            {
                Console.WriteLine($"{date1} eşittir {date2}");
            }

            long sayisalTarih = DateTime.Now.Ticks;
            Console.WriteLine(sayisalTarih);
            #endregion

            string dogumTarihi;

            #region Do while Ikıncı yöntem
            //do
            //{

            //    dogumTarihi = Console.ReadLine();
            //    if (!(dogumTarihi == "Ç" || dogumTarihi == "Ç"))
            //    {
            //         Console.WriteLine($"Yaşınız:  {DogumTarihiHesapla(dogumTarihi)}");
            //    }   
            //} while (dogumTarihi != "Ç" && dogumTarihi != "ç");   //!(dogumTarihi == "Ç" || dogumTarihi == "Ç") 
            #endregion


            //Kullanıcı girişi ile doğum tarihi ile yaş hesaplama
            Console.Write("Doğum tarihi (gün.ay.yıl): ");
            dogumTarihi = Console.ReadLine();

            while (!(dogumTarihi == "Ç" || dogumTarihi == "ç"))
            {
                Console.WriteLine($"Yaşınız:  {DogumTarihiHesaplaDogru(dogumTarihi)}");
                Console.Write("Doğum tarihi (gün.ay.yıl): ");
                dogumTarihi = Console.ReadLine();
            }


            // Son kullanma tarihi kontrolü
            Console.WriteLine("Enter expiration date (mont/day/year): ");
            string expirationDate = Console.ReadLine();
            bool result = IsExpired(expirationDate);
            Console.WriteLine(result ? "Expired." : "Not expired.");   //Ternary ile yapımı

        }

        private static bool IsExpired(string date)
        {
            bool result = false;
            DateTime today = DateTime.Now.Date;
            DateTime expirationDate = DateTime.Parse(date, new CultureInfo("en-US"));
            if (expirationDate < today)
            {
                result = true;
            }
            return result;
        }
        private static bool IsExpired3(string date) => DateTime.Parse(date, new CultureInfo("en-US")) < DateTime.Now.Date;  // Tek satırda işlem

        private static bool IsExpired2(string date)
        {
            return DateTime.Parse(date, new CultureInfo("en-US")) < DateTime.Now.Date;   // Tek satırda yapma
        } 

        static int DogumTarihiHesaplaYanlis(string dogumTarihi)
        {
            DateTime tarih = Convert.ToDateTime(dogumTarihi, new CultureInfo("tr-TR"));
            //DateTime tarih2 = DateTime.Parse(dogumTarihi, new CultureInfo("tr-TR"));
            int yas = DateTime.Now.Year - tarih.Year;     // DateTime.Now.Date, DateTime.Now.Today
            return yas;
        }
        static int DogumTarihiHesaplaDogru(string dogumTarihi)
        {
            DateTime tarih = DateTime.Parse(dogumTarihi, new CultureInfo("tr-TR"));
            TimeSpan tarihFarki = DateTime.Today.Subtract(tarih);     // subtract çıkarma methodu  TimeSpan => Süre tutuluyor  (Tarih farkı) maximum gün
            int yas = (int)(tarihFarki.TotalHours / (365 * 24 + 6));
            return yas;
        }

    }
}