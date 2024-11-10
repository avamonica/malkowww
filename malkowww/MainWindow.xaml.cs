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

namespace malkowww
{
    public partial class MainWindow : Window
    {
        private List<int> numbers = new List<int>();  // Список чисел

        public MainWindow()
        {
            InitializeComponent();
        }

        // Обработчик нажатия на кнопку Add
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Увеличиваем значение на 1 при каждом добавлении
            int newNumber = numbers.Count == 0 ? 0 : numbers[^1] + 1;
            numbers.Add(newNumber);
            UpdateListView();
        }

                // Обработчик нажатия на кнопку Del
        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            if (listView.SelectedItem != null)
            {
              // Удаляем элемент
                numbers.Remove((int)listView.SelectedItem);
                UpdateListView();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите элемент для удаления.");
            }
        }

        
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            numbers.Clear();  // Очищаем список
            UpdateListView();
        }

        // Метод обновления ListView
        private void UpdateListView()
        {
            listView.Items.Clear();
            foreach (var num in numbers)
            {
                listView.Items.Add(num);
            }
        }
    }
}
