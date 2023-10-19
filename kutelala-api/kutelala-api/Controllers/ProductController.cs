using kutelala_api.Interfaces;
using kutelala_api.Models;
using Microsoft.AspNetCore.Mvc;
using RepoDb.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kutelala_api.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository m_productRepository;

        public ProductController(IProductRepository productRepository)
        {
            m_productRepository = productRepository;
        }

        [HttpGet()]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return m_productRepository.GetAllProducts().AsList();
        }

        [HttpGet("/save")]
        public int Save(Product p)
        {
            return m_productRepository.Save(p);
        }


        [HttpPost("/saveall")]
        public int SaveAll([FromBody]IEnumerable<Product> p)
        {
            return m_productRepository.SaveAll(p);
        }

        [HttpGet("/get/{id}")]
        public ActionResult<Product> Get(int id)
        {
            return m_productRepository.GetById(id);
        }

        [HttpGet("/getname/{name}")]
        public ActionResult<Product> Get(string name)
        {
            return m_productRepository.GetByName(name);
        }

        [HttpGet("/update")]
        public int Update(Product p)
        {
            return m_productRepository.UpdateProduct(p);
        }

        [HttpGet("/delete/{id}")]
        public int Delete(int id)
        {
            return m_productRepository.DeleteProduct(id);
        }
    }
    
}
