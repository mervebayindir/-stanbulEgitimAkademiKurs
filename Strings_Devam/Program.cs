using System.Globalization;

namespace Strings_Devam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test1 = "test1";
            string test2 = "test2";
            if (test1 == test2)
            {
                Console.WriteLine("test1 eşittir test2");
            }
            else
            {
                Console.WriteLine("test1 eşit değildir test2");//*
            }
            if (test1.Equals(test2))
            {
                Console.WriteLine("test1 eşittir test2");
            }
            else
            {
                Console.WriteLine("test1 eşit değildir test2");//*
            }
            string ad = "Merve";
            string soyad = "Bayındır";
            string sonuc;

            sonuc = "\"Merve\"";  //"Merve"
            Console.WriteLine(sonuc);

            sonuc = ad + "\n" + soyad;
            Console.WriteLine(sonuc);

            sonuc = ad + "\r\n" + soyad;   // \r görevi enter tuşu gibidir ayn \n gibi    carriage return
            Console.WriteLine(sonuc);

            sonuc = ad + "\t" + soyad;  // \t tab

            string dosyaYolu1 = "P:\\Users\\Merve\\Source\\repos";
            Console.WriteLine(dosyaYolu1);


            string dosyaYolu2 = @"C:\Users\cv.docx";
            Console.WriteLine(dosyaYolu2);

            char karakter = '\''; // \' -> '
            Console.WriteLine(karakter);

            string tamAd = "Merve Bayındır";
            Console.WriteLine("\"" + tamAd + "\"");  //Merve Bayındır
            Console.WriteLine("\"" + tamAd.Trim() + "\"");  //Merve Bayındır
            Console.WriteLine("\"" + tamAd.TrimStart() + "\"");  //Merve Bayındır
            Console.WriteLine("\"" + tamAd.TrimEnd() + "\"");  //Merve Bayındır
            Console.WriteLine($"\" {tamAd.Trim()} \"");  //Merve Bayındır

            string ayrac = ", ";
            string diller = "C#, Java, Python";
            diller = $"C#{ayrac}Java{ayrac}Python{ayrac}";

            string virgulsuzDiller = diller.TrimEnd(' ', ' '); //C#, Java, Python
            //string virgulsuzDiller2 = diller.TrimEnd(ayrac);  //ayracta hata verir

            //virgulsuzDiller = diller.Substring(0, diller.Length - 2); ayrac.lenght gibidir
            Console.WriteLine(virgulsuzDiller);

            char[] ayracDizi = new char[ayrac.Length];
            for (int i = 0; i < ayracDizi.Length; i++)
            {
                ayracDizi[i] = ayrac[i];
            }
            char[] ayracDizisi = ayrac.ToCharArray(); // yukarıdakı forun görevini yapar stringi karakter dizisine çevirir
            virgulsuzDiller = diller.TrimEnd(ayracDizisi);


            virgulsuzDiller = diller.Substring(diller.Length - ayrac.Length);
            //Console.WriteLine(virgulsuzDiller);

            int ogrenciNo = 123456;
            string ogrenciNoYazi = "" + ogrenciNo; // "123456"
            ogrenciNoYazi = ogrenciNo + ""; //"123456"
            ogrenciNoYazi = ogrenciNo.ToString();  //"123456"

            bool dogruNu = true;
            Console.WriteLine(dogruNu.ToString());  //"True

            int[] sayilar = new int[] { 1, 2, 3 };
            Console.WriteLine(sayilar.ToString()); //değer tiplerin tipini gösterir ekrana 1 2 3 diye yazmaz for ile yazmamız gerek
            foreach (int sayi in sayilar)
                Console.WriteLine(sayi);

            Console.WriteLine(sayilar[0]);  // "1"

            char[] karakterler = { 'l', 'e', 'o' };
            Console.WriteLine(karakterler.ToString());  // değerin tipini gösterır char dizisini stringe çevirmez for kullanarak yazmak zorunlu yoksa olmaz

            string karakterlerYazi = "";
            foreach (char k in karakterler)
            {
                karakterlerYazi += k;
            }
            Console.WriteLine(karakterlerYazi);

            int ajanNo = 17; // 017, 007 217
            string ajanNoYazi = UcKaraktereTamamla(7);
            Console.WriteLine(ajanNoYazi);
            ajanNoYazi = UcKaraktereTamamla(17);
            Console.WriteLine(ajanNoYazi);
            ajanNoYazi = UcKaraktereTamamla(217);
            Console.WriteLine(ajanNoYazi);

            int gun = 8;
            int ay = 8;
            int yil = 2023;

            Console.WriteLine(gun.ToString().PadLeft(2, '0') + "." + ay.ToString().PadLeft(2, '0') + "." + yil);  //soldan sıfır eklıyor

            string message = "To be continued";
            message = message + "...";
            message = message.PadRight(18, '.');  //To be continued...
            Console.WriteLine(message);



            // Türkçe: 12.34 -> 1234 -> 12,34 -> 12,34
            // İngilizce: 12.34 -> 12.34, 12,34 -> 1234
            double sayi1 = 12.34;

            string format1;
            format1 = sayi1.ToString("NO", new CultureInfo("tr-TR"));  //N:number
            Console.WriteLine(format1);  // 12,3

            format1 = sayi1.ToString("C1", new CultureInfo("en-Us"));  //N:number
            Console.WriteLine(format1); // $12,3

            string bolge = "en-Us";
            Console.Write("Para: ");
            string para = Console.ReadLine();
            double paraSayi = Convert.ToDouble(para, new CultureInfo(bolge));
            Console.WriteLine(paraSayi.ToString("C2", new CultureInfo(bolge)));





        }
        static string UcKaraktereTamamla(int sayi)
        {
            string sonuc = "";
            string[] karakterler = new string[3]
            {
                "0",
                "0",
                "0"
            };
            string sayiString = sayi.ToString();
            karakterler[2] = sayiString[sayiString.Length - 1].ToString();
            karakterler[1] = sayiString[sayiString.Length - 2].ToString();

            int karakterlerSonIndex = karakterler.Length - 1;
            for (int i = sayiString.Length - 1; i >= 0; i--)
            {
                karakterler[karakterlerSonIndex--] = sayiString[i].ToString();
            }
            foreach (string karakter in karakterler)
            {
                sonuc += karakter;
            }

            sonuc = sayi.ToString().PadLeft(3, '0'); // yukarıdaki kodun method hali
            return sonuc;

        }
    }
}