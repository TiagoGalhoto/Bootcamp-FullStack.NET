namespace LacoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new List<string>();
            tasks.Add(item: "Ir ao supermecado...!!!");
            tasks.Add(item: "Ir a academia...!!!");
            foreach (var item in tasks)
            {
                Console.WriteLine(item);
            }
        }
    }
}