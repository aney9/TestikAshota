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
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        public ObservableCollection<testmodel> Testmodels { get; set; }
        json Json = new json();
        public FirstPage()
        {
            InitializeComponent();
            Testmodels = new ObservableCollection<testmodel>();
            dataGrid.ItemsSource = Testmodels;
        }
        private void sohraa(object sender, RoutedEventArgs e)
        {
            Json.Ser(Testmodels, "alo.json");
        }

    }
}
