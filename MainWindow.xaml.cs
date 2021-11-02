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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Listbox_Layouts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var data = new[] { 
            new { Name = "James" },
            new { Name = "Mike" },
            new { Name = "John" },
            new { Name = "Luke" },
            new { Name = "Oscar" },
            new { Name = "Charles" },
            };



            MyListbox.ItemsSource = data;
        }



        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MyListbox.layout = Layout.Tile;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MyListbox.layout = Layout.List;
        }


    }
}
