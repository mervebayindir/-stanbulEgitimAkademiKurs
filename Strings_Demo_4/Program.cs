namespace Strings_Demo_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kelime: ");
            string kelime = Console.ReadLine();
            string[] sesliler = new string[]
            {
                "a","e","ı","i","o","ö","u","ü"
            };
            Console.WriteLine($"Sesliler: {SesliBul(kelime.ToLower(), sesliler)}");
            Console.WriteLine($"Sesliler: {SesliBul2(kelime.ToLower(), sesliler)}");
            Console.WriteLine($"Sesliler: {SesliSessizBul1(kelime.ToLower(), sesliler, false)}");
           // Console.WriteLine($"Sesliler: {SesliSessizBul(kelime.ToLower(), sesliler, false)}");



        }
        static string SesliBul(string kelime, string[] sesliler)
        {
            string sonuc = "";
            bool sesliMi;  // flag
            //char[]
            foreach (char harf in kelime)
            {
                sesliMi = false;
                foreach (string sesli in sesliler)
                {
                    if (harf.ToString() == sesli)
                    {
                        sesliMi = true;
                        break;
                    }
                }
                if (sesliMi) //sessiz ise ! koayacagız (!sesliMi)
                {
                    if (!sonuc.Contains(harf))
                    {
                        sonuc += harf;
                    }

                }
            }
            return sonuc;
        }
        static string SesliBul2(string kelime, string[] sesliler)   // olmadı
        {
            string sonuc = "";
            foreach (char harf in kelime)
            {
                if (sesliler.Contains(harf.ToString()) && !sonuc.Contains(harf))
                {
                    sonuc += harf;
                }
            }
            return sonuc;
        }
        static string SesliSessizBul1(string kelime, string[] sesliler, bool sesliMiBulunacak)
        {
            string sonuc = "";
            bool sesliMi;  // flag
            //char[]
            foreach (char harf in kelime)
            {
                sesliMi = false;
                foreach (string sesli in sesliler)
                {
                    if (harf.ToString() == sesli)
                    {
                        sesliMi = true;
                        break;
                    }
                }
                if (sesliMi && sesliMiBulunacak) //sessiz ise ! koayacagız (!sesliMi)
                {
                    if (!sonuc.Contains(harf))
                    {
                        sonuc += harf;
                    }
                }
                else if (!sesliMiBulunacak && !sesliMiBulunacak)
                {
                    if (!sonuc.Contains(harf))
                    {
                        sonuc += harf;
                    }
                }
            }
            return sonuc;
        }
        static string SesliSessizBul(string kelime, string[] sesliler)
        {
            string sonuc = "";
            foreach (char harf in kelime)
            {
                if (sesliler.Contains(harf.ToString()) && !sonuc.Contains(harf))
                {
                    sonuc += harf;
                }
                else if (!sesliler.Contains(harf.ToString()) && !sonuc.Contains(harf))
                {
                    sonuc += harf;
                }
            }
            return sonuc;
        }
    }
}