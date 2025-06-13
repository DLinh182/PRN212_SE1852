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

namespace HelloWpfApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            //giả lập account
            //nếu username là obam và pass là 123
            //thì cho vào màn hình main window
            if(txtUsername.Text == "obama" && txtPassword.Password == "123")
            {
                Hide();//ẩn màn hình đăng nhập
                MainWindow mw = new MainWindow();
                mw.Show();
                Close(); //đóng màn hình đăng nhập để thu hồi ô nhớ đã cấp cho loginwindow 
            } else
            {
                MessageBox.Show("sai r");
            }
        }
    }
}
