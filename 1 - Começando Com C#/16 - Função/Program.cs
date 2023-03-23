namespace Funcao
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            order.Place();
            Console.WriteLine(order.Place(DateTime.Now, amount: 10.5M));
        }
    }
    public class Order
    {
        public string Place(
            DateTime date,
            decimal amount = 9.5M)
        {
            return $"XPTO00123456 | valor : {amount} | Data : {date}";
        }
        public void Place()
        {
            Console.WriteLine("XPTO00123456");
        }
    }
}