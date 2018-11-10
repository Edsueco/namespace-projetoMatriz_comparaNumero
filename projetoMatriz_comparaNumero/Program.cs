using System;

namespace projetoMatriz_comparaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int qtde = 0;
            string msg = "";
            int[,] matriz = new int[2, 2];

            Console.Write("INFORME UM NUMERO:");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 2; i++){
                for (int j = 0; j < 2; j++){
                    Console.Write("INFORME A LINHA {0} E A COLUNA {1} DA MATRIZ: ", i, j);
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (num == matriz[i, j])
                    {
                        msg += "LINHA: " + i + " E COLUNA " + j + "VALOR INFORMADO: " + matriz[i, j] + "\n";
                        qtde += 1;
                    }
                }
            }
            Console.WriteLine("RESULTADO: {0}", qtde);
            Console.WriteLine("\nENDEREÇO DOS REGISTROS INFORMADOS:");
            Console.WriteLine(msg);
        }
    }
}
