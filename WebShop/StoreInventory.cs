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
            if (listToPrint == "1") Print(_inventory);
            else if (listToPrint == "2") Print(GetListOfPhysicalItems());
            else Print(GetListOfDownloadableItems());
        }
    }
}
