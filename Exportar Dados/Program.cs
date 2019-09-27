using System;

namespace Exportar_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu endereço");
            string endereço = Console.ReadLine();

            Console.WriteLine("Digite a data da sua compra");
            int data = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da sua compra");
            int compra = int.Parse(Console.ReadLine());

        Document documento = new Document();
        
        Section secao = documento.AddSection();

        Paragraph paragrafo = secao.AddParagraph();
        CharacterFormat format = new CharacterFormat(documento);
        format.Bold = true;

        paragrafo.AppendText("Nome").ApplyCharacterFormat(format);
        paragrafo.AppendText(nome);

        documento.SaveToFile("result.docx", FileFormat.Docx)

        }
    }
}
