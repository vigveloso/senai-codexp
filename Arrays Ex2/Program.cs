using System;

namespace Arrays_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício de Arrays 2");
            string[] nomes = new string[5];
            string[] telefones = new string[5];
            string[] email = new string[5];

            int contador = 0;
            while(contador <= 2){
                Console.WriteLine("Digite o seu nome");
                nomes[contador] = Console.ReadLine();

                Console.WriteLine("Digite o seu telefone");
                telefones[contador] = Console.ReadLine();

                Console.WriteLine("Digite seu email");
                email[contador] = Console.ReadLine();
                contador++;
            }//fim do while

            int contadorB = 0;
            while(contadorB <= 2){
                Console.WriteLine($"O cliente número {contadorB+1} - Nome: {nomes[contadorB]}, Tel: {telefones[contadorB]}");
                contadorB++;
            }//fim do while
        }
    }
}
