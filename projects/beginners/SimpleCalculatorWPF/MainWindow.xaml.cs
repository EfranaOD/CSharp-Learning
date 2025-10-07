using System.Windows;
using System.Windows.Controls;

namespace SimpleCalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtNumOne.Focus();

            txtNumOne.IsReadOnly = true;
            txtNumTwo.IsReadOnly = true;
        }
        TextBox activeTextBox;
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            activeTextBox = (TextBox)sender;
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            bool success1 = double.TryParse(txtNumOne.Text, out double num1);
            bool success2 = double.TryParse(txtNumTwo.Text, out double num2);

            if (!success1 || !success2)
            {
                lblResult.Content = "Invalid input!";
                return;
            }

            double sum = num1 + num2;
            lblResult.Content = $"Addition: {sum}";
        }
        private void SubButton_Click(object sender, RoutedEventArgs e)
        {
            bool success1 = double.TryParse(txtNumOne.Text, out double num1);
            bool success2 = double.TryParse(txtNumTwo.Text, out double num2);

            if (!success1 || !success2)
            {
                lblResult.Content = "Invalid input!";
                return;
            }

            double sub = num1 - num2;
            lblResult.Content = $"Difference: {sub}";
        }
        private void ProdButton_Click(object sender, RoutedEventArgs e)
        {
            bool success1 = double.TryParse(txtNumOne.Text, out double num1);
            bool success2 = double.TryParse(txtNumTwo.Text, out double num2);

            if (!success1 || !success2)
            {
                lblResult.Content = "Invalid input!";
                return;
            }

            double prod = num1 * num2;
            lblResult.Content = $"Product: {prod}";
        }
        private void DivButton_Click(object sender, RoutedEventArgs e)
        {
            bool success1 = double.TryParse(txtNumOne.Text, out double num1);
            bool success2 = double.TryParse(txtNumTwo.Text, out double num2);

            if (!success1 || !success2)
            {
                lblResult.Content = "Invalid input!";
                return;
            }

            double div = num1 / num2;
            lblResult.Content = $"Division: {div}";
        }
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            txtNumOne.Text = string.Empty;
            txtNumTwo.Text = string.Empty;

            lblResult.Content = "";
        }
        private void PeriodButton_Click(object sender, RoutedEventArgs e)
        {
            if (!activeTextBox.Text.Contains('.'))
            {
                activeTextBox.Text += '.';
            }
            else
            {
                activeTextBox.Text += "";
            }
        }

        private void NumberButton_Click(Object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            activeTextBox.Text += btn.Content.ToString();
        }
    }
}