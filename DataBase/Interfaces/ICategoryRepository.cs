using Domain.Entities;
using System.Collections.Generic;

namespace DataBase.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}