using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopNS
{
    internal abstract class GameItem
    {
        public int Price { get; }
        public string GameName { get; }
        public string Id { get; }

        protected GameItem(int price, string gameName, string id)
        {
            Price = price;
            GameName = gameName;
            Id = id;
        }

        public void PrintGameNameAndPrice()
        {
            Console.WriteLine($"ID: {Id}, {GameName}, pris: {Price}kr");
        }
    }
}
