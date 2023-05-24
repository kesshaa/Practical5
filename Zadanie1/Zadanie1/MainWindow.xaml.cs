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

namespace Zadanie1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<int> numbers = new List<int>(); // список для хранения введённых чисел
        private int count = 0; // переменная для подсчёта количества чисел кратных 5 или 9
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TbNumber.Text, out int num))
            {
                if (num != 0)
                {
                    numbers.Add(num); // добавляем число в список
                    ListBoxData.Items.Add(num); // добавляем число в ListBox
                }
                else
                {
                    // проходим по списку чисел и считаем количество чисел, кратных 5 или 9
                    foreach (int n in numbers)
                    {
                        if (n % 5 == 0 || n % 9 == 0)
                            count++;
                    }

                    TextBlockAnswer.Text = "Ответ: " + count; // выводим результат
                }
            }

            TbNumber.Clear(); // очищаем TextBox для нового ввода числа
        }
        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {

            if (int.TryParse(TbNumber.Text, out int num))
            {
                if (num != 0)
                {
                    numbers.Add(num); // добавляем число в список
                    ListBoxData.Items.Add(num); // добавляем число в ListBox
                }
                else
                {
                    // проходим по списку чисел и считаем количество чисел, кратных 5 или 9
                    foreach (int n in numbers)
                    {
                        if (n % 5 == 0 || n % 9 == 0)
                            count++;
                    }

                    TextBlockAnswer.Text = "Ответ: " + count;
                }

               
            }
            }



        }
    }

