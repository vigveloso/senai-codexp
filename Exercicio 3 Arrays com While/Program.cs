using System;

namespace Exercicio_3_Arrays_com_While
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Exercício 3 Arrays");
           
         string[] produtos = new string[3]; //Array é igual a vetor Colchetes - essa é a linha que declara o vetor
        
        int contador = 0; //precisa declara de onde comecar porque se nao o programa nao vai saber

        while(contador <= 2){

            Console.WriteLine($"Digite o produto nº"); //aparece na tela

            produtos[contador] = Console.ReadLine(); // recebe a informação dentro do vetor e nas posições certas - ode tem colchete é a aplicação do array

            contador++; //adiciona um valor extra a cada rodada
        }

        Console.WriteLine("---------Listando----------");
      //IMPRIMINDO 
        int contadorB = 0; // está B só pra ajudar na identificação
        while(contadorB <=2){
            Console.WriteLine(produtos[contadorB]);
            contadorB++;
        }

        }
    }
}