using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksDAL.Models
{
    public partial class Product
    {
        public override string ToString()
        {
            return $"Product: {this.ProductTitle ?? "**Bez nazwy**"}, Autor: {this.ProductAuthor ?? "**Bez autora**"}, Cena: {this.ProductPrice}.";
        }
    }
}
