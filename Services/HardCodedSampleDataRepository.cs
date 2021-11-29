using Bogus;
using ProductsCatalogWebApp.Models;

namespace ProductsCatalogWebApp.Services
{
    public class HardCodedSampleDataRepository : IProductDataService
    {
        static List<ProductModel> productsList = new List<ProductModel>();

        public int Delete(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public ProductModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            if (productsList.Count == 0)
            {
                productsList.Add(new ProductModel { Id = 1, Name = "Mouse", Price = 5.379m, Description = "Micey moving things" });
                productsList.Add(new ProductModel { Id = 2, Name = "Brick", Price = 1.34m, Description = "heys" });
                productsList.Add(new ProductModel { Id = 3, Name = "Apple", Price = 3.34m, Description = "grewfewfaw fe ewaf" });
                productsList.Add(new ProductModel { Id = 4, Name = "Keyboard", Price = 45.34m, Description = "SO many keys" });

                for (int i = 0; i < 100; i++)
                {
                    productsList.Add(new Faker<ProductModel>()
                        .RuleFor(p => p.Id, i + 5)
                        .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                        .RuleFor(p => p.Price, f => f.Random.Decimal(136))
                        .RuleFor(p => p.Description, f => f.Rant.Review())
                        );
                }
            }
            return productsList;
        }

        public int Insert(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
