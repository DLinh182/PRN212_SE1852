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
using Services;
using BusinessObject;

namespace SampleManagementWpfApp
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        ProductService productService = new ProductService();
        bool isLoaded = false;
        public ProductWindow()
        {
            InitializeComponent();
            isLoaded = false; 
            productService.InitializeDataset();
            lvProduct.ItemsSource = productService.GetAllProducts();
            isLoaded = true; 
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Product p = new Product();
            p.Id = int.Parse(txtGia.Text);
            p.Name = txtTen.Text;
            p.Price = decimal.Parse(txtGia.Text);
            p.Quantity = int.Parse(txtSoLuong.Text);
            bool kq = productService.SaveProduct(p);
            if (kq == true)
            {
                lvProduct.ItemsSource = null; // Clear the current items
                lvProduct.ItemsSource = productService.GetAllProducts(); // Refresh the list
            }
        }

        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(isLoaded == false)
            {
                return; // Chưa load dữ liệu, không làm gì cả
            }
            if (e.AddedItems.Count < 0)
            
                return;//người dùng chưa chọn sản phẩm nào
                //vì coding của chúng ta là biding list product
                //nên ta lấy đôis tượng product rara
                Product p = e.AddedItems[0] as Product;
                txtMa.Text = p.Id.ToString();
                txtTen.Text = p.Name;
                txtGia.Text = p.Price.ToString();
                txtSoLuong.Text = p.Quantity.ToString();
            
        }

        private void btnCapNhat_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                isLoaded = false;
                Product pUpdate = new Product();
                pUpdate.Id = int.Parse(txtMa.Text);
                pUpdate.Name = txtTen.Text;
                pUpdate.Price = decimal.Parse(txtGia.Text);
                pUpdate.Quantity = int.Parse(txtSoLuong.Text);
                bool kq = productService.UpdateProduct(pUpdate);
                if (kq == true)
                {
                    lvProduct.ItemsSource = null; // Clear the current items
                    lvProduct.ItemsSource = productService.GetAllProducts(); // Refresh the list
                }
                else
                {
                    MessageBox.Show("Cập nhật sản phẩm thất bại!");
                }
                isLoaded = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult ret = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (ret == MessageBoxResult.No)
            {
                return; 
            }
            try
            {
                isLoaded = false;
                int id = int.Parse(txtMa.Text);
                bool kq = productService.DeleteProduct(id);
                if (kq == true)
                {
                    lvProduct.ItemsSource = null; // Clear the current items
                    lvProduct.ItemsSource = productService.GetAllProducts(); // Refresh the list
                    txtMa.Text = ""; // Clear the text box
                    txtTen.Text = "";
                    txtGia.Text = "";
                    txtSoLuong.Text = "";

                }
                isLoaded = true;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
