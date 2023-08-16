namespace ArraysDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kullanici giris algoritması1
            string[] kullaniciAdlari = new string[3]
                {
                "Merve", "Zümra", "Kutluhan"
                };
            string[] sifre = new string[]
            {
                "c123", "l321", "a123"
            };
            Console.Write("Kullanıcı adı: ");
            string kullaniciAdiGiris = Console.ReadLine();

            Console.Write("Şifre: ");
            string sifreGiris = Console.ReadLine();

            bool bulunduMu = false;
            for (int i = 0; i < kullaniciAdlari.Length; i++)
            {
                if (kullaniciAdiGiris == kullaniciAdlari[i] && sifreGiris == sifre[i])
                {
                    bulunduMu = true;
                    break;
                }
            }
            if (bulunduMu)
            {
                Console.WriteLine("Hoşgeldin " + kullaniciAdiGiris);

            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre yanlış!... ");
            }
            #endregion

            /*
            merve    c123
            zümra    l321
            kutluhan a123
             */
            string[,] users = new string[3, 2];
            users[0, 0] = "merve";
            users[0, 1] = "c123";
            users[1, 0] = "zümra";
            users[1, 1] = "l321";
            users[2, 0] = "kutluhan";
            users[2, 1] = "a123";

            Console.Write("Kullanici adı: ");
            string userName = Console.ReadLine();

            Console.Write("Şifre: ");
            string password = Console.ReadLine();

            bool found = false;
            for (int row = 0; row <= users.GetUpperBound(0); row++)
            {
                if (users[row,0] == userName  && users[row,1] == password)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("Welcome " + kullaniciAdiGiris);

            }
            else
            {
                Console.WriteLine("User not found!... ");
            }
        }
    }
}