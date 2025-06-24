using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Services
{
    public interface IProductService
    {
        public void InitializeDataset();
        public List<Product> GetAllProducts();
        public bool SaveProduct(Product p);

        public bool UpdateProduct(Product p);
        public bool DeleteProduct(int id);
    }
}
