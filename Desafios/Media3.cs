using System;
using System.Globalization;

namespace dio_dotnet_desafios
{
    public class Program_Med3
    {
        public static void Main_Med3(string[] args)
        {
            double notaA, notaB, notaC, notaD, media;
            string[] notasRecebidas = Console.ReadLine().Split(" ");
      
            notaA = double.Parse(notasRecebidas[0]) * 0.2;
            notaB = double.Parse(notasRecebidas[1]) * 0.3;
            notaC = double.Parse(notasRecebidas[2]) * 0.4;
            notaD = double.Parse(notasRecebidas[3]) * 0.1;
            media = (notaA + notaB + notaC + notaD);
            
            Console.WriteLine("Media: " + media.ToString("0.0"));
            
            if (media > 6.9 && media <= 7) {}
            else if (media > 7) Console.WriteLine("Aluno aprovado.");
            else if (media < 5) Console.WriteLine("Aluno reprovado.");
            else if (media >= 5 && media <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                
                double notaExame = double.Parse(Console.ReadLine());
                
                media = (media + notaExame) / 2;
                
                Console.WriteLine("Nota do exame: {0}", notaExame.ToString("0.0"));
                
                if (media >= 5) Console.WriteLine("Aluno aprovado.");
                else Console.WriteLine("Aluno reprovado");
              
                Console.WriteLine("Media final: {0}", media.ToString("0.0"));
            }
        }
    }
}

            
