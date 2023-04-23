using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopNS
{
    internal class StoreInventory
    {
        private List<GameItem> _inventory;
        private string CurrentList { get; set; }

        public StoreInventory()
        {
            _inventory = new List<GameItem>
            {
                new Battlefield(150, "Battlefield", "1"),
                new Cyberpunk(250, "Cyberpunk", "2"),
                new Pokemon(400, "Pokemon Let's GO Eevee", "3"),
                new PUBG(100, "PUBG", "4"),
            };
        }

        public GameItem? FindGameByIdInCurrentList(string gameId)
        {
            if (CurrentList == "2")
            {
                return GetListOfPhysicalItems().Find(game => game.Id == gameId);
            }
            else if (CurrentList == "3")
            {
                return GetListOfDownloadableItems().Find(game => game.Id == gameId);
            }
            else
            {
                return _inventory.Find(game => game.Id == gameId);
            }
        }

        public GameItem? FindGameById(string gameId)
            => _inventory.Find(game => game.Id == gameId);

        private List<GameItem> GetListOfPhysicalItems()
        {
            return _inventory.Where(gameItem =>
            gameItem is IPhysicalCopy).ToList();
        }

        private List<GameItem> GetListOfDownloadableItems()
        {
            return _inventory.Where(gameItem =>
            gameItem is IDownloadable).ToList();
        }

        private void Print(List<GameItem> list)
        {
            foreach (var item in list)
            {
                item.PrintGameNameAndPrice();
            }
        }

        public void PrintList(string listToPrint)
        {
            if (listToPrint == "2")
            {
                Console.Clear();
                Console.WriteLine("----- Physical Games -----\n");
                Print(GetListOfPhysicalItems());
            }
            else if (listToPrint == "3")
            {
                Console.Clear();
                Console.WriteLine("----- Downloadable Games -----\n");
                Print(GetListOfDownloadableItems());
            }
            else
            {
                Console.Clear();
                Console.WriteLine("----- All Games -----\n");
                Print(_inventory);
            }
            CurrentList = listToPrint;
        }
    }
}
