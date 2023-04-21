﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    internal class GameItem
    {
        public int Price { get; set; }
        public string GameName { get; set; }
        public int Id { get; set; }

        public GameItem(int price, string gameName, int id)
        {
            Price = price;
            GameName = gameName;
            Id = id;
        }
    }
}