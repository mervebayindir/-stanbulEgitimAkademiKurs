namespace IfDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sonuc;
            char islem;
            Console.Write("1. sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İslem seçiniz => ( +, -, *, /, % ) = ");
            islem = Convert.ToChar(Console.ReadLine());

            if (islem == '+')
            {
                sonuc = sayi1 + sayi2;
                Console.WriteLine("Sonuc = " + sonuc);
            }
            else if (islem == '-')
            {
                sonuc = sayi1 - sayi2;
                Console.WriteLine("Sonuc = " + sonuc);
            }
            else if (islem == '*')
            {
                sonuc = sayi1 * sayi2;
                Console.WriteLine("Sonuc = " + sonuc);
            }
            else if (islem == '/')
            {
                sonuc = sayi1 / sayi2;
                Console.WriteLine("Sonuc = " + sonuc);
            }
            else if (islem == '%')
            {
                sonuc = sayi1 % sayi2;
                Console.WriteLine("Sonuc = " + sonuc);
            }
        }
    }
}