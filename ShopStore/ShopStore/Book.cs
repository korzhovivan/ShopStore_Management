using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore
{
    [Table(Name = "Books")]
    public class Book
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID_BOOK { get; set; }
        [Column]
        public string NameBook { get; set; }
        [Column]
        public string Fio { get; set; }
        [Column]
        public string PublishName { get; set; }
        [Column]
        public decimal Price { get; set; }
        [Column]
        public int Pages { get; set; }
        [Column]
        public DateTime DateOfPublishing { get; set; }
        [Column]
        public decimal SalePrice { get; set; }

    }
}
