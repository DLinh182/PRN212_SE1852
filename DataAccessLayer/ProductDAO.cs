using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        static List<Product> products = new List<Product>();
        public void InitializeDataset()
        {
            products.Add(new Product { Id = 1, Name = "Product A", Price = 10.99m, Quantity = 100 });
            products.Add(new Product { Id = 2, Name = "Product B", Price = 20.99m, Quantity = 200 });
            products.Add(new Product { Id = 3, Name = "Product C", Price = 30.99m, Quantity = 300 });
            products.Add(new Product { Id = 4, Name = "Product D", Price = 30.55m, Quantity = 700 });
            products.Add(new Product { Id = 5, Name = "Product E", Price = 10.99m, Quantity = 320 });
        }
        public List<Product> GetAllProducts()
        {
            return products;
        }
        public bool SaveProduct(Product p)
        {
            Product old = products.FirstOrDefault(x => x.Id == p.Id);
            if (old != null) return false;
            products.Add(p);
            return true;
        }

        public bool UpdateProduct(Product p)
        {
            Product old = products.FirstOrDefault(x => x.Id == p.Id);
            if (old == null) return false; //sửa thất bại vì không tìm thấy sản phẩm cũ
            old.Name = p.Name;
            old.Price = p.Price;
            old.Quantity = p.Quantity;
            return true;
        }
        public bool DeleteProduct(int id)
        {
            Product old = products.FirstOrDefault(x => x.Id == id);
            if (old == null) return false; //sửa thất bại vì không tìm thấy sản phẩm cũ
            products.Remove(old);
            return true;
        }
    }
}
