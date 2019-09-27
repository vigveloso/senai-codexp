using System;

namespace Exercício_Array
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Exercício 3 Arrays");
           
            string[] produtos = new string[3]; //Array é igual a vetor Colchetes
           

            Console.WriteLine("Digite o Primeiro Produto");
            produtos[0] = Console.ReadLine();

            Console.WriteLine("Digite o segundo produto");
            produtos[1] = Console.ReadLine();

            Console.WriteLine("Digite o Terceiro Produto");
            produtos[2] = Console.ReadLine();


            Console.WriteLine("---------Listando----------");

            Console.WriteLine(produtos[0]);
            Console.WriteLine(produtos[1]);
            Console.WriteLine(produtos[2]);


        }
    }
}
