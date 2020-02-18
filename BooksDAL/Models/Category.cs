using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BooksDAL.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwę kategorii")]
        [StringLength(100)]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Wprowadz opis kategorii")]
        public string CategoryDescription { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
