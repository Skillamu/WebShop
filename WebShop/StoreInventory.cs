using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
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

        public List<GameItem> ListDigitalItems()
        {
            return InventoryList.Where(gameItem =>
            gameItem is IDigitalCopy).ToList();
        }
    }
}
