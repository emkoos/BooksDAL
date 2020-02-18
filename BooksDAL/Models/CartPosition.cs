using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksDAL.Models
{
    public class CartPosition
    {
        public int CartPostionId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
