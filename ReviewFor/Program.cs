// See https://aka.ms/new-console-template for more information
using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//B1: ỨNG DỤNG OUT ĐỂ KIỂM TRA NHẬP HỢP LỆ
//B2: NHẬP KHI NÀO ĐÚNG THÌ MỚI DỪNG 
int n;
Console.WriteLine("Nhập n > = 0");
string s= Console.ReadLine();
if(int.TryParse(s, out n) == false)
{
    Console.WriteLine("Bạn phải nhập s");
} else
{
    if (n < 0)
    {
        Console.WriteLine("tui đã nói n phải >=0 mà");
    } else
    {
        //THỰC THI TÍNH GIAI THỪA n!
        int gt = 1;
        for(int i = 1; i <= n; i++)
            gt = gt * i;
            Console.WriteLine($"{n}!={gt}");
        
    }
}
