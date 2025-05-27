// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
void giai_bac_1(double a, double b)
{
    if (a == 0 && b == 0)
    {
        Console.WriteLine("pt vo so nghiem");
    }
    else if (a == 0 && b != 0)
    {
        Console.WriteLine("pt vo nghiem");
    }
    else Console.WriteLine("X={0}", -b / a);
}

void giai_bac_2(double a, double b, double c)
{
    if (a == 0 )
    {
        giai_bac_1(b, c);
    } else
        {
        var delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta < 0)
            Console.WriteLine("pt vo nghiem");
        else if (delta == 0)
            Console.WriteLine("X1=X2={0}", -b / 2 * a);
        else
        {
            var x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            var x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("X1={0}, X2={1}", x1, x2);
        }
        }
}

Console.WriteLine("pt bac 2");
Console.WriteLine("nhap a");
var a = double.Parse(Console.ReadLine());
Console.WriteLine("nhap b");
var b = double.Parse(Console.ReadLine());
Console.WriteLine("nhap c");
var c = double.Parse(Console.ReadLine());
Console.WriteLine("{0}X^2 + {1}X + {2} = 0", a,b,c);
giai_bac_2(a, b, c);
Console.ReadLine();

