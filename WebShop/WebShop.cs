using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopNS
{
    internal class WebShop
    {
        public StoreInventory _storeInventory;

        public WebShop(StoreInventory storeInventory)
        {
            _storeInventory = storeInventory;

            while (true)
            {
                _storeInventory = new StoreInventory();

                Console.WriteLine("Welcome to the web shop! ");
                Console.WriteLine("1: Show all available games");
                Console.WriteLine("2: Show only physical games");
                Console.WriteLine("3: Show only downloadable games");

                HandleCommand();
            }
        }

        public void HandleCommand()
        {
            var cmd = Console.ReadLine();
            _storeInventory.PrintInventory(cmd);
            Console.WriteLine("Enter the ID of the game you want to buy");
            var gameId = Convert.ToInt32(Console.ReadLine());
            var gameToBuy = _storeInventory.InventoryList.Find(game => game.Id == gameId);
            // Will add shopping cart list later.
            var buyProcedure = gameToBuy is IPhysicalCopy && gameToBuy is IDownloadable ? "Downloading" :
                               gameToBuy is IPhysicalCopy ? "Shipping" : "Downloading";

            Console.WriteLine(buyProcedure);

            Thread.Sleep(5000);
        }
    }
}
