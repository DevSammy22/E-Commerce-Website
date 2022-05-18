using Domain.Entities;
using System;
using System.Collections.Generic;

namespace DataBase.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        /// <summary>
        /// Creates and saves a new Order to the database
        /// </summary>
        /// <param name="order"></param>
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
            order.OrderDetails = new List<OrderDetail>();
            //adding the order with its details

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = shoppingCartItem.Amount,
                    ProductId = shoppingCartItem.Product.ProductId,
                    OrderId = order.OrderId,
                    Price = shoppingCartItem.Product.Price
                };

                _appDbContext.OrderDetails.Add(orderDetail);
            }
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
        }
    }
}
