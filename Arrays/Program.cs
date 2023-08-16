namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region One Dimensional Array
            // dizi ( kolleksiyon == Collection )
            string ogrenci1 = "Merve";
            string ogrenci2 = "Zümra";
            string ogrenci3 = "Kutluhan";
            Console.WriteLine($"1) {ogrenci1}");
            Console.WriteLine($"2) {ogrenci2}");
            Console.WriteLine($"3) {ogrenci3}");

            Console.WriteLine("*********************");
            string[] ogrenciler = { "Merve", "Zümra", "Kutluhan" };
            Console.WriteLine($"1) {ogrenciler[0]}");
            Console.WriteLine($"2) {ogrenciler[1]}");
            Console.WriteLine($"3) {ogrenciler[2]}");
            Console.WriteLine("********************* for ile");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine((i + 1) + ")" + ogrenciler[i]);
            }
            ogrenciler = new string[3];

            Console.WriteLine("*********************");


            ogrenciler[0] = "Mustafa";  //1. eleman
            ogrenciler[1] = "Eyüp";
            ogrenciler[2] = "Suide";

            Console.WriteLine($"1) {ogrenciler[0]}");
            Console.WriteLine($"2) {ogrenciler[1]}");
            Console.WriteLine($"3) {ogrenciler[2]}");

            Console.WriteLine("********************* for ile");
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine((i + 1) + ")" + ogrenciler[i]);  // for (int i=0; i <= ogrenciler.Lenght -1; i++) olarak da yazılabilir
            }
            int[] sayilar = new int[4];
            sayilar[0] = 11;
            sayilar[1] = 22;
            sayilar[2] = 33;
            sayilar[3] = 11;
            Console.WriteLine("Düz yazdırma");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            Console.WriteLine("Tersten yazdırma..");
            for (int i = sayilar.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(sayilar[i]);
            }

            Console.WriteLine("Decimal örneği");

            decimal[] ondalikSayilar = new decimal[5]
            {
                9.9m,
                8.8m,
                7.7m,
                6.6m,
                5.5m
            };
            for (int i = 0; i < ondalikSayilar.Length; i++)
            {
                Console.WriteLine(ondalikSayilar[i]);
            }

            Console.WriteLine("Char örneği");
            char[] nameChar1 = new char[] { 'M', 'e', 'r', 'v', 'e' };
            char[] nameChar2 = new char[5] { 'M', 'e', 'r', 'v', 'e' };
            char[] isimChar3 = { 'M', 'e', 'r', 'v', 'e' };

            for (int i = 0; i < isimChar3.Length; i++)
            {
                Console.WriteLine(isimChar3[i]);
            }
            Console.WriteLine("İsim (string) örneği");
            string name = "Merve";
            Console.WriteLine(name);
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i]);
            }
            Console.WriteLine("Number örneği");
            double[] numbers = new double[9]
            {
                10.1,
                20.1,
                30.3,
                40.4,
                50.5,
                60.6,
                70.7,
                80.8,
                90.9
            };
            Console.WriteLine("Sum: " + numbers.Sum());
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("For ile toplama:" + sum);
            #endregion

            #region Multidimensional Arrays
            //string[,] bolgelerVeSehirler = new string[3, 2];  // 3 : satır, 1.boyut(0)
            //                                                  // 2 : sütun, 2.boyut(1)

            //bolgelerVeSehirler[0, 0] = "Marmara";
            //bolgelerVeSehirler[0, 1] = "İstanbul";
            //bolgelerVeSehirler[1, 0] = "İç Anadolu";
            //bolgelerVeSehirler[1, 1] = "Ankara";
            //bolgelerVeSehirler[2, 0] = "Ege";
            //bolgelerVeSehirler[2, 1] = "İzmir";

            string[,] bolgelerVeSehirler = new string[3, 2]
            {
                {"Marmara", "İstanbul" },
                {"İç Anadolu", "Ankara" },
                {"Ege", "İzmir" }
            };

            Console.WriteLine($"Bölge: {bolgelerVeSehirler[1, 0]}, Şehir: {bolgelerVeSehirler[1, 1]}");

            for (int satir = 0; satir < 3; satir++)
            {
                for (int sutun = 0; sutun < 2; sutun++)
                {
                    Console.Write($"{bolgelerVeSehirler[satir,sutun]} ");
                    Console.Write(":");
                }
                Console.WriteLine();
            }
            for (int satir = 0; satir <= bolgelerVeSehirler.GetUpperBound(0); satir++)  //getUpperbound 0 -> son satır indexini
            {
                for (int sutun = 0; sutun <=bolgelerVeSehirler.GetUpperBound(1); sutun++) //getUpperbound 1 -> son satır indexini
                {
                    Console.Write($"{bolgelerVeSehirler[satir, sutun]} ");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}