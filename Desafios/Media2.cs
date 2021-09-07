using System;

namespace dio_dotnet_desafios
{
    public class Program_Med2
    {
        public static void Main_Med2(string[] args)
        {
           double A, B, C;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            
            var media = Math.Round((A * 0.20 + B * 0.30 + C * 0.50),1);
            
            Console.WriteLine($" MEDIA = {media}");
            Console.ReadKey();
        }
    }
}