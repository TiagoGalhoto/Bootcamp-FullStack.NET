/*
Exemplo de concatenação de texto utilizando maior alocação de memoria...
*/

namespace ConstruirStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = "Meu Texto...!!!";
            teste += "Meu Texto 2...!!!";
            teste += "Meu Texto 3...!!!";
            teste += "Meu Texto 4...!!!";
            Console.WriteLine(teste);
        }
    }
}
