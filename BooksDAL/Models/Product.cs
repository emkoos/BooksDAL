using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksDAL.Models
{
    public partial class Product
    {
        [Key]
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwę produktu")]
        [StringLength(100)]
        public string ProductTitle { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwę autora")]
        [StringLength(100)]
        public string ProductAuthor { get; set; }
        public string ProductDescription { get; set; }
        public string ProductShortDescription { get; set; }
        public DateTime AddedDate { get; set; }
        public decimal ProductPrice { get; set; }
        public string ISBN { get; set; }
        public string PublishingHouse { get; set; }
        public string CardDimensions { get; set; }
        public bool Bestseller { get; set; }
        public bool Hidden { get; set; }
        public string ImageFileName { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
