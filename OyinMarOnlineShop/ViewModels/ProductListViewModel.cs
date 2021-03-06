using Domain.Entities;
using System.Collections.Generic;

namespace OyinMarOnlineShop.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string CurrentCategory { get; set; }
    }
}
