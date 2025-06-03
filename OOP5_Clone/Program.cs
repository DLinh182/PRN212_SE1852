// See https://aka.ms/new-console-template for more information


using OOP5_Clone;

Product p1 = new Product
{
    Id = 1,
    Name = "Coca",
    Quantity = 10,
    Price = 100
};
Product p2 = new Product
{
    Id = 2,
    Name = "Pepsi",
    Quantity = 10,
    Price = 150
};

Console.WriteLine("tt");
Console.WriteLine(p1);

Product p3 = new Product
{
    Id = 3,
    Name = "P3",
    Quantity = 10,
    Price = 150
};
Product p4 = new Product
{
    Id = 4,
    Name = "P4",
    Quantity = 10,
    Price = 150
};
Product p5 = new Product
{
    Id = 5,
    Name = "P5",
    Quantity = 10,
    Price = 150
};
p5 = p3;
p3 = p4;
//ô nhớ cấp phát cho p3 có bị tự động giải phóng không?

Product p6 = new Product
{
    Id = 6,
    Name = "P6",
    Quantity = 6,
    Price = 16
};

Product p7 = p6.Clone();
//lúc này hệ điều hành sẽ cấp phát một vùng nhớ mới cho p7 quản lí
//và ô nhớ này có giá trị y chang giá trị của ô nhớ mà p6 đang quản lý
//tức là p6 va  ̀ p7 sẽ quản lí hai vùng nhớ khác nhau
//p6 đổi ko liên quan gì đến p7 và ngược lại
//==> không phải alias 
Console.WriteLine("p6:-----------");
Console.WriteLine(p6);
Console.WriteLine("p7:-----------");
Console.WriteLine(p7);
p7.Name = "Thuốc gì đó ";
Console.WriteLine("p6 lần 2:-----------");
Console.WriteLine(p6);

