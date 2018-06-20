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

namespace Converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string s = Fa.Text;
                if (String.IsNullOrEmpty(s))
                {
                    throw new Exception("Вы не ввели градусы!");
                }

               

                int _s = Convert.ToInt32(s);
                int _benefit = _s + 273;

                string res =
                    $"Result :  {_benefit} ";
                result.Text = res;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка выполнения",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void calc_Click1(object sender, RoutedEventArgs e)
        {
            try
            {
                string s = Fa.Text;
                if (String.IsNullOrEmpty(s))
                {
                    throw new Exception("Вы не ввели градусы!");
                }
                int _s = Convert.ToInt32(s);
                int _benefit = _s - 273;

                string res =
                    $"Result :  {_benefit} ";
                result.Text = res;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка выполнения",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
