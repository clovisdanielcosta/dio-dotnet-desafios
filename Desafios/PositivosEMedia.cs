using System;

namespace dio_dotnet_desafios
{
    public class Program_PosMed
    {
        public static void Main_PosMed(string[] args)
        {
           double soma = 0, media = 0, positivos = 0;
            
            for (double i = 1; i <= 6; i++)
            {
              var entrada = Double.Parse(Console.ReadLine());
              
              if (entrada > 0)
                {
                   positivos++;
                   soma = soma + entrada;
                }
            }   
            
            media = Math.Round(soma / positivos, 1);
            Console.WriteLine("{0} valores positivos", positivos);
            Console.WriteLine("{0}", media);
        }
    }
}