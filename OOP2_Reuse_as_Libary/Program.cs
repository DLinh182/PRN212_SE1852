// See https://aka.ms/new-console-template for more information

using OOP2;
using OOP2_Reuse_as_Libary;

FullTimeEmployee e1 = new FullTimeEmployee();
e1.Id = 1;
e1.Name = "Tèo";
e1.Birthday = new DateTime(1960, 1, 2);
Console.WriteLine("----Thông tin E1----");
Console.WriteLine(e1);
Console.WriteLine("AGE = " + e1.TinhTuoi());