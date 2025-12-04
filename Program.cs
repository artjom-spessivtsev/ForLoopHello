namespace ForLoopHello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //teha konsoolirakendus, kus kasutad for loopi
            //kolm korda näidatakse Tere tulemast
            ushort i = 0;

            for (; ; )
            {
                Console.WriteLine("Tere inimene");
                i++;
                if (i > 2)
                {
                    break;
                }
            }
        }
    }
}
