using kutelala_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kutelala_api.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        int Save(Product student);
        int SaveAll(IEnumerable<Product> product);
        Product GetById(int id);
        Product GetByName(string name);
        int UpdateProduct(Product product);
        int DeleteProduct(int id);
    }
}
