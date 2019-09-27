using System;

namespace laço_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laço de Repetição Tabuada");
     
     
            Console.WriteLine("Digite qual tabuada deseja conhecer");
            float numero = float.Parse(Console.ReadLine());//8

            Console.WriteLine("Digite onde quer que inicie o mult");
            float iniciomultiplicador = float.Parse(Console.ReadLine());//8

             Console.WriteLine("Digite onde quer que termine o mult");
            float finalmultiplicador = float.Parse(Console.ReadLine());//8
            

            Console.WriteLine("------------------------------------");
            
            while(iniciomultiplicador<=finalmultiplicador)
            {
                Console.WriteLine(numero*iniciomultiplicador);
                iniciomultiplicador = iniciomultiplicador + 1;
            }

        }
    }
}
