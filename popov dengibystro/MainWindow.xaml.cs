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

namespace popov_dengibystro
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            manager.MainFrame = MainFrame;
        }

      
      
      

        private void btn_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new otrasl());
        }

        private void btn_click2(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new siz());
        }

        private void btn_click3(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new qwer());
        }
    }
}
