using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Repositories
{
    public interface IProductRepository
    {
        public void InitializeDataset();
        public List<Product> GetAllProducts();
        public bool SaveProduct(Product p);
        public bool UpdateProduct(Product p);
        public bool DeleteProduct(int id);

    }
}
