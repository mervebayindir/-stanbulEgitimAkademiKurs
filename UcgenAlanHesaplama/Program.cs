namespace UcgenAlanHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double taban, yukseklik, alan;
            Console.Write("Üçgen tabanını giriniz : ");
            taban = Convert.ToDouble(Console.ReadLine());
            Console.Write("Üçgen yükseklik giriniz : ");
            yukseklik = Convert.ToDouble(Console.ReadLine());
            alan = taban * yukseklik / 2;
            Console.WriteLine("Üçgen alanı = " + alan);
        }
    }
}