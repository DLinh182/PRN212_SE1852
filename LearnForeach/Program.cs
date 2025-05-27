// See https://aka.ms/new-console-template for more information


//Dấu $ trong C# trước một chuỗi (như $"...") được gọi là interpolated string (chuỗi nội suy).
//Nó cho phép bạn chèn giá trị của biến hoặc biểu thức trực tiếp vào chuỗi một cách dễ đọc hơn, thay vì phải dùng nối chuỗi (+).

//Viết hàm nhận bao nhiêu phần tử cũng được, trả về tổng
int sums(params int[] arr)
{
    int s = 0;
    foreach (int x in arr)
        s += x;
    return s;
}
int s1 = sums(1);
int s2 = sums(1,8);
int s3 = sums(12,5,10);
Console.WriteLine($"s1={s1}; s2={s2}; s3={s3}");
