namespace IfDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string ogrenciAdi;
            //double v1, v2, fin, ort;
            const double vize1carpan = 0.2;
            const double vize2carpan = 0.2;
            const double finalCarpan = 0.4;

            string adSoyad;
            double ortalama, vize1, vize2, final;
            Console.Write("Öğrenci adınız: ");
            adSoyad = Console.ReadLine();

            Console.Write("Lütfen vize 1 notunuzu giriniz : ");
            vize1 = Convert.ToDouble(Console.ReadLine());

            if (adSoyad == "")
            {
                Console.WriteLine("Öğrenci adı boş geçilemez");
            }
            else
            {
                if (vize1 >= 0 && vize1 <= 100)
                {
                    Console.Write("Lütfen vize 2 notunuzu giriniz : ");
                    vize2 = Convert.ToDouble(Console.ReadLine());
                    if (vize2 >= 0 && vize2 <= 100)
                    {
                        Console.Write("Lütfen final notunuzu giriniz : ");
                        final = Convert.ToDouble(Console.ReadLine());
                        if (final >= 0 && final <= 100)
                        {
                            ortalama = ((vize1 * vize1carpan) + (vize2 * vize2carpan)) + (final * finalCarpan);
                            if (ortalama >= 60)
                            {
                                Console.WriteLine("Geçti: " + ortalama);
                            }
                            else
                            {
                                Console.WriteLine("Kaldı :" + ortalama);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Final notu 0 ve 100 arasında olmalıdır!.. ");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Vize2 notu 0 ve 100 arasında olmalıdır!.. ");

                    }
                }
                else
                {
                    Console.WriteLine("Vize1 notu 0 ve 100 arasında olmalıdır!.. ");

                }
            }          
        }
    }
}