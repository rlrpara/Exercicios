using System;

namespace Questor.Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;

            Console.WriteLine("Calcular números Reais em C#");
            Console.WriteLine("----------------------------\n");

            Console.WriteLine("Informe o 1º número natutal e aperte Enter.");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o 2º número natural e aperte Enter.");
            num2 = Convert.ToInt32(Console.ReadLine());

            var resultado = CalculaValor(num1, num2).ToString();

            Console.WriteLine($"Seu resultado é {resultado}");
            Console.WriteLine("Pressione uma tecla para encerrar");
            Console.ReadKey();
        }

        static int CalculaValor(int valor1, int valor2)
        {
            int[] resultado = new int[99];
            int valor = 0;

            for (int i = valor1; i <= valor2; i++)
                resultado[i] = i;

            foreach (var x in resultado)
                valor += resultado[x];

            return valor;
        }
    }
}
