using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SardiniaVillageServer.Models
{
    public class Price
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double PriceRoom { get; set; }

        public Price(int id, string description, double priceRoom)
        {
            Id = id;
            Description = description;
            PriceRoom = priceRoom;
        }

    }
}
