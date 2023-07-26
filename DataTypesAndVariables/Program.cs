namespace DataTypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Comments (Yorumlar)
            // Bu bir yorumdur
            /*
              Yorum satırı 1
              Yorum satırı 2
             */
            #endregion

            #region
            Console.WriteLine("Hello, World!");  //"": string
            #endregion

            #region Value Types (Değer Tipler)
            int sayi1;  //declare (tanımlama)
            sayi1 = 10;  // assigment (atama)
            #endregion
            Console.WriteLine("Sayı : " + sayi1 + "sayısıdır.");  //concatenation
            Console.WriteLine("Sayı : {0}", sayi1);
            Console.WriteLine($"Sayı : {sayi1}");  //en çok kullanılan yöntem

            int sayi1eski = sayi1; //Int32
            sayi1 = 200;
            Console.WriteLine("int max : " + int.MaxValue + ", int min:" + int.MinValue);
            Console.WriteLine("Sayı : " + sayi1 + ", eski s:" + sayi1eski);

            uint sayi2;  //unsigned, pozitif tam sayı 0 dahil, 0....4
            sayi2 = 300000000;
            Console.WriteLine(sayi2);

            long sayi3 = 3000000000; //-9 kentilyon.... 9 kentilyon, 64 bit
            Console.WriteLine("Sayı 3 " + sayi3 + "'tür.");

            ulong sayi4 = 0; // 0....18 kentilyon
            Console.WriteLine(sayi4);

            short sayi5 = 26;   // -32000.....32000, 16 bit
            Console.WriteLine(sayi5);

            ushort sayi6 = 126; // 0...64000
            Int16 sayi55 = -12;
            Console.WriteLine(sayi6);

            byte sayi7 = 255; // 8 bit, 0....255, 1 byte=8 bit
            Console.WriteLine(sayi7);

            sbyte sayi8 = -100; // -128....127
            Console.WriteLine(sayi8);

            bool durum = false; //true
            Console.WriteLine("Durum: " + durum);

            durum = true;
            Console.WriteLine("Yeni durum :" + durum);

            char karakter = 'A';
            Console.WriteLine("Karakter:" + karakter + ", ASCII: " + (int)karakter);

            int sayi9 = 9;
            long sayi10 = (long)sayi9;
            Console.WriteLine(sayi10);
            //Daha geniş tipinden daha dar veri tipine cast edilirken dikkat edilmeli
            //long sayi11 = 3000000000;
            //int sayi12 = (int)sayi11;
            //Console.WriteLine(sayi12);

            double sayi13 = 1.7; // 64 bit   programlama tipindeki veri tipi
            Double sayi14 = -2.8;
            Console.WriteLine(sayi13 + "," + sayi14);

            float sayi15 = 22.567F; // (F, f ) sonuna F yazılmalı 32 bit
            Console.WriteLine(sayi15);
            decimal sayi16 = -123.445677887m; // (M, m)  sonuna m yazılmalı 192 bit
            Console.WriteLine(sayi16);   // ctrl + D imleç olan satırı kopyalama


            Console.WriteLine($"Day is {Days.Monday}, day value is {(int)Days.Monday}");
            Console.WriteLine($"Day is {Gunler.Çarşamba}, day value is {(int)Gunler.Çarşamba}");
            Console.WriteLine($"Day is {Cinsiyet.Kadın}, day value is {(int)Cinsiyet.Kadın}");

            Console.WriteLine("Kişinin cinsiyeti " + Cinsiyet.Kadın + "'dır.");
            Console.WriteLine("Kişinin cinsiyet değeri " + (int)Cinsiyet.Kadın + "'dır.");

            string characters = "Antalya";  //2 milyar byte'a kadar yazılabılır

            Console.WriteLine(characters + "," + characters + ", güzel " + characters);  //Antalya, Antalya, güzel Antalya
            string ad1;
            ad1 = "Merve";
            var ad2 = 123;
            Console.WriteLine(ad2); //zümra

            ad2 = 'l';
            Console.WriteLine(ad2);
        }

    }
    enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    enum Gunler
    {
        Pazar = 1, // Başlangıç index'i 1 olsun demek
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi
    }

    enum Cinsiyet
    {
        Kadın = 11,
        Erkek = 12
    }

}