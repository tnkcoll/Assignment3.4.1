using System.Runtime.CompilerServices;
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

namespace Assignment3._4._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Coffee> coffeeList = new List<Coffee>();
        List<Tea> teaList = new List<Tea>();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        public void btnAddBeverage_Click(object sender, RoutedEventArgs e)
        {
            bool isCoffee = false;

            if (string.IsNullOrEmpty(this.txtBeverageName.Text))
            {
                MessageBox.Show("The beverage must have a name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                if (this.txtBeverageName.Text == "Tea")
                {
                    isCoffee = false;
                }
                else if (this.txtBeverageName.Text == "Coffee")
                {
                    isCoffee = true;
                }
            }

            if(isCoffee)
            {
                var coffee = new Coffee();

                coffee.Name = this.txtBeverageName.Text;

                if (string.IsNullOrEmpty(this.txtBeverageType.Text))
                {
                    MessageBox.Show("The beverage must have a type", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else
                {
                    coffee.Type = this.txtBeverageType.Text;
                }

                if (string.IsNullOrEmpty(this.txtBeverageStyle.Text))
                {
                    MessageBox.Show("The beverage must have a style", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else
                {
                    coffee.Type = this.txtBeverageStyle.Text;
                }

                if (string.IsNullOrEmpty(this.txtBeveragePrice.Text))
                {
                    MessageBox.Show("The beverage must have a price", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else
                {
                    coffee.Type = this.txtBeveragePrice.Text;
                }
                coffeeList.Add(coffee);
            }
            
            if(!isCoffee)
            {
                var tea = new Tea();

                tea.Name = this.txtBeverageName.Text;

                if (string.IsNullOrEmpty(this.txtBeverageType.Text))
                {
                    MessageBox.Show("The beverage must have a type", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else
                {
                    tea.Type = this.txtBeverageType.Text;
                }

                if (string.IsNullOrEmpty(this.txtBeverageStyle.Text))
                {
                    MessageBox.Show("The beverage must have a style", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else
                {
                    tea.Type = this.txtBeverageStyle.Text;
                }

                if (string.IsNullOrEmpty(this.txtBeveragePrice.Text))
                {
                    MessageBox.Show("The beverage must have a price", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else
                {
                    tea.Type = this.txtBeveragePrice.Text;
                }
                teaList.Add(tea);
            }
        }
    }
}