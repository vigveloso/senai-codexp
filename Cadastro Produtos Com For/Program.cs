using System;

namespace Cadastro_Produtos_Com_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de Produtos com For");

            string[] produtoNome = new string[3];
            double[] produtoPreco = new double[3];

            for(int i = 0; i < 3; i ++) // 
            {
                Console.WriteLine($"Digite o nome do {i+1}º produto");
                produtoNome[i] = Console.ReadLine();
                Console.WriteLine("Digite o Preço:");
                produtoPreco[i] = double.Parse(Console.ReadLine());
            }

            foreach (var produto in produtoNome)
            {
                Console.WriteLine($"Produto: {produto}");
            }

            for (int i = 0; i < 3; i++)
                Console.WriteLine($"Produto: {produtoNome[i]}");
             }
        }
    }
