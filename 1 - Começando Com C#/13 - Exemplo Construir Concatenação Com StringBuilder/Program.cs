/*
Construindo concatenação, utilizando StringBuilder de forma a ocupar menos locação de memória.
*/
using System.Text;

namespace MeuConsoleApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            var Teste = new StringBuilder();
            Teste.Append ("Meu Texto...!!!");
            Teste.Append ("Meu Texto 2...!!!");
            Teste.Append ("Meu Texto 3...!!!");
            Teste.Append ("Meu Texto 4...!!!");
            Console.WriteLine(Teste.ToString());
        }
    }
}
