namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine();

            //Döngüleri bu şekilde kullanmıyoruz
            //i = 1;
            //while (true)
            //{
            //    if (i > 10)
            //    {
            //        break;
            //        Console.WriteLine(i);
            //        i++;
            //    }
            //}
            Console.WriteLine("Taban: ");
            int taban = int.Parse(Console.ReadLine());
            Console.WriteLine("Üs: ");
            int us = int.Parse(Console.ReadLine());
            int usluSayi = UsAl(taban, us);
            Console.WriteLine($"{taban} ^ {us}  =  {usluSayi}");
        }
        static int UsAl(int taban, int us)
        {
            int sonuc = 1;
            int i = 1;
            while (i <= us)
            {
                sonuc *= taban;
                i++;
            }
            return sonuc;
        }
    }
}