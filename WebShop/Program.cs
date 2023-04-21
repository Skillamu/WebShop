namespace WebShopNS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var storeInventory = new StoreInventory();
            var webShop = new WebShop(storeInventory);

            Console.ReadKey(true);
        }
    }
}