using Domain.Entities;

namespace DataBase.Repository
{
    public interface IRequestForm
    {
        void SaveRequest(Request request);
    }
}