using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo Funções");

            Console.WriteLine("Digite o primeiro número");
            int numero1 = int.Parse(Console.ReadLine());//
            Console.WriteLine("Digite o segundo número");
            int numero2 = int.Parse(Console.ReadLine());

            int resultadoDaSoma = SomaDeDoisNumeros(numero1, numero2);
            Console.WriteLine($"O resultado da soma é{resultadoDaSoma}");
            }//fim do main
            
            
            /// <summary>
            /// Efetua a soma de dois números
            /// </summary>
            /// <param name="a">Primeiro valor inteiro</param>
            /// <param name="b">Segundo valor inteiro</param>
            /// <returns>Retorna a soma dos dois números</returns>
            int SomaDeDoisNumeros(int a, int b)
            {
                int soma = a + b;

                return soma;
            }

            public static string MensagemBoasVindas()
            {
                return "Bem vindo ao SENAI de Informática";
            }
    }
}
