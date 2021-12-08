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
using System.Collections;

namespace pr_10_kozub_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList numbers = new ArrayList();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void fill_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                mainListBox.ItemsSource = null;
                Random _random = new Random();
                int length = Int32.Parse(inputLength.Text);
                for (int i = 0; i < length; i++)
                {
                    numbers.Add(_random.Next(0, 11));
                }
                mainListBox.ItemsSource = numbers;
            }
            catch 
            {
                MessageBox.Show("Проверьте введенное значение", "Ошибка");
            }
        }

        private void calculateCounts_Click(object sender, RoutedEventArgs e)
        {
            int fiveCounter = 0, sevenCounter = 0;
            if (numbers.Count != 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (Convert.ToInt32(numbers[i]) == 5)
                        fiveCounter++;
                    if (Convert.ToInt32(numbers[i]) == 7)
                        sevenCounter++;
                }
                MessageBox.Show($"Количество '5' - {fiveCounter}\nКоличество '7' - {sevenCounter}");
            }
            else MessageBox.Show("Заполните массив", "Ошибка");
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №10\n" +
                "Козуб Дмитрий ИСП-34\n" +
                "Дан массив в диапазоне [0;10] найти количество значений равных 5 и 7.", "О программе", MessageBoxButton.OK);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
