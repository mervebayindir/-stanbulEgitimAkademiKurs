using System.Numerics;

namespace SwitchDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Plaka: ");
            int plaka = int.Parse(Console.ReadLine());  // 06 -> 6 olarak tutar stack de

            YazdırIf(plaka);
            YazdirSwitch(plaka);


        }

        private static void YazdırIf(int plaka)
        {
            if (plaka == 6)
                Console.WriteLine("Ankara");
            else if (plaka == 34)
                Console.WriteLine("İstanbul");
            else if (plaka == 7)
                Console.WriteLine("Antalya");
            else
                Console.WriteLine("Başka şehir");
        }

        private static void YazdirSwitch(int plaka)
        {
            switch (plaka)
            {
                case 6:
                    Console.WriteLine("Ankara");
                    break;
                case 34:
                    Console.WriteLine("İstanbul");
                    break;
                case 7:
                    Console.WriteLine("Antalya");
                    break;
                default:
                    Console.WriteLine("Başka şehir");
                    break;
            }
        }
    }
}