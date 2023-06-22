using System.Security.Cryptography;

namespace Thread_Oqim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter number: ");
            int number=int.Parse(Console.ReadLine());
            Thread thread = new Thread(()=>TUB(number));
            Thread thread1 = new Thread(()=>JUFT(number));
            thread.Start(); 
            thread1.Start();

        }
        public static void TUB(int number)
        {
            for(int i = 0; i < number; i++)
            {
                int count = 0;
                for(int  j = 1; j <=number; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if(count==2)
                {
                    Console.WriteLine($" Tub: {i}");
                    Thread.Sleep(400);
                }
            }
        }
        public static void JUFT(int number)
        {
            for(int i=0; i < number; i++) 
            {
                if (i % 2 == 0)
                {
                    Thread.Sleep(200);
                    Console.WriteLine($" Juft: {i}");
                }
            }
        }
    }
}