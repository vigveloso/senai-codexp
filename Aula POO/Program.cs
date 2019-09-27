using System;
using Aula_POO.Models;

namespace Aula_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoModel aluno1 = new AlunoModel ();//como o arquivo aluno modelo está publico, a 
            //variavel aluno model esta sendo reaproveitada e logo não precisa ser apresentada
            //aqui novamente!
            Console.Clear();

            Console.WriteLine("Insira o nome do aluno");
            aluno1.Nome = Console.ReadLine();

            Console.WriteLine("Insira o curso");
            aluno1.Curso = Console.ReadLine();

            Console.WriteLine("Insira o RG");
            aluno1.RG = Console.ReadLine();

            Console.WriteLine("Insira a Idade");
            aluno1.Idade = Console.ReadLine();

            Console.WriteLine($@"
            
            Nome: {aluno1.Nome}
            Curso: {aluno1.Curso}
            Rg: {aluno1.RG}
            Idade: {aluno1.Idade}
            ");

        }
    }
}
