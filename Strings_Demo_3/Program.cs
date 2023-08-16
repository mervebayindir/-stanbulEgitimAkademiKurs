namespace Strings_Demo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //boşlukla ayrılmış kelimelerde girilen bir kelimeyi eş anlamlısı ile değiştirme
            string cumle = "Macera Beyaz Siyah Rüya Anı";
            Console.WriteLine($"Cümle: {cumle}");
            string[,] esAnlamliKelimeler = new string[5, 2]
            {
                {"Macera", "Serüven" },
                {"Beyaz", "Ak" },
                {"Siyah", "Kara" },
                {"Rüya", "Düş" },
                {"Anı", "Hatıra" }

            };
            Console.WriteLine("Eş anlamları ile değiştirilmiş kelimeler: " + SplitIleEsAnlamlilariDegistir(esAnlamliKelimeler, cumle));
        }

        static string SplitIleEsAnlamlilariDegistir(string[,] esAnlamliKelimeler, string cumle, char ayrac = ' ')
        {
            string sonuc = "";
            string[] kelimeler = cumle.Split(ayrac);
            foreach (string kelime in kelimeler)
            {
                for (int satir = 0; satir <= esAnlamliKelimeler.GetUpperBound(0); satir++)
                {
                    if (kelime == esAnlamliKelimeler[satir,0])
                    {
                        sonuc += esAnlamliKelimeler[satir, 1] + ayrac;
                        break;
                    }
                }
            }
            return sonuc.TrimEnd(ayrac);
        }
    }
}