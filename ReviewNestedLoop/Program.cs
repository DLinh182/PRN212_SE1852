// See https://aka.ms/new-console-template for more information
//CÂU 1 : VẼ HÌNH 
void hinh1(int n)
{
    for(int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if( j == 0 || j == (n-1) || i == j)
            {
                Console.Write("*");
            } else 
                { 
                    Console.Write(" "); 
                }
        }
        Console.WriteLine();
    }
}
//hinh1(10);


//CÂU 2 : SẮP XẾP MẢNG TĂNG DẦN DÙNG DO WHILE LỒNG NHAU 
void swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

void mysort(int[] arr)  // mảng là tham chiếu,biến
{
    int i = 0;
    int j = i + 1;
    do 
    {
        do
        {
            if (arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
            j++;
        } while (j < arr.Length -1);
        i++;
        j = i + 1;
    } while (i < arr.Length -1);
}
int[] array = { 10, 3, 7, 2, 9 };
Console.WriteLine("Mảng trc khi sx: ");
foreach(int x in array)
    Console.Write($"{x}\t");
Console.WriteLine();
mysort(array);
Console.WriteLine("Mảng sau khi sx:");
foreach(int x in array)
{
    Console.Write($"{x}\t");
}