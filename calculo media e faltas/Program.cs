using System;

namespace calculo_media_e_faltas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App Cálculo de Média e Faltas");
            Console.WriteLine("Bem Vindo a Escola SENAI de Informática");

            //Entrada de dados
            Console.WriteLine("Digite a primeira nota"); //Mensagem na tela
            int nota1 = int.Parse(Console.ReadLine()); //Inserção da nota1

            Console.WriteLine("Digite a segunda nota"); //Mensagem na tela
            int nota2 = int.Parse(Console.ReadLine()); //Inserção da nota1

            Console.WriteLine("Digite a quantidade de faltas"); //Mensagem na tela
            int faltas = int.Parse(Console.ReadLine()); //Inserção das faltas

            //Processamento
            double media = (nota1+nota2)/2;

            if(media>=50 && faltas<=30){
            //resultado verdadeiro
            Console.WriteLine("Parabéns, você foi aprovado!");
        }else{
            //resultado falso
            Console.WriteLine("Você foi reprovado");
        }
        }
    }
}
