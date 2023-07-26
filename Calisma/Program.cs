namespace Calisma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vize, final, ortalama;
            Console.WriteLine("Vize notunuzu giriniz : ");
            vize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final notunuzu giriniz : ");
            final = Convert.ToDouble(Console.ReadLine());

            ortalama = (vize * 0.4) + (final * 0.6);

            Console.WriteLine(ortalama);

            if (ortalama == 85 || ortalama>=85)
            {
                Console.WriteLine("Harf notunuz AA");
            }
            else if (ortalama == 60 || ortalama>=60)
            {
                Console.WriteLine("Harf notunuz BB");
            }
            else if (ortalama == 45 || ortalama>=45)
            {
                Console.WriteLine("Harf notunuz CC");
            }
            else if (ortalama == 40 || ortalama>=40)
            {
                Console.WriteLine("Şartlı geçiş");
            }
            else
            {
                Console.WriteLine("Kaldı");
            }
        }
    }
}