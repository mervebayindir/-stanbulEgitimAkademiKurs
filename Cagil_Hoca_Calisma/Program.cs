namespace Cagil_Hoca_Calisma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AsalSayiBulma();
            AsalSayiBulma2();
        }

        private static void AsalSayiBulma2()
        {
            int sayac = 0;
            Console.Write("Sayıyı Girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                    Console.WriteLine(sayac);
                }
            }
            if (sayac == 1)
            {
                Console.WriteLine($"Girdiğiniz {sayi} sayısı Asal Sayıdır.");
            }
            else
            {
                Console.WriteLine($"Girdiğiniz {sayi} sayısı Asal Sayı Değildir.");
            }
        }

        static void AsalSayiBulma()
        {
            int sayac = 0;
            Console.Write("Sayıyı Girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());//100

            for (int i = 1; i <= sayi; i++)
            {
                //1 ve kendisinden başka bölünemeyen sayılara asal sayı denir...
                // koşul ?  doğru : yanlış;
                //int sonuc = sayi % i == 0 ? sayac++ : 0;//harika kafalar var burada
                if (sayi % i == 0)
                {
                    sayac++;//25
                }
            }
            if (sayac == 2)  //asal sayı kendisi ve 1 e bölünür
            {
                Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayıdır.", sayi);
            }
            else
            {
                Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayı Değildir.", sayi);
            }
        }

    }
}