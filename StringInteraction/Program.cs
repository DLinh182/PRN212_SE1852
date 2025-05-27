// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
String ho = "Nguyễn";
String tenlot = "Thị";
String ten = "Tèo";
String tenfull = ho + " " + tenlot + " " + ten;
Console.WriteLine(tenfull);
StringBuilder sb = new StringBuilder();
sb.Append(ho);
sb.Append(" ");
sb.Append(tenlot);
sb.Append(" ");
sb.Append(ten);
String name2 = sb.ToString();
Console.WriteLine(name2);
Console.ReadLine();
