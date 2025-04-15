using Poprigunchick.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Poprigunchick.views
{
    /// <summary>
    /// Логика взаимодействия для ProductsList.xaml
    /// </summary>
    public partial class ProductsList : Page
    {
        List<Product> products;
        int order = 0;
        public ProductsList()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            if (DataGridProducts != null)
            {
                using (PoprigunchickEntities poprigunchickEntities = new PoprigunchickEntities())
                {
                    if (order == 0)
                    {
                        products = poprigunchickEntities.Product.OrderBy(p => p.Title).ToList();
                    }
                    else
                    {
                        products = poprigunchickEntities.Product.OrderByDescending(p => p.Title).ToList();
                    }
                }
                DataGridProducts.ItemsSource = products;
            }
        }

        private void ComboBoxSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox)
            {
                if (((ComboBox)sender).SelectedIndex == 0)
                {
                    order = 0;
                }
                else
                {
                    order = 1;
                }
            }
            Load();
        }

        private void ButtonAddProduct_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductAddView());
        }

        private void ButtonDeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridProducts.SelectedIndex != -1)
            {
                using (var context = new PoprigunchickEntities())
                {
                    var productToDelete = context.Product.Find(products[DataGridProducts.SelectedIndex].ID);
                    context.Product.Remove(productToDelete);
                    context.SaveChanges();
                    Load();
                }
            }
            else
            {
                MessageBox.Show("Выберите продукт для удаления");
            }
        }

        private void ButtonAgents_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridProducts.SelectedIndex != -1)
            {
                using (var context = new PoprigunchickEntities())
                {
                    NavigationService.Navigate(new AgentsList(products[DataGridProducts.SelectedIndex].ID));
                }
            }
            else
            {
                MessageBox.Show("Выберите продукт для удаления");
            }
        }
    }
}
