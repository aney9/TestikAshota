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

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string avtooriz { get; set; }
        Avtorizir avtoriz = new Avtorizir();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click1(object sender, RoutedEventArgs e)
        {
            avtoriz.Show();
            this.Close();
            avtoriz.redaktor.IsEnabled = false;
        }

        private void click2(object sender, RoutedEventArgs e)
        {
            Avtoriz.IsEnabled = true;
            avtooriz = Avtoriz.Text;
            if (avtooriz == "попуск")
            {
                avtoriz.Show();
                this.Close();
            }
        }
    }
}