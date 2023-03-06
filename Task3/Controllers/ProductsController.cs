using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task3.Models;
using Task3.Repository.Interfaces;
using Task3.Services.Interfaces;

namespace Task3.Controllers
{
    public class ProductsController : Controller
    {
        private IListAllProducts _listAllProducts;


        public ProductsController(IListAllProducts listAllProducts)
        {
            _listAllProducts = listAllProducts;
        }
        // GET: ProductsController
        public ActionResult Index()
        {
            var products = _listAllProducts.ListAll();
            var list = new List<ProductCategory>();
            foreach (var product in products)
            {
                ProductCategory productCategory = new ProductCategory()
                {
                    ProductName = product.ProductName,
                    SupplierId = product.SupplierId,
                    QuantityPerUnit = product.QuantityPerUnit,
                    UnitPrice = product.UnitPrice,
                    UnitsInStock = product.UnitsInStock,
                    UnitsOnOrder = product.UnitsOnOrder,
                    ReorderLevel = product.ReorderLevel,
                    Discontinued = product.Discontinued,
                    LastUserId = product.LastUserId,
                    LastDateUpdated = product.LastDateUpdated,
                    CategoryName = product.Category.CategoryName,
                    Description = product.Category.Description,
                    Picture = product.Category.Picture,
                };
                list.Add(productCategory);
            }
            return View(list);
        }
    }
}
