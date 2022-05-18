using Domain.Entities;

namespace DataBase.Repository
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}