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
    /// Логика взаимодействия для ProductAddView.xaml
    /// </summary>
    public partial class ProductAddView : Page
    {
        public ProductAddView()
        {
            InitializeComponent();
            ComboBoxProductType.ItemsSource = new PoprigunchickEntities().ProductType.ToList();
            ComboBoxProductType.DisplayMemberPath = "Title";
            ComboBoxProductType.SelectedIndex = 0;
            ButtonAdd.Click += Button_Click;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string error = "";
                string title = TextBoxTitle.Text;
                string article = TextBoxArticul.Text;
                string description = TextBoxOpisanie.Text;
                int personCount;
                bool personCountBool = Int32.TryParse(TextBoxKolichestvoSotrudnikov.Text, out personCount);
                int workshopCount;
                bool workshopCountBool = Int32.TryParse(TextBoxKolichestvoSotrudnikov.Text, out workshopCount);
                decimal minCost;
                bool minCostBool = Decimal.TryParse(TextBoxMinimalnayaCena.Text, out minCost);
                if (title.Length <= 100 && title.Length != 0 && description.Length <= 100 && article.Length <= 10 && article.Length != 0 && personCountBool && workshopCountBool && minCostBool)
                {
                    Product product = new Product();
                    product.Title = title;
                    product.Description = description;
                    product.ArticleNumber = article;
                    product.ProductionPersonCount = personCount;
                    product.ProductionWorkshopNumber = workshopCount;
                    product.MinCostForAgent = minCost;
                    ProductType type = (ProductType)ComboBoxProductType.SelectedItem;
                    product.ProductTypeID = type.ID;
                    using (var context = new PoprigunchickEntities())
                    {
                        context.Product.Add(product);
                        context.SaveChanges();
                    }
                    NavigationService.Navigate(new ProductsList());
                }
                else
                {
                    if (title.Length > 100)
                    {
                        error += "Поле название должно быть меньше 100 символов\n";
                    }
                    if (title.Length == 0)
                    {
                        error += "Поле название не должно быть пустым\n";
                    }
                    if (description.Length > 100)
                    {
                        error += "Поле Описание должно быть меньше 100 символов\n";
                    }
                    if (article.Length > 10)
                    {
                        error += "Поле артикул должно быть меньше 10 символов\n";
                    }
                    if (article.Length == 0)
                    {
                        error += "Поле артикул не должно быть пустым\n";
                    }
                    if (!personCountBool)
                    {
                        error += "Поле количество сотрудников должно быть целым числом\n";
                    }
                    if (!workshopCountBool)
                    {
                        error += "Поле количество номер цеха должно быть целым числом\n";
                    }
                    if (!minCostBool)
                    {
                        error += "Поле минимальная цена было в неверном формате\n";
                    }
                    MessageBox.Show(error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка");
            }
            
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductsList());
        }
    }
}
