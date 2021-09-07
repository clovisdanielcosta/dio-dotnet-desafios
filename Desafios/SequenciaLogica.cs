using System;

namespace dio_dotnet_desafios
{
    public class Program_SeqLog
    {
        public static void Main_SeqLog(string[] args)
        {
           int n = Convert.ToInt32(Console.ReadLine());
            for ( int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} {i*i} {i*i*i}");
                Console.WriteLine($"{i} {i*i+1} {i*i*i+1}");
            }        
        }
    }
}