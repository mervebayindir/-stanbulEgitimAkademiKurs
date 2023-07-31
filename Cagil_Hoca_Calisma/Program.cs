namespace Cagil_Hoca_Calisma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AsalSayiBulma();
        }
        static void AsalSayiBulma()
        {
            int sayac = 0;
            Console.WriteLine("Sayıyı Girin");
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
            if (sayac == 2)  //asal sayaı kendisi ve 1 e bölünür
            {
                Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayıdır.", sayi);
            }
            else
            {
                Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayı Değildir.", sayi);
            }
            Console.ReadKey();
        }
    }
}