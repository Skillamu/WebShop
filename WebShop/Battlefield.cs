using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopNS
{
    internal class Battlefield : GameItem, IDownloadable
    {
        public Battlefield(int price, string gameName, int id)
            : base(price, gameName, id)
        {

        }
    }
}
