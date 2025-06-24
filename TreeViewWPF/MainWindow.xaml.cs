using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TreeViewWPF.models;

namespace TreeViewWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<int, Category> categories = SampleDataset.GenerateDataset();
        public MainWindow()
        {
            InitializeComponent();
            DisplayCategoriesAndProducts();
            
        }
        public void DisplayCategoriesAndProducts()
        {
            tvCategory.Items.Clear();
            TreeViewItem root = new TreeViewItem();
            root.Header = "Kho hang Binh Duong";
            tvCategory.Items.Add(root);
            foreach (KeyValuePair<int, Category> cate_kvp in categories)
            {
                Category cate = cate_kvp.Value;
                TreeViewItem cate_node = new TreeViewItem();
                cate_node.Header = cate;
                root.Items.Add(cate_node);
                foreach(KeyValuePair<int, Product> product_kvp in cate.Products)
                {
                    Product product = product_kvp.Value;
                    TreeViewItem product_node = new TreeViewItem();
                    product_node.Header = product;
                    cate_node.Items.Add(product_node);
                }
            } 
        }
    }
}