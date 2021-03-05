using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkInProgress2.Shared.Models
{
    public class ProductList
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }
    }
}
