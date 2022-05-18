using DataBase.Repository;

namespace OyinMarOnlineShop.ViewModels
{
    public class ShoppingCartViewModel
    {
        /// <summary>
        /// Model for displaying the shopping cart page
        /// </summary>
        public ShoppingCart ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
    }
}
