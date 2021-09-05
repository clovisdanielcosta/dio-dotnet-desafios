using System;
using System.Numerics;

namespace dio_dotnet_desafios
{
    public class Program2
    {
        public static void Main2(string[] args)
        {
            int qtdTeste = 9;
            int[] valoresRecebidos = {0, 8, 16, 24, 32, 40, 48, 56, 64};
            
            for (int i = 0; i < qtdTeste; i++)
            {
                var graos = new BigInteger(1);
                int casas = valoresRecebidos[i];
             
                while (casas != 0){
                    graos = graos * 2;
                    casas--;
                }
            Console.WriteLine($"{graos/12000} kg");
            }

        }
    }
}
