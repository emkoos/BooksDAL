using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksDAL.Models
{
    public class CartPosition
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
    }
}
