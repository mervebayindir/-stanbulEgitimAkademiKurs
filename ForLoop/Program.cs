namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("**************");
            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("**************");
            //for (int i = 0; i <= 20; i = i + 2)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("**************");
            //for (int j = 19; j <= 20; j = j + 1)
            //{
            //    Console.WriteLine(j);
            //}
            int k;
            Console.WriteLine("**************");
            for (k = 19; k >= 1; k -= 2) // cevap: -2 2'şer 2'şer azalttığı için
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("j en son değer: " + k);
            Console.WriteLine("**************");
            Console.WriteLine();

            Console.Write("Başlangıç Sayı: ");
            int baslangic = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitiş Sayı: ");
            int bitis = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tek sayı toplamı için t, çift sayı toplamı için ç:  ");
            string tekCift = Console.ReadLine();
            int toplam = 0;
            if (tekCift == "t" || tekCift == "ç" || tekCift == "T" || tekCift == "Ç")
            {
                for (int index = baslangic; index < bitis; index++) // index += -> index = index + 1
                {
                    if (index % 2 == 0 && (tekCift == "ç" || tekCift == "Ç"))
                    {
                        toplam += index;
                    }
                    else if (index % 2 != 0 && (tekCift == "t" || tekCift == "T"))
                    {
                        toplam += index;
                    }
                }
                Console.WriteLine($"Toplam: {toplam}");
            }
            else
            {
                Console.WriteLine("Lütfen t veya ç giriniz!...");
            }


        }
    }
}