namespace IfDemo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaslikYaz();
            bool atesVarmMi = Giris("Ateşin var mı? (e: Evet, h:Hayır): ");
            bool bogazAgrisiVarMi = Giris("Boğaz ağrın var mı? (e: Evet, h:Hayır): ");
            bool oksurukVarMi = Giris("Öksürük var mı? (e: Evet, h:Hayır): ");

            bool koronaMi = BelirtiTespitEt(atesVarmMi, bogazAgrisiVarMi, oksurukVarMi);
            SonucuYazdir(koronaMi);

            int yuzde = YuzdeTespitEt(atesVarmMi, bogazAgrisiVarMi, oksurukVarMi);
            
            SonucuYazdir(yuzde);
        }
        static void SonucuYazdir(int yuzde)
        {
            Console.WriteLine("Korona olma ihtimaliniz %" + yuzde);
        }

        static int YuzdeTespitEt(bool ates, bool bogazAgri, bool oksuruk)
        {
            int yuzde = 0;
            if (ates)
            {
                yuzde += 60;  //yuzde=yuzde + 60
            }
            if (bogazAgri)
            {
                yuzde += 30;
            }
            if (oksuruk)
            {
                yuzde += 10;
            }
            return yuzde;
        }

        static void SonucuYazdir(bool koronaMi)
        {
            if (koronaMi) //if(koronaMi == true)
            {
                Console.WriteLine("Koronasınız");
            }
            else
            {
                Console.WriteLine("Korona değilsiniz");
            }
        }

        static bool BelirtiTespitEt(bool atesVarmMi, bool bogazAgrisiVarMi, bool oksurukVarMi)
        {
            //if (atesVarmMi == true || bogazAgrisiVarMi == true || oksurukVarMi == true)

            if (atesVarmMi || bogazAgrisiVarMi || oksurukVarMi)
                return true;
            return false;
        }

        static void BaslikYaz()
        {
            Console.WriteLine("*** Koronavirüs Belirti ve Yüzde Tespit Programı ***");
        }
        static bool Giris(string mesaj)
        {
            bool sonuc;
            Console.WriteLine(mesaj);
            string giris = Console.ReadLine();
            if (giris == "e")
            {
                sonuc = true;
            }
            else
            {
                sonuc = false;
            }
            return sonuc;
        }
    }
}