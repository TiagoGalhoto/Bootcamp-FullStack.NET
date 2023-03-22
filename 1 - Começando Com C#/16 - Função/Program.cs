namespace Funcao
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            order.Place();
            Console.WriteLine(order.Place(amount: 10.5M));
            
        }
    }
    public class Order
    {
        public string Place(decimal amount)
        {
            return $"XPTO00123456 {amount}";
        }
        public void Place()
        {
            Console.WriteLine("XPTO00123456");
        }
    }

}