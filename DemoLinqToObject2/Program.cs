// See https://aka.ms/new-console-template for more information
using System.Text;
using DemoLinqToObject2;

Console.OutputEncoding=Encoding.UTF8;
ListProduct lp = new ListProduct();
//giả lập dữ liệu
lp.gen_sample_product();
Console.WriteLine("Danh sách Products: ");
lp.PrinProduct();
Console.WriteLine("Danh sách sp có giá từ 10 tới 100: ");
lp.FilterProductByPrice(80, 100);
Console.WriteLine("Danh sách sp có giá từ 80 tới 100 giảm dần: ");
lp.FilterProductByPriceDsc(10, 100);

