// See https://aka.ms/new-console-template for more information

using System.Text;

Console.OutputEncoding=Encoding.UTF8;

//dùng linq2object để lọc ra các số chẵn trong danh sách
int[] arr = { 100, 35, 80, 17, 22, 40, 70, 33, 18 };
//cách 1: dùng method syntax hay extention method 
var even_list = arr.Where(x => x % 2 == 0);
Console.WriteLine("Danh sách các số chẵn theo method syntax: ");
foreach (var x in even_list)
    Console.Write(x+"\t");

//cách 2: dùng query syntax ( cú pháp tương tự sql )
var even_list2 = from x in arr 
                 where x % 2 == 0
                 select x;
Console.WriteLine("\nDanh sách các số chẵn theo query syntax: ");
foreach (var x in even_list2)
    Console.Write(x + "\t");

//Sắp xếp mảng tăng dần và giảm dần dùng method và query syntax
//cách 1 : method
var list_asc = arr.OrderBy(x => x);
var list_desc = arr.OrderByDescending(x => x);
//cách 2 : query
var list_asc2 = from x in arr
                orderby x
                select x;
var list_desc2 = from x in arr
                orderby x descending
                select x;
//Tính tổng danh sách
Console.WriteLine("\nTổng = " + arr.Sum());
Console.WriteLine("Đếm số chẵn : "+arr.Where(x => x %2==0).Count());


