using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopNS
{
    internal class WebShop
    {
        private StoreInventory _storeInventory;

        public WebShop(StoreInventory storeInventory)
        {
            _storeInventory = storeInventory;

            while (true)
            {
                Console.WriteLine("Welcome to the web shop! ");
                Console.WriteLine("1: Show all available games");
                Console.WriteLine("2: Show only physical games");
                Console.WriteLine("3: Show only downloadable games");

                HandleCommand();
            }
        }

        private void HandleCommand()
        {
            var listToPrint = AskForListToPrint();
            _storeInventory.PrintList(listToPrint);
            Console.WriteLine("Enter the ID of the game you want to buy");
            var gameToBuy = AskForGameId();
            // Will add shopping cart list later.
            var processToHandle = GetProcessToRecieveTheGame(gameToBuy);
            HandleProcess(processToHandle);

            Thread.Sleep(5000);
        }

        private string GetProcessToRecieveTheGame(GameItem gameToBuy)
        {
            string processToHandle;

            if (IsShippable(gameToBuy) && IsDownloadable(gameToBuy))
            {
                processToHandle = ChooseProcessToRecieveTheGame();
            }
            else if (IsShippable(gameToBuy)) processToHandle = "ship";
            else processToHandle = "download";

            return processToHandle;
        }

        private string ChooseProcessToRecieveTheGame()
        {
            Console.WriteLine("Do you want to ship or download the game?");
            Console.WriteLine("Enter \"s\" to have the game shipped.");
            Console.WriteLine("Enter \"d\" to have the game downloaded.");
            while (true)
            {
                var processToHandle = Console.ReadKey(true).KeyChar.ToString();
                if (processToHandle == "s" || processToHandle == "d")
                {
                    return processToHandle == "s" ? "ship" : "download";
                }
            }
        }
        // Bug to fix: After a list is chosen, make it only
        // possible to search for id's in that chosen list.
        private void HandleProcess(string processToHandle)
        {
            if (processToHandle == "ship") PrintShippingMessage();
            else if (processToHandle == "download") PrintDownloadMessage();
        }

        private GameItem AskForGameId()
        {
            while (true)
            {
                var gameId = Console.ReadKey(true).KeyChar.ToString();
                var gameToBuy = _storeInventory.FindGameById(gameId);
                if (gameToBuy != null) return gameToBuy;
            }
        }

        private string AskForListToPrint()
            => Console.ReadKey(true).KeyChar.ToString();

        private bool IsShippable(GameItem gameToBuy)
            => gameToBuy is IPhysicalCopy ? true : false;

        private bool IsDownloadable(GameItem gameToBuy)
            => gameToBuy is IDownloadable? true : false;

        private void PrintShippingMessage()
            => Console.WriteLine($"Game will be shipped shortly...");

        private void PrintDownloadMessage()
            => Console.WriteLine($"Game will now be downloaded...");
    }
}
