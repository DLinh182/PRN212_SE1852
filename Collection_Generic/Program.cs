// See https://aka.ms/new-console-template for more information



//Ứng dụng Generic để quản lý nhân viên, thực hiện các thao tác CRUD
//C : Create --> Thêm mới
//R : Read(Retrieve) --> Truy vấn: xem, sắp xếp, lọc dữ liệu ..
//U : Update --> Chỉnh sửa dữ liệu
//D : Delete --> Xóa dữ liệu


//Câu 1 ; Tạo 5 nhân viên, 4 fulltime, 1 partime
using System.Text;
using OOP2;

List<Employee>employees = new List<Employee>();
FullTimeEmployee fe1 = new FullTimeEmployee()
{
    Id = 1,
    Name = "Name 1",
    IdCard = "123",
    Birthday = new DateTime(2000,1,2)
};
employees.Add(fe1);
FullTimeEmployee fe2 = new FullTimeEmployee()
{
    Id = 2,
    Name = "Name 2",
    IdCard = "234",
    Birthday = new DateTime(2003, 1, 2)
};
employees.Add(fe2);
FullTimeEmployee fe3 = new FullTimeEmployee()
{
    Id = 3,
    Name = "Name 3",
    IdCard = "345",
    Birthday = new DateTime(2007, 5, 2)
};
employees.Add(fe3);
FullTimeEmployee fe4 = new FullTimeEmployee()
{
    Id = 4,
    Name = "Name 4",
    IdCard = "456",
    Birthday = new DateTime(2000, 12, 7)
};
employees.Add(fe4);
ParttimeEmployee pe1 = new ParttimeEmployee()
{
    Id = 1,
    Name = "Name 5",
    IdCard = "789",
    Birthday = new DateTime(1999, 12, 7),
    WorkingHour = 3
};


employees.Add(pe1);

//Câu 2 : Xuất toàn bộ thông tin toàn bộ nhân sự
Console.OutputEncoding=Encoding.UTF8;
Console.WriteLine("Thông tin toàn bộ nhân sự cách expression body");
//Cách 1 dùng Expression body : là =>
employees.ForEach(e => Console.WriteLine(e));
Console.WriteLine("Thông tin toàn bộ nhân sự cách thông thường");
//Cách 2 : dùng for thông thường
foreach (var e in employees)
{
    Console.WriteLine(e);
}


//Câu 3 : Sắp xếp nhân viên năm sinh tăng dần 
//cũng là R
for (int i = 0; i < employees.Count; i++)
{
    for (int j = i+1; j < employees.Count; j++)
    {
        Employee ei = employees[i];
        Employee ej = employees[j];
        if(ei.Birthday < ej.Birthday)
        {
            employees[i] = ej;
            employees[j] = ei;
        }

    }
}
Console.WriteLine("------sau khi sắp xếp thoe năm sinh-------");
employees.ForEach(e => Console.WriteLine(e));


