using Dapper;
using Microsoft.AspNetCore.Connections;
using System.Data;
using Task3.Models;
using Task3.Repository.Interfaces;

namespace Task3.Repository
{
    public class ListAllProductsRepository : IListAllProductsRepository
    {
        public List<Products> ListAll()
        {
            using (IDbConnection db = DbConnectionFactory.CreateConnection())
            {
                var query = "SELECT p.*, c.CategoryName, c.Description, c.Picture " +
                 "FROM Products p " +
                 "JOIN Categories c ON p.CategoryId = c.CategoryID";

                var products = db.Query<Products, Categories, Products>(
                    query,
                    (product, category) =>
                    {
                        product.Category = category;
                        return product;
                    },
                    splitOn: "CategoryName").ToList();
                return products;
            }
        }
    }
}
