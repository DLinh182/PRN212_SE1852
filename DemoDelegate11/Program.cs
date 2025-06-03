// See https://aka.ms/new-console-template for more information


using System.Text;

class Program
{
    static int[] ListEven(int n)
    {
        List<int> list = new List<int>();
        for (int i = 2; i <= n; i=i+2)
            list.Add(i);
        return list.ToArray();
    }

    static int[]ListPrime(int n)
    {
        List<int>list = new List<int>();
        for(int i = 2;i <= n; i++)
        {
            int count = 0;
            for (int j = 1; j <= i; j++)
            {

                if (i % j == 0)
                    count++;
               
            }
            if(count==2)
                list.Add(i);
        }
        return list.ToArray();
    }


    public static void Main(string[] args)
    {
        Console.OutputEncoding=Encoding.UTF8;
        MyDelegate d1 = new MyDelegate(ListEven);
        int[] result1 = d1(10);
        Console.WriteLine("Danh sách số chẵn : ");
        foreach (int i in result1)
            Console.WriteLine(i);


        MyDelegate d2 = new MyDelegate(ListPrime);
        int[] result2 = d2(10);
        Console.WriteLine("Danh sách số nguyên tố: ");
        foreach(int i in result2)
            Console.WriteLine(i);
    }
}
public delegate int[] MyDelegate(int n);

