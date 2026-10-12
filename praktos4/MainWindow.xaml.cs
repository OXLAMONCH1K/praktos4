using praktos4;
using System;
using System.Windows;

namespace praktos4
{
    public partial class MainWindow : Window
    {
        Triangle triangle;
        public MainWindow()
        {
            InitializeComponent();
            triangle = new Triangle(3, 4, 5);
            txtResult.Text = triangle.Show();
        }
        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double c = Convert.ToDouble(txtC.Text);
                triangle.SetParams(a, b, c);
                txtResult.Text = triangle.Show();
            }
            catch
            {
                MessageBox.Show("Введите числа в поля сторон!");
            }
        }
        private void btnDouble_Click(object sender, RoutedEventArgs e)
        {
            triangle.SetParams();
            txtA.Text = triangle.A.ToString();
            txtB.Text = triangle.B.ToString();
            txtC.Text = triangle.C.ToString();
            txtResult.Text = triangle.Show();
        }
        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Практическая работа №4\n" +
                "Разработчик: Бучмеюк Михаил\n\n" +
                "Задание:\n" +
                "Создать класс Triangle с полями-сторонами. " +
                "Определить метод вычисления периметра. " +
                "Создать перегруженные методы SetParams " +
                "для установки параметров и увеличения сторон в 2 раза."
            );
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}