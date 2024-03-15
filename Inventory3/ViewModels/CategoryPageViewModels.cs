using Inventory3.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Inventory3.ViewModels
{
    internal class CategoryPageViewModels
    {
        public List<Models.Product> Products { get; set; }
        public Product Product { get; set; }

        public CategoryPageViewModels(Product product, string place)

        {
            Products = new List<Models.Product>();
            Product = product;
            var task = Task.Run(() => GetProductsFromDb(place));
            task.Wait();
            Products.AddRange(task.Result);
        }
        public static async Task<List<Models.Product>> GetProductsFromDb(string place)
        {
            List<Models.Product> productsFromDb = null;
            if (place == "All")
            {
                productsFromDb = (await DB.DataManager.ProductCollection().AsQueryable().ToListAsync());
            }
            else
            {
                productsFromDb = (await DB.DataManager.ProductCollection().AsQueryable().ToListAsync()).Where(x => x.Place == place).ToList();

            }
            return productsFromDb;
        }
    }
}
