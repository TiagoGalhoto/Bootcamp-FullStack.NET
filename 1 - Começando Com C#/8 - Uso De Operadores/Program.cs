namespace Operador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World...!!!");

            Console.WriteLine("Soma mais um...!!!");
            var Teste = 1;
            Teste++;
            Console.WriteLine(Teste);

            Console.WriteLine("Subtrai um...!!!");
            var TesteB = 2;
            TesteB--;
            Console.WriteLine(TesteB);

            Console.WriteLine("Iguala um valor...!!!");
            var TesteC = 2023;
            TesteC = 1992;
            Console.WriteLine(TesteC);

            Console.WriteLine("Atribui somando o valor...!!!");
            var TesteD = 1992;
            TesteD += 2023;
            Console.WriteLine(TesteD);

            Console.WriteLine("Atribui subtraindo o valor...!!!");
            var TesteE = 2023;
            TesteE -= 1992;
            Console.WriteLine(TesteE);

            Console.WriteLine("Atribui multiplicando o valor....!!!");
            var TesteF = 10;
            TesteF *= 100;
            Console.WriteLine(TesteF);

            Console.WriteLine("Atribui dividindo o valor...!!!");
            var TesteG = 1000;
            TesteG /= 10;
            Console.WriteLine(TesteG);
        }
    }
}