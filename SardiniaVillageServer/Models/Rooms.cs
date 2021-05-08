using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SardiniaVillageServer.Models
{
    public class Rooms
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsFree { get; set; }
        public List<Price> Prices { get; set; }

        public Rooms(int id, string description, double price, bool isFree, List<Price> prices)
        {
            Id = id;
            Description = description;
            Price = price;
            IsFree = isFree;
            Prices = prices;
        }


    }

  
}
