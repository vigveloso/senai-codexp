using System;

namespace EXERCÍCIOaumentosalário
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa Aumento Salário");
            
            //Entrada de dados
            Console.WriteLine("Digite seu salário");
            double salário = double.Parse(Console.ReadLine()); //quando vou receber texto

            //Processamento
            if (salário <= 990){ 
                salário = salário * 0.3;
                Console.WriteLine("Seu salário aumentou "+ salário);//concatenção
                Console.WriteLine($"Seu salário aumentou {salário}");//interpolação
            }
            else{
                Console.WriteLine ("Seu salário não será reajustado");
            }


        }
    }
}
