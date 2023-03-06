using Task3.Models;
using Task3.Repository.Interfaces;
using Task3.Services.Interfaces;

namespace Task3.Services
{
    public class ListAllProducts : IListAllProducts
    {
        private IListAllProductsRepository _listAllProducts;


        public ListAllProducts(IListAllProductsRepository listAllProducts)
        {
            _listAllProducts = listAllProducts;
        }
        
        public List<Products> ListAll()
        {
            return _listAllProducts.ListAll();

        }

       
    }
}
