using System.Transactions;

namespace Thread_Oqim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Thread thread = new Thread(() => TUB(number));
            Thread thread1 = new Thread(() => JUFT(number));
            thread.Start();
            thread1.Start();
        }
        public static void TUB(int number)
        {
            string path = "C:\\Project\\TUB.txt";
            if(!File.Exists(path))
            {
                File.Create(path).Close();
                using(StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(" TUB sonlar: ");
                    for (int i = 0; i < number; i++)
                    {
                        
                        int count = 0;
                        for (int j = 1; j <= number; j++)
                        {
                            if (i % j == 0)
                            {
                                count++;
                            }
                        }
                        if (count == 2)
                        {
                            sw.Write(i+" ");
                            
                        }
                    }
                }
            }
        }
        public static void JUFT(int number)
        {
            string path = "C:\\Project\\JUFT.txt";
            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(" JUFT sonlar: ");
                for (int i = 0; i < number; i++)
                {
                    if (i % 2 == 0)
                    {
                       sw.Write(i+" ");
                    }
                }
            }
            
        }
    }      
}