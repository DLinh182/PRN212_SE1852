using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Repositories;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public bool DeleteProduct(int id)
        {
            return _productRepository.DeleteProduct(id);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }
        public void InitializeDataset()
        {
            _productRepository.InitializeDataset();
        }
        public bool SaveProduct(Product p)
        {
            return _productRepository.SaveProduct(p);

        }
        public bool UpdateProduct(Product p)
        {
            return _productRepository.UpdateProduct(p);
        }
        
    }
}
