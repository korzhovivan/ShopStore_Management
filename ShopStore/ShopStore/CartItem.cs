using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore
{
    [Table(Name = "Cart")]
    public class CartItem
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public string User_Login { get; set; }
        [Column]
        public int Book_ID { get; set; }

    }
}