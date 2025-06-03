using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }
        public Category()
        {
            Products = new Dictionary<int, Product>();
        }
        //CRUD

        //them moi sanphamcho Category
        public void AddProduct(Product p)
        {
            if (Products.ContainsKey(p.Id) == false)
            {
                Products.Add(p.Id, p);
            }
        }
        public void PrintAllProduct()
        {
            foreach (KeyValuePair<int, Product> item in Products)
            {
                Product p = item.Value;
                Console.WriteLine(p);
            }
        }

        //lấy sản phầm theo id 
        public Product GetProduct(int id)
        {
            if (Products.ContainsKey(id) == false)
                return null;
            return Products[id];
        }

        public Dictionary<int, Product>SortProduct() 
        { 
            return Products.OrderBy(item => item.Value.Price).ToDictionary<int, Product>();
        }

        //sắp xếp giá tăng dần, nếu giá trùng nhau thì quantity giảm dần
        //phương thức sau khi đè lên phương thức trước
        public Dictionary<int, Product>ComplexSort()
        {
            return Products
                .OrderByDescending(item => item.Value.Quantity)
                .OrderBy(item => item.Value.Price)
                .ToDictionary<int, Product>();
        }


        //sửa
        public void EditProduct(Product p)
        {
            if(Products.ContainsKey(p.Id) == false)
            {
                return;
            }
            //Sửa dữ liệu tại ô nhớ có chứa p.id 
            Products[p.Id] = p;
        }

        //xóa
        public bool RemoveProduct(int id)
        {
            if (Products.ContainsKey(Id) == false)
            {
                return false;
            }
            //Sửa dữ liệu tại ô nhớ có chứa p.id 
            return Products.Remove(Id);
        }


        //xóa tất cả sản phẩm bán ế trong quý 1 2025
        //ế : chỉ bán được 1 sản phẩm 


    }
}

