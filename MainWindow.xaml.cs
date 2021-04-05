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

namespace GenericList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        List<User> Users = new List<User>();



        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i < 6; i++)
            {
                User userItem = new User();
                userItem.ID = i;
                userItem.Name = "Name " + i;
                userItem.Surname = "Surname " + i;

                Users.Add(userItem);
            }

            Users.OrderBy(o => o.ID).ToList(); // sorting list by id
            Users.Reverse();

            dataGrid1.ItemsSource = Users;
            MessageBox.Show("Count : " + Users.Count().ToString() );
        }

        
        
    }
}
