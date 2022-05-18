using Domain.Entities;
using System.Collections.Generic;

namespace DataBase.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
        IEnumerable<Product> TopDealProducts { get; }

        Product GetProductById(int productId);
    }
}