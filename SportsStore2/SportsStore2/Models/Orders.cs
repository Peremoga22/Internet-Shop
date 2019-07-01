using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore2.Models
{
    public class Orders
    {
        public int OrderId { get; set; }

        public ICollection<CartLine> Lines { get; set; }

        public string Street { get; set; }

        public string NumberHouse { get; set; }

        public string NumberFlat { get; set; }

        public string City { get; set; }

        public string Oblast { get; set; }

        public string Zip { get; set; }

        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }
}
