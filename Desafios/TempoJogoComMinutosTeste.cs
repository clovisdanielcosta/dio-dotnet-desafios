using System;

namespace dio_dotnet_desafios
{
    public class Program_TempoJogoTeste
    {
        public static void Main_TempoJogoTeste(string[] args)
        {
            int hhInicial, hhFinal, mmInicial, mmFinal;
            string[] valoresRecebidos = {
                    "7 8 9 10",     //O JOGO DUROU 2 HORA(S) E 2 MINUTO(S)
                    "7 10 9 8",     //O JOGO DUROU 1 HORA(S) E 58 MINUTO(S)
                    "7 10 9 10",    //O JOGO DUROU 2 HORA(S) E 0 MINUTO(S)
                    "9 8 7 10",     //O JOGO DUROU 22 HORA(S) E 2 MINUTO(S)
                    "9 10 7 8",     //O JOGO DUROU 21 HORA(S) E 58 MINUTO(S)
                    "10 10 10 10", //O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)
                    "9 10 10 10",  //O JOGO DUROU 1 HORA(S) E 0 MINUTO(S)
                    "10 10 9 10",  //O JOGO DUROU 23 HORA(S) E 0 MINUTO(S)
                    "7 7 7 7",     //O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)
                    "7 8 9 10",     //O JOGO DUROU 2 HORA(S) E 2 MINUTO(S)
                    "7 10 8 9",     //O JOGO DUROU 0 HORA(S) E 59 MINUTO(S)
                    "7 9 6 1",      //O JOGO DUROU 22 HORA(S) E 52 MINUTO(S)
                    "9 10 9 9",     //O JOGO DUROU 23 HORA(S) E 59 MINUTO(S)
                    "9 10 9 10",    //O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)
                    "5 15 2 10",    //O JOGO DUROU 20 HORA(S) E 55 MINUTO(S)
                    "0 2 24 5",     //O JOGO DUROU 24 HORA(S) E 3 MINUTO(S)
                    "24 60 24 59",  //O JOGO DUROU 23 HORA(S) E 59 MINUTO(S)
                    "0 0 0 0",      //O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)
                    "0 0 0 1",      //O JOGO DUROU 0 HORA(S) E 1 MINUTO(S)
                    "0 0 1 0",      //O JOGO DUROU 1 HORA(S) E 0 MINUTO(S)
                    "0 1 0 0",      //O JOGO DUROU 23 HORA(S) E 59 MINUTO(S)
                    "1 0 0 0",      //O JOGO DUROU 23 HORA(S) E 0 MINUTO(S)
                    "7 10 10 7",   //O JOGO DUROU 2 HORA(S) E 57 MINUTO(S)
                    "7 10 10 10",  //O JOGO DUROU 3 HORA(S) E 0 MINUTO(S) 
                    "7 10 10 7",   //O JOGO DUROU 2 HORA(S) E 57 MINUTO(S)
                    "7 10 7 7",    //O JOGO DUROU 23 HORA(S) E 57 MINUTO(S)
                    "7 7 7 7",     //O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)
                    "7 7 7 10",    //O JOGO DUROU 0 HORA(S) E 3 MINUTO(S)
                    "7 7 10 10",   //O JOGO DUROU 3 HORA(S) E 3 MINUTO(S) 
                    "10 7 7 10",   //O JOGO DUROU 21 HORA(S) E 3 MINUTO(S)
                    "10 10 7 7",   //O JOGO DUROU 20 HORA(S) E 57 MINUTO(S)
                    "10 10 7 10",  //O JOGO DUROU 21 HORA(S) E 0 MINUTO(S)  
                };
           
           for (int i = 0; i < valoresRecebidos.Length; i++)
           {
                string[] arr = valoresRecebidos[i].Split(" ");
                hhInicial = int.Parse(arr[0]);
                mmInicial = int.Parse(arr[1]);
                hhFinal = int.Parse(arr[2]);
                mmFinal = int.Parse(arr[3]);
                
                int horas = (hhInicial < hhFinal && mmInicial < mmFinal) ? Math.Abs(hhInicial - hhFinal) :
                            (hhInicial < hhFinal && mmInicial > mmFinal) ? Math.Abs(hhInicial - hhFinal) - 1 :
                            (hhInicial < hhFinal && mmInicial == mmFinal) ? Math.Abs(hhInicial - hhFinal) :
                            (hhInicial > hhFinal && mmInicial < mmFinal) ? 24 - Math.Abs(hhInicial - hhFinal) :
                            (hhInicial > hhFinal && mmInicial > mmFinal) ? 24 - Math.Abs(hhInicial - hhFinal) - 1 :
                            (hhInicial == hhFinal && mmInicial < mmFinal) ? Math.Abs(hhInicial - hhFinal) :  
                            (hhInicial == hhFinal && mmInicial > mmFinal) ? 23 : 24 - Math.Abs(hhInicial - hhFinal); 
                                
                int minutos = (mmInicial < mmFinal) ? Math.Abs(mmInicial - mmFinal) :
                        (60 - Math.Abs(mmInicial - mmFinal)) == 60 ? 0 : 60 - Math.Abs(mmInicial - mmFinal);  
            
                Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
           }
        }
    }
}