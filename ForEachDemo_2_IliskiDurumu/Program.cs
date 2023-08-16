namespace ForEachDemo_2_IliskiDurumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorular = new string[5]
            {
                "Kıskanç mısın? (1:hayır, 2:evet)",
                "Aşk mı para mı? (1:aşk, 2:para)",
                "Köpek mi kedi mi? (1:köpek, 2:kedi)",
                "Marka takıntılı mısın? (1:hayır, 2:evet)",
                "Zeka mı tip mi? (1:zeka, 2:tip)"
            };
            string[] cevaplar = new string[sorular.Length];
            int sayac = 0;
            foreach (string soru in sorular)
            {
                Console.WriteLine(soru + " ");
                cevaplar[sayac++] = Console.ReadLine();
                //sayac++; yukarıdaki gibi de artırılır aynı işlem
            }
            int yuzde = 0;
            foreach (string cevap in cevaplar)
            {
                if (cevap == "1")
                {
                    yuzde += 20;
                }
            }
            if (yuzde > 70)
            {
                Console.WriteLine("Harika bir ilişki olabilir.");
            }
            else if (yuzde >= 30 && yuzde<= 70)
            {
                Console.WriteLine("Bir şans verilebilir.");
            }
            else
            {
                Console.WriteLine("Kaç kurtar kendini.");
            }
        }
    }
}