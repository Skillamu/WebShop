using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopNS
{
    internal class StoreInventory
    {
        public List<GameItem> InventoryList;

        public StoreInventory()
        {
            InventoryList = new List<GameItem>
            {
                new Battlefield(150, "Battlefield", 1),
                new Cyberpunk(250, "Cyberpunk", 2),
            };
        }

        public List<GameItem> ListPhysicalItems()
        {
            return InventoryList.Where(gameItem =>
            gameItem is IPhysicalCopy).ToList();
        }

        public List<GameItem> ListDownloadableItems()
        {
            return InventoryList.Where(gameItem =>
            gameItem is IDownloadable).ToList();
        }

        public void Print(List<GameItem> list)
        {
            foreach (var item in list)
            {
                item.PrintGameNameAndPrice();
            }
        }

        public void PrintInventory(string cmd)
        {
            if (cmd == "1") Print(InventoryList);
            else if (cmd == "2") Print(ListPhysicalItems());
            else Print(ListDownloadableItems());
        }
    }
}
