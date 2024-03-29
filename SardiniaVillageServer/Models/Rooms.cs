﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SardiniaVillageServer.Models
{
    public class Rooms
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsFree { get; set; }
        public int Beds { get; set; }
        public string Image { get; set; }
        public List<Price> Prices { get; set; }

        public Rooms(int id, string description, string name, double price, bool isFree, int beds, string image, List<Price> prices)
        {
            Id = id;
            Description = description;
            Name = name;
            Price = price;
            IsFree = isFree;
            Beds = beds;
            Image = image;
            Prices = prices;
        }
    }

  
}
