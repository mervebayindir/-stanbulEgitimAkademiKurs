namespace ForEachDemo1_PlakaVeSehirler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] plakaVeSehirler = new string[3, 2]
            {
                {"06", "Ankara" },
                {"34", "İstanbul" },
                {"35", "İzmir" },
            };
            foreach (string plakaVeSehir in plakaVeSehirler)
            {
                Console.WriteLine(plakaVeSehir);
            }
            for (int satir = 0; satir <= plakaVeSehirler.GetUpperBound(0); satir++)
            {
                for (int sutun = 0; sutun <= plakaVeSehirler.GetUpperBound(1); sutun++)
                {
                    Console.WriteLine(plakaVeSehirler[satir, sutun] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}