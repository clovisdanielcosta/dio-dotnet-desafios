using System;

namespace dio_dotnet_desafios
{
    public class Program_PreenhVetor
    {
        public static void Main_PreenhVetor(string[] args)
        {
            int valorLido = int.Parse(Console.ReadLine());
            int[] n = new int[10];
            
            n[0] = valorLido;
            Console.WriteLine($"N[0] = {n[0]}");
            
            for (int j = 1; j < 10; j++)
            {
                n[j] = n[j-1] * 2;               
                Console.WriteLine($"N[{j}] = {n[j]}");
            }
        }
    }
}