using System;
using System.Globalization;

namespace dio_dotnet_desafios
{
    public class Program4
    {
        public static void Main4(string[] args)
        {
        //complete os espaços em branco com sua solução para o problema
            string[] valores = ("3.5 -2").Split(" ");
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0) Console.WriteLine("Origem");
            else if (x == 0 && y > 0 ||x == 0 && y < 0) Console.WriteLine("Eixo Y");
            else if (y == 0 && x > 0 ||y == 0 && x < 0) Console.WriteLine("Eixo X");
            else if (x > 0  && y > 0) Console.WriteLine("Q1");
            else if (x < 0 && y > 0) Console.WriteLine("Q2");
            else if (x < 0 && y < 0) Console.WriteLine("Q3");
            else if (x > 0 && y < 0) Console.WriteLine("Q4");
            //else Console.WriteLine("Q4");
        }
    }
}

