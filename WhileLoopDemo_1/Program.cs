namespace WhileLoopDemo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Do while ve while genelde bir koşulu sağlıyorsa çalışması için kullanılır

            //Kdv Hesaplama

            const double kdv = 0.18;
            double ucret;
            double toplamUcret;
            Console.Write("Ücret (çıkış: -1): ");
            ucret = Convert.ToDouble(Console.ReadLine());

            while (ucret > -1)
            {
                toplamUcret = ucret + ucret * kdv;
                Console.WriteLine("Ücret: " + ucret);
                Console.WriteLine("KDV: %" + (kdv * 100));
                Console.WriteLine("Toplam ücret: " + toplamUcret);

                Console.Write("Ücret: " );
                ucret = Convert.ToDouble(Console.ReadLine());
            }

        }
    }
}