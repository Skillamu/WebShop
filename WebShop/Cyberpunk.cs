using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopNS
{
    internal class Cyberpunk : GameItem, IDownloadable, IPhysicalCopy
    {
        public Cyberpunk(int price, string gameName, int id)
            : base(price, gameName, id)
        {

        }
    }
}
