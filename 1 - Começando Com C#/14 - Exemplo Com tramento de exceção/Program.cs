/*
Com Tratamento de exceção.
*/
namespace TratamentoExcecao
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = new[] { "Ir ao supermecado" };
            try
            {
                Console.WriteLine(teste[0]);
                throw new MyException ();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Indíce fora do array...!!! ERRRO : {ex.Message}");
            }
            catch (Exception ex )
            {
                Console.WriteLine($"Deu ruim...!!! ERRO : {ex.Message}");
            }
        }
        public class MyException : Exception
        {
            public MyException() : base(message:"Deu algo muito ruim...!!!")
            {

            }
        }
    }
}