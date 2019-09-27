using System;

namespace Meia_Entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App de Meia Entrada");
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine()); //Inserção da idade

            if(idade<=18 || idade >=60){
            Console.WriteLine("Você tem direito a meia entrada");
            }else{
            Console.WriteLine("Você não tem direito a meia entrada");
            }
        }
    }
}
