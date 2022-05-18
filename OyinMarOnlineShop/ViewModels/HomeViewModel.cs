using Domain.Entities;
using System.Collections.Generic;

namespace OyinMarOnlineShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> TopDealProducts { get; set; }
    }
}
