using System;

namespace Validação_com_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação com Do While");
            string email;
            do
            {
                Console.WriteLine("Digite seu email");
                email = Console.ReadLine();

            }while (!email.Contains("@") || !email.Contains(".")); //do while verifica a condição depois
        
        string senha;
        do
        {
        Console.WriteLine("Digite a senha");
        senha = Console.ReadLine();
        } while (senha.Length <= 6);
        
        }
    }
}
