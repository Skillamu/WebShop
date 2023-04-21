namespace WebShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var storeInventory = new StoreInventory();

            var listPhysicalItems = storeInventory.ListPhysicalItems();

            foreach (var item in listPhysicalItems)
            {
                Console.WriteLine(item.GameName);
            }

            var listDigitalItems = storeInventory.ListDigitalItems();

            foreach (var item in listDigitalItems)
            {
                Console.WriteLine(item.GameName);
            }

            Console.ReadKey(true);
        }
    }
}