namespace CondicionalEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa();
            pessoa.EstadoCivil = EstadoCivil.Casado;

            switch (pessoa.EstadoCivil)
            {
                case EstadoCivil.Casado:
                    Console.WriteLine("Casado...!!!");
                    break;

                case EstadoCivil.Solteiro:
                    Console.WriteLine("Solteiro...!!!");
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
    public class Pessoa
    {
        public EstadoCivil EstadoCivil { get; set; }
    }
    public enum EstadoCivil
    {
        Casado = 1,
        Solteiro = 2
    }
}
