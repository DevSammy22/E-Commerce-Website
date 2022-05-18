using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Repository
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> AllCategories => _appDbContext.Categories;

    }
}
