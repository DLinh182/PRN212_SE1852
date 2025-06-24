using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewWPF.models
{
    public class SampleDataset
    {
        public static Dictionary<int, Category> GenerateDataset()
        {
            Dictionary<int, Category> categories = new Dictionary<int, Category>();
            Category c1 = new Category();
            c1.Id = 1;
            c1.Name = "Laptop";

            Category c2 = new Category();
            c2.Id = 2;
            c2.Name = "Phụ kiện";

            Category c3 = new Category();
            c3.Id = 3;
            c3.Name = "Điện thoại";

            categories.Add(c1.Id, c1);
            categories.Add(c2.Id, c2);
            categories.Add(c3.Id, c3);

            //tạo sản phẩm cho danh mục
            Product p1 = new Product() { Id = 1, Name = "Dell 1", Price = 123, Quantity = 10 };
            c1.Products.Add(p1.Id,p1);
            Product p2 = new Product() { Id = 2, Name = "Asus 2", Price = 543, Quantity = 610 };
            c1.Products.Add(p2.Id, p2);
            Product p3 = new Product() { Id = 3, Name = "Dell 2", Price = 334, Quantity = 710 };
            c1.Products.Add(p3.Id, p3);
            Product p4 = new Product() { Id = 4, Name = "hp 1", Price = 1000, Quantity = 10 };
            c1.Products.Add(p4.Id, p4);
            Product p5 = new Product() { Id = 5, Name = "mac 1", Price = 5000, Quantity = 107 };
            c1.Products.Add(p5.Id, p5);


            Product p6 = new Product() { Id = 6, Name = "remote", Price = 123, Quantity = 10 };
            c2.Products.Add(p6.Id, p6);
            Product p7 = new Product() { Id = 7, Name = "mouse 2", Price = 50, Quantity = 610 };
            c2.Products.Add(p7.Id, p7);
            Product p8 = new Product() { Id = 8, Name = "headphone 2", Price = 184, Quantity = 710 };
            c2.Products.Add(p8.Id, p8);
            Product p9 = new Product() { Id = 9, Name = "mouse 1", Price = 10, Quantity = 10 };
            c2.Products.Add(p9.Id, p9);
            Product p10 = new Product() { Id = 10, Name = "remote 1", Price = 5000, Quantity = 107 };
            c2.Products.Add(p10.Id, p10);

            Product p11 = new Product() { Id = 11, Name = "ip", Price = 123, Quantity = 10 };
            c3.Products.Add(p11.Id, p11);
            Product p12 = new Product() { Id = 12, Name = "oppo 2", Price = 543, Quantity = 610 };
            c3.Products.Add(p12.Id, p12);
            Product p13 = new Product() { Id = 13, Name = "samsung 2", Price = 334, Quantity = 710 };
            c3.Products.Add(p13.Id, p13);
            Product p14 = new Product() { Id = 14, Name = "nokia 1", Price = 1000, Quantity = 10 };
            c3.Products.Add(p14.Id, p14);
            Product p15 = new Product() { Id = 15, Name = "xiaomi 1", Price = 5099, Quantity = 107 };
            c3.Products.Add(p15.Id, p15);

            return categories;
        }
    }
}
