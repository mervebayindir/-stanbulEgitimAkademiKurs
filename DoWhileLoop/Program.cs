namespace DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 11;
            do
            {
                Console.WriteLine("do while: " + i);
                i++;
            }
            while (i <= 10);

            while (i <= 10)
            {
                Console.WriteLine("while: " + i);
            }
        }
    }
}