namespace ArithmeticOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam1 = 1 + 2;
            Console.WriteLine("1 + 2 = " + toplam1);  // 1 + 2 = 3

            int toplam2 = 1 + 2 + 3 + 4;
            Console.WriteLine($"1 + 2 + 3 + 4 = {toplam2}"); // 1 + 2 + 3 + 4 = 10

            int n1, n2;
            int n3;
            int n4;

            int no1 = 11, no2 = 22; 
            int no3 = 88;
            int no4 = 77;

            int toplam3 = no1 + no2 + no3 + no4;
            Console.WriteLine("Toplam 3 = " + toplam3);  //Toplam 3 = 198

            long sayi1 = -111;
            sayi1 = sayi1 + 11;
            Console.WriteLine("Sayı 1 : " + sayi1);

            //sayi1 = sayi1 + 50;
            sayi1 += 50;
            Console.WriteLine("Sayı 1: " + sayi1);

            short sayi2 = 6;

            byte yas1 = 10;
            byte yas2 = 50;
            byte yas3 = 100;

            int toplamYas = yas1 + yas2 + yas3;


            //sayi2 = sayi2 + 21474836; //int.MaxValue burada sayı integer olabılır riski oldugu ıcın hata verıyor
            sayi2++; //sayi2 += 1; sayi2 = sayi2 + 1
            Console.WriteLine(sayi2);

            long sayi3 = 3;
            Console.WriteLine("S3: " + sayi3++);  // 3  önce değişkenin değeri kullan ve bir artır altta da artırılan degerı yazar
            Console.WriteLine("S3: " + sayi3);  //4

            sayi3 = 3;
            Console.WriteLine("S3: " + ++sayi3); //4
            Console.WriteLine("S3: " + sayi3); //4

            int s1 = 22;
            int s2 = 11;
            Console.WriteLine("Fark" + (s1-s2));

            double s3 = 8.9;
            s3 -= 0.9;
            Console.WriteLine(s3);  //8

            double s4 = 9;
            --s4;
            Console.WriteLine(s4); //8

            float f1 = 13.31f;
            f1 *= 2;  //f1 = f1 * 2;
            Console.WriteLine(f1);

            long l1 = 14;
            long l2 = 5;
            long bolum1 = l1 / l2; // 2.8değil , 2
            Console.WriteLine("Bölüm 1: " + bolum1);

            double bolum2 = (double)l1 / l2; // 14.0 / 5.0 = 2.8
            Console.WriteLine("Bölüm 2: " + bolum2);

            double l11 = 14;
            double l22 = 5;
            double bolum22 = l11 / l22;
            Console.WriteLine("Bölüm 22: " + bolum22);

            //dikkat edelim!
            double test2 = 2.0;
            int test1 = (int)test2;

            decimal dcml1 = 15.5m;
            dcml1 /= 5;  //dcml1 = dcml1 / 5;
            Console.WriteLine(dcml1);

            int numara1 = 21, numara2 = 2;
            int kalan = numara1 % numara2; //1
            Console.WriteLine("Kalan: " + kalan);

            int numara3 = 23;
            numara3 %= 3; //numara3 = numara3 % 3;
            Console.WriteLine("Kalan: {0}", numara3);
        }
    }
}