// See https://aka.ms/new-console-template for more information

using System.Text;
using OOP2;

Console.OutputEncoding=Encoding.UTF8;

FullTimeEmployee teo = new FullTimeEmployee();
teo.Id = 1;
teo.Name = "Teo";
Console.WriteLine(teo.calSalary());

ParttimeEmployee ti = new ParttimeEmployee();
ti.WorkingHour = 2;
ti.Id = 2;
ti.Name = "Tí";
Console.WriteLine(ti.calSalary());

FullTimeEmployee obama = new FullTimeEmployee()
{
    Id = 100,
    Name = "Barac Obama",
    Birthday = new DateTime(1960, 1, 25),
    IdCard = "123"
};
Console.WriteLine("---------Thông tin của Obama---------");
Console.WriteLine(obama);

ParttimeEmployee trump = new ParttimeEmployee()
{
    Id = 200,
    IdCard = "456",
    Birthday = new DateTime(1940, 12, 26),
    Name = "Donal Trump",
    WorkingHour = 2
};
Console.WriteLine("----------Thông tin của Trump---------");
Console.WriteLine(trump);



