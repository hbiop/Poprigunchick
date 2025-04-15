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
    /// Логика взаимодействия для AgentsList.xaml
    /// </summary>
    public partial class AgentsList : Page
    {
        List<AgentDto> agents;
        int productId;
        public AgentsList(int id)
        {
            InitializeComponent();
            using (var context = new PoprigunchickEntities())
            {
                var productSale = context.ProductSale.Where(ps => ps.ProductID == id);
                agents = productSale.Select(t => t.Agent).Select(a => new AgentDto{ title = a.Title, description = a.Phone, PhotoPath = a.Logo == "" || a.Logo == null ? "/agents/agent_1.png" : a.Logo  }).ToList();
            }
            productId = id;
            DataGridAgents.ItemsSource = agents;
        }

        private void ButtonAddAgents_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AgentRecordAdd(productId));
        }

        private void ButtonDeleteAgents_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductsList());
        }
    }
}
