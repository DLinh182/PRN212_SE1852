using System.Text;
using OOP4_Dictionary;
Console.OutputEncoding=Encoding.UTF8;

Category laptop = new Category();
laptop.Id = 1;
laptop.Name = "Danh muc Laptop";

Product dell1 = new Product()
{ Id = 1, Name = "Dell 1", Quantity = 10, Price = 15000000 };
laptop.AddProduct(dell1);

Product dell2 = new Product()
{ Id = 2, Name = "Dell 2", Quantity = 20, Price = 20000000 };
laptop.AddProduct(dell2);

Product dell3 = new Product()
{ Id = 3, Name = "Dell 3", Quantity = 15, Price = 17000000 };
laptop.AddProduct(dell3);

Product HP2 = new Product()
{ Id = 4, Name = "HP2", Quantity = 20, Price = 12000000 };
laptop.AddProduct(HP2);

Product HP3 = new Product()
{ Id = 5, Name = "HP3", Quantity = 15, Price = 12000000 };
laptop.AddProduct(HP3);

Console.WriteLine("Danh sach san pham cua danh muc Laptop");
laptop.PrintAllProduct();

Console.WriteLine("Nhap id san pham can tim:");
int pid = int.Parse(Console.ReadLine());
Product p = laptop.GetProduct(pid);
if (p != null)
{
    Console.WriteLine("San pham co id = " + pid + " la:");
    Console.WriteLine(p);
}
else
{
    Console.WriteLine("Khong tim thay san pham co id = " + pid);
}

Console.WriteLine("Danh sách");
laptop.PrintAllProduct();
Dictionary<int, Product> sortedproducts = laptop.SortProduct();
Console.WriteLine("Sau sắp xếp: ");
foreach(KeyValuePair<int, Product> item in sortedproducts)
{
    Product x = item.Value;
    Console.WriteLine(x);
}

Dictionary<int, Product> complexSort = laptop.ComplexSort();
Console.WriteLine("Sau sắp xếp phức tạp : ");
foreach (KeyValuePair<int, Product> item in complexSort)
{
    Product x = item.Value;
    Console.WriteLine(x);
}


Product px = new Product();
px.Id = 1;
px.Name = "macbook";
px.Quantity = 122;
px.Price = 3456789;
laptop.EditProduct(px);
Console.WriteLine("danh sách sau khi sửa");
laptop.PrintAllProduct();

int pid_remove = 1;
laptop.RemoveProduct(pid_remove);
Console.WriteLine("danh sách sau khi sửa");
laptop.PrintAllProduct();