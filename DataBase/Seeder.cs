

using Domain.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DataBase
{
    public class Seeder
    {
        //private static IServiceProvider serviceProvider;

        //public static void SeedDataBase(IServiceCollection services)
        //{
        //    serviceProvider = services.BuildServiceProvider();
        //    AppDbContext context = serviceProvider.GetRequiredService<AppDbContext>();
        //    CategoryData(context).Wait();
        //    ProductData(context).Wait();
        //}

        /// <summary>
        /// Saves a list of products to the database
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>

        static string FilePath(string folderName, string fileName)
        {
            return Path.Combine(folderName, fileName);
        }
        public static async Task ProductData(AppDbContext dbContext)
        {
            var baseDir = Directory.GetCurrentDirectory();
            await dbContext.Database.EnsureCreatedAsync();

            if (!dbContext.Products.Any())
            {
                var path = File.ReadAllText(FilePath(baseDir, "JSONFile/Product.json"));
                var products = JsonConvert.DeserializeObject<List<Product>>(path);
                await dbContext.Products.AddRangeAsync(products);
                await dbContext.SaveChangesAsync();
            }

            if (!dbContext.Categories.Any())
            {
                var path = File.ReadAllText(FilePath(baseDir, "JSONFile/Category.json"));
                var categories = JsonConvert.DeserializeObject<List<Category>>(path);
                await dbContext.Categories.AddRangeAsync(categories);
                await dbContext.SaveChangesAsync();
            }
            //    try
            //    {
            //        context.Database.EnsureCreated();
            //        if (!context.Products.Any())
            //        {
            //            var data = File.ReadAllText(@"JSONFile/Product.json");
            //            var listOfProducts = JsonConvert.DeserializeObject<List<Product>>(data);
            //            await context.Products.AddRangeAsync(listOfProducts);
            //            await context.SaveChangesAsync();
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        throw;
            //    }
            //}

            ///// <summary>
            ///// Saves a list of categories to the database
            ///// </summary>
            ///// <param name="context"></param>
            ///// <returns></returns>
            //public static async Task CategoryData(AppDbContext context)
            //{
            //    try
            //    {
            //        context.Database.EnsureCreated();
            //        if (!context.Categories.Any())
            //        {
            //            var data = File.ReadAllText(@"JSONFile/Category.json");
            //            var listOfCategories = JsonConvert.DeserializeObject<List<Category>>(data);
            //            await context.Categories.AddRangeAsync(listOfCategories);
            //            await context.SaveChangesAsync();
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        throw;
            //    }
            //}
        }
    }
}
