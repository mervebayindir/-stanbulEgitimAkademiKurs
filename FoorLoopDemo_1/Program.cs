namespace FoorLoopDemo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı (1 dışında pozitif ): ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi < 2)
            {
                Console.WriteLine("Sayı 1 dışında pozitif olmalıdır.");
            }
            else
            {
                Console.WriteLine(AsalMi(sayi));
            }
        }
        static string AsalMi(int sayi)
        {
            bool asalMi = true; // flag
            for (int sayac = 2; sayac < sayi; sayac++)
            {
                if (sayi % sayac == 0)
                {
                    asalMi = false;
                    break;
                }
            }
            return asalMi ? "Asal" : "Asal Değil";
        }
    }
}