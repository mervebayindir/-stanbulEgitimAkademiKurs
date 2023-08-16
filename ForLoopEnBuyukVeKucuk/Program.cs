namespace ForLoopEnBuyukVeKucuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Girilecek tam sayı adedi: ");
            int adet = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[adet];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write($"{i + 1}. tam sayı: ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            int sonuc = EnBuyukVeyaEnKucukBul(sayilar);
            Console.WriteLine("En büyük tam sayı: " + sonuc);
            sonuc = EnBuyukVeyaEnKucukBul(sayilar, false);
            Console.WriteLine("En küçük tam sayı: " + sonuc);


            //EnBuyukEnKucukSayi();
        }
        //static int EnBuyukEnKucukSayi()
        //{
        //    int[] sayilar = { 45, 3, 18, 1, 89 };
        //    int enBuyukVeyaEnkucuk = sayilar[0];
        //    for (int i = 1; i < sayilar.Length; i++)
        //    {
        //        if (sayilar[i] > enBuyukVeyaEnkucuk)
        //        {
        //            enBuyukVeyaEnkucuk = i;
        //            Console.WriteLine(enBuyukVeyaEnkucuk);
        //        }
        //        else if (enBuyukVeyaEnkucuk > sayilar[i])
        //        {
        //            enBuyukVeyaEnkucuk = i;
        //            Console.WriteLine(enBuyukVeyaEnkucuk);
        //        }

        //    }
        //    return 1;
        //}
        static int EnBuyukVeyaEnKucukBul(int[] sayilar, bool enBuyukMu = true)
        {
            int enBuyukVeyaEnKucukSayi = sayilar[0];
            for (int i = 1; i < sayilar.Length; i++)
            {
                if (enBuyukMu)
                {
                    if (sayilar[i] > enBuyukVeyaEnKucukSayi)
                    {
                        enBuyukVeyaEnKucukSayi = sayilar[i];
                    }
                }
                else
                {
                    if (sayilar[i]<enBuyukVeyaEnKucukSayi)
                    {
                        enBuyukVeyaEnKucukSayi = sayilar[i];
                    }
                }
            }
            return enBuyukVeyaEnKucukSayi;
        }
    }
}