namespace IfDemo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1.Başla
            2.Ad soyad alınır
            3.Yaş alınır
            4.Eğitim Durumu(i:İlkokul veya altı, o:ortaokul, l:lise, ü:Üniversite veya üstü)
            5.Eğer yaş 18'den büyük eşitse
            6.Eğer eğitim lise veya üstü ise
            7.Ad soyad yazdır ve ehliyet alabilirsiniz yazdır
            8.Eğer yaş 18'den küçükse
            9.Ad soyad yazdır ve ehliyet alamazsınız yazdır
            10.Eğer eğitim lise altı ise
            11.Ad soyad yazdır ve ehliyet alamazsınız yazdır
            12.bitiş
             */
            string adSoayd, egitim;
            int yas;
            Console.WriteLine("****  Yaş ve Eğitim Durumuna Göre Ehliyet Alabilme");
            Console.Write("Adınız soyadınız: ");
            adSoayd = Console.ReadLine();

            if (adSoayd == "")
            {
                Console.WriteLine("Ad ve soyad girilmelidir!..");
            }
            else
            {
                Console.Write("Yaşınız: ");
                yas = Convert.ToInt32(Console.ReadLine());
                if (yas<0  || yas>120)
                {
                    Console.WriteLine("Yaş 0 ile 120 aralığında olmalıdır.");
                }
                else
                {
                    Console.WriteLine("Eğitim (i:ilokul, l:lise, o:ortaokul, ü:üniversite veya üstü)");
                    egitim = Console.ReadLine();
                    if (egitim=="i" || egitim=="l" || egitim=="o" || egitim=="ü")
                    {
                        //if (yas>=18) 
                        //{
                        //    if (egitim == "l" && egitim == "ü")
                        //    {
                        //        Console.WriteLine($"{adSoayd}  egitim durumu: {egitim}  ehliyet alabilirsiniz");
                        //    }
                        //    else
                        //    {
                        //        Console.WriteLine($"{adSoayd}  egitim durumu: {egitim}  ehliyet almazsınız");
                        //    }
                        //}
                        //else
                        //{
                        //    Console.WriteLine($"{adSoayd}  egitim durumu: egitim");
                        //}
                        if (yas>=18 && (egitim=="l" || egitim == "ü"))
                        {
                            Console.WriteLine(adSoayd + ", ehliyet alabilirsiniz");
                        }
                        else
                        {
                            Console.WriteLine(adSoayd + ", ehliyet alamazsınız");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Eğitim (i:ilokul, l:lise, o:ortaokul, ü:üniversite veya üstü girilmelidir");
                    }
                }

            }


        }
    }
}