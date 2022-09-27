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

namespace ISO_PR3_3__Cherednichenko_V5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Pusk_Click(object sender, RoutedEventArgs e)
        {
            //Получение исходных данных из TextBox
            double x = Convert.ToDouble(X.Text);

            //Ввод исходных данных в окно результатов
            Itog.Text = "Результаты работы программы ст. гр. 402 ИСП Чередниченко Е.К. Вариант 5" + Environment.NewLine;
            Itog.Text += "При X = " + X.Text + Environment.NewLine;

            //Определение номера выбранной функции
            int n = 0;
            double u;

            //Вычисление U
            
                    if (x < 3.5) u = -((2 * x) / (-4 * x + 1));
                    else if (x >= -3.5) u = 4 * x * x + 2 * x - 19;
                    else u = 0 ; 
            Itog.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
                   
            }

        private void Clin_Click(object sender, RoutedEventArgs e)
        {
            Itog.Clear();
        }
    }

    }
