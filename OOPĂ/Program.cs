// See https://aka.ms/new-console-template for more information


using OOP1;
using System.Text;

Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nuoc mam";
Console.OutputEncoding=Encoding.UTF8;
c1.PrintInfor();

Employee emp1= new Employee();
//emp1.Id = 1;
//để thay đổi giá tị của thuộc tính
emp1.Id = 1;
emp1.Name = "Tèo";
emp1.Email = "teo@gmail.com";
emp1.Phone = "113";
//để lấy giá tị của thuộc tính 
//tự gọi get cho property id
Console.WriteLine($"Employee id = {emp1.Id}");
Console.WriteLine($"Employee Name = {emp1.Name}");
//hoặc chúng ta gọi hàm 
emp1.PrintInfor();


//Ngoài ra mọi lớp đối tượng có hàm toString giống java
//để tự động gọi hàm này khi đối tượng được xuất ra màn hình 
Console.WriteLine("-------------------------");
Console.WriteLine(emp1); // tự gọi toString 

//vừa tạo đối tượng vừa khởi tạo giá trị cho thuộc tính 
Employee employee2= new Employee(2,"Tỷ đại bàng","ty@gmail.com", "1234");
Console.WriteLine(employee2);

//hoặc coding như sau 
Employee employee3 = new Employee()
{
    Id = 1,
    Name = "Tun",
    Email = "@",
    Phone = "1234"
};
//xuất thông tin 
Console.WriteLine(employee3);