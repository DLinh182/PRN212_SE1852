// See https://aka.ms/new-console-template for more information



//Ứng dụng Generic để quản lý nhân viên, thực hiện các thao tác CRUD
//C : Create --> Thêm mới
//R : Read(Retrieve) --> Truy vấn: xem, sắp xếp, lọc dữ liệu ..
//U : Update --> Chỉnh sửa dữ liệu
//D : Delete --> Xóa dữ liệu


//Câu 1 ; Tạo 5 nhân viên, 4 fulltime, 1 partime
using System.Text;
using OOP2;
Console.OutputEncoding = Encoding.UTF8;

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
    Id = 5,
    Name = "Name 5",
    IdCard = "789",
    Birthday = new DateTime(1999, 12, 7),
    WorkingHour = 3
};


employees.Add(pe1);

// Menu system
while (true)
{
    Console.WriteLine("\n=== MENU QUẢN LÝ NHÂN VIÊN ===");
    Console.WriteLine("1. Xem danh sách nhân viên");
    Console.WriteLine("2. Sắp xếp nhân viên theo năm sinh");
    Console.WriteLine("3. Sửa thông tin nhân viên");
    Console.WriteLine("4. Xóa nhân viên");
    Console.WriteLine("5. Thoát");
    Console.Write("Chọn chức năng (1-5): ");

    if (int.TryParse(Console.ReadLine(), out int choice))
    {
        switch (choice)
        {
            case 1:
                Console.WriteLine("\nDanh sách nhân viên:");
                employees.ForEach(e => Console.WriteLine(e));
                break;
            case 2:
                SortEmployees(employees);
                Console.WriteLine("\nDanh sách sau khi sắp xếp theo năm sinh tăng dần:");
                employees.ForEach(e => Console.WriteLine(e));
                break;
            case 3:
                EditEmployee(employees);
                break;
            case 4:
                DeleteEmployee(employees);
                break;
            case 5:
                Console.WriteLine("Bye!");
                return;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ!");
                break;
        }
    }
    else
    {
        Console.WriteLine("Vui lòng nhập số!");
    }
}

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

static void SortEmployees(List<Employee> employees)
{
    for (int i = 0; i < employees.Count; i++)
    {
        for (int j = i + 1; j < employees.Count; j++)
        {
            Employee ei = employees[i];
            Employee ej = employees[j];
            if (ei.Birthday < ej.Birthday)
            {
                employees[i] = ej;
                employees[j] = ei;
            }
        }
    }
}


//câu 4: sửa thông tin nhân viên
static void EditEmployee(List<Employee> employees)
{
    Console.WriteLine("\n=== Sửa thông tin nhân viên ===");
    Console.Write("Nhập mã nhân viên cần sửa: ");
    if (int.TryParse(Console.ReadLine(), out int id))
    {
        Employee employeeToEdit = employees.Find(e => e.Id == id);
        if (employeeToEdit != null)
        {
            Console.Write("Nhập tên mới: ");
            employeeToEdit.Name = Console.ReadLine();

            Console.Write("Nhập IdCard mới: ");
            employeeToEdit.IdCard = Console.ReadLine();

            Console.Write("Nhập ngày sinh mới (dd/MM/yyyy): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime birthday))
            {
                employeeToEdit.Birthday = birthday;
            }

            // Kiểm tra nếu là nhân viên part-time thì cho phép sửa số giờ làm
            if (employeeToEdit is ParttimeEmployee parttimeEmployee)
            {
                Console.Write("Nhập số giờ làm mới: ");
                if (int.TryParse(Console.ReadLine(), out int workingHours))
                {
                    parttimeEmployee.WorkingHour = workingHours;
                }
            }

            Console.WriteLine("Đã cập nhật thông tin thành công!");
        }
        else
        {
            Console.WriteLine("Không tìm thấy nhân viên có mã này!");
        }
    }
    else
    {
        Console.WriteLine("Mã nhân viên không hợp lệ!");
    }
}


EditEmployee(employees);

Console.WriteLine("\nDanh sách nhân viên sau khi sửa:");
employees.ForEach(e => Console.WriteLine(e));

//câu 5: xóa nhân viên
static void DeleteEmployee(List<Employee> employees)
{
    Console.WriteLine("\n=== Xóa nhân viên ===");
    Console.Write("Nhập mã nhân viên cần xóa: ");
    if (int.TryParse(Console.ReadLine(), out int id))
    {
        Employee employeeToDelete = employees.Find(e => e.Id == id);
        if (employeeToDelete != null)
        {
            employees.Remove(employeeToDelete);
            Console.WriteLine("Đã xóa nhân viên thành công!");
        }
        else
        {
            Console.WriteLine("Không tìm thấy nhân viên có mã này!");
        }
    }
    else
    {
        Console.WriteLine("Mã nhân viên không hợp lệ!");
    }
}

// Gọi hàm xóa nhân viên
DeleteEmployee(employees);

// Hiển thị danh sách sau khi xóa
Console.WriteLine("\nDanh sách nhân viên sau khi xóa:");
employees.ForEach(e => Console.WriteLine(e));