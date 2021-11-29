using Bogus;
using Microsoft.AspNetCore.Mvc;
using ProductsCatalogWebApp.Models;
using ProductsCatalogWebApp.Services;
using PagedList;

namespace ProductsCatalogWebApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductsDAO products = new ProductsDAO();
            return View(products.GetAllProducts());
            // save for when adding paged lists return View(products.GetAllProducts().ToPagedList(1,16));
        }

        public IActionResult SearchResults(string searchTerm)
        {
            ProductsDAO products = new ProductsDAO();
            List<ProductModel> productsList = products.SearchProducts(searchTerm);
            return View("Index", productsList);
        }
        
        public IActionResult SearchForm()
        {
            return View();
        }

        public IActionResult InputForm()
        {
            return View();
        }

        public IActionResult CreateInput()
        {
            return View();
        }

        public IActionResult ProcessCreateInput(ProductModel product)
        {
            ProductsDAO products = new ProductsDAO();
            products.Insert(product);
            return View("Index", products.GetAllProducts());
        }

        public IActionResult ShowDetails(int id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel foundProduct = products.GetProductById(id);
            return View(foundProduct);
        }

        public IActionResult Edit(int id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel foundProduct = products.GetProductById(id);
            return View("ShowEdit", foundProduct);
        }

        public IActionResult ProcessEdit(ProductModel product)
        {
            ProductsDAO products = new ProductsDAO();
            products.Update(product);
            return View("Index", products.GetAllProducts());
        }
        
        public IActionResult Delete(int Id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel product = products.GetProductById(Id);
            products.Delete(product);
            return View("Index", products.GetAllProducts());
        }
    }
}
