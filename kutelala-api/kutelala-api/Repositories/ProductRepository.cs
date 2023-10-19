using kutelala_api.Interfaces;
using kutelala_api.Models;
using Microsoft.Data.SqlClient;
using RepoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kutelala_api.Repositories
{
    public class ProductRepository : BaseRepository<Product, SqlConnection>,
    IProductRepository
    {
        public ProductRepository()
            : base(@"Data Source=172.27.62.7;Initial Catalog=DataWarehouse;User ID=isc;Password=rnd1280rnd;Connection Timeout=3600;TrustServerCertificate=True")
        {
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return QueryAll();
        }

        public Product GetById(int id)
        {
            return Query(id).FirstOrDefault();
        }
        public Product GetByName(string name)
        {
            return Query(e => e.Name == name).FirstOrDefault();
        }
        //public Response Save(Product product)
        //{
        //    var data = Insert<Product>(product);
        //    return new Response { Code = 1, Status = true, Message = "Insert thành công", Data = data };
        //}
        public int SaveAll(IEnumerable<Product> product)
        {
            return InsertAll(product);
        }

        public int Save(Product product)
        {
            return Insert<int>(product);
        }

        public int UpdateProduct(Product product)
        {
            return Update(product);
        }

        public int DeleteProduct(int id)
        {
            return Delete(id);
        }
    }
}
