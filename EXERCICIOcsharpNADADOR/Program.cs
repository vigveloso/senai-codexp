using System;

namespace EXERCICIOcsharpNADADOR
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados
            Console.WriteLine("App Nadador");
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());
            //int.Parse é para converter letra para nro, assim como parentesis

            //Processamento
            if (idade <= 7){
                Console.WriteLine("Você fará parte do Infantil A");
        }else if (idade <=10){
            Console.WriteLine ("Infantil B");
        } else if (idade <=13){
            Console.WriteLine ("Juvenil A");
        } else if (idade <=17){
            Console.WriteLine ("Juvenil B");
        }else {
            Console.WriteLine ("Adulto");
        }
    }
}
}
