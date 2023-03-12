namespace VDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Hello World...!!! ");
            dynamic Teste = new
            {
                Id = 1
            };
            Console.WriteLine(Teste.Id);
        }
    }
}