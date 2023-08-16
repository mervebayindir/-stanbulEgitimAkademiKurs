namespace ForLoopDemo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 65; i <= 90; i++)
            {
                Console.Write((char)i + "  ");
            }
            Console.WriteLine("**********************");
            for (int i = 97; i <= 122; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine("*******************");
            for (char c = 'A'; c < 'Z'; c++)
            {
                // !((c>='A' && c<='Z' || c>='a' && c<='z'))   ünlemi dağıtıyoruz
                // (c < 'A' || c > 'Z' )  && (c < 'a' || c > 'z')
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    Console.Write(c + " ");
                }

            }
        }
    }
}