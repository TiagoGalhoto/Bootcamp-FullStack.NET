namespace Condicional
{
    class Program
    {
        static void Main(string[] argds)
        {
            var Teste = 1;
            if (Teste == 2)
                Console.WriteLine(Teste);
            else if (Teste == 3)
                Console.WriteLine(Teste);
            //else
            //Console.WriteLine(Teste);

            var TesteB = "Sou uma string...!!!";
            if (TesteB == "sou uma string...!!!")
                Console.WriteLine(TesteB);
            else if (TesteB == "sou uma string...!!!")
                Console.WriteLine(TesteB);
            //else
            //Console.WriteLine(TesteB);

            var TesteC = 1;
            if (TesteC >= 2)
                Console.WriteLine(TesteC);
            else if (TesteC >= 3)
                Console.WriteLine(TesteC);
            //else
            //Console.WriteLine(TesteC);

            var TesteD = 3;
            if (TesteD <= 2)
                Console.WriteLine(TesteD);
            else if (TesteD <= 3)
                Console.WriteLine(TesteD);
            //else
            //Console.WriteLine(TesteD);

            var TesteE = 5;
            if (TesteE > 2)
                Console.WriteLine(TesteE);
            else if (TesteE > 3)
                Console.WriteLine(TesteE);
            //else
            //Console.WriteLine(TesteE);

            var TesteF = 4;
            if (TesteF < 3)
                Console.WriteLine(TesteF);
            else if (TesteF < 5)
                Console.WriteLine(TesteF);
            //else
            //Console.WriteLine(TesteF);

            var TesteG = 3;
            if (TesteG != 3)
                Console.WriteLine(TesteG);
            else if (TesteG != 6)
                Console.WriteLine(TesteG);
            //else 
            //Console.WriteLine(TesteG);
        }
    }
}