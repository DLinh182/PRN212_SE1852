using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MyStoreWpfAoo_EntityFrameWork.Models;

namespace MyStoreWpfAoo_EntityFrameWork
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        MyStoreContext context = new MyStoreContext();
        bool isLoadListViewCompleted = false; //biến kiểm tra xem có đang ở chế độ sửa hay không
        public AdminWindow()
        {
            InitializeComponent();
            DisplayCategoriesAndProducts();
        }
        private void DisplayCategoriesAndProducts()
        {
            tvCategory.Items.Clear();
            TreeViewItem root = new TreeViewItem();
            root.Header = "Kho hàng Trà Vinh";
            tvCategory.Items.Add(root);

            //duyệt vòng lặp qua tất cả các danh mục
            var categories = context.Categories.ToList();
            foreach (var category in categories)
            {
                //tạo node category
                TreeViewItem cate_node = new TreeViewItem();
                cate_node.Header = category.CategoryName;
                cate_node.Tag = category;
                root.Items.Add(cate_node);
                //vòng lặp duyệt qua các sản phẩm 
                var products = context.Products
                    .Where(p => p.CategoryId == category.CategoryId)
                    .ToList();
                foreach (var product in products)
                {
                    //tạo node product
                    TreeViewItem prod_node = new TreeViewItem();
                    prod_node.Header = product.ProductName;
                    prod_node.Tag = product;
                    cate_node.Items.Add(prod_node);
                }
            }
            root.ExpandSubtree();
        }

        private void tvCategory_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (isLoadListViewCompleted = false) return;
            TreeViewItem item = e.NewValue as TreeViewItem;
            if (item != null)
            {
                Category category = item.Tag as Category;
                if (category != null)
                {
                    //nạp sản phẩm của danh mục lên giao diện ListView
                    var products = context.Products
                   .Where(p => p.CategoryId == category.CategoryId)
                   .ToList();
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = products;
                }
            }
            isLoadListViewCompleted = true;
        }

        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (isLoadListViewCompleted = false) return;
             if(e.AddedItems.Count == 0)
            {
                return;
            }
            Product product = e.AddedItems[0] as Product;
            if (product == null)
                return;
            txtMa.Text = product.ProductId + "";
            txtTen.Text = product.ProductName;
            txtDonGia.Text = product.UnitPrice + "";
            txtSoLuong.Text = product.UnitsInStock + "";
            isLoadListViewCompleted = true;
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //chức năng thêm mới sản phẩm
            TreeViewItem item = tvCategory.SelectedItem as TreeViewItem;
            if (item == null)
            {
                MessageBox.Show("Bạn phải chọn danh mục trước","Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Category category = item.Tag as Category;
            if (category == null) 
            {
                MessageBox.Show("Bạn phải chọn danh mục trước", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            //Bước 2 : tạo sản phẩm
            Product p = new Product();
            p.ProductName = txtTen.Text;
            p.UnitPrice = decimal.Parse(txtDonGia.Text);
            p.UnitsInStock = short.Parse(txtSoLuong.Text);
            p.CategoryId = category.CategoryId; //gán mã danh mục cho sản phẩm
            //Đánh dấu thêm mới
            context.Products.Add(p);
            //xác nhận thêm mới
            context.SaveChanges();
            MessageBox.Show("Thêm mới sản phẩm thành công");

            TreeViewItem productNode = new TreeViewItem();
            productNode.Header = p.ProductName;
            productNode.Tag = p;

            item.Items.Add(productNode);
            item.IsExpanded = true;

            var products = context.Products.Where(pr => pr.CategoryId == category.CategoryId).ToList();
            lvProduct.ItemsSource = null;
            lvProduct.ItemsSource = products;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
             if (isLoadListViewCompleted = false) return;
            //chức năng sửa sản phẩm
            //bước 1 : phải tìm ra sản phẩm muốn sửa trước
            int id = int.Parse(txtMa.Text);
            Product product = context.Products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return;
            }
            //bước 2 : cập nhật thông tin sản phẩm
            product.ProductName = txtTen.Text;
            product.UnitPrice = decimal.Parse(txtDonGia.Text);
            product.UnitsInStock = short.Parse(txtSoLuong.Text);
            //bước 3 : đánh dấu sửa
            context.SaveChanges();
            //bước 4 : cập nhật lại giao diện
            TreeViewItem tvitem = tvCategory.SelectedItem as TreeViewItem;
            if (tvitem == null)
                return;
            Category category = tvitem.Tag as Category;
            if (category == null)
                return;

            // Xóa các node sản phẩm cũ trong danh mục
            tvitem.Items.Clear();

            // Thêm lại các node sản phẩm mới cho danh mục này
            var products = context.Products.Where(pr => pr.CategoryId == category.CategoryId).ToList();
            foreach (var prod in products)
            {
                TreeViewItem productNode = new TreeViewItem();
                productNode.Header = prod.ProductName;
                productNode.Tag = prod;
                tvitem.Items.Add(productNode);
            }
            tvitem.IsExpanded = true;

            // Cập nhật lại ListView
            lvProduct.ItemsSource = null;
            lvProduct.ItemsSource = products;
            MessageBox.Show("Cap nhat san pham thanh cong", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Information);

            isLoadListViewCompleted = true;
        }
        

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //tìm sp để xóa
            int id = int.Parse(txtMa.Text);
            Product product = context.Products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm để xóa", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            MessageBoxResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No) 
            {
                return;
            }
            context.Products.Remove(product);
            context.SaveChanges();
            DisplayCategoriesAndProducts(); // Tải lại toàn bộ giao diện
            
        }
    }
}
