namespace DoWhileLoopDemo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string islem;
            int baslangic, bitis, toplam, i;
            Console.Write("Başlangıç: ");
            baslangic = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitiş: ");
            bitis = Convert.ToInt32(Console.ReadLine());

            Console.Write("İşlem (t:tek, ç:çift, *:tüm): ");
            islem = Console.ReadLine();

            toplam = 0;
            i = baslangic;
            do
            {
                if (islem == "*")
                {
                    toplam += i;
                }
                else if (islem == "t" && i % 2 != 0)
                {
                    toplam += i;
                }
                else if (islem == "ç" && i % 2 == 0)
                {
                    toplam += i;
                }
                i++;
            } while (i <= bitis);
            Console.WriteLine($"{baslangic} sayısından {bitis} sayıaına kadar {(islem == "*" ? "tüm" : islem == "t" ? "tek" : islem == "ç" ? "çift" : "")} " +
                $"sayıların toplamı: {toplam}.");
        }
    }
}