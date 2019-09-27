using System;

namespace Exercício_Array_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa Qual a sua idade?");
            int[] idade = new int[10]; //apresentação do vetor

            int contador = 0; // tipo nome = atribuir valor
            while (contador < 10)
            {
                Console.WriteLine("Escreva sua idade");
                idade [contador] = int.Parse(Console.ReadLine());
                contador ++;//se nâo colocar não adiciona um a cada rodada
            }
            contador = 0; //ao final do while o contador com o ++ foi ganhando valor, enâo pe necessário zerar ele
            
                int contadoridade = 0;
            while (contador < 10)
            {
                if(idade[contador] >= 18)
                {
                 contadoridade ++;
                }
                contador ++;
            }

            Console.WriteLine($"A quantidade de pessoas maiores de 18 anos é {contadoridade}");
            Console.WriteLine($"A quantidade de pessoas menores de 18 anos é {10 - contadoridade}");
        }
    }
}
