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

namespace WpfAppSmi
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page1
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(VerticalAlignment.Top);
            double b = Convert.ToDouble(VerticalAlignment.Top);
            double c = Convert.ToDouble(VerticalAlignment.Top);
            double d = b * b - 4 * a * c;

            if (d < 0)
            {
                MessageBox.Show("Дискриминант меньше нуля. Корней нет.");
            }

            if (d == 0)
            {
                double x = (-b / (2 * a));
                MessageBox.Show("Дискриминант равен нулю. Корень равен " + x + ".");
            }

            if (d > 0)
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                MessageBox.Show("Дискриминант равен " + d + ". Первый корень равен " + x1 + ". Второй корень равен " + x2 + ".");
            }
        }
    }
}

