namespace SwiitchDemo2
{
    internal class Program
    {
        /*
                    Algoritma:
                    1. başla
                    2. kullanıcıdan TL cinsinden para girilmesi istenir
                    3. kullanıcı para girer
                    4. kullanıcıdan para birimi girilmesi istenir (Dolar: d, Euro: e, Pound: p)
                    5.1 eğer para birimi dolar ise 
                    5.2 kullanıcının girdiği parayı tanımlı olan dolar kuruna böl
                    5.3 eğer para birimi euro ise
                    5.4 kullacının girdiği parayı tanımlı olan euro kuruna böl
                    5.5 eğer para birimi pound ise
                    5.6 kullanıcının girdiği parayı tanımlı olan pound kuruna böl
                    5.7 eğer para birimi dolar, euro ve pound değil ise
                    5.8 kullanıcıdan doğru tanımlı para birimi girilmesi istenir
                    6. işlem sonucu ekrana tarih ile birlikte yazdırılır
                    7. bitir
                    */
        static void Main(string[] args)
        {
            string tarih = "31.07.2023";
            decimal para;
            string paraBirimi;

            Console.WriteLine("Para birimi: ");
            paraBirimi = Console.ReadLine();

            Console.WriteLine("Para: ");
            para = Convert.ToDecimal(Console.ReadLine());

            decimal sonuc = Hesapla(para, paraBirimi);
            if (sonuc == 1)
            {
                Console.WriteLine("Geçersiz para birimi.");
            }
            else
            {
                Console.WriteLine($"Tarih: {tarih}  Sonuç: {sonuc} ");
            }

            //Console.WriteLine("Tarih: " + tarih + ", Sonuç: " + Hesapla(para, paraBirimi));
            //Hesapla(para, paraBirimi);

        }

        static decimal Hesapla(decimal tl, string paraBirimi)
        {
            decimal sonuc = -1; // olarak atadığımız da switch de default kullanmadıgımızda geçersiz olacak
            const decimal dolar = 27.55m;
            const decimal euro = 30.14m;
            const decimal pound = 32m;


            switch (paraBirimi)
            {
                case "d":
                    sonuc = tl / dolar;
                    break;
                case "e":
                    sonuc = tl / euro;
                    break;
                case "p":
                    sonuc = tl / pound;
                    break;
            }
            return sonuc;
        }
    }
}