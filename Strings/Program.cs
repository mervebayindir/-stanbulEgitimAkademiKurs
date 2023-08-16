namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string sehir1 = "Ankara";
            //Console.WriteLine(sehir1[0]);
            //foreach (var s in sehir1)
            //{
            //    Console.WriteLine(s); //Ankara
            //}
            //Console.WriteLine();
            //string word = "YAZILIM";
            //string reverseWord = "";
            //for (int i = word.Length - 1; i >= 0; i--)
            //{
            //    reverseWord += word[i];  //MILIZAY
            //}
            //Console.WriteLine(reverseWord);


            //string sehir2 = "İstanbul";
            //string sehir3 = sehir1 + " " + sehir2;  //Ankara İstanbuli string concatenation
            //Console.WriteLine(sehir3);

            //string sehir4 = string.Format("{0} {1}", sehir2, sehir1);  //İstanbul, Ankara
            //Console.WriteLine(sehir4);


            //string sehir5 = "İzmir";
            //string sehir6 = $"Ege'nin incisi: {sehir5}";   //Egenin'nin incisi: İzmir
            //Console.WriteLine(sehir6);

            //Console.WriteLine();

            //string isim1 = "Merve Bayındır";
            //int isim1Lenght = isim1.Length;  //   12
            //Console.WriteLine(isim1Lenght);

            //string isim2 = isim1.Replace('M', 'm');  //bu çok kullanılmaz  merve Bayındır
            //string isim3 = isim1.Replace("M", "m");  // genelde char değilde string methodlar kullanılır.    merve Bayındır
            //string isim4 = isim1.Replace("Merve", "Zümra");  //Zümra Bayındır

            //Console.WriteLine(isim2 + " - " + isim3 + " - " + isim4);

            //string isim5 = "Bill Gates";
            //if (isim5.StartsWith("b"))
            //{
            //    Console.WriteLine("b ile başlıyor");
            //}
            //else
            //{
            //    Console.WriteLine("B ile başlamıyor");  //*
            //}
            //Console.WriteLine(isim5.EndsWith("Gates") ? "Gates ile bitiyor" : "Gates ile bitmiyor"); //Gates ile bitiyor mu

            //if (isim5.Contains("ga")) //ga içeriyor mu  başlayanda olabılır bıten de veya ıcınde gecen de olabılır
            //{
            //    Console.WriteLine("İsim ga içeriyor");
            //}
            //else
            //{
            //    Console.WriteLine("İsim ga içermiyor");
            //}
            //if (isim5.Contains("ate"))
            //    Console.WriteLine("isim ate içeriyor"); //*
            //else
            //    Console.WriteLine("isim ate içermiyor");

            //Console.WriteLine();

            //Console.Write("Kelime: ");
            //string kelime = Console.ReadLine();
            //Console.Write("Tekil olup olmadığını bulacak harf: ");
            //string harf = Console.ReadLine();
            //int harfSayisi = KelimeIcindekiHarfSayisi(kelime, harf[0]); //"a"
            //if (harfSayisi == 0)
            //{
            //    Console.WriteLine("harf bulunamadı.");
            //}
            //else if (harfSayisi == 1)
            //{
            //    Console.WriteLine("tekil"); //kelime içinde bır harf kaç tane tekil mi çoğulmu
            //}
            //else
            //{
            //    Console.WriteLine("tekil değil");
            //}
            //int harfIndex = kelime.IndexOf(harf);// kelimenin içinde harf bulduğu ilk indexi verir baştan başlar  son ındex 1 // yoksa -1
            //int lastIndex = kelime.LastIndexOf(harf);  //baştan başlayarak tarar son ındexı bulur // son ındex 1'den başlar // yoksa -1
            //if (harfIndex == -1)
            //    Console.WriteLine("harf bulunamadı");
            //else if (harfIndex == lastIndex)
            //    Console.WriteLine("Tekil");
            //else
            //    Console.WriteLine("tekil değil");

            //string mesaj = "Dünya";
            //// mesaj += "!";
            //mesaj = mesaj.Insert(5, "!"); //Dünya!;  //ekleme
            //Console.WriteLine(mesaj); // Dünya!

            //mesaj = "Merhaba " + mesaj;
            //mesaj = mesaj.Insert(0, "Merhaba "); //Merhaba Dünya!
            //Console.WriteLine(mesaj);

            //mesaj = mesaj.Insert(8, "Güzel ");  //Merhaba Güzel Dünya
            //Console.WriteLine(mesaj);

            //mesaj = mesaj.Remove(8, 6); // Güzel           ilk değer index sonrakı kaç karakter kaldır
            //Console.WriteLine(mesaj); // Merhaba Dünya!

            //// mesaj=mesaj.Remove(7,7)
            //mesaj = mesaj.Remove(7); // Merhaba
            //Console.WriteLine(mesaj);


            ////A123456-7, A:Abone tipi(A:biraysel, B:kurumsal), 123456:bina no, -7:daire no
            //Console.Write("Abone numarası giriniz: ");
            //string aboneNo = Console.ReadLine();
            ////yapılmasa daha iyi
            ////string aboneTipi = "" + aboneNo[0]; //'A' -> "A"
            ////string aboneTipi = aboneNo[0] + ""; //'A' -> "A"

            ////yapılabilir
            ////string aboneTipi = aboneNo[0].ToString(); //'A' -> "A"

            ////yapılabilir
            //string aboneTipi = aboneNo.Substring(0, 1); //'A' -> "A"   ilk değer başlama index kaç karakter alınacak değer
            //string binaNo = aboneNo.Substring(1, 6);   //"123456"
            //string daireNo = aboneNo.Substring(8); //"7" ? "A123456-13" ->", "A123456-100" ->"

            //string aboneTipiSonuc = aboneTipi == "A" ? "Bireysel" : "Kurumsal";

            //Console.WriteLine($"abone tipi: {aboneTipiSonuc}, bina no: {binaNo}, daire no: {daireNo}");

            //string ulke = "Türkiye";
            //Console.WriteLine(ulke.ToLower() + ", " + ulke.ToUpper());  //türkiye TÜRKİYE

            ////hocam amma çok string methodu varmış
            //Console.WriteLine("cümle: ");
            //string cumle = Console.ReadLine();
            //string[] kelimeler = cumle.Split(' ');

            //foreach (string k in kelimeler)
            //{
            //    Console.WriteLine(k);
            //}

            //Bir metin içerisinde tek haneli sayılara kadar olan metinsel verileri parça parça yazdırma ve en uzun parçayı bulup yazdırma:
            // örenek veri: Merve1Bayıdnır2Zümra3Kutluhan
            Console.Write("Metin giriniz: ");
            string metin = Console.ReadLine();
            char[] ayraclar = new char[10];
            for (int i = 0; i <= 9; i++)
            {
                ayraclar[i] = i.ToString()[0];
            }
            //string[] metinParcalari = metin.Split('0', '1', '2', '3','4','5','6','7'); ;
            string[] metinParcalari = metin.Split(ayraclar);
            Console.WriteLine("Metin parçalari: ");
            foreach (string metinParcasi in metinParcalari)
            {
                Console.WriteLine(metinParcasi);
            }
            Console.WriteLine("En uzun parça: ");
            int enUzunMetinParcasiUzunlugu = metinParcalari[0].Length;
            int enUzunMetinParcasiIndexi = 0;
            for (int i = 1; i < metinParcalari.Length; i++)
            {
                if (metinParcalari[i].Length > enUzunMetinParcasiUzunlugu)
                {
                    enUzunMetinParcasiUzunlugu = metinParcalari[i].Length;
                    enUzunMetinParcasiIndexi = i;
                }
            }
            Console.WriteLine(metinParcalari[enUzunMetinParcasiIndexi] + "(" + enUzunMetinParcasiUzunlugu + ")");




        }
        static int KelimeIcindekiHarfSayisi(string kelime, char harf)
        {
            int harfSayisi = 0;
            foreach (char karakter in kelime)
            {
                if (karakter == harf)
                {
                    harfSayisi++;
                }
            }
            return harfSayisi;
        }
        //static int GetIndex(string kelime, char harf)
        //{
        //    for (int i = 0; i < kelime.Length; i++)
        //    {
        //        if (kelime[i] == harf)
        //        {
        //            return i;
        //        }
        //        return -1;
        //    }
        //}
    }
}