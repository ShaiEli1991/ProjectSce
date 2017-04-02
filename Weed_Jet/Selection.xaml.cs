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

namespace Weed_Jet
{
    /// <summary>
    /// Interaction logic for Selection.xaml
    /// </summary>
    public partial class Selection : Window
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Weather_Border.Visibility = Visibility;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WorldClock_Border.Visibility = Visibility;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DayBefore_Border.Visibility = Visibility;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Calc_Border.Visibility = Visibility;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ToDo_Border.Visibility = Visibility;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Album_Border.Visibility = Visibility;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Memo_Border.Visibility = Visibility;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Calc_Border.Visibility = Visibility;
            DayBefore_Border.Visibility = Visibility;
            Weather_Border.Visibility = Visibility;
            WorldClock_Border.Visibility = Visibility;
            Weather_Border.Visibility = Visibility;
            Memo_Border.Visibility = Visibility;
            Album_Border.Visibility = Visibility;
            ToDo_Border.Visibility = Visibility;
        }
    }
}
