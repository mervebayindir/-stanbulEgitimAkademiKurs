namespace IfDemos3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string dogruKullaniciAdi = "Merve";
            const string dogruSifre = "133";

            Console.WriteLine("*** Kullanici Girişi ***");
            Console.Write("Kullanici Adi: ");
            string kullaniciAdi = Console.ReadLine();
            Console.Write("Şifre: ");
            string sifre = Console.ReadLine();
            if (dogruKullaniciAdi == kullaniciAdi)
            {
                if (dogruSifre == sifre)
                {
                    Console.WriteLine("Kullanıcı adı ve şifre doğrudur.");
                    Console.WriteLine("Hoşgeldiniz!");
                }
                else
                {
                    Console.WriteLine("Şifreniz yanlıştır, tekrar deneyiniz...");
                }
            }
            else //  ! (dogruKullaniciAdi  == kullaniciAdi ) -> dogruKullaniciAdi != kullaniciAdi
            {
                Console.WriteLine("Kullanıcı adınız yanlıştır, tekrar deneyiniz...");
            }
        }
    }
}