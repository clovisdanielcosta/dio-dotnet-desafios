using System;
using System.Numerics;

namespace dio_dotnet_desafios
{
    public class Program_TrigoTabuleiro
    {
        public static void Main_TrigoTabuleiro(string[] args)
        {
            int qtdTeste = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdTeste; i++)
            {
                int casas = int.Parse(Console.ReadLine());
                var graos = new BigInteger(1);
                
                while(casas != 0){
                    graos = graos * 2;
                    casas--;
                }
                Console.WriteLine($"{graos/12000} kg");
            }
        }
    }
}
