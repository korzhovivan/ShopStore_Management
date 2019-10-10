using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore
{
    [Table(Name = "Sales")]
    public class Sale
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID_SALE { get; set; }
        [Column]
        public int ID_BOOK { get; set; }
        [Column]
        public string Login { get; set; }
        [Column]
        public DateTime DateOfSale { get; set; }
        [Column]
        public decimal Price { get; set; }

    }
}
