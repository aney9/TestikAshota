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

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для Avtorizir.xaml
    /// </summary>
    public partial class Avtorizir : Window
    {
        public Avtorizir()
        {
            InitializeComponent();
        }

        private void click1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

        private void clickred(object sender, RoutedEventArgs e)
        {
            PageFrame1.Content = new FirstPage();
        }

        private void clickpro(object sender, RoutedEventArgs e)
        {
            json Json = new json();
            var testModel = json.Deser<List<testmodel>>("alo.json");
            if (testModel == null)
            {
                PageFrame3.Content = new Pusto();
            }
            else
            {
                PageFrame2.Content = new Prohod();
            }
        }
    }
}
