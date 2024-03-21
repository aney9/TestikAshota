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

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для Prohod.xaml
    /// </summary>
    public partial class Prohod : Page
    {
        List<testmodel> Testmodel = new List<testmodel>();
        int pravilnotvet;
        int nepravilnotvet;
        int i = 1;
        public Prohod()
        {
            InitializeComponent();
            json Json = new json();
            var testModel = Json.Deser<List<testmodel>>("alo.json");
            Nazv.Text = testModel[0].Name;
            Opis.Text = testModel[0].Description;
            Otvet1.Content  = testModel[0].FisrtAnswer;
            Otvet2.Content = testModel[0].SecondAnswer;
            Otvet3.Content = testModel[0].ThirdAnswer;
        }

        private void otvet1(object sender, RoutedEventArgs e)
        {
            if (Otvet1.Content == Testmodel[i - 1].PravilniOtvet.ToString())
            {
                pravilnotvet = i ++;
            }
            else
            {
                nepravilnotvet++;
            }
            if(i != Testmodel.Count)
            {
                Prisv();
            }
            else
            {
                Nazv.Text = $"ТЫ ПРАВ БРАД В {pravilnotvet} А НЕ ПРАВ В {nepravilnotvet}";
            }
        }

        private void otvet2(object sender, RoutedEventArgs e)
        {
            if (Otvet2.Content == Testmodel[i - 1].PravilniOtvet.ToString())
            {
                pravilnotvet = i ++;
            }
            else
            {
                nepravilnotvet++;
            }
            if (i != Testmodel.Count)
            {
                Prisv();
            }
            else
            {
                Nazv.Text = $"ТЫ ПРАВ БРАД В {pravilnotvet} А НЕ ПРАВ В {nepravilnotvet}";
            }
        }

        private void otvet3(object sender, RoutedEventArgs e)
        {
            if (Otvet3.Content == Testmodel[i - 1].PravilniOtvet.ToString())
            {
                pravilnotvet = i += 1;
            }
            else
            {
                nepravilnotvet++;
            }
            if (i != Testmodel.Count)
            {
                Prisv();
            }
            else
            {
                Nazv.Text = $"ТЫ ПРАВ БРАД В {pravilnotvet} А НЕ ПРАВ В {nepravilnotvet}";
            }
        }
        private void Prisv()
        {
            Nazv.Text = Testmodel[i].Name;
            Opis.Text = Testmodel[i].Description;
            Otvet1.Content = Testmodel[i].FisrtAnswer;
            Otvet2.Content = Testmodel[i].SecondAnswer;
            Otvet3.Content = Testmodel[i].ThirdAnswer;
        }
    }
}
