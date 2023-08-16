namespace WhileLoopDemo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif sayı ortalama hesaplama: ");
            int l = 0;  //kaç sayı girildiği
            double sayilarinToplami = 0;
            double sayi;
            string giris;
            Console.Write((l + 1) + ". sayı (çıkış: ç): ");
            giris = Console.ReadLine();
            while (giris != "ç" && giris !="Ç")
            {
                sayi = double.Parse(giris);
                sayilarinToplami += sayi;
                l++;
                Console.Write((l + 1) + ". sayı (çıkış: ç): ");
                giris = Console.ReadLine();
            }
            if (l > 0)
                Console.WriteLine("aritmetik ortalama: " + sayilarinToplami / l);
            else
                Console.WriteLine("Herhangi bir sayı giriniz.");
        }
    }
}