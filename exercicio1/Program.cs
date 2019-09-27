using System;

namespace PrimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Aqui é onde iremos inserir o código
           Console.WriteLine("Soma de dois números");//mensagem que aparece para o usuario

           int n1;//variável numero 1//
           int n2;//entrada manual//
           Console.WriteLine("Digite o Primeiro Número");
           n1= int.Parse(Console.ReadLine());
           Console.WriteLine("Digite o Segundo Número");
           n2 = int.Parse(Console.ReadLine());
           int resultado = n1+n2;
           Console.WriteLine($"O resultado é: {resultado}");

        }
    }
}
