﻿namespace Condicional
{
    class Progran
    {
        static void Main(string[] args)
        {
            var Teste = 1;
            switch (Teste)
            {
                case 1:

                    Console.WriteLine("Um...!!!");
                    break;

                case 2:

                    Console.WriteLine("Dois...!!!");
                    break;

                default:

                    Console.WriteLine("Não encontrou nada...!!!");
                    break;
            }
        }
    }
}