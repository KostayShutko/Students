using Students.Model;
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

namespace Students
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext =new ViewModel.ViewModel(new DefaultDialogService(), new XmlFileService());
        }

        private void CreateStudent_Click(object sender, RoutedEventArgs e)
        {
            FormStudent.Visibility = Visibility.Visible;
        }

        private void SaveStudent_Click(object sender, RoutedEventArgs e)
        {
            FormStudent.Visibility = Visibility.Hidden;
        }

        private void CancelStudent_Click(object sender, RoutedEventArgs e)
        {
            FormStudent.Visibility = Visibility.Hidden;
        }
    }
}
