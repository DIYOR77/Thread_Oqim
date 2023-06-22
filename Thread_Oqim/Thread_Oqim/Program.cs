namespace Thread_Oqim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter number: ");
            int number=int.Parse(Console.ReadLine());
            Thread thread = new Thread(() => NUMBERall(number));
            thread.Start();
        }
        public static void NUMBERall(int number)
        {
            for(int i = 0; i < number; i++)
            {
                Console.Write(i+"  ");
            }
        }
    }
}