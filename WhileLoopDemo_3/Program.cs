namespace WhileLoopDemo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write an algorithm that calculates and returns the following sum:
            // (1 x 2 - 3 x 4) + (5 x 6 - 7 x 8) + ... + (997 x 998 - 999 x 1000)
            long sayi;
            long sonuc = 0;
            for (sayi = 1; sayi <= 997; sayi += 4)
            {
                sonuc += sayi * (sayi + 1) - (sayi + 2) * (sayi + 3);
            }
            Console.WriteLine("Sonuc: " + sonuc);
            Console.WriteLine();
            sonuc = 0;
            sayi = 1;
            while (sayi <= 997)
            {
                sonuc += sayi * (sayi + 1) - (sayi + 2) * (sayi + 3);
                sayi += 4;
            }
            Console.WriteLine("Sonuc: " + sonuc);
        }
    }
}