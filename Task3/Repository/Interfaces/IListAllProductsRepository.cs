using Task3.Models;

namespace Task3.Repository.Interfaces
{
    public interface IListAllProductsRepository
    {
        List<Products> ListAll();
    }
}
