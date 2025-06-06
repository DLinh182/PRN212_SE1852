// See https://aka.ms/new-console-template for more information
using System.Text;
using DemoMyStoreLINQ2SQL;

Console.OutputEncoding=Encoding.UTF8;

string connectionString = "server=localhost\\SQLEXPRESS;database=MyStore;uid=sa;pwd=12345";
MyStoreDataContext context = new MyStoreDataContext(connectionString);
//Caau 1: dungf linq2sql ddeer laays toanf booj danh mucj
var categories = context.Categories;
foreach (var cate in categories)
{
    Console.WriteLine(cate.CategoryID+"\t"+cate.CategoryName);
}

//Caau 2: timf chi tieets 1 danh mujc khi bieets id
int catid = 5;
Category category = context.Categories.FirstOrDefault(c => c.CategoryID == catid);
if(category == null)
{
    Console.WriteLine("Khong tim thay danh muc voi id = " + catid);
}
else
{
    Console.WriteLine($"danh muc co id = {catid}");
    Console.WriteLine($"Ten danh muc: {category.CategoryName}");
}

//caau 3 : theem mowsi 1 danh muc
/*Category cnew = new Category();
cnew.CategoryName = "thuoc";
context.Categories.InsertOnSubmit(cnew);
context.SubmitChanges();*/

//caau 4: theem mosiw nhieeuf danh muc cung 1 luc
/*List<Category> dsdm = new List<Category>();
dsdm.Add(new Category() { CategoryName = "dau an" });
dsdm.Add(new Category() { CategoryName = "dau goi" });
dsdm.Add(new Category() { CategoryName = "dau xa" });
context.Categories.InsertAllOnSubmit(dsdm);
context.SubmitChanges();
*/

//caau 5: sua ten danh muc
//nguyen tac : tim thay moi sua
Category c = (from x in context.Categories
            where x.CategoryID == 5
            select x).FirstOrDefault();

Category c2 = context.Categories.FirstOrDefault(x => x.CategoryID == 10); 
if(c2 != null)
{
    c2.CategoryName = "sua lai r";
    context.SubmitChanges();
}

//Cau 6 : xoa danh muc
//tim thay danh muc r moi xoa
Category c3 = context.Categories.FirstOrDefault(x => x.CategoryID == 12);
if (c3 != null)
{
    context.Categories.DeleteOnSubmit(c3);
    context.SubmitChanges();
}
else
{
    Console.WriteLine("Khong tim thay danh muc can xoa");
}

//cau 7: xoa tat ca danh muc ko có san pham
var listdel = from x in context.Categories
              where !x.Products.Any()
              select x;
if(listdel.Any())
{
    context.Categories.DeleteAllOnSubmit(listdel);
    context.SubmitChanges();
}
else
{
    Console.WriteLine("Khong co danh muc nao khong co san pham");
}

