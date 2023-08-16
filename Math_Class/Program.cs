namespace Math_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            int mutlakDeger = Math.Abs(sayi1 - sayi2);
            Console.WriteLine("sayi1 - sayi2 = " + (sayi1 - sayi2) + ", mutlak deger = " + mutlakDeger);

            int sayi3 = 3;
            int sayi4 = 4;
            Console.WriteLine("büyük: " + Math.Max(sayi3, sayi4) + ", küçük: " + Math.Min(sayi3, sayi4));
            Console.WriteLine($"{sayi3} ^ {sayi4} = {Math.Pow(sayi3, sayi4)}");  // 3 üzeri 4 = 81
            Console.WriteLine($"{sayi4} kare kökü: {Math.Sqrt(sayi4)}");  // 4 kare kökü: 2

            // 2 = 8 ^ 1/3
            double kup = 1 / 3; // 0,3333 -> 0
            kup = 1.0 / 3;
            kup = 1 / 3.0;
            kup = 1.0 / 3.0; //0.3333
            Console.WriteLine("8'in' küp kökü: " + Math.Pow(8, kup));

            double sayi5 = 12.345;
            double sayi6 = 98.765;

            Console.WriteLine("Taban: " + Math.Floor(sayi5) + ", " + Math.Floor(sayi6) + ", " + (int)sayi5 + ", " + (int)sayi6);
            Console.WriteLine("Tavan: " + Math.Ceiling(sayi5) + ", " + Math.Ceiling(sayi6));

            Console.WriteLine(Math.Ceiling(12.34));
            Console.WriteLine(sayi5 + " (12): " + Math.Round(sayi5));
            Console.WriteLine(sayi6 + " (99): " + Math.Round(sayi6));

            Console.WriteLine(sayi5 + " (12,3): " + Math.Round(sayi5, 1));  // 12,3     1 haneli ondalık yuvarlama yapar
            Console.WriteLine(sayi6 + " (98,7): " + Math.Round(sayi6), 1);     // 98,8

            Console.WriteLine(sayi5 + " (12,34): " + Math.Round(sayi5, 2));  // 12,34
            Console.WriteLine(sayi6 + " (98,76): " + Math.Round(sayi6, 2));  // 98,76

            double yuvarlanmis = Yuvarla(1.65);
            Console.WriteLine(yuvarlanmis);

        }

        private static double Yuvarla(double sayi)
        {
            return Math.Round(sayi, 2);
        }
    }
}