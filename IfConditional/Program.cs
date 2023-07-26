namespace IfConditional
{
    internal class Program
    {
        //arithmetic operators: +, - *, /, %
        //assigment operator: =
        // relational operators: ==, >=, <=, <, >, !=
        //logical operators: &&, ||, !
        static void Main(string[] args)
        {
            int sayi = 10;
            if (sayi==10)
            {
                Console.WriteLine("On");
            }
            sayi = 30;
            if (sayi==10)
            {
                Console.WriteLine("On");
            }
            else //değili !(sayi==10), sayi !=10
            {
                Console.WriteLine("On değil");
            }

            string adSoyad;
            Console.Write("Adınızı ve soyadınızı giriniz:");
            adSoyad = Console.ReadLine();
            Console.WriteLine("Adınız ve soyadınız: " + adSoyad);

            /*
            1.Başla
            2.kullanıcıya yaş sor
            3.kullanıcıdan yaş alınır
            4.eğer kullanıcının yaşı 0 ile 30 arasında ise genç
            5.eğer kuallnıcının yaşı 31 ve 60 arasında ise orta yaşlı
            6.eğer kullanıcının yaşı 60'dan büyük ise yaşlı 
            7.bitir
             */

            string giris;
            int yas;
            Console.Write("Yaş giriniz: ");
            giris = Console.ReadLine();
            yas = Convert.ToInt32(giris);
            if (yas >= 0 && yas <= 30)
            {
                Console.WriteLine("Yaşınız " + yas + ", yaş grubunuz hgenç");
            }
            else if (yas > 30 && yas <= 60) 
            {
                Console.WriteLine("Yaşınız " + yas + ", yaş grubunuz orta yaşlı");
            }
            else
            {
                Console.WriteLine("Yaşınız " + yas + ", yaş grubunuz yaşlı");
            }
        }
    }
}