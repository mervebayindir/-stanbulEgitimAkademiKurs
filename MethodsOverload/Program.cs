namespace MethodsOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = Topla(1, 2);

            double sum = Topla(1.1, 2.2);
            Console.WriteLine(sum); //3.3

            sum = Topla(11, 22, 33);
            Console.WriteLine(sum);

            string firstName = "Muhittin";
            string lastName = "Böcek";
            string middleName = "Jr.";
            string name = Birlestir(firstName, middleName, lastName);
            Console.WriteLine(name);

            SumAll(1);
            Console.WriteLine(SumAll(2, 3));
            Console.WriteLine(SumAll(20,-30, 55, 66.6m, 89));

            JoinNames("Mustafa", "Kemal", "Atatürk");


            string giris;
            int yas;
            Console.WriteLine("Yas griniz");
            giris = Console.ReadLine();
            yas = Convert.ToInt32(giris);
            if(yas>=0 && yas <= 60)
            {
                Console.WriteLine("Yaşınız " + yas + ", yaş grubunuz genç");
            }
            else if (yas>30  && yas<=60)
            {
                Console.WriteLine("Yaşınız " + yas + ", yaş grubunuz orta yaşlı");
            }
            else  //if(yas < 0  || yas > 60)
            {
                Console.WriteLine("Yaşınız " + yas + ", yaş grubunuz yaşlı");
            }


            // TODO: BinaryReader koşul grubunun değilini alma  (// 2 * 3 + = 10, 2 * (3 + 4) = 14)
            if (!(yas >= 0  && yas <=120)) //if (yas<0 || yas>120
            {
                Console.WriteLine("yas 0 ile 120 aralığında olmalıdır.");
            }
            else //yas>=0 && yas <=120
            {
                if (yas <= 30)
                {
                    Console.WriteLine("Yaşınız " + yas + ", yaş grubunuz genç");
                }
                else
                {
                    if(yas<=60)
                    {
                        Console.WriteLine("Yaşınız " + yas + ", yaş grubunuz orta yaşlı");
                    }
                    else
                    {
                        Console.WriteLine("Yaşınız " + yas + ", yaş grubunuz yaşlı");
                    }
                }
            }

            int age = 60;
            bool result = (age >= 0 && age <= 40) || (age >= 60 && age <= 100);
            Console.WriteLine(result);
        }

        static int Topla(int sayi1, int sayi2)
        {
            int toplam;
            toplam = sayi1 + sayi2;
            return toplam;
        }
        static double Topla(double sayi1, double sayi2)  //method overload
        {
            return sayi1 + sayi2;
        }

        static double Topla(double s1, double s2, double s3)
        {
            return s1 + s2 + s3;
        }
        static double Topla(double s1, double s2, double s3, double s4 =4)  //method overload yaparsak default parametre verilirken çok dikkat edilmeli verilmezse çakışır, verilirse 3 parametre verılen methodda hangi method oldugu anlasılmaz o yuzden default parametre verilmemeli
        {
            return s1 + s2 + s3 + s4;
        }
        static string Birlestir(string ad, string soyad)
        {
            return ad + " " + soyad;
        }
        static string Birlestir(string ad, string ortaAd, string soyad)
        {
            return ad + " " + ortaAd + " " + soyad;
        }

        // methodlarda params anahtar kelimesi
         static decimal SumAll(params decimal [] numbers)  // arraylar collectiondur sum methodu .net de tanımlı methodu çağırarak toplama yaptık
        {
            return numbers.Sum(); // değişken üzerinden methodu yaptık
        }

        static void JoinNames(params string[] names)
        {
            string result = string.Join(" ", names); // string tipi üzerinden methodu yaptık
            Console.WriteLine(result);
        }
    }
}