using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    internal class Cyberpunk : GameItem, IDigitalCopy, IPhysicalCopy
    {
        public Cyberpunk(int price, string gameName, int id)
            : base(price, gameName, id)
        {

        }
    }
}
