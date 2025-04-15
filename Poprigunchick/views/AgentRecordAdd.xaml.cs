using Poprigunchick.models;
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

namespace Poprigunchick.views
{
    /// <summary>
    /// Логика взаимодействия для AgentRecordAdd.xaml
    /// </summary>
    public partial class AgentRecordAdd : Page
    {
        int productId;
        List<Agent> agents;
        public AgentRecordAdd(int productId)
        {
            InitializeComponent();
            this.productId = productId;
            using (var context = new PoprigunchickEntities())
            {
                agents = context.Agent.ToList();
            }
            ComboBoxAgents.ItemsSource = agents;
            ComboBoxAgents.SelectedIndex = 0;
            ComboBoxAgents.DisplayMemberPath = "Title";
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AgentsList(productId));
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            string error = "";
            int productCount;
            bool productCountBool = Int32.TryParse(TextBoxProductCount.Text, out productCount);
            if (productCountBool)
            {
                ProductSale productSale = new ProductSale();
                productSale.ProductID = productId;
                productSale.AgentID = ((Agent)ComboBoxAgents.SelectedItem).ID;
                productSale.SaleDate = Convert.ToDateTime(DatePickerDateSale.Text);
                productSale.ProductCount = productCount;
                using (var context = new PoprigunchickEntities())
                {
                    context.ProductSale.Add(productSale);
                    context.SaveChanges();
                }
                NavigationService.Navigate(new AgentsList(productId));
            }
            else
            {
                if (!productCountBool)
                {
                    error += "Количество товаров должно быть целым числом\n";
                }
            }
        }
    }
}
