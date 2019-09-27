using System;

namespace Rodízio_Veicular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicativo de Rodízio Veicular");
            Console.WriteLine("Insira o número da placa do seu carro");
            
            string placa = Console.ReadLine(); //string porque a placa tem letra e númros também
            int caracteres = placa.Length;
            int final = int.Parse(placa.Substring(caracteres - 1));

            Console.WriteLine($"A posição 0 é: {final}");
            if (final == 0 || final == 1){
            Console.WriteLine("O dia do seu rodízio é segunda-feira");
        }else if (final == 2 || final == 3){
            Console.WriteLine ("O dia do seu rodízio é terça-feira");
        } else if (final == 4 || final == 5){
            Console.WriteLine ("O dia do seu rodízio é quarta-feira");
        } else if (final == 6 || final == 7){
            Console.WriteLine ("O dia do seu rodízio é quinta-feira");
        }else if (final == 8 || final == 9){
            Console.WriteLine ("O dia do seu rodízio é sexta-feira");
        }else{
            Console.WriteLine ("Insira apenas o último dígito");
        }
    }
}
}