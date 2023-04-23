using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopNS
{
    internal class PUBG : GameItem, IPhysicalCopy, IDownloadable
    {
        public PUBG(int price, string gameName, string id)
            : base(price, gameName, id)
        {
        }
    }
}
