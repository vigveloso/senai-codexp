using System;

namespace menu_2_números
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu Switch");

            //entrada de daddos
            Console.WriteLine("Digite o primeiro número");
            float n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            float n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número do cargo para descobrir o salário");
            Console.WriteLine("( a ) - soma");
            Console.WriteLine("( b ) - subtração do primeiro pela segundo");
            Console.WriteLine("( c ) - subtração do segundo pelo primeiro");
            Console.WriteLine("( d ) - multiplicação");
            Console.WriteLine("( e ) - divisão do primeiro pelo segundo");
            Console.WriteLine("( f ) - divisão do segundo pelo primeiro");
            Console.WriteLine("-------------------");
            string resposta = Console.ReadLine();

            switch(resposta){

                case "a":
                float soma = n1 + n2; 
                Console.WriteLine($"O resultado da soma é: {soma}");
                break;

                case "b":
                float subtração1 = n1 - n2;
                Console.WriteLine($"O resultado da subtração é: {subtração1}");
                break;

                case "c":
                float subtração2 = n2 - n1;
                Console.WriteLine($"O resultado da subtração é: {subtração2}");
                break;

                case "d":
                float multiplicacao = n1 * n2;
                Console.WriteLine($"O resultado da multiplicação é: {multiplicacao}");
                break;

                case "e":
                float divisao1 = n1/n2;
                Console.WriteLine($"O resultado da divisão é: {divisao1}");
                break;

                case "f":
                float divisao2 = n2/n1;
                Console.WriteLine($"O resultado da divisão é: {divisao2}");
                break;

            }
        }
    }
}
