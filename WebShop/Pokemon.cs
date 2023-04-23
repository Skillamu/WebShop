using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopNS
{
    internal class Pokemon : GameItem, IPhysicalCopy
    {
        public Pokemon(int price, string gameName, string id)
            : base(price, gameName, id)
        {
        }
    }
}
